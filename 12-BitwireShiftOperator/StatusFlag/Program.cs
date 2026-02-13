using System;
using System.Runtime.CompilerServices;

const int k_Poison = 0b0001;
const int k_Burned = 0b0010;
const int k_Freeze = 0b0100;
const int k_Stun = 0b1000;

int playerStatus = 0;

// 1. 독 상태 추가
Console.WriteLine($"--- 1. 독 상태 추가 ---");
Console.WriteLine($"연산 : playerStatus |= k_Poison");
Console.WriteLine($"계산 : {playerStatus} | {k_Poison} = {playerStatus | k_Poison}");
Console.WriteLine($"결과 : {Convert.ToString(playerStatus | k_Poison, 2).PadLeft(4, '0')}");
playerStatus |= k_Poison;
Console.WriteLine();

// 2. 화상 상태 추가
Console.WriteLine($"--- 2. 화상 상태 추가 ---");
Console.WriteLine($"연산 : playerStatus |= k_Burned");
Console.WriteLine($"계산 : {playerStatus} | {k_Burned} = {playerStatus | k_Burned}");
Console.WriteLine($"결과 : {Convert.ToString(playerStatus | k_Burned, 2).PadLeft(4, '0')}");
playerStatus |= k_Burned;
Console.WriteLine();

// 3. 빙결 상태 확인
Console.WriteLine($"--- 3. 빙결 상태 확인---");
Console.WriteLine($"연산 : playerStatus & k_Freeze != 0");
Console.WriteLine($"계산 : {playerStatus} & {k_Freeze} = {playerStatus & k_Freeze}");
Console.WriteLine($"결과 : {((playerStatus & k_Freeze) == 0 ? "빙결 상태" : "빙결 상태 아님")}");
Console.WriteLine();

// 4. 독 상태 확인
Console.WriteLine($"--- 4. 독 상태 확인---");
Console.WriteLine($"연산 : playerStatus & k_Poison != 0");
Console.WriteLine($"계산 : {playerStatus} & {k_Poison} = {playerStatus & k_Poison}");
Console.WriteLine($"결과 : {((playerStatus & k_Poison) == 0 ? "독 상태" : "독 상태 아님")}");
Console.WriteLine();

// 5. 독 상태 제거
Console.WriteLine($"--- 5. 독 상태 제거---");
Console.WriteLine($"연산 : playerStatus &= ~k_Poison");
Console.WriteLine($"~k_Poison = ~{k_Poison} = {~k_Poison} (2진수 : ....{Convert.ToString(~k_Poison, 2)[^4..]})");
Console.WriteLine($"계산 : {playerStatus} & {~k_Poison} = {playerStatus & ~k_Poison}");
Console.WriteLine($"결과 : (0b{Convert.ToString(playerStatus &= ~k_Poison, 2).PadLeft(4, '0')}");
Console.WriteLine();


Console.WriteLine();
Console.WriteLine();