using System;
using System.Collections.Generic;
using System.Text;

class Multy
{
    static void PrintOriginal(string s)
    {
        Console.WriteLine($"원본: {s}");
    }
    static void PrintUpper(string s)
    {
        Console.WriteLine($"대문자: {s.ToUpper()}");
    }
    static void PrintLower(string s)
    {
        Console.WriteLine($"소문자: {s.ToLower()}");
    }
    static void PrintLength(string s)
    {
        Console.WriteLine($"길이: {s.Length}");
    }
    static void Main()
    {
        Console.WriteLine("=== 문자열 처리 파이프라인 ===");
        Console.WriteLine();
        Action<string> pipeline = PrintOriginal;

        Console.WriteLine("--- 단계 1: 원본 출력만 ---");
        pipeline("Hello World");
        Console.WriteLine();

        Console.WriteLine("--- 단계 2: 대문자 추가 ---");
        pipeline += PrintUpper;
        pipeline("Hello World");
        Console.WriteLine();

        Console.WriteLine("--- 단계 3: 소문자, 길이 추가 ---");
        pipeline += PrintLower;
        pipeline += PrintLength;
        pipeline("Hello World");
        Console.WriteLine();

        Console.WriteLine("--- 단계 4: 대문자 제거 ---");
        pipeline -= PrintUpper;
        pipeline("Hello World");

    }
}
