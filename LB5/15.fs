(*Написать функцию обход взаимно простых компонентов
числа, которая выполняет операции над числами, взаимно простыми 
с данным, принимает три аргумента, число, функция (например, сумма,
произведение, минимум, максимум, количество) и инициализирующее
значение. Функция должна иметь два Int аргумента и возвращать Int.*)

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


let F (a:int, h:int, func: int->int->int) = Del(a,h,1,func)

[<EntryPoint>]
let main argv =
    printfn "Введите число: "
    let a = System.Convert.ToInt32(Console.ReadLine())
    printfn "Функции обхода: "
    printfn $"Сумма делителей: {a}: {F(a,0,fun a b -> a+b)}"
    printfn $"Произведение делителей: {a}: {F(a,1,fun a b -> a*b)}"
    0
