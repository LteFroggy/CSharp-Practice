using System;
using System.Globalization;

// 1. 기본 메서드 선언
{
    Calculator calculator = new Calculator();
    Console.WriteLine(calculator.Add(3, 5));
    Console.WriteLine();
    Console.WriteLine();
}

// 2. 정적 메서드 호출
{
    Console.WriteLine(MathHelper.Square(5));
    Console.WriteLine();
    Console.WriteLine();
}

// 3. 값 전달
{
    int num = 10;
    Console.WriteLine($"[1] 호출 전 : {num}");
    UtilClass.ChangeValue(num);
    Console.WriteLine($"[3] 호출 후 : {num}");
    Console.WriteLine();
    Console.WriteLine();
}

// 4. 값 전달과 참조 전달 비교
{
    int num = 10;

    Console.WriteLine($"PassByValue 실행 전 : {num}");
    UtilClass.PassByValue(num);
    Console.WriteLine($"PassByValue 실행 후 : {num}");
    Console.WriteLine();
    Console.WriteLine($"PassByReference 실행 전 : {num}");
    UtilClass.PassByReference(ref num);
    Console.WriteLine($"PassByReference 실행 후 : {num}");
    Console.WriteLine();
    Console.WriteLine();
}

// 5. ref키워드
{
    int num = 10;
    Console.WriteLine($"[1] 호출 전 : {num}");
    UtilClass.ChangeRef(ref num);
    Console.WriteLine($"[3] 호출 후 : {num}");
    Console.WriteLine();
    Console.WriteLine();
}


// 6. ref를 사용한 두 변수 교환
{
    int a = 10, b = 20;
    Console.WriteLine($"교환 전 : a = {a}, b = {b}");
    UtilClass.Swap(ref a, ref b);
    Console.WriteLine($"교환 후: a = {a}, b = {b}");
    Console.WriteLine();
    Console.WriteLine();
}

// 7. out 키워드
{
    int result;
    Calculator.Calculate(out result);
    Console.WriteLine($"결과 : {result}");
    Console.WriteLine();
    Console.WriteLine();
}

// 8. Out을 이용한 여러 값 반환
{
    string fullName = "홍길동", lastName, firstName;
    UtilClass.SplitName(fullName, out firstName, out lastName);
    Console.WriteLine($"성 : {lastName}, 이름 : {firstName}");
    Console.WriteLine();
    Console.WriteLine();
}

// 9. out 변수 인라인 선언
{
    string str = "123";
    int output;

    int.TryParse(str, out output);
    Console.WriteLine();
    Console.WriteLine();
}

// 10. in 키워드
{
    Point ptr = new Point(10, 20);
    Point.PrintPoint(ptr);
    Console.WriteLine();
    Console.WriteLine();
}

// 11. params 가변 길이 매개변수
{
    Console.WriteLine(UtilClass.SumAll(3, 4, 5, 6, 23782, 8 ,9, 10, 15, 2, 4, 24, 3, 5));
    Console.WriteLine(UtilClass.SumAll(15, 78 ,452));
    Console.WriteLine();
    Console.WriteLine();
}

// 12. params와 일반 매개변수 함께 사용
{
    UtilClass.PrintMessage("합계", 1, 2, 3, 4, 5);
    Console.WriteLine();
    Console.WriteLine();
}

// 13. 식 본문 메서드
{
    UtilClass.Add(15, 15);
    UtilClass.Square(5);
    UtilClass.Print("Hello, World!");
    Console.WriteLine();
    Console.WriteLine();
}

// 14. 선택적 매개변수
{
    UtilClass.Add(5);
    UtilClass.Add(5, 3);
    Console.WriteLine();
    Console.WriteLine();
}

// 15. 여러 개의 선택적 매개변수
{
    UtilClass.Greet();
    UtilClass.Greet("홍길동");
    UtilClass.Greet("홍길동", "안녕하세요");
    Console.WriteLine();
    Console.WriteLine();
}

// 16. 명명된 인수
{
    UtilClass.PrintInfo("홍길동", 25, "서울");
    UtilClass.PrintInfo("김철수", city : "부산", age : 25);
    UtilClass.PrintInfo(city : "대전", age : 28, name : "이영희");
    Console.WriteLine();
    Console.WriteLine();
}