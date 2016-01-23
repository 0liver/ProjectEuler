// https://projecteuler.net/problem=2
module Problem2

let prependNext (arr : int[]) =
    Array.append [| arr.[0] + arr.[1] |] arr

let prependUpTo limit (arr : int[]) =
    let mutable newArr = arr
    while newArr.[0] < limit
        do newArr <- prependNext newArr
    newArr

let solution =
    [| 2; 1 |]
    |> prependUpTo 4000000
    |> Array.filter (fun i -> i <= 4000000 && i % 2 = 0)
    |> Array.sum