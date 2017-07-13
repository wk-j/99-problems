
let rotate n xs = 
    match n > 0 with
    | true ->
        let h = List.take n xs
        let t = List.skip n xs
        t @ h
    | false ->
        let h = List.take (List.length xs + n) xs
        let t = List.skip (List.length xs + n) xs
        t @ h

let input = ['a' .. 'h']
input |> rotate 3   |> printfn "%A"
input |> rotate -2 |> printfn "%A"