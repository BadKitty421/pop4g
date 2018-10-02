open vec2d

let polyLen (n:int) : float =
    let n = (float)n
    let x1 = cos((2.0*System.Math.PI*0.0)/n)
    let x2 = cos((2.0*System.Math.PI*1.0)/n)
    let y2 = sin((2.0*System.Math.PI*1.0)/n)
    let v1 = scale -1.0 (x1, 0.0)
    let v3 = add v1 (x2, y2)
    len v3 * 1000.0


printfn "%A" (polyLen 1000)


/// opgave B: Når n bliver højere bliver omkredsen mere præcis, evt ændre på n
/// med eksempler
