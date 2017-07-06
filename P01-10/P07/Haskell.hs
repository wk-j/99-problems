-- stack runghc

data NestedList a = Elem a | List [NestedList a] deriving Show
data Item a = One [a] | Many [Item a]
-- data NestedList a = Elem a | List [NestedList a]

f1 :: NestedList a -> [a]
f1 (Elem x) = [x]
f1 (List xs) = foldr ((++) . f1) [] xs

f2 :: NestedList a -> [a]
f2 (Elem x) = [x]
f2 (List xs) = concatMap f2 xs

f3 :: Item a -> [a]
f3 (One x) = x
f3 (Many x) = concatMap f3 x

main = do
    let l1 = List [Elem 100, List [Elem 200, Elem 300, List [Elem 200, Elem 200]]]
    let l2 = Many [One [1, 2]]
    print $ f1 l1
