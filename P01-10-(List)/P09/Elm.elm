import Html exposing (text)
import List

pack : List a -> List (List a)
pack list = 
    List.foldr (\x acc ->
        case acc of
        [] -> [[x]]
        ((h::t) :: tail) -> 
            if x == h then
                [x :: h :: t] ++ tail
            else
                [x] :: acc
        _ -> [x] :: acc

    ) [] list

main : Html.Html msg
main =
    [1,1,1,2,3,3,3,4,4,4,4,5,6,6] |> (pack >> toString >> text)