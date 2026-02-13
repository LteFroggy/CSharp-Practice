using System;

int age = 15;
string state = default;
int fee = default;

if (age >= 19) {
    state = "성인";
    fee = 12000;
} else if (age >= 13) {
    state = "청소년";
    fee = 8000;
} else if (age >= 7) {
    state = "어린이";
    fee = 5000;
} else if (age >= 0) { 
    state = "유아";
    fee = 0;
} else {

    fee = -1;
}

if (fee > 0) {
    Console.WriteLine($"나이 : {age}세");
    Console.WriteLine($"상태 : {state}");
    Console.WriteLine($"요금 : {fee}");
} else {
    Console.WriteLine("잘못된 나이입니다");
}