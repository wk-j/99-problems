let dup count xs = xs |> List.map (List.replicate count) |> List.collect id

[1;2;3] |> dup 3 |> printfn "%A"

[ "A"
  "B"
  "C" ] |> dup 3 |> printfn "%A"



let dup1 (x: int) = [x; x]
let dup2 x = [x; x]  : int list
let dup3 x = [(x: int); x]

