open System

let rec myLast = function
    | [] -> raise <| Exception("Empty")
    | [x] -> x
    | _ :: xs -> myLast xs


let q x = myLast >> ((=) x) >> (printfn "%A")

q 4     [1;2;3;4]       
q 'z'   ['z';'y'; 'z']  


