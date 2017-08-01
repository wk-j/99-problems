import Html exposing (text)
import List exposing (head, length)
import Maybe

nth: Int -> List a -> Maybe a
nth n list = 
    case list of
        [] -> Nothing
        h :: t -> 
                if n == 0 then
                    Just h
                else
                    nth (n - 1) t

main : Html.Html msg
main = 
    case nth 3 [1,2,3,4] of
        Just a -> text (toString a)
        Nothing -> text "No element found"