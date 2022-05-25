module FSharpLab.Functions

// Define a function that takes an integer and returns the square of that integer
let square x = x * x
square 8

// Define a function that takes two integers and returns the sum of those integers
let add a b = a + b
add 3 5


// To define a multiline function, just use indents. No semicolons needed.
// Define "isEven" as an inner ("nested") function
// List.filter is a library function
// with two parameters: a boolean function
// and a list to work on

let evens list =
    let isEven x = x % 2 = 0
    List.filter isEven list

let oneToFive = [1;2;3;4;5]
evens oneToFive

// You can pipe the output of one operation to the next using "|>"
// Here is the same sumOfSquares function written using pipes
let sumOfSquaresTo100piped =
    [1..100] |> List.map square |> List.sum // "square" was defined earlier in this file

// You can define lambdas (anonymous functions) using the "fun" keyword
let sumOfSquaresTo100withFun =
    [1..100] |> List.map (fun x-> x*x) |> List.sum