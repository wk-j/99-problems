module Main where

import Control.Monad.Eff.Console (CONSOLE, logShow)
import Control.Monad.Eff 
import Data.Array ((!!))
import Prelude (($), Unit)

main :: forall t3.              
  Eff                   
    ( console :: CONSOLE
    | t3                
    )                   
    Unit
main = 
    logShow $ ([1,2,3,4,5] !! 3)