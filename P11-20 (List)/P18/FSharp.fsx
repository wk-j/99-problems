
let slice n1 n2 xs = 
    xs |> List.skip (n1 - 1) |> List.take (n2 - n1 + 1)

let input = ['a' ..'i'] @ ['k']
input |> slice 3 7 |> printfn "%A"