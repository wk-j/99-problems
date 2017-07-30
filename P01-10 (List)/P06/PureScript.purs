module Main where

import Control.Monad.Eff.Console (logShow, CONSOLE)
import Control.Monad.Eff (Eff)
import Data.Array (reverse)
import Prelude ((==), Unit)
import Data.Eq (class Eq)

p1 :: forall t3. Eq t3 => Array t3 -> Boolean
p1 xs = (reverse  xs) == xs

main :: forall t7.              
  Eff                   
    ( console :: CONSOLE
    | t7                
    )                   
    Unit
main =  do
    let a = [1,2,3,2,1]
    let rs = p1 a
    logShow rs
