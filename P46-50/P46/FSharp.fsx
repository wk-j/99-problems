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

table (fun a b -> (and' a (or' a b)))