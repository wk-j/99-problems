-- stack runghc --package strict

range :: Int -> Int -> [Int]
range s e = [s .. e]

main :: IO()
main = 
    print $ range 4 9