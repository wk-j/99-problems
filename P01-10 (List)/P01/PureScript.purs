module Main where

import Control.Monad.Eff (Eff)
import Control.Monad.Eff.Console (CONSOLE, logShow)
import Data.Array (last)
import Prelude (Unit)

main :: forall t3.              
  Eff                   
    ( console :: CONSOLE
    | t3                
    )                   
    Unit
main = do  
    let a = [1,2,3,4]
    let k = last a
    logShow (k)
    -- log "Hello, world!"
    