open System.Linq

module List = 
    let fromString str = 
        (str : string).ToCharArray() |> Array.toList

let toString obj = obj.ToString()

let c1 str = 
    let list = str |> List.fromString

    list 
    |> List.fold (fun a x -> 
        let lastChar = a |> Seq.tryLast
        match lastChar with
        | Some char ->
            if char = x then a
            else a @ [x]
        | None ->
            [x]
    ) [] 
    |> List.map (toString) 
    |> String.concat ""

"aaaabccaadeeee" |> c1 |> (=) "abcade" |> printfn "%A"