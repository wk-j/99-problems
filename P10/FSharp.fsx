
let p1 xs = 
    List.foldBack (fun x a -> 
        let h = a |> List.tryHead
        match h with 
        | Some (c:int, s: char) -> 
            if s = x then 
                (c + 1, s) :: a.Tail 
            else (1, x) :: a
        | None -> [(1, x)]
    ) xs [] 


"aaaabccaadeeee".ToCharArray() |> List.ofArray |> p1 |> printfn "%A"