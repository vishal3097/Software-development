let rec zip (l1,l2) =
    if List.length l1 = 1 && List.length l2 = 1 
    then [(List.head l1,List.head l2)]
    else zip([List.head l1],[List.head l2]) @ zip ((List.tail l1),(List.tail l2))

    
let pair = zip (["a"; "b"; "c"; "d"; "e"], [1; 2; 3; 4; 5])
printfn "pair: %A" pair
