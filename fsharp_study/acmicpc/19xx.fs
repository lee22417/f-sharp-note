module OnenineFunctions 

open System

// 1978 = one nine seven eight
// Find and count prime numbers
module OnseFunction =

    let rec isPrime x i = 
        match i with
        |a when a = 1 -> 1
        |b when b = 0 -> 0
        |c when x%c = 0 -> 0
        |y ->  isPrime x (y-1)

    let getIsPrime x = 
        isPrime x (x-1)

    let rec cntPrime xs =
        match xs with
        | []    -> 0
        | y::ys -> (getIsPrime y) + (cntPrime ys)

    let input =
        Console.ReadLine() |> ignore
        Console.ReadLine().Split() 
            |>Array.toList 
            |>List.map Convert.ToInt32

    let run =
        cntPrime input |> printfn "%d"
        