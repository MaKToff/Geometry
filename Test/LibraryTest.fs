module LibraryTest

open NUnit.Framework
open GeomLibrary

[<TestCase([|1.0f; 2.0f; 2.0f; 1.0f|], [|2.0f; 2.0f; 1.0f; 1.0f|], Result = "This is a convex quadrangle")>]
[<TestCase([|-2.0f; 0.0f; 2.0f; 0.0f|], [|0.0f; 2.0f; 0.0f; -2.0f|], Result = "This is a convex quadrangle")>]
[<TestCase([|-3.0f; 1.0f; 0.0f; 1.0f|], [|1.0f; 1.0f; 0.0f; -1.0f|], Result = "This is not a convex quadrangle")>]
[<TestCase([|-1.0f; 0.0f; 1.0f; 1.0f|], [|2.0f; 0.0f; -2.0f; 1.0f|], Result = "This is a triangle")>]
[<TestCase([|-1.0f; 0.0f; 1.0f; 2.0f|], [|-1.0f; 0.0f; 1.0f; 2.0f|], Result = "This is a line")>]
[<TestCase([|1.0f; 1.0f; 1.0f; 1.0f|], [|2.0f; 2.0f; 2.0f; 2.0f|], Result = "This is a dot")>]
let test (x : float32 array, y : float32 array) =
    let lib = Library()
    lib.result(x, y)