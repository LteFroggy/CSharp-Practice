// 기본 생성자
using System;

ShoppingCart cart1 = new ShoppingCart();
cart1.AddItem("연필", 500);
cart1.AddItem("노트", 1500);
cart1.PrintInfo();

Console.WriteLine();

// 상점명만 지정
ShoppingCart cart2 = new ShoppingCart("문구점");
cart2.AddItem("볼펜", 1000);
cart2.PrintInfo();

Console.WriteLine();

// 상점명 + 할인율
ShoppingCart cart3 = new ShoppingCart("할인마트", 20);
cart3.AddItem("과자", 3000);
cart3.AddItem("음료", 2000);
cart3.AddItem("빵", 1500);
cart3.PrintInfo();