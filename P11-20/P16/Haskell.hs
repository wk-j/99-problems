-- stack runghc --package strict

drop' :: [a] -> Int -> [a]
drop' xs n = do
    let h = take (n - 1) xs
    if length xs > (n - 1) then
        let t = drop n xs in h ++ drop' t n
    else h

main :: IO()
main = 
    print $ drop' "abcdefghik" 3 