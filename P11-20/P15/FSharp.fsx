let dup count xs = xs |> List.map (List.replicate count) |> List.collect id

[1;2;3] |> dup 3 |> printfn "%A"