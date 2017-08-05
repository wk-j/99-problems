import Html exposing (text)
import List

range : Int -> Int -> List Int
range n1 n2 = 
    if n1 <= n2  then
        n1 :: range (n1 + 1) n2
    else []

main : Html.Html msg
main = 
    range 4 9 |> toString |> text