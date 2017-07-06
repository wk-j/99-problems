-- (script)

module X where

import Control.Category hiding ((.))

last1 [y,_] = y
last1 (_: xs) = last1 xs
last1 [] = error "Err"

last2 (x: (_:[])) = x
last2 (_ : xs) = last2 xs
last2 [] = error "Err"

-- last3 = fst . foldl (\(a,b) x -> (b, Just x)) (Nothing, Nothing)
last3 :: Foldable f => f a -> Maybe a
last3 = fst . foldl (\(a,b) x -> (b,Just x)) (Nothing,Nothing)

q x = last1 >>> (==) x >>> show >>> putStrLn
q2 f x = (show >>> putStrLn) <<< (==) x <<< f

main = do
    q 3     [1,2,3,4] 
    q 'y'   ['a' .. 'z']
    q 1     [1,2]

    q2 last2    3   [1,2,3,4]
    q2 last1    3   [1,2,3,4]

    q2 last3    (Just 3)   [1,2,3,4]