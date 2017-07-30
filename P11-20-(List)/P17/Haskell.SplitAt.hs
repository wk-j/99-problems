-- stack runghc --package strict

main :: IO()
main = do
    let input = ['a' .. 'i'] ++ ['k']
    print $ splitAt 3 input