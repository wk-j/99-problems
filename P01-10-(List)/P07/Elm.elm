import Html exposing (text)
import List

type NestedList a =
    Elem a
    | NestedList (List (NestedList a)) 

flatten : NestedList a -> List a
flatten nested = 
    case nested of
        Elem a -> [a]
        NestedList [] -> []
        NestedList (h :: t) ->
            flatten h ++ flatten (NestedList t)

main : Html.Html msg
main = 
    NestedList [Elem 1, NestedList [Elem 2, NestedList[Elem 3, Elem 4], Elem 5]]
    |> flatten
    |> toString
    |> text