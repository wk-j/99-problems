let dup x = [x;x]

let data = [1;2;3]

#time
let result = data |> (List.map dup >> List.collect id)
#time

result = [1;1;2;2;3;3;] |> printfn "%A"

