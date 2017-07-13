-- stack runghc --package strict

insertAt :: Int -> a -> [a]  -> [a]
insertAt n s xs = 
    let (h, t) = splitAt (n - 1) xs in h ++ s : t

main :: IO()
main = do
    let input = ["a", "b", "c", "d"]
    print $ insertAt 2 "ALFA" input