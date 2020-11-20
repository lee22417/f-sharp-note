module OnethreeFunctions 

open System

// 1330 = one three three zero 
// Compare two values
// https://docs.microsoft.com/ko-kr/dotnet/fsharp/language-reference/pattern-matching
module OttzFunction =
    let num = Console.ReadLine().Split()
                |>Array.map int

    let compareNum xs=
        match xs with 
        | [| a; b|] when (a > b) -> ">"
        | [| a; b|] when (a = b) -> "=="
        | [| a; b|] when (a < b) -> "<"
        |_ -> "Error"

    let result = compareNum num        

