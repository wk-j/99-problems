
module  Main where

import Control.Monad.Eff.Console (logShow)
import Data.Array (uncons, (:))
import Data.Foldable (foldr)
import Data.Maybe (Maybe(..))
import Prelude ((==))

zip xs = 
    let f x []  = [x]
        f x a = 
            case uncons a of 
            Just { head: h, tail : t }  ->
                if h == x then h : t
                else x : h : t 
            Nothing -> []
    in foldr f [] xs

main = do
    let a = [1,1,1,2,3,3,4,5]
    logShow (zip a)