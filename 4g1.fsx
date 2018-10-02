open vec2d

printfn "White-box testing of vec2d library"
printfn "   Unit: len"
printfn "      Branch: 0 - %b" (len (3.0,4.0) = 5.0)
printfn "      Branch: 1 - %b" (len (0.0,0.0) = 0.0)
printfn "      Branch: 2 - %b" (len (-3.0,-4.0) = 5.0)
printfn "      Branch: 3 - %b" (len (-4.0,3.0) = 5.0)

printfn "   Unit: Ang"
printfn "      Branch: 0 - %b" ((ang (0.0, 1.0)) = 0.0)
printfn "      Branch: 1 - %b" ((ang (1.0, 1.0)) = System.Math.PI/4.0)
printfn "      Branch: 2 - %b" ((ang (1.0, 0.0)) = System.Math.PI/2.0)
printfn "      Branch: 3 - %b" ((ang (0.0, 0.0)) = 0.0)


printfn "   Unit: Scale"
printfn "      Branch: 0 - %b" ((scale 3.0 (2.0, 3.0)) = (6.0,9.0))
printfn "      Branch: 0 - %b" ((scale 2.0 (2.0, 3.0)) = (4.0,6.0))
printfn "      Branch: 0 - %b" ((scale 3.0 (0.0, 0.0)) = (0.0,0.0))
printfn "      Branch: 0 - %b" ((scale 0.0 (2.0, 3.0)) = (0.0,0.0))

printfn "   Unit: Add"
printfn "      Branch: 0 - %b" ((add (2.0, 3.0) (4.0, 5.0)) = (6.0, 8.0))
printfn "      Branch: 0 - %b" ((add (-1.0, -1.0) (4.0, 5.0)) = (3.0, 4.0))
printfn "      Branch: 0 - %b" ((add (0.0, 0.0) (4.0, 5.0)) = (4.0, 5.0))
printfn "      Branch: 0 - %b" ((add (200.0, 300.0) (4.0, 5.0)) = (204.0, 305.0))

printfn "   Unit: Dot"
printfn "      Branch: 0 - %b" ((dot (2.0, 3.0) (4.0, 5.0)) = 23.0)
printfn "      Branch: 0 - %b" ((dot (2.0, 4.0) (3.0, 5.0)) = 26.0)
printfn "      Branch: 0 - %b" ((dot (0.0, 3.0) (1000.0, 5.0)) = 15.0)
printfn "      Branch: 0 - %b" ((dot (-3.0, 3.0) (4.0, 5.0)) = 3.0)
