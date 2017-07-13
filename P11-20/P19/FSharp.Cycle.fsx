module Seq = 
    let cycle xs = seq { while true do yield! xs }

let rotate n xs = 
    let len = List.length xs
    xs |> Seq.cycle |> Seq.skip (len + n) |> Seq.take (len) |> Seq.toList

let input = ['a' .. 'h']
input |> rotate 3   |> printfn "%A"     // ['d'; 'e'; 'f'; 'g'; 'h'; 'a'; 'b'; 'c']
input |> rotate -2  |> printfn "%A"     // ['g'; 'h'; 'a'; 'b'; 'c'; 'd'; 'e'; 'f']