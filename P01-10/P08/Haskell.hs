-- stack runghc --package strict
zip' xs = 
    let f [] x =  [x]
        f a  x = 
            if x == last a then a
            else a ++ [x]
    in foldl f [] xs

main :: IO()
main = 
    print $ zip' [1 :: Int,1,1,2,3,3,4,5]