module Main where

import Control.Monad.Eff.Console (CONSOLE, logShow)
import Control.Monad.Eff (Eff)
import Data.Array (reverse)
import Prelude (Unit)

main :: forall t5.              
  Eff                   
    ( console :: CONSOLE
    | t5                
    )                   
    Unit
main = do 
    let a = [1,2,3,4,5]
    let b = reverse a
    logShow b