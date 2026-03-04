using System;

Console.WriteLine("===== 개체 생성 =====");
Counter c1 = new Counter();
Counter c2 = new Counter();
Counter c3 = new Counter();

Console.WriteLine("\n===== 결과 확인 =====");
Console.WriteLine($"c1은 {c1.GetInstanceNumber()}번째 개체");
Console.WriteLine($"c2는 {c2.GetInstanceNumber()}번째 개체");
Console.WriteLine($"c3은 {c3.GetInstanceNumber()}번째 개체");
Console.WriteLine($"총 생성된 개체 수: {Counter.GetTotalCount()}개");