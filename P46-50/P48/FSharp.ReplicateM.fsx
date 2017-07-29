

let replicateM n x = 
    let k m m' = List.collect (fun x -> 
        List.collect(fun xs -> 
            [List.Cons(x,xs)]) m') m       
    List.foldBack k (List.replicate n x) [[]]

[true;false] |> replicateM 3 |> printfn "%A"