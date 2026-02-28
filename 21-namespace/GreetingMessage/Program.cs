using System;

string name = "홍길동";
Console.WriteLine($"=== 인사 테스트 ===");
Console.WriteLine($"[격식체]");
Formal.Message.SayHello(name);
Formal.Message.SayBye(name);
Console.WriteLine();

name = "철수";
Console.WriteLine($"[비격식체]");
Casual.Message.SayHello(name);
Casual.Message.SayBye(name);
Console.WriteLine();
Console.WriteLine();