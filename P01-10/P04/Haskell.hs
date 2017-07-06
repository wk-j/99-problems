-- (script)
module X where

import Control.Category hiding ((.))

len1 :: [a] -> Int
len1 = length

len2 [] = 0
len2 (x:xs) = 1 + len2 xs

len3 :: [a] -> Int
len3 = foldr ((+) . (const 1)) 0

q x = (<<<) $ print <<< (==) x

main = do
    q 5     len1 [1,2,3,4,5]
    q 5     len2 [1,2,3,4,5]
    q 2     len2 ["Hello", "World"]
    q 2     len3 ["Hello", "World"]


