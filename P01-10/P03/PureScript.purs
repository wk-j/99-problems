
module Main where

import Control.Monad.Eff.Console (logShow)
import Prelude (($))
import Data.Array ((!!))


main = 
    logShow $ ([1,2,3,4,5] !! 3)
