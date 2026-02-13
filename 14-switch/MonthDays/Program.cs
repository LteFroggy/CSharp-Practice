using System;

Console.Write("월을 입력하세요(1 ~ 12) : ");
int inputVal = Convert.ToInt32(Console.ReadLine());

switch (inputVal) {
    case 1:
    case 3:
    case 5:
    case 7:
    case 8:
    case 10:
    case 12:
        Console.WriteLine($"{inputVal}월은 31일까지 있습니다");
        break;
    
    case 4:
    case 6:
    case 9:
    case 11:
        Console.WriteLine($"{inputVal}월은 30일까지 있습니다");
        break;

    case 2:
        Console.WriteLine($"{inputVal}월은 28일까지 있습니다");
        break;

    default :
        Console.WriteLine("잘못된 월입니다");
        break;
}
Console.WriteLine();