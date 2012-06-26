open System

let x = [1; 2; 3]
Console.WriteLine(x)

let mutable badSum = 0

for n in x do
    badSum <- badSum + n

Console.WriteLine(badSum)

