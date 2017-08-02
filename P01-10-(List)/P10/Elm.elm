import Html exposing (text)
import List

runLengthEncode : List a -> List (a, Int)
runLengthEncode list = 
    List.foldr (\x acc ->
        case acc of
        [] -> [(x,1)]
        (e, count) :: tail -> 
            if x == e then 
                (e, count + 1) :: tail
            else 
                (x, 1) :: acc
    ) [] list

main : Html.Html msg
main = 
    [1,1,1,2,3,3,3,4,4,4,4,5,6,6] |> (runLengthEncode >> toString >> text)
