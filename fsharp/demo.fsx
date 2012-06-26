open System

let x = [1; 2; 3]
Console.WriteLine(x)

let add = fun accum item -> accum + item

let sum = List.reduce add x

Console.WriteLine(sum)

