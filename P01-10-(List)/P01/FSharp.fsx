open System

let rec myLast = function
    | [] -> raise <| Exception("Empty")
    | [x] -> x
    | _ :: xs -> myLast xs

myLast [1;2;3;4;5] = 5      |> printfn "%A"
myLast ["a;";"b";"c"] = "c" |> printfn "%A"

