let rec search f e = 
        match e with 
        | [ ] -> -1
        | head :: tail ->
        if f head then 0
        else
        let b = search f tail
        if b = -1 then -1 else b+1
    
let value = search (fun b -> b = 5) [ 3; 7; 12; 6 ]
printfn "value: %A" value