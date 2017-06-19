
open System

let elementAt x (lst: 'a list) = lst.[x - 1]

[1;2;3;4]       |> elementAt 1 |> ((=) 1)   |> printfn "%A"
['a';'b';'c']   |> elementAt 1 |> ((=) 'a') |> printfn "%A"
['a';'b';'c']   |> elementAt 3 |> ((=) 'c') |> printfn "%A"

let rec elementAt2 t = function
    | [] -> raise <| Exception("Err")
    //| x :: _  when t = 1 -> x
    | xs -> xs.[t - 1]


[1;2;3;4]       |> elementAt2 1 |> ((=) 1)   |> printfn "%A"
['a';'b';'c']   |> elementAt2 1 |> ((=) 'a') |> printfn "%A"
['a';'b';'c']   |> elementAt2 3 |> ((=) 'c') |> printfn "%A"


let elementAt3 x = List.take x >> List.last

[1;2;3;4]       |> elementAt3 1 |> ((=) 1)   |> printfn "%A"
[1;2;3;4]       |> elementAt3 4 |> ((=) 4)   |> printfn "%A"







