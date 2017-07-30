let remove n xs = 
    let a,b = xs |> List.splitAt (n - 1)
    List.head b, a @ (b |> List.tail)

let input = ["a"; "b"; "c"; "d"]
input |> remove 2 |> printfn "%A"