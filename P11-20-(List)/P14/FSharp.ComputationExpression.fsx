
type Dup() = 
    member this.Bind (x, f) = 
        List.collect f x
    //member this.ReturnFrom l = 
    //    l : _ list
    member this.Return x = x

let dup = Dup()

dup {
    let! x =    [1;2;3] 
    return     [x;x]
} |> printfn "dup {} %A"

dup.Bind([1;2;3], fun x -> dup.Return [x;x])
|> printfn "%A"


// test return from 
let returnFrom l = l : _ list
[1;2;3] |> List.map(fun x -> [x;x]) |> List.collect returnFrom 
|> printfn "%A"

// test id
let id x = x;
[1;2;3] |> List.map(fun x -> [x;x]) |> List.collect id
|> printfn "%A"