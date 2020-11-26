# Tuple in F#

### 1. Introduction
- comma-separated collection of values
- for creating ad hoc data structures
- Example - 3-tuple -> ("Fruit", "Apple", 10)
<br><br>

### 2. Access Individual Tuple Members
- **Individual members can be assessed and printed using pattern matching**
- Code
```
let display tuple1 =
    match tuple1 with
    | (a,b,c) -> printfn "Print: %A %A %A" a b c

display("Fruit", "Apple", 10)
```
- Output
```
Print: "Fruit" "Apple" 10
```
<br>

- **Two built-in functions, fst and snd -> return the first and second items in a 2-tuple**
- Code
```
printfn "First : %A" (fst(1,20))
printfn "Second: %A" (snd(1,20))
```
- Output
```
First : 1
Second : 20
```

<br><br>

# Reference
https://www.tutorialspoint.com/fsharp/fsharp_tuples.htm
