
let p1 xs = 
    List.foldBack (fun x a -> 
        let last = a |> List.tryHead
        match last with 
        | Some (d: string) -> 
            if d.Contains(x) then d + x :: a.Tail 
            else x :: a 
        | None -> x :: a) xs [] 

#time
["a"; "a"; "a"; "a"; "b"; "c"; "c"; "a"; "a"; "d"; "e"; "e"; "e"; "e"] |> p1 |> printfn "%A"
#time
