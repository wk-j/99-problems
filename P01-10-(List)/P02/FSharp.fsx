open System

let rec last2 (lst: 'a list) = 
    match lst with
    | [] -> raise <| Exception "Err"
    | [k;_] -> k
    | k :: xs -> last2 xs

[1;2;3;4] |> last2 = 3 |> printfn "%A"