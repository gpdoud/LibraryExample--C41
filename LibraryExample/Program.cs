using clib = ConsoleLibrary;
var x = 12;
var y = 4;

Console.WriteLine($"{x} + {y} = {clib.Math.Add(x,y)}");
Console.WriteLine($"{x} - {y} = {clib.Math.Sub(x,y)}");
Console.WriteLine($"{x} * {y} = {clib.Math.Mult(x,y)}");
Console.WriteLine($"{x} / {y} = {clib.Math.Div(x,y)}");
Console.WriteLine($"{x} inverse = {clib.Math.Inverse(x):F4}");
Console.WriteLine($"{x} % {y} = {clib.Math.Modulo(x, y)}");
Console.WriteLine($"{x} cubed = {clib.Math.Cubed(x):N0}");
Console.WriteLine($"{x} pow {y} = {clib.Math.Power(x, y):N0}");