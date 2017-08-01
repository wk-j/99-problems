import Html exposing (text)
import List

reverse : List a -> List a
reverse list = 
    List.foldr (\a b -> b ++ [a]) [] list

main : Html.Html msg
main = 
    [1,2,3,4] |> reverse |> toString |> text