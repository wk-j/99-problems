type 'a NestedList =
    | Elem of 'a
    | List of NestedList<'a> list

let rec f1 x = 
    match x with
    | Elem x    -> [x]
    | List xs   -> List.fold (fun a x -> a @ f1 x) [] xs

let i = List [Elem 1; Elem 2; List [Elem 200; Elem 200]]

printfn "%A" <| f1 i

