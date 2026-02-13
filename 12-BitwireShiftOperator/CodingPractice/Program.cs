using System; 

{
    // 1-1. 이진수 리터럴
    int a = 0b1010;
    int b = 0b_1010;
    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine();
    Console.WriteLine();
}

// 1-2. 10진수와 2진수 변환
{
    int a = 10;
    string binInt = Convert.ToString(a, 2);
    Console.WriteLine($"10진수 {a} = 2진수 {binInt}");
    Console.WriteLine($"2진수 {binInt} = 10진수 {a}");
    Console.WriteLine();
    Console.WriteLine();
}

// 2-1. 비트 And 연산자
{
    byte x = 0b1010, y = 0b1100;
    Console.WriteLine($"  {Convert.ToString(x, 2)} ({x})");
    Console.WriteLine($"& {Convert.ToString(y, 2)} ({y})");
    Console.WriteLine($"----");
    Console.WriteLine($"  {Convert.ToString(x & y, 2)}  ({x & y})");
    Console.WriteLine();
    Console.WriteLine();
}

// 2-2. 비트 Or 연산자
{
    byte x = 0b1010, y = 0b1100;
    Console.WriteLine($"  {Convert.ToString(x, 2)} ({x})");
    Console.WriteLine($"| {Convert.ToString(y, 2)} ({y})");
    Console.WriteLine($"----");
    Console.WriteLine($"  {Convert.ToString(x | y, 2)}  ({x | y})");
    Console.WriteLine();
    Console.WriteLine();
}

// 2-3. 비트 XOR 연산자 (^)
{
    byte x = 0b1010, y = 0b1100;
    Console.WriteLine($"  {Convert.ToString(x, 2)} ({x})");
    Console.WriteLine($"^ {Convert.ToString(y, 2)} ({y})");
    Console.WriteLine($"----");
    Console.WriteLine($"  {Convert.ToString(x ^ y, 2)}  ({x ^ y})");
    Console.WriteLine();
    Console.WriteLine();
}

// 2-4. 비트 NOT 연산자 (^)
{
    byte x = 0b0000_1010;
    Console.WriteLine($"~{Convert.ToString(x, 2).PadLeft(8, '0')} ({x})");
    Console.WriteLine($"----------");
    int intResult = (int)~x;
    Console.WriteLine($"결과값 : {~x}");
    Console.WriteLine($"{Convert.ToString((byte)intResult, 2).PadLeft(8, '0')}  ({(byte)intResult})");
    Console.WriteLine();
    Console.WriteLine();
}

// 2-5. 비트 연산자 종합
{
    int x = 0b1010, y = 0b0110;
    Console.WriteLine($"x = {x} (0b{Convert.ToString(x, 2)})");
    Console.WriteLine($"y = {y} (0b{Convert.ToString(y, 2)})");
    Console.WriteLine();
    Console.WriteLine($"x & y = {x & y} (0b{Convert.ToString(x & y, 2).PadLeft(4, '0')})");
    Console.WriteLine($"x | y = {x | y} (0b{Convert.ToString(x | y, 2).PadLeft(4, '0')})");
    Console.WriteLine($"x ^ y = {x ^ y} (0b{Convert.ToString(x ^ y, 2).PadLeft(4, '0')})");
    Console.WriteLine($"~x = {~x}");
    Console.WriteLine();
    Console.WriteLine();
}

// 3-1. 왼쪽 시프트 연산자 (<<)
{
    int a = 2;
    Console.WriteLine($"원본 : {a} (0b{Convert.ToString(a, 2).PadLeft(4, '0')})");
    Console.WriteLine();
    Console.WriteLine($"{a} << 1 = {a << 1} (0b{Convert.ToString(a << 1, 2).PadLeft(4, '0')})");
    Console.WriteLine($"{a} << 2 = {a << 2} (0b{Convert.ToString(a << 2, 2).PadLeft(4, '0')})");
    Console.WriteLine($"{a} << 3 = {a << 3} (0b{Convert.ToString(a << 3, 2).PadLeft(4, '0')})");
    Console.WriteLine();
    Console.WriteLine();
}

