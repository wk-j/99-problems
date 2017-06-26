-- stack runghc --package strict

import Control.Category

sp :: [a] -> [a] -> ([a], [a])
sp = length >>> (flip quot 2) >>> splitAt

p1 x = do
    let (l1,l2) = sp x x
    let f = foldl (\a k -> k : a) [] l1
    f == tail l2

q = (==)

main = do
    print $ q True  $ p1 [1,2,3,2,1] 
    print $ q False $ p1 [1,2,3,4,5]


