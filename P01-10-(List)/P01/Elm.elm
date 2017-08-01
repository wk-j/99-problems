import Html exposing (text)

last : List a -> Maybe a
last list = 
    case list of
    [] -> Nothing
    [a] -> Just a
    a :: b -> last b

main : Html.Html msg
main = 
    case last [1,2,3,4] of
        Just a -> text (toString a)
        Nothing -> text "No element found"