-- stack runghc --package strict

sp :: [a] -> Int -> Int -> [a]
sp xs n1 n2 = do 
    let t = drop (n1 - 1) xs
    take (n2 - n1 + 1) t

main :: IO()
main = do
    let input = ['a' .. 'i' ] ++ ['k']
    print $ sp input 3 7