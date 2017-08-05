import Html exposing (text)
import List

type Item a
    = Single a
    | Multiple Int a

decodeMofified : List (Item a) -> List a
decodeMofified list = 
    case list of
        [] -> []
        h :: xs ->
            case h of
                Single a -> 
                    a :: decodeMofified xs
                Multiple n a -> 
                    if n > 1 then
                        a :: decodeMofified (Multiple (n - 1) a :: xs)
                    else 
                        a :: decodeMofified xs

main : Html.Html msg
main =
    [Multiple 3 'a', Single 'b', Multiple 3 'c', Single 'd', Multiple 5 'e']
    |> decodeMofified
    |> toString 
    |> text