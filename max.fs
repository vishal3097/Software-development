let rec max l=
    if List.length l=1 then
     List.head l
     else if List.head l> max(List.tail l) then
     List.head l
     else max(List.tail l) 

let maxOfNumbers = max[-5; 0; -12; -3]
printfn "max of list: %d" maxOfNumbers
