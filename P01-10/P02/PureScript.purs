module Main where

import Control.Monad.Eff (Eff)
import Control.Monad.Eff.Console (CONSOLE, logShow)
import Data.Array (length, (!!))
import Prelude (Unit, (-))

main :: forall t1.              
  Eff                   
    ( console :: CONSOLE
    | t1                
    )                   
    Unit
main =  do
    let a = [1,2,3,4,5]
    let k = a !! (length a - 2)
    logShow k