open System

let isPrime x = 
    if x % 2 = 0 && x <> 2 then
        false
    else
        [3 .. 2 .. int <| Math.Floor(Math.Sqrt(float x))]
        |> List.takeWhile (fun k -> x % k = 0) 
        |> List.isEmpty

100000002 |> isPrime |> printfn "%A"
