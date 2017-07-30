-- stack runghc --package strict

module X where

myLast :: [a] -> a
myLast [] = error "Empty"
myLast [x] = x 
myLast (_:xs) = myLast xs

main :: IO()
main = do
    print $ myLast [1::Int,2,3,4,5] == 5
    print $ myLast ["a", "b", "c"] == "c"