(*Для введенного списка построить новый список, который получен из
начального упорядочиванием по количеству встречаемости элемента,
То есть из списка [5,6,2,2,3,3,3,5,5,5] необходимо получить список
[5,5,5,5,3,3,3,2,2,6].*)

let F list =
    let rec fr list a = 
        match list with
        |h::t ->
            let rec fa list x k =
                match k with
                |k when k>0 ->
                    let l1 = list @ [x]
                    let k1 = k-1
                    fa l1 x k1
                |k -> list
            let a1 = fa a (fst h) (snd h)
            fr t a1
        |[] -> a
    fr list []
        

[<EntryPoint>]
let main argv =
    printfn "%A" (F(List.sortByDescending (fun(_,x) -> x) ([5;6;2;2;3;3;3;5;5;5] |> List.countBy id)))
    0
