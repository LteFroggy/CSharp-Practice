using System;

int playerLevel = 25;
bool playerBanned = false;
bool playerAuth = true;

Console.WriteLine("케이스 1 : 일반 사용자 접근 가능");
Console.WriteLine($"=== 사용자 정보 ===");
Console.WriteLine($"레벨 : {playerLevel}");
Console.WriteLine($"차단 여부 : {playerBanned}");
Console.WriteLine($"인증 여부 : {playerAuth}");
Console.WriteLine();
Console.WriteLine($"=== 접근 권한 확인 ===");
Console.WriteLine($"관리자인가? : {playerLevel >= 00}");
Console.WriteLine($"일반 접근 조건 충족? : {playerLevel >= 20 && !playerBanned && playerAuth}");
Console.WriteLine($"최종 접근 가능 ? : {(playerLevel >= 00) || (playerLevel >= 20 && !playerBanned && playerAuth)}");

Console.WriteLine();
Console.WriteLine();

playerLevel = 100;
playerBanned = true;
playerAuth = false;
Console.WriteLine("케이스 2 : 관리자 접근");
Console.WriteLine($"=== 사용자 정보 ===");
Console.WriteLine($"레벨 : {playerLevel}");
Console.WriteLine($"차단 여부 : {playerBanned}");
Console.WriteLine($"인증 여부 : {playerAuth}");
Console.WriteLine();
Console.WriteLine($"=== 접근 권한 확인 ===");
Console.WriteLine($"관리자인가? : {playerLevel >= 00}");
Console.WriteLine($"일반 접근 조건 충족? : {playerLevel >= 20 && !playerBanned && playerAuth}");
Console.WriteLine($"최종 접근 가능 ? : {(playerLevel >= 00) || (playerLevel >= 20 && !playerBanned && playerAuth)}");

Console.WriteLine();
Console.WriteLine();


playerLevel = 5;
playerBanned = false;
playerAuth = true;
Console.WriteLine("케이스 3 : 접근 불가");
Console.WriteLine($"=== 사용자 정보 ===");
Console.WriteLine($"레벨 : {playerLevel}");
Console.WriteLine($"차단 여부 : {playerBanned}");
Console.WriteLine($"인증 여부 : {playerAuth}");
Console.WriteLine();
Console.WriteLine($"=== 접근 권한 확인 ===");
Console.WriteLine($"관리자인가? : {playerLevel >= 00}");
Console.WriteLine($"일반 접근 조건 충족? : {playerLevel >= 20 && !playerBanned && playerAuth}");
Console.WriteLine($"최종 접근 가능 ? : {(playerLevel >= 00) || (playerLevel >= 20 && !playerBanned && playerAuth)}");