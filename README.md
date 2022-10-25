# Learning C#

## Getting Set Up

In this repository I will be documenting my learning of `C#`.

`C#` Files have the suffix .cs

```sh
csharp_example.cs
```

`C#` is an `object oriented` language. To run the files we need to use an extension called `dotnet` (https://dotnet.microsoft.com/en-us/learn/dotnet/what-is-dotnet). To create the file we need to write the following command in zsh:

```sh
dotnet new {application type} -o {application name}
```

This will create a file structure that allows us to run the code. Next we have some example skeleton code written in `C#`:

```sh
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string my_name = args[0];
            Console.WriteLine("Hello World from " + my_name);
        }
    }
}
```

To run this program from your terminal, navigate to the `bin/debug/net6.0` directory and execute the following command:

```sh
dotnet {application name}.dll {arguments specified}
```

Be sure to rebuild your application each time you make a change to it by using the following command at the top level of the directory:

```sh
dotnet build {directory_name}
```

Then redirect to `bin/debug/net6.0` and re run the code.

## Data Types

| Type   | Description                                     |
| ------ | ----------------------------------------------- |
| bool   | true/false                                      |
| byte   | any 8 bit integer ($0 \lt int \leq 255$)        |
| sbyte  | signed byte ($-128 \leq int \leq 127$)          |
| char   | character defined using single quotes           |
| string | string defined using double quotes              |
| float  | floating point number, must end in f e.g 23.23f |
| double | more precise than a floating point number       |

examples of assignment:

```sh
byte number = 2;
int count = 10;
float floating_point = 18.2f;
char character = 'B';
string first_name = "Ben";
bool im_hungry = true;
```

Conveniently we can actually use the `var` keyword to allow C# to infer the datatype. so the above becomes:

```sh
var number = 2;
var count = 10;
var floating_point = 18.2f;
var character = 'B';
var first_name = "Ben";
var im_hungry = true;
```

However do be warned that var will never assign a byte, only an integer.

To `convert` one variable type to another we write:

```sh
float f = 1.0f;
int i = (int)f;
```

One must be careful though as if you convert from a larger type to a smaller type information will be lost. This process is called `casting`.

We can use `Convert` to convert non compatible data types, such as strings to integers.

```sh
string s = "1";

int i = Convert.ToInt32(s);
OR
int j = int.Parse(s);
```

## Formatting strings

Say we want to format a string to print to the console. We can write

```sh
Console.WriteLine("{0} {1}",placeholder_0_filler,placeholder_1_filler);
```

So for example:

```sh
Console.WriteLine("{0} {1}",byte.MinValue,byte.MaxValue);
--> 0 255
```

## Error Handling

We can use `try` `catch` blocks to handle errors that would otherwise crash the program.

```sh
try
{
    code
}
catch(Exception)
{
    code
}
```

## Operators

There are 5 types of operators in c#:

- Arithmetic
- Comparison
- Assignment
- Logical
- Bitwise

### Arithmetic Operators

These are operators like add (+), subtract (-), multiply (\*), divide (/), remainder (%), increment (++) and decrement (--).

| Operation | Operator |
| --------- | -------- |
| add       | +        |
| subtract  | -        |
| multiply  | \*       |
| divide    | /        |
| remainder | %        |
| increment | ++       |
| decrement | --       |

The increment operators can be used in 2 ways:

```sh
int a = 1;
int b = a++;
```

In this case a = 2 and b = 1

However in this block

```sh
int a = 1;
int b = ++a
```

a = 2 and b = 2

### Comparison Operators

| Operation                | Operator |
| ------------------------ | -------- |
| equal                    | ==       |
| not equal                | !=       |
| greater than             | >        |
| greater than or equal to | >=       |
| less than                | <        |
| less than or equal to    | <=>      |

### Assignment Operators

| Operation                 | Operator |
| ------------------------- | -------- |
| assignment                | =        |
| addition assignment       | +=       |
| subtraction assignment    | -=       |
| multiplication assignment | \*=      |
| division assignment       | \=       |

### Logical Operators

| Operation | Operator           |
| --------- | ------------------ |
| and       | &&                 |
| or        | two vertical lines |
| not       | !                  |

### Bitwise Operators

| Operation | Operator          |
| --------- | ----------------- |
| and       | &                 |
| or        | one vertical line |

## Comments

In c# A `single line` comment is denoted with `\\` and a `multi line comment` is denoted with `/* comment */`
