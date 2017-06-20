

module l1 = 
    let len1 = List.length

    let q x = len1 >> (=) x >> printfn "%A"

    q 4     [1;2;3;4] 
    q 0     []
    q 26    ['a' .. 'z']


module l2 =


    let len2 = List.fold (fun a x -> a + 1) 0
    let q x = len2 >> (=) x >> printfn "%A"

    q 5 [1;2;3;4;5]

module l3 = 
    let con x y = x
    //let add = fun y -> (+) 1
    let add x y = x + 1
    let len3 = List.fold add 0
    //let len3 = List.fold ((+) << con 0) 0
    let q x = len3 >> (=) x >> printfn "l3 = %A"
    q 5 [1;2;3;4;10]

    [1;2;3;4;10] |> len3 |> printfn "%A"

let l4 = 
    let con x y = x
    let len = List.map (con 1)  >> List.sum
    let q x = len >> (=) x >> printfn "%A"
    q 5 [1;2;3;4;5]


let l5 =
    let con x y = x

    let k = (+) << con 1

    List.foldBack (fun x a -> a + 1) [1;2;3;4;3903] 0 |>  printfn "%A"
    List.foldBack ((+) << con 1) [1;2;3;4;3903] 0 |>  printfn "%A"





