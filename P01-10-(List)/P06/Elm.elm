
import Html exposing (text)
import List

isPalindrome : List a -> Bool
isPalindrome list  = 
    list == List.reverse list

main : Html.Html msg
main = 
    [1,2,3,2,1] |> isPalindrome |> toString |> text
