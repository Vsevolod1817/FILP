open System

let rec min a =
    match a with
    | a when a<>0 ->
        let a1 = min(a/10)
        match a1 with
        | _ when a%10<a1 -> a%10
        | a1 -> a1
    | a->9

let rec max a =
    match a with
    | a when a<>0 ->
        let a1 = max(a/10)
        match a1 with
        | _ when a%10>a1 -> a%10
        | a1 -> a1
    | a->0

let rec mult a =
    match a with
    | 0 -> 1
    | a -> (a%10) * mult(a/10)

let rec mult1 a =
    let rec mlt a b =
        match a with
        | a when a=0 -> b
        | a ->
            let a1 = a/10
            let a2 = b*(a%10)
            mlt a1 a2
    mlt a 1

let rec max1 a =
    let rec mx a b =
        match a with
        | a when a=0 -> b
        | a when (a%10)>b ->
            let a1 = a/10
            let a2 = a%10
            mx a1 a2
        | a ->
            let a3 = a/10
            mx a3 b
    mx a 0

let rec min1 a =
    let rec mn a b =
        match a with
        | a when a=0 -> b
        | a when (a%10)<b ->
            let a1 = a/10
            let a2 = a%10
            mn a1 a2
        | a ->
            let a3 = a/10
            mn a3 b
    mn a 9

[<EntryPoint>]
let main argv = 
    printfn "Введите число: "
    let x = System.Convert.ToInt32(Console.ReadLine())
    printfn "Рекурсия вниз: "
    printfn "Произведение цифр: "
    printfn "%d" (mult1 x)
    printfn "Максимальное число: "
    printfn "%d" (max1 x)
    printfn "Минимальное число: "
    printfn "%d" (min1 x)
    printfn "Рекурсия вверх: "
    printfn "Произведение цифр: "
    printfn "%d" (mult x)
    printfn "Минимальное число: "
    printfn "%d" (min x)
    printfn "Максимальное число: "
    printfn "%d" (max x)
    0
