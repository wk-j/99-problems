
open System

let rec myButLast (lst: 'a list) = 
    match lst with
    | [] -> raise <| Exception "Err"
    | [k;_] -> k
    | k :: xs -> myButLast xs

let q x = myButLast >> ((=) x) >> printfn "%A"

q 3     [1;2;3;4]
q 'y'   ['a' .. 'z']