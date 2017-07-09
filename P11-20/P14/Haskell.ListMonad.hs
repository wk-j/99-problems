-- stack runghc --package strict

d1 xs = xs >>= \x -> [x,x]

d2 xs = do
    x <- xs
    [x,x]

main :: IO()
main = do
    print $ d1 [1,2,3]
    print $ d2 [1,2,3]