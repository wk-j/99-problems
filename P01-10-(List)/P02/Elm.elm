
import Html exposing (text)
import List
import Maybe

penultimate : List a -> Maybe a
penultimate list = 
    case List.reverse list of
    [] -> Nothing
    h1 :: h2 :: tail -> Just h2
    h1 :: tail -> Just h1

main : Html.Html msg
main = 
    case  penultimate [1,2,3,4] of
        Just a -> text (toString a)
        Nothing -> text "No element found"
