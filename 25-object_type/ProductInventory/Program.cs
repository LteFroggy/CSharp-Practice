using System;

Product[] products = new Product[3];
products[0] = new Product {
    Name = "노트북",
    Price = 1500000,
    Stock = 5
};

products[1] = new Product {
    Name = "마우스",
    Price = 35000,
    Stock = 20
};

products[2] = new Product {
    Name = "키보드",
    Price = 89000,
    Stock = 15
};

Console.WriteLine($"=== 상품 목록 ===");
foreach (Product product in products) { Console.WriteLine(product); }
Console.WriteLine();
Console.WriteLine($"=== 거래 ===");
products[0].Sell(2);
products[1].Sell(5);
products[2].Sell(20);
products[2].AddStock(10);
Console.WriteLine();

Console.WriteLine($"=== 최종 상품 목록 ===");
foreach (Product product in products) { Console.WriteLine(product); }
Console.WriteLine();

Console.WriteLine($"=== 총 재고 가치 ===");
int totalValueSum = 0;
foreach (Product product in products) { 
    Console.WriteLine($"{product.Name} : {product.GetTotalValue():N0}원"); 
    totalValueSum += product.GetTotalValue(); 
}
Console.WriteLine($"---");
Console.WriteLine($"전체 재고 총 가치 : {totalValueSum:N0}원");
Console.WriteLine();
Console.WriteLine();