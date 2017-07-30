let splitAt n xn xs = 
    let h, t = xs |> List.splitAt (n - 1) in h @ [xn] @ t


["a";"b";"c";"d"] |> splitAt 2 "ALFA" |> printfn "%A"