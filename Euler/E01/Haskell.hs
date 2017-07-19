-- stack runghc --package strict
import Data.List (union)

p1 :: Int
p1 = sumStep 3 999 + sumStep 5 999 - sumStep 15 999
    where 
        sumStep s n     = s * sumOneToN (n `div` s)
        sumOneToN n     = n * (n + 1) `div` 2

p2 :: Int
p2 = sum([3, 6 .. 999] `union` [5, 10 .. 999])

p3 :: Int
p3 = sum [x | x <- [1..999], x `mod` 3 == 0 || x `mod` 5 == 0]

main :: IO()
main = do
    print p1
    print p2
    print p3