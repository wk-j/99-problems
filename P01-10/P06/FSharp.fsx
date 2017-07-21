
let flip f x y = f y x

let p1 (x: 'a list) = 
    let l1,l2 = List.splitAt (x.Length / 2) x
    l2.Tail = List.fold (fun a x -> x :: a) [] l1


let q f x = f x |> ((=))

q p1    [1;2;3;2;1] true    |> printfn "%A"
q p1    [1;2;3;4;5] false   |> printfn "%A"