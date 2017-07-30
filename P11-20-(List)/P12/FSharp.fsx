open System;

type C<'a> =
    | Single of 'a
    | Multiple of int * 'a

let compressed = [Multiple (4,'a'); Single 'b'; Multiple (2,'c'); Multiple (2,'a'); Single 'd'; Multiple (4,'e')] 

let copy c = 
    match c with
    | Single k -> k.ToString()
    | Multiple (i, k) -> k.ToString() |> String.replicate i

#time
let str = compressed |> List.map copy |> String.concat ""
#time

str = "aaaabccaadeeee" |> printfn "%A"
