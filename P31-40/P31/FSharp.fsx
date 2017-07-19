
let isPrime x = 
    if x % 2 = 0 && x <> 2 then
        false
    else
        [3 .. 2 .. x - 1]
        |> List.map (fun k -> x % k = 0) 
        |> List.forall (not)

7   |> isPrime |> printfn "%A" 
5   |> isPrime |> printfn "%A"
11  |> isPrime |> printfn "%A"
13  |> isPrime |> printfn "%A"
17  |> isPrime |> printfn "%A"
5   |> isPrime |> printfn "%A"

2  |> isPrime |> printfn "%A"
8  |> isPrime |> printfn "%A"
15 |> isPrime |> printfn "%A"
