-- stack runghc -- -Wall 

{-# LANGUAGE FlexibleInstances #-}

dup :: Int -> [a] -> [a]
dup count = concatMap (replicate count)

main :: IO()
main =
    print $ dup 3 [1 :: Int,2,3]

{-
P11-20/P15/Haskell.hs:8:5: warning: [-Wtype-defaults]
    • Defaulting the following constraints to type ‘Integer’
        (Show a0)
          arising from a use of ‘print’ at P11-20/P15/Haskell.hs:8:5-25
        (Num a0) arising from the literal ‘1’ at P11-20/P15/Haskell.hs:8:20
    • In the expression: print $ dup 3 [1, 2, 3]
      In an equation for ‘main’: main = print $ dup 3 [1, 2, 3]
[1,1,1,2,2,2,3,3,3]
-}

