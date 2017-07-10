
let rec rotate n xs = 
    if (n < 0) then
        let t = xs |> List.last
        let h = xs |> List.take ((xs |> List.length) - 1)
        rotate (n + 1) ([t] @ h)
    elif n <> 0 then
        let h :: t = xs
        rotate (n - 1) (t @ [h])
    else
        xs

let input = ['a' .. 'h']
input |> rotate 3   |> printfn "%A"
input |> rotate -2  |> printfn "%A"
    
