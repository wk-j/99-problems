#nowarn "25"

let replicateM n x = 
    let k m m' = List.collect (fun x -> 
        List.collect(fun xs -> 
            [List.Cons(x,xs)]) m') m       
    List.foldBack k (List.replicate n x) [[]]

let rec replicateMM m l = seq {
  if m = 1 then 
    // If we want just one replication, generate singleton lists
    for v in l do yield [v]
  else 
    // Otherwise, iterate over all lists with m-1 replicates
    for s in replicateM (m - 1) l do
      // .. and append elements from 'l' to the front
      for v in l do yield v::s }

let table n f =
    let ls = replicateM n [true;false]
    for x in ls do 
        let rs = f x
        printfn "%A %A" x rs
    printfn ""

fun [a: bool; b;c;] -> a && (b || c) = a && b || a && c 
|> table 3