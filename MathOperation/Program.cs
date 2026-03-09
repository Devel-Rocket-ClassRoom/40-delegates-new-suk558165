using System;


static int Add(int a, int b) => a + b;
static int Subtract(int a, int b) => a - b;
static int Multiply(int a, int b) => a * b;
static int Divide(int a, int b) => a / b;



    int a = 20;
    int b = 4;
    Console.WriteLine("=== 사칙연산 대리자 ===\n");
    MathOp op = Add;
    Console.WriteLine("[덧셈]");
    Console.WriteLine($"{a} + {b} = {op(a,b)}\n");

    op = Subtract;
    Console.WriteLine("[뺄셈]");
    Console.WriteLine($"{a} - {b} = {op(a,b)}\n");

    op = Multiply;
    Console.WriteLine("[곱셈]");
    Console.WriteLine($"{a} * {b} = {op(a,b)}\n");

    op = Divide;
    Console.WriteLine("[나눗셈]");
    Console.WriteLine($"{a} / {b} = {op(a,b)}\n");












delegate int MathOp(int a, int b);

