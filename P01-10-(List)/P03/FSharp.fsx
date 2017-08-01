
open System

let elementAt x (lst: 'a list) = lst.[x - 1]

let rec elementAt2 t = function
    | [] -> raise <| Exception("Err")
    | xs -> xs.[t - 1]

[1;2;3] |> elementAt 1 = 1  |> printfn "%A"
[1;2;3] |> elementAt2 1 = 1 |> printfn "%A"