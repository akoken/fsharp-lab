module FSharpLab.Functions

let square x = x * x
square 8

let add a b = a + b
add 3 5


// to define a multiline function, just use indents. No semicolons needed.
// Define "isEven" as an inner ("nested") function
// List.filter is a library function
// with two parameters: a boolean function
// and a list to work on

let evens list =
    let isEven x = x % 2 = 0
    List.filter isEven list

let oneToFive = [1;2;3;4;5]
evens oneToFive