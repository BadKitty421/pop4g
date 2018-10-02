open vec2d

printfn "White-box testing of vec2d library"
printfn "   Unit: len"
printfn "      Branch: 0 - %b" (len (3.0,4.0) = 5.0)


printfn "   Unit: Ang"
printfn "      Branch: 0 - %b" ()

printfn "   Unit: Scale"
printfn "      Branch: 0 - %b" ((scale 3.0 (2.0, 3.0) = (3.0,9.0))

printfn "   Unit: Add"
printfn "      Branch: 0 - %b" ((add (2.0, 3.0) (4.0, 5.0)) = (6.0, 8.0)

printfn "   Unit: Dot"
printfn "      Branch: 0 - %b" ((dot (2.0, 3.0) (4.0, 5.0)) = 23))