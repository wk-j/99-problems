let rv = List.rev

type Rev = Rev with
    static member (./) (_ ,ls :'a list) = List.rev ls
    static member (./) (_ ,ls : string) = ls.ToCharArray() |> Array.rev |> Array.map (fun x -> x.ToString()) |> String.concat ""

let inline rev1 ls = Rev ./ ls

let rec rev2 = function
    | [] -> []
    | x :: xs -> rev2 xs  @ [x]


let rev3 xs = List.foldBack (fun x a -> a @ [x]) xs []

let flip f x y = f y x

let cons x y = List<_>.Cons(x, y)

let rev4 xs = List.fold (fun a x -> x :: a) [] xs
let rev5 xs = List.fold (flip cons) [] xs

let inline show f x = 
    f x |> ((=)) >> printfn "%A"

show rev1 [1;2;3]                            [3;2;1]
show rev1 ['a';'b';'c']                      ['c';'b';'a']
show rev1 "A man, a plan, a canal, panama!"  "!amanap ,lanac a ,nalp a ,nam A"

show rev2 [1;2;3]                           [3;2;1]
show rev2 ['a';'b';'c']                     ['c';'b';'a']

show rev3 [1;2;3]                           [3;2;1]
show rev3 ['a';'b';'c']                     ['c';'b';'a']

show rev4 [1;2;3]                           [3;2;1]
show rev4 ['a';'b';'c']                     ['c';'b';'a']

show rev5 [1;2;3]                           [3;2;1]
show rev5 ['a';'b';'c']                     ['c';'b';'a']
