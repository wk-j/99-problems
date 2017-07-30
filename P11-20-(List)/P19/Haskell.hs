-- stack runghc --package strict

rotate :: [a] -> Int -> [a]
rotate xs n = take (length xs) $ drop (length xs + n) $ cycle xs

main :: IO()
main = do
    let input = ['a' .. 'h']
    print $ rotate input 3      -- "defghabc"
    print $ rotate input (-2)   -- "ghabcdef"