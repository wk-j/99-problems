-- stack runghc --package strict

data Route = 
    Companies
    | Company String
    | EditCompany String

getValue (Company c) = c

main = 
    let 
        a = Company "A"
        (Company e) = a
    in 
        print $ e


