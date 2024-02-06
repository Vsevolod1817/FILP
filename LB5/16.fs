(*Протестировать написанную функцию. Построить отдельные
функции для вычисления числа Эйлера и НОД.*)

open System

let rec G a b =
    match a with
    |_ when a%b = 0 -> b
    |_ -> G b (a%b)

let rec Del(a:int,h:int,beg:int,func: int->int->int):int =
    match beg with
    |beg when beg=a -> h
    |beg when G a beg = 1 -> Del(a, func h beg, beg+1, func)
    |beg -> Del(a,h,beg+1,func)

let rec Eyl(a:int,h,beg:int):int =
    match a with
    |a when beg = a -> h
    |a when G a beg = 1 ->
        printfn $"Взаимно простое число: {beg}"
        Eyl(a,h+1,beg+1)
    |a->Eyl(a,h,beg+1)

let F (a:int, h:int, func: int->int->int) = Del(a,h,1,func)
let E a h = Eyl(a,h,1)

[<EntryPoint>]
let main argv =
    printfn "Введите число: "
    let a = System.Convert.ToInt32(Console.ReadLine())
    printfn "Функции обхода: "
    printfn $"Сумма делителей: {a}: {F(a,0,fun a b -> a+b)}"
    printfn $"Произведение делителей: {a}: {F(a,1,fun a b -> a*b)}"
    printfn $"Кол-во взаимно простых элементов числа: {a}: {E a 0}"
    0
