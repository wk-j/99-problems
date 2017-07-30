module Main where

import Data.List

import Control.Monad.Eff.Console (log, logShow)
import Data.Array (uncons)
import Data.Array.Partial (head)
import Data.Foldable (foldr)
import Data.Maybe (Maybe(..))
import Prelude ((==))

pack xs = do
    let f x [] = []
        f x a = 
            if (head x) == x then 
                (x : h) : (tail a)
            else
                x : a

    foldr f xs []

main = do
    let x = [1,1,1,2,2,3]
    logShow (pack x)