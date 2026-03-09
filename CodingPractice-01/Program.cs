using System;
using System.Xml.Serialization;

//static void Hello() => Console.WriteLine("Hello Delegate");

//SayDelegate sayPointer = new SayDelegate(Hello);

//sayPointer();

//sayPointer.Invoke();

//delegate void SayDelegate();


//## 2. 대리자 인스턴스 생성 방법

//static void Hi() => Console.WriteLine("안녕하세요.");

//SayDelegate say = Hi;
//say();

//var hi = new SayDelegate(Hi);
//hi();

//delegate void SayDelegate();


//## 3. 매개변수와 반환값이 있는 대리자
//static double GetArea(int r) => 3.14 * r * r;
//GetAreaDelegate pointer = GetArea;

//Console.WriteLine(pointer.Invoke(10));
//Console.WriteLine(pointer(10));

//delegate double GetAreaDelegate(int r);


//## 4. 강력한 형식의 대리자

//MathOperation pow = Math.Pow;

//double result = pow(2, 10);
//Console.WriteLine(result);

//delegate double MathOperation(double x, double y);



//## 5. 정적 메서드 참조

//Transformer t = Calculator.Square;
//Console.WriteLine(t(5));

//delegate int Transformer(int x);

//class Calculator
//{
//    public static int Square(int x) => x * x;
//}


//## 6. 멀티캐스트 대리자: 진행률 보고
//ProgressReporter reporter = WriteToConsole;
//reporter += WriteToFile;
//static void WriteToConsole(int percent)
//{
//    Console.WriteLine($"진행률: {percent}%");
//}

//static void WriteToFile(int percent)
//{
//    // 파일에 기록하는 로직 (예시)
//    Console.WriteLine($"[파일 기록] {percent}%");
//}


//for (int i = 0; i <= 100; i += 25)
//{
//    reporter(i);
//    Console.WriteLine();
//}

//delegate void ProgressReporter(int percent);

//## 7. 대리자를 매개변수로 전달
// 다른 동작을 전달
//RunnerCall(Go);
//Console.WriteLine();
//RunnerCall(Back);
//static void Go() => Console.WriteLine("직진");
//static void Back() => Console.WriteLine("후진");

//static void RunnerCall(Runner runner)
//{
//    Console.WriteLine("=== 실행 시작 ===");
//    runner();
//    Console.WriteLine("=== 실행 종료 ===");
//}

//delegate void Runner();


//## 8. Action 대리자

//Action greet = () => Console.WriteLine("안녕하세요!");
//greet();


//Action<string> print = (msg) => Console.WriteLine(msg);
//print("Hello, Action!");

//Action<string, int> printRepeat = (msg, count) =>
//{
//    for (int i = 0; i < count; i++)
//    {
//        Console.WriteLine(msg);
//    }
//};
//printRepeat("반복", 3);

//## 9. Func 대리자
//Func<int> getNumber = () => 42;
//Console.WriteLine(getNumber());

//// 매개변수와 반환값이 있는 Func
//Func<int, int> square = (x) => x * x;
//Console.WriteLine(square(5));

//// 여러 매개변수와 반환값
//Func<int, int, int> add = (a, b) => a + b;
//Console.WriteLine(add(3, 7));

//// 문자열 반환
//Func<int, int, string> addToString = (a, b) => (a + b).ToString();
//Console.WriteLine(addToString(3, 5));


//## 10. Predicate 대리자
//Predicate<int> isEven = (x) => x % 2 == 0;
//Predicate<int> isPositive = (x) => x > 0;

//Console.WriteLine(isEven(4));     
//Console.WriteLine(isEven(7));      
//Console.WriteLine(isPositive(5));  
//Console.WriteLine(isPositive(-3)); 

//## 11. 익명 메서드
// delegate 키워드로 익명 메서드 정의
SayDelegate say = delegate ()
{
    Console.WriteLine("반갑습니다.");
};

say();

delegate void SayDelegate();


