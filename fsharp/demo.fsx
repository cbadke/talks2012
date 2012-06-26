open System

let x = [1; 2; 3; 4]
Console.WriteLine(x)

let double = fun a -> 2*a
let even = fun a -> a % 2 = 0

let d = x
         |> List.filter even
         |> List.map double

Console.WriteLine(d)

