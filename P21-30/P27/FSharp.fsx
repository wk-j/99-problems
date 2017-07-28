let rec group ns xs = 
    let rec combination n xs = 
        match n,xs with
            | 0, xs -> [([], xs)]
            | _, [] -> []
            | n, x::xs -> 
                let ts = [ for ys, zs in combination (n-1) xs do yield (x::ys, zs)]
                let ds = [ for ys, zs in combination n xs do yield (ys, x::zs)]
                ts @ ds
    match ns,xs with
        | [], _ -> [[]]
        | n::ns, xs ->
            [ for g, rs in combination n xs do
                for gs in group ns rs do
                    yield g::gs ]

let rs = group [2;3;4] ["aldo";"beat";"carla";"david";"evi";"flip";"gary";"hugo";"ida"] 

rs |> printfn "%A"
rs |> List.length |> printfn "%A"