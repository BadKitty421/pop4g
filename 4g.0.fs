module vec2d

let len (x:float, y:float) : float =
  let v = sqrt(x**2.0 + y**2.0)
  v

let ang (x:float, y:float) : float = 
  let v = atan2 x y
  v

let scale (a:float) (x:float, y:float) : float*float =
  let x2 = a*x
  let y2 = a*y
  let v = (x2, y2)
  v

let add (x1:float, y1:float) (x2:float, y2:float) : float*float =
  let x3 = x1 + x2
  let y3 = y1 + y2
  let v = (x3, y3)
  v

let dot (x1:float, y1:float) (x2:float, y2:float) : float =
  let x3 = x1 * x2
  let y3 = y1 * y2
  let v = x3 + y3
  v