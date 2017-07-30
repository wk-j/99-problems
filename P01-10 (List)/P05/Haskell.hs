-- stack runghc --package strict

module X where

import Control.Category

rev1 :: [a] -> [a]
rev1 [] = []
rev1 (x : xs) = rev1 xs ++ [x]

q f e x = 
    print (f e == x) 

main = do 
    q rev1 [1,2,3]  [3,2,1]
    q rev1 "A man, a plan, a canal, panama!"  "!amanap ,lanac a ,nalp a ,nam A"