import Html exposing (text)
import List

length1 : List a -> Int
length1 list =
    List.foldl (\a x -> x + 1) 0 list 

main : Html.Html msg
main = 
    text <| toString <| length1 [1,2,3,4]