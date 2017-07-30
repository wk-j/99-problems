-- stack runghc --package strict
import Data.List

combinations :: Int -> [a] -> [[a]]
combinations k ns = filter ((k==).length) (subsequences ns)

main :: IO()
main = do
    print $ combinations 3 "abcdef"
    print $ length (combinations 3 "abcdef")
