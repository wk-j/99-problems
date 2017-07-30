-- stack runghc --package strict

import Control.Category
import Control.Applicative
import Control.Monad


sp :: [a] -> [a] -> ([a], [a])
sp = length >>> (flip quot 2) >>> splitAt

p1 :: Eq a => [a] -> Bool
p1 x = do
    let (l1,l2) = sp x x
    let f = foldl (\a k -> k : a) [] l1
    f == tail l2

p2 x = reverse x == x

-- p3 :: (Eq a) => [a] -> bool
-- p3 = (==) Control.Applicative.<*> reverse

p4 :: (Eq a) => [a] -> Bool
p4 = Control.Monad.liftM2 (==) Prelude.id reverse

main :: IO ()
main = do
    print $ p1 [1,2,3,2,1] == True 
    print $ p1 [1,1,1,1,1] == True

    print $ p2 [1,2,3,2,1] == True 
    print $ p2 [1,1,1,1,1] == True

    -- print $ p3 [1,2,3,2,1] == True
    -- print $ p3 [1,1,1,1,1] == True
    let k = liftM2 (+) Prelude.id Prelude.id 100

    print $ p4 [1,2,3,2,1] == True





