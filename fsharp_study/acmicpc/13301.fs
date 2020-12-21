open System

module BasicFunctions =
    let rec getResult n cnt x y =
        if cnt=n then (x+y)*2
        else if x > y then getResult n (cnt+1) x (x+y)
        else getResult n (cnt+1) (x+y) y

    let getRes n =
        getResult n 1 1 1

    Console.ReadLine() |> Convert.ToInt32 |> getRes |> printfn "%d"

