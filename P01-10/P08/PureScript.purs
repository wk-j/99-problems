
module  Main where

import Control.Monad.Eff.Console (log, logShow)
import Data.Array (concat, last)
import Data.Foldable (foldl)
import Prelude ((==))

zip xs = 
    let f x a = 
        let lastt = last x
        in  
            case lastt of
            | Just l -> 
                if l == x then a
                else a @ [l]
            | Nothing ->
                a
    in foldl (\x a -> f) xs []

main = do
    let a = [1,1,1,2,3,3,4,5]
    logShow (zip a)