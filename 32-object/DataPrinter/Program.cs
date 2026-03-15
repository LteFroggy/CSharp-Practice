using DataPrinter;
using System;

object[] data = { 42, 3.14, "Hello", true, 100, "World", false, 2.718 };

Console.WriteLine($"=== 데이터 출력기 ===");
Console.WriteLine();

Console.WriteLine($"[전체 데이터 출력]");
Util.PrintAll(data);
Console.WriteLine();

Console.WriteLine($"[타입별 통계]");
Util.PrintStatic();
Console.WriteLine();
Console.WriteLine();
