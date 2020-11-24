module OnefivesevenFunctions 

open System
open System.Numerics

// 15700
// N*M Wall. how many 1*2 or 2*1 tiles can be used?
module OfszzFunction =
    let run = 
        Console.ReadLine().Split()
        |>Array.map BigInteger.Parse
        |>printfn "%A"
        
        