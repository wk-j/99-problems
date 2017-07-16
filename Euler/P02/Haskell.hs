-- stack runghc --package strict

p1 :: Int
p1 = sum [ x | x <- takeWhile (<= 1000000) fibs, even x]
    where
        fibs = 1 : 1 : zipWith (+) fibs (tail fibs)

main :: IO()
main = 
    print p1 
