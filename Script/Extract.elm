module Main exposing (..) 

import Html exposing (text)

type Route = 
    Companies
    | Company String
    | EditCompany String

-- getValue (Company c) = c

main : Html.Html msg
main =
    let 
        route = Company "A"
        (Company e) = route
    in 
        text "100"
