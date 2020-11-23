module OnethreeFunctions 

open System

// 1330 = one three three zero 
// Compare two values
// https://docs.microsoft.com/ko-kr/dotnet/fsharp/language-reference/pattern-matching
module OttzFunction =
    let input = 
        Console.ReadLine().Split()
            |>Array.map int

    let compareNum xs=
        match xs with 
        | [| a; b|] when (a > b) -> ">"
        | [| a; b|] when (a = b) -> "=="
        | [| a; b|] when (a < b) -> "<"
        |_ -> "Error"

    let run = compareNum input        

// 1356
// https://www.acmicpc.net/problem/1356
// ex) input = 1236, 1*2*3 = 6, output = yes
// ex) input = 1221, 1*2=2*1, output = yes
// ex) input = 1234, output = no
module OtfsFunction =
    let rec multiply xs =
       match xs with
       | [] -> 1
       | y::ys -> y * multiply ys
    
    let rec compare lefts rights =
        if multiply lefts = multiply rights then true
        else
            match rights with
            | [] -> false
            | rs when rs.Length = 1 -> false
            | y::ys -> compare (y::lefts) ys

    let input = 
        Console.ReadLine()
            |> Seq.map (string >> int) 
            |> Seq.toList  // change "123" to [1;2;3]

    let init xs =
        match xs with
        | [] -> false
        | zs when zs.Length = 1 -> false
        |_ -> compare [] xs

    let run = 
        match init input with
        | true -> printfn "YES"
        | false -> printfn "NO"