
module AFunctions

module singleInputFunction =
    let add x = x + x
    let square x = x * x
    let addSquareValue value = add value |> square

module twoInputsFunction = 
    let add x y = x + y
    let sub x y = x - y
    let mul x y = x * y
    let div x y = x / y
    let random1 x y = add x y |> sub x     // x-(x+y)
    let random2 x y = sub (add x y) x   // (x+y)-x

module displayFunction =
    let x = 1
    let y = 2

    let xresult = singleInputFunction.addSquareValue x |> printfn "%d"
    let xyresult = twoInputsFunction.random2 x y |> printfn "%d"

module disFloatFunction=
    let x = 1.1
    let y = 1.2
    let xyresult =  (+) x y |> printfn "%f"
    let xyresult2 =  (+) 1 2 |> printfn "%d"

