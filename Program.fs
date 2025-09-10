// Church booleans
let TRUE x y = x
let FALSE x y = y
let IF b x y = b x y
let NOT b = IF b FALSE TRUE

// Church numerals
let ZERO f x = x
let SUCC n f x = f (n f x)

// Predecessor

let LT (a: int) (b: int) =
    match System.Math.Sign a - b with
    | -1 -> TRUE
    | _ -> FALSE


[<EntryPoint>]
let main argv = //
    let result = IF NOT (LT 1 2) "Less" "Not Less"
    printfn "%A" result
    let result2 = IF NOT TRUE 1 2
    printfn "%A" result2

    0
