
type Dup() = 
    member this.Bind (x, f) = 
        List.collect f x
    member this.ReturnFrom l = 
        l : _ list

let dup = Dup()

///////////// ---
dup {
    let! x =    [1;2;3] 
    printfn "x = %A" x
    return!     [x;x]
} |> printfn "%A"

///////////// ---
dup.Bind([1;2;3], fun x -> dup.ReturnFrom [x;x])
|> printfn "%A"

///////////// ---
let returnFrom l = l : _ list
[1;2;3] |> List.map(fun x -> [x;x]) |> List.collect returnFrom 
|> printfn "%A"
