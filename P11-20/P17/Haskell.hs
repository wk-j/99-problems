-- stack runghc --package strict

sa :: Int -> [a] -> ([a], [a])
sa n xs = 
    if length xs > n then
        (take n xs, drop n xs)
    else 
        (xs, [])

main :: IO()
main = do
    let input = ['a' .. 'i' ] ++ ['k']
    print $ sa 3 input