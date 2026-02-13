using System;

Console.WriteLine("점수를 입력하세요 : ");
int inputVal = Convert.ToInt32(Console.ReadLine());
char grade = default;

switch (inputVal / 10) {
    case 10 :
    case 9 :
        grade = 'A';
        break;

    case 8 :
        grade = 'B';
        break;

    case 7 :
        grade = 'C';
        break;

    case 6 :
        grade = 'D';
        break;

    default :
        grade = 'F';
        break;
}
Console.WriteLine($"학점 : {grade}");
Console.WriteLine();