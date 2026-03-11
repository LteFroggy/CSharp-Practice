using System;

FruitPriceList priceList = new FruitPriceList(5);

priceList.Add("사과", 1500);
priceList.Add("바나나", 3000);
priceList.Add("딸기", 8000);
Console.WriteLine($"등록된 과일 수 : {priceList.Count}개");
Console.WriteLine();

Console.WriteLine($"사과 가격 : {priceList["사과"]:N0}원");
Console.WriteLine($"바나나 가격 : {priceList["바나나"]:N0}원");
Console.WriteLine($"포도 가격 : {priceList["포도"]:N0}원");
Console.WriteLine($"");

priceList.GetList();

