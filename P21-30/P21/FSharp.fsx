
let insertAt n ns xs = 
    let h, t = xs |> List.splitAt (n - 1)
    h @ [ns] @ t

["a"; "b"; "c"; "d"] |> insertAt 2 "ALFA" |> printfn "%A"