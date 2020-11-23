// Learn more about F# at http://fsharp.org

open System
// src
//open AFunctions

// acmicpc
//open OneoneFunctions
open OnethreeFunctions
open OnenineFunctions

// let helloPrint = 
//     printfn "----------hello_world.fs----------"
//     HelloFunction.hello
// let testPrint = 
//     printfn "\n----------test.fx----------"
//     TestFunction.get
// let aPrint = 
//     printfn "\n----------chapter_a.fs----------"
//     displayFunction.xresult
//     disFloatFunction.xyresult
// let oneonePrint =
//     printfn "\n----------11xx.fs----------"
//     OoftFunction.numString |> printfn "%d"
let onethreePrint =
    printfn "\n----------13xx.fs----------"
    OtfsFunction.run
// let oneninePrint =
//     printfn "\n----------19xx.fs----------"
//     OnseFunction.run
    

[<EntryPoint>]
let main argv =
    onethreePrint
    0 // return an integer exit code
