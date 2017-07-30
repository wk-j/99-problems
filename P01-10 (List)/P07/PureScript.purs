module Main where

import Control.Monad.Eff.Console (log)

data L a =  Elem a | List [L]

main = do
    log "Hello"