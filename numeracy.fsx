(*

Functional Programming at St Matthews. 

A 1-hr crash course in functional programming. Taught, as "Programming 101",
during Science Week at St Matthews Primary School, Cambridge, UK to Years 5 
and 6 (10-11 year olds). 


History:

Samin Ishtiaq, 10/08/2013. 
    Camb Science Centre. Avoid duplicate names for tryfsharp. 
    
Tomas Petricek, 30/November/2010.
    Minor naming and indentation changes
    (to comply with the usual formatting style)
    
Samin Ishtiaq, {9,10}/March/2010. 
    Dropped areas for doubling, is_even. 
    Thanks to Tim Morley for helping out. 

Samin Ishtiaq, 9/March/2009.
    First version. 
*)


(*
   
Part 1: Calculating

Programming is calculating. We're going to begin by using F#, literally, as a
calculator:

1. Double-click the F# icon to start up the F# programming environment. 

2. This gives a you a new window with a prompt, ">". You can type 
arithmetic expressions at this prompt, like you would into any calculator.

3. Try typing in a few expressions to see what answers you get. You have to
end every expression with a ";;" and then press Enter:
*)

2+3 ;;

3+2 ;;

3*4 ;;

1*2*3*4*5 ;;

(4/2) ;;

(* 
4. Try typing in other expressions to evaluate. Use brackets to get the right
order of calculation:
*)

(2 + 3) * 4 ;;

2 + (3 * 4) ;;

2 + 3 * 4 ;;


(*
   
Part 2: Variables

1. You can give a "name" to a particular expression. You know about this idea
already: in Excel spreadsheets, you might have cell A2 hold the expression
=(2+3); you can think of "A2" as the name that holds the value 5.

2. In F#, like in maths, you use "let" to give a name to an expression. Try
this:

*)

let z = 42;;

(* 
This binds z to 42, and you can now use z in your calculations:
*)

z - 40 ;;

z + z ;;

z ;;

(*
In fact, you don't have to use "z". You can use any word, like your own
name:
*)

let samin = 42;;

samin - 40 ;;

samin - 50 ;;

(*
But it's always a good idea to use a name that makes sense for the
context. For instance, if you're calculating with the length of a rectangle,
you should use "length" rather than "foo".
*)

(* 

Part 3: Doubling/Halving

You know what doubling and halving numbers means. Say you had a number 4, 
then it's double is 8 and it's half is 2. 

*)

let x = 4 ;;

let doubleX = x * 2 ;;

let halfX = x / 2 ;;

(* 
Danger: function ahead

2. The answer "8" is all very well for a number which is 4. But
the function you know of that doubles the number (x*x) actually
applies to any number. The function says "give me a number and 
I'll give you back it's double", and this is how you write 
exactly that in F#:
*)

let double n = n * n ;;

(* 
On the left-hand side of the "=" sign is the "give me the"
parameter. On the right-hand side, is the "I'll give you back"
result.

3. Try running this program now. Here, we use it to double various
numbers: 
*)

double 3 ;;
double 5 ;;

(*

4. Now you have to do a bit thinking: Try writing down the function to
cube a number by filling out the "..." in the definition below:
*)

//let cube n = ... ;;

(* We can now use the [cube] function to generate the first 10
cubic numbers: 

First, some wrappers to make printing easier. 
*)
let printString s = 
  printf "%s" s ;;
let printStringNewline s = 
  printfn "%s" s ;;
let printNum n = 
  printf "%d" n ;;

(* Now the first 12 cubic numbers. *)
for y = 1 to 12 do
  printNum y
  printString " * "
  printNum y
  printString " * "
  printNum y
  printString " = "
//  printNum (cube y)
  printStringNewline ""   ;;



(*
1. You know what odd and even numbers are. Here's a function to test whether a
number, x, is even:
*)

let isEven x =
  if ((x % 2) = 0) then
    printStringNewline "x is even"
  else
    printStringNewline "x is not even" ;;

(*
"%" is the "remainder" operation: x%y it returns the remainder after we divide
x by y.

The isEven function uses "if-then-else", a programming language construct
that tests a condition; if the condition holds then it does the "then" part of
the program; if the condition doesn't hold, it does the "else" part of the
program.

Can you write isOdd, the function that takes a number and tests for whether
number is odd? Think how you'd modify isEven to write isOdd:

> let isOdd x   =  ...
*)

(*
2. Let's write a program to generate the times tables. First, a very simple
version, that only multiplies two numbers x and y:

> let multiply x y = ...

To generate the times table for 4, say, we actually need to multiply 4 by 1,
by 2, by 3,.... all the way to 12. We can do things stupidly like this:

> (multiply 4 1) ;;
> (multiply 4 2) ;;
> (multiply 4 3) ;;
...
> (multiply 4 12) ;;

Or we can be smart and realize that we're doing the same thing over and over
again. In such a case, we can use a "for" loop to repeatedly do (almost) the
same thing:
*)

let timesTable x =  
  for y = 1 to 12 do
    printNum (x*y)
    printStringNewline "" ;;
(*
Try it:
*)
timesTable 4 ;;
timesTable 7 ;;
timesTable 100 ;;

(*
And my favourite:
*)
timesTable 0 ;;

(*
Here's a much prettier version of timesTable:
*)
let timesTablePretty x =
  for y = 1 to 12 do
    printNum x
    printString " x "
    printNum y
    printString " = "
    printNum (y*x)
    printStringNewline ""   ;;

(*
5. Write a function to calculate the Fibonacci series. 

The n-th fibonacci number is the sum of the previous two fibonacci numbers:

fib 0 = 0 
fib 1 = 1
fib n = fib n-1 + fib n-2 
*)

let rec fib n = 
  if (n=0) then 0
  else if (n=1) then 1
  else (fib (n-1)) + (fib (n-2))
    

(*
 
Finding out more:

F# is a programming language in the ML-tradition. Look at:
        http://fsharp.net
        http://caml.inria.fr

There are lots of programming languages out there. Take a look at python,
smalltalk, JavaScript, C, ARM Assembler. 

*)