// 3-2. 오른쪽 시프트 연산자 (>>)
{
    int a = 24;
    Console.WriteLine($"원본 : {a} (0b{Convert.ToString(a, 2).PadLeft(4, '0')})");
    Console.WriteLine();
    Console.WriteLine($"{a} >> 1 = {a >> 1} (0b{Convert.ToString(a >> 1, 2).PadLeft(4, '0')})");
    Console.WriteLine($"{a} >> 2 = {a >> 2} (0b{Convert.ToString(a >> 2, 2).PadLeft(4, '0')})");
    Console.WriteLine($"{a} >> 3 = {a >> 3} (0b{Convert.ToString(a >> 3, 2).PadLeft(4, '0')})");
    Console.WriteLine();
    Console.WriteLine();
}

// 3-3. 시프트 연산 기본
{
    int a = 2;
    Console.WriteLine($"원본 : {a} (0b{Convert.ToString(a, 2).PadLeft(4, '0')})");
    Console.WriteLine($"왼쪽 시프트 (× 2) : {a << 1}");
    Console.WriteLine($"오른쪽 시프트 (÷ 2) : {a >> 1}");
    Console.WriteLine();
    Console.WriteLine();
}

// 4. 복합 할당 연산자
{
    byte a = 4, b = 4, c = 4, d = 4, e = 4;
    Console.WriteLine($"{a} &= 5 결과 : {a &= 5}");
    Console.WriteLine($"{b} |= 1 결과 : {b |= 1}");
    Console.WriteLine($"{c} ^= 2 결과 : {c ^= 2}");
    Console.WriteLine($"{d} <<= 1 결과 : {d <<= 1}");
    Console.WriteLine($"{e} >>= 1 결과 : {e >>= 1}");
    Console.WriteLine();
    Console.WriteLine();
}

// 5. 연산자 우선순위
{
    Console.WriteLine(3 + 4 * 2);
    Console.WriteLine((3 + 4) * 2);
    Console.WriteLine(10 / 5 * 2 + 1);
    Console.WriteLine(10 / 5 * (2 + 1));
    Console.WriteLine();
    Console.WriteLine();
}

// 6-1. 플래그 관리
{
    const int k_Poison = 0b0001;
    const int k_Burned = 0b0010;
    const int k_Freeze = 0b0100;
    const int k_Stun = 0b1000;
    int userState = 0;

    // 상태 추가
    userState |= k_Poison;
    userState |= k_Burned;

    Console.WriteLine($"현재 상태 : {Convert.ToString(userState, 2).PadLeft(4, '0')}");
    Console.WriteLine($"독 상태 : {userState & k_Poison}");
    Console.WriteLine($"빙결 상태 : {userState & k_Freeze}");
    userState &= ~k_Poison;
    Console.WriteLine($"독 해제 후 : {Convert.ToString(userState, 2).PadLeft(4, '0')}");
    Console.WriteLine();
    Console.WriteLine();
}

// 6-2. XOR을 이용한 값 교환
{

    /// a = 01010
    /// b = 10100
    /// a^b = 11110
    /// 
    int a = 10, b = 20;
    Console.WriteLine($"교환 전 : a = {a}, b = {b}");

    a = a ^ b; // a = a ^ b
    b = a ^ b; // b = a ^ b ^ b = a
    a = b ^ a; // a = a ^ b ^ b ^ a ^ b = b
    Console.WriteLine($"교환 후 : a = {a}, b = {b}");
    Console.WriteLine();
    Console.WriteLine();
}

// 6-3. 홀수, 짝수 판별
{
    Console.WriteLine($"{1}은(는) {((1 & 1) == 1 ? "홀" : "짝")}수입니다.");
    Console.WriteLine($"{2}은(는) {((2 & 1) == 1 ? "홀" : "짝")}수입니다.");
    Console.WriteLine($"{3}은(는) {((3 & 1) == 1 ? "홀" : "짝")}수입니다.");
    Console.WriteLine($"{4}은(는) {((4 & 1) == 1 ? "홀" : "짝")}수입니다.");
    Console.WriteLine($"{5}은(는) {((5 & 1) == 1 ? "홀" : "짝")}수입니다.");
    Console.WriteLine();
    Console.WriteLine();
}


Console.WriteLine();