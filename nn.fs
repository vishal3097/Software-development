namespace v

module Say =
    let rec max list = 
            match list with
|[x] -> x 
| _ -> if List.head list > max (List.tail list) then List.head list  

else max(List.tail list) 