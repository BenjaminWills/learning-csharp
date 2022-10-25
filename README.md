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
