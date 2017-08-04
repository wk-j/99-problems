import Html exposing (text)
import List

type Item a
    = Single a
    | Multiple Int a

runLengthEncode : List a -> List (Item a)
runLengthEncode list = 
    List.foldr(\x acc ->
        case acc of 
            (Single k) :: t -> 
                if k == x then (Multiple 2 k) :: t
                else (Single x) :: acc
            (Multiple n k) :: t ->
                if k == x then (Multiple (n + 1) k) :: t
                else (Single x) :: acc
            [] -> [Single x]
    ) [] list

main : Html.Html msg
main = 
    ["a","a","a", "b","c","c","d", "e", "e", "e", "e", "e"] 
    |> runLengthEncode
    |> toString |> text