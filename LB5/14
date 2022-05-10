(*Написать функцию обход делителей числа, которая
выполняет операции над делителями числа, принимает три аргумента,
число, функция (например, сумма, произведение, минимум, максимум) и
инициализирующее значение. Функция должна иметь два Int аргумента и
возвращать Int.*)

open System

let rec Del(a:int,h:int,beg:int,func: int->int->int):int =
    match beg with
    |beg when beg>a/2 -> h
    |beg when a%beg = 0 -> Del(a, func h beg, beg+1, func)
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
