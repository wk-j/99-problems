
let input = ['a' .. 'i'] @ ['k']

let split n xs = 
    if List.length xs > n then
        xs |> List.take n, xs |> List.skip (n)
    else
        xs, []

input   |> split 3 |> printfn "%A"
[1;2]   |> split 3 |> printfn "%A"
[1;2;3] |> split 3 |> printfn "%A"