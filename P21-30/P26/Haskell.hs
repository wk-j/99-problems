-- stack runghc --package strict
import Data.List

-- combinations :: Int -> [Char] -> [[Char]]
conbinations k ns = filter ((k==).length) (subsequences ns)

main :: IO()
main = do
    print $ conbinations 3 "abcdef"
    print $ length $ conbinations 3 [1..12]
