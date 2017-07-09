-- stack runghc --package strict

dupi :: [a] -> [a]
dupi = concatMap (\ x -> [x, x])

main :: IO()
main = do
    print $ dupi [1,2,3]
    print $ dupi ['a','b','c']