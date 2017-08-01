-- stack runghc --package strict

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

main = do
    print $ last1 [1,2,3,4,5] == 4
    print $ last2 [1,2,3,4,5] == 4