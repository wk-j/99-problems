
let rec drop n xs = 
    let rec find xs = 
        let h = xs |> List.truncate (n-1)
        if xs.Length > (n-1) then
            let tail = xs |> List.skip (n) in h @ find tail
        else h
    find xs

['a' .. 'k']    |> drop 3 |> printfn "%A"
[1 .. 10]       |> drop 3 |> printfn "%A"      



