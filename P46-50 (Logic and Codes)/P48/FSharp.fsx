#nowarn "25"

#r "../../packages/FSharpPlus/lib/net40/FSharpPlus.dll"

open FSharpPlus.Data

let not' = function
    | true -> false
    | false -> true

let and' a b = 
    match (a, b) with
    | true , true -> true
    | _ -> false

let or' a b = 
    match (a, b) with
    | true, _ -> true
    | _, true -> true
    | _ -> false

let nor' a b = not' <| or' a b
let xor' a b = (a: bool) <> b
let equ' a b = (a: bool) = b
let impl' a b = or' (not' a) b

type System.Boolean with
    member x.Or = or' x
    member x.And = and' x
    member x.Equ = equ' x

let table n f =
    let ls = List.replicateM n [true;false]
    for x in ls do 
        let rs = f x
        printfn "%A %A" x rs
    printfn ""

fun [a: bool; b;c;] ->  (a .Or b) .Or c
|> table 3

fun [a: bool; b;c;] ->  (a || b) || c
|> table 3

fun [a: bool; b;c;] -> a && (b || c) = a && b || a && c 
|> table 3
