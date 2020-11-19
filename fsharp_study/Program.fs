// Learn more about F# at http://fsharp.org

open System
open AFunctions
open OneoneFunctions
open OnethreeFunctions

let helloPrint = 
    printfn "----------hello_world.fs----------"
    HelloFunction.hello

let testPrint = 
    printfn "\n----------test.fx----------"
    TestFunction.get

let aPrint = 
    printfn "\n----------chapter_a.fs----------"
    displayFunction.xresult
    disFloatFunction.xyresult

let oneonePrint =
    printfn "\n----------11xx.fs----------"
    OoftFunction.numString |> printfn "%d"

let onethreePrint =
    printfn "\n----------13xx.fs----------"
    OttzFunction.result |> printfn "%s"

[<EntryPoint>]
let main argv =
    //helloPrint
    //testPrint
    //aPrint
    //oneonePrint
    onethreePrint


    0 // return an integer exit code
