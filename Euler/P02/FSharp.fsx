#nowarn "40"

let fibs = Seq.unfold (fun (a, b) -> Some( a + b, (b, a+b))) (0,1)
let find k = 
    seq { 
        for x in Seq.takeWhile (fun i -> i <= k) fibs do 
            if x % 2 = 0 then yield x }

let ans = Seq.sum (find 1000000)

printfn "%A" ans