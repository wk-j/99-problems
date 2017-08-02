import Html exposing (text)
import List

compress : List a -> List a
compress list = 
    List.foldr (\x acc -> 
        case acc of 
            [] -> [x]
            h :: _ -> if h == x then acc else x :: acc
    ) [] list
    
main : Html.Html msg
main = 
    [1,1,2,2,3,3,3,4,5,4,4,4,4] |> compress |> compress |> toString |> text