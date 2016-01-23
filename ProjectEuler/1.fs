// https://projecteuler.net/problem=1
module Problem1

let solution =
    [1 .. 999]
    |> List.filter (fun x -> x % 3 = 0 || x % 5 = 0)
    |> List.sum