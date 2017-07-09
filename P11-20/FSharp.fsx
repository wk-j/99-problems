type C<'a> =
    | Single of 'a
    | Multiple of int * 'a

let go x a = 
    match a with
    | [] -> [Single x]
    | h::tail -> 
        match h with
        | Single k when k = x -> 
            Multiple (2,k) :: tail
        | Multiple (i, k) when k = x -> 
            Multiple (i + 1, k) :: tail
        | _ -> Single x :: h :: tail

let data = "aaaabccaadeeee" |> Seq.toList
let compress = List.foldBack go data []

compress |> printfn "%A"
