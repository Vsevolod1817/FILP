(*Дан целочисленный массив. Найти количество чётных элементов.*)

let rec readList n = 
    match n with
       | 0-> []
       | _ -> 
          let Head = System.Convert.ToInt32(System.Console.ReadLine())
          let Tail = readList (n-1)
          Head::Tail

let ch list =
   let rec prom list count =
       match list with
       |[] -> count
       |head::tail -> 
           let newq = if head % 2 = 0 then count+1 else count
           prom tail newq
   prom list 0

let f list =
    match list with
    |[] -> 0
    |_ -> ch list

[<EntryPoint>]
 let main argv =
     printfn $"Введите количество элементов: "
     let list = readList (System.Convert.ToInt32(System.Console.ReadLine()))
     let result = f list
     printfn $"Результат: "
     printfn "%O" result
     0
