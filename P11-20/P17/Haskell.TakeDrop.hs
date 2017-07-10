-- stack runghc --package strict

main :: IO()
main = do
    let input = ['a' .. 'i'] ++ ['k']
    print  (take 3 input, drop 3 input)