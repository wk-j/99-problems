#nowarn "40"

let fibs = Seq.unfold (fun (a, b) -> Some( a + b, (b, a + b))) (0,1)
let find k = 
    seq { 
        for x in Seq.takeWhile (fun i -> i <= k) fibs do 
            if x % 2 = 0 then yield x }

let ans = Seq.sum (find 1000000)


printfn "%A" ans

// test
find 100 |> printfn "%A"
fibs |> Seq.take 10 |> Seq.toList |> printfn "%A"

Seq.unfold (fun state -> if (state > 20) then None else Some(state, state + 1)) 0 |> Seq.toList |> printfn "%A"

Seq.unfold (fun state -> Some(state, state + 1)) 0 |> Seq.take 5 |> printfn "%A"
Seq.unfold (fun (a,b) -> Some(b, (b, a + b))) (1,1) |> Seq.take 5 |> printfn "%A"