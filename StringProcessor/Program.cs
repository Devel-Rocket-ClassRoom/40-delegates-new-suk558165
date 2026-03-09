using System;

class StringProcessorDemo
{
    // 1. 대리자 선언
    delegate string StringProcessor(string s);

    // 2. 문자열 가공 메서드들
    static string ToUpperCase(string s) => s.ToUpper();
    static string ToLowerCase(string s) => s.ToLower();
    static string AddBrackets(string s) => "[" + s + "]";
    static string Reverse(string s)
    {
        char[] chars = s.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }

    // 3. ProcessAndPrint 메서드
    static void ProcessAndPrint(string input, StringProcessor processor)
    {
        string result = processor(input);
        Console.WriteLine("결과: " + result);
    }

    static void Main()
    {
        string input = "Hello World";

        Console.WriteLine("=== 문자열 가공기 ===");
        Console.WriteLine("원본: " + input);

        Console.WriteLine("[대문자 변환]");
        ProcessAndPrint(input, ToUpperCase);

        Console.WriteLine("[소문자 변환]");
        ProcessAndPrint(input, ToLowerCase);

        Console.WriteLine("[괄호 추가]");
        ProcessAndPrint(input, AddBrackets);

        Console.WriteLine("[문자열 뒤집기]");
        ProcessAndPrint(input, Reverse);
    }
}