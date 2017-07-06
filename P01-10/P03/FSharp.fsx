
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

let elementAt3 = ((<<) List.last) << List.take
let elementAt5 = ((<<) List.last) << List.take
let elementAt4<'a> : int -> 'a list -> 'a = ((<<) List.last) << List.take

[1;2;3;4]       |> elementAt4 1 |> ((=) 1)   |> printfn "%A"
['a';'b';'c']   |> elementAt4 1 |> ((=) 'a') |> printfn "%A"

(*
error FS0030: Value restriction. The value 'elementAt4' has been inferred to
have generic type
    val elementAt4 : (int -> '_a list -> '_a)
Either make the arguments to 'elementAt4' explicit or, 
if you do not intend for it to be generic, add a type annotation.
*)

[1;2;3;4]       |> elementAt3 1 |> ((=) 1)   |> printfn "%A"
[1;2;3;4]       |> elementAt5 4 |> ((=) 4)   |> printfn "%A"






