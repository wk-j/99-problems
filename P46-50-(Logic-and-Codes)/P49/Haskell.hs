-- stack runghc --package strict

gray :: Integral a => a -> [String]
gray 0 = [""]
gray n = foldr (\s acc -> ("0" ++ s):("1" ++ s):acc) [] $ gray (n-1)

main :: IO()
main =  do
    print $ gray 2
    print $ gray 3