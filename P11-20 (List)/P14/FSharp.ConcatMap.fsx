
let concatMap f x = x |> Seq.map f |> Seq.collect id

[1;2;3]         |> concatMap (fun x -> [x;x]) |> Seq.toList |> printfn "%A"
["A"; "B"; "C"] |> concatMap (fun x -> [x;x]) |> Seq.toList |> printfn "%A"