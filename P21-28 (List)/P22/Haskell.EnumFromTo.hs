-- stack runghc --package strict

range :: Int -> Int -> [Int]
range = enumFromTo

main :: IO()
main = 
    print $ range 4 9