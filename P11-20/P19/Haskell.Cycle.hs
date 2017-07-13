-- stack runghc
import Control.Arrow
import Prelude hiding (cycle)

cycle :: [a] -> [a]
cycle xs = xs' where xs' = xs ++ xs'

rotate :: Int -> [a] -> [a]
rotate n xs = 
    (cycle >>> drop (length xs + n) >>> take (length xs)) xs

main :: IO()
main = do
    let input = ['a' .. 'h']
    print $ rotate 3    input       -- "defghabc"
    print $ rotate (-2) input       -- "ghabcdef"