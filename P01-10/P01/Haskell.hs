-- stack runghc --package strict

module X where

import Control.Category

myLast :: [a] -> a
myLast [] = error "Empty"
myLast [x] = x 
myLast (_:xs) = myLast xs

q x =   myLast >>> (x ==) >>> show >>> putStrLn
    
main :: IO()
main = do
    q 4     [1,2,3,4] 
    q 'z'   ['z', 'y', 'z']