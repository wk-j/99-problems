-- stack runghc --package strict

range :: Int -> Int -> [Int]
range s e = take (e - s + 1) $ iterate (+ 1) s

main :: IO()
main = 
    print $ range 4 9