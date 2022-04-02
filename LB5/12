open System

let F (a:string) =
    match a with
    | "F#" -> printfn "ПОДЛИЗА!!!"
    | "Prolog" -> printfn "ПОДЛИЗА!!!"
    | a -> printfn "ну ладно"

[<EntryPoint>]
let main argv = 
    printfn "Какой ваш любимый ЯП?"
    printfn "Каррирование: "
    let kar = Console.ReadLine()
    kar|>F
    printfn "Суперпозиция: "
    (Console.ReadLine >> F >> Console.WriteLine)()
    0
