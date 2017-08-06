import Html exposing (text)
import List

duplicate : List a -> List a
duplicate xs = 
    xs 
    |> List.map (\x -> [x,x])
    |> List.concatMap identity

main =
    [1,2,3,4,5,8,8] |> duplicate |> toString |> text
