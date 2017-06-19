-- (script)

import Control.Category hiding ((.))

main = do
    let k  = (last <<<) <<< take
    let g  = (last <<<) <<< take
    let a = k 4 [1,2,3,4]
    putStrLn $ show a 