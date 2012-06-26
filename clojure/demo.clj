(defn fib
  [n]
  (cond
    (= n 0) 1
    (= n 1) 1
    (true) (+ (fib (- n 1)) (fib (- n 2)))))

(println (fib 5))

(def x (iterate inc 0))

(take 5 x)

(take 5 (map #(+ % %) x))
(take 5 (filter #(= 0 (mod % 2)) x)) 
