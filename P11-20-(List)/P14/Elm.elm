import Html exposing (text)
import List

repleateElement n xs = 
    xs
    |> List.concatMap (List.repeat (n - 1))

main = 
    [1,2,3,3] |> repleateElement 3 |> toString |> text