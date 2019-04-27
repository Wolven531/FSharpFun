// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    let input = stdin.ReadLine()
    printfn "User entered: %s" input
    let intVal = input |> int
    printfn "int val: %i" intVal
    0 // return an integer exit code
