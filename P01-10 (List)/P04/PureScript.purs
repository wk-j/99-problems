module Main where

import Control.Monad.Eff.Console (logShow)
import Data.Array (length)

main = do
    let a = [1,2,3,4,5]
    logShow (length a)
