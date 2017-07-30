
open System.Linq

let split n xs  =
    match List.length xs > n with
    | true ->
        xs |> List.take n,  xs |> List.skip n
    | false ->
        xs, []

let input = ['a'..'i'] @ ['k']
input |> split 3 |> printfn "%A"