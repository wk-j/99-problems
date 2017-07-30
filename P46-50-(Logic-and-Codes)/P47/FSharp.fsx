let not' = function
    | true -> false
    | false -> true

let and' a b = 
    match (a, b) with
    | true , true -> true
    | _ -> false

let or' a b = 
    match (a, b) with
    | true, _ -> true
    | _, true -> true
    | _ -> false

let nor' a b = not' <| or' a b
let xor' a b = (a: bool) <> b
let equ' a b = (a: bool) = b
let impl' a b = or' (not' a) b

type System.Boolean with
    member x.Or = or' x
    member x.And = and' x

let table f =
    let ls = 
        query { 
            for a in [ true; false] do
            for b in [ true; false] do
            select (a,b)
        }

    for x in ls do 
        let x1 = fst x
        let x2 = snd x
        let x = f x1 x2
        printfn "%A %A %A" x1 x2 x

fun (a:bool) b -> a .And (a .Or (not' b))
|> table