using System;

class OrderUtil {
    public static void PrintOrder(string menu, string size = "Regular", int shots = 1, bool takeout = false) {
        string takeoutType = takeout ? "[매장]" : "[포장]";
        Console.WriteLine($"{takeoutType} {size} {menu} (샷 : {shots})");
    }
}

class Program {
    public static void Main() {
        Console.WriteLine($"=== 커피 주문서 ===");
        Console.WriteLine();
        OrderUtil.PrintOrder("아메리카노");
        OrderUtil.PrintOrder("카페라떼", "Large");
        OrderUtil.PrintOrder("바닐라라떼", shots : 2);
        OrderUtil.PrintOrder("카푸치노", "small", 3, true);
        OrderUtil.PrintOrder("에스프레소", takeout : true);
        Console.WriteLine();
        Console.WriteLine();
    }
}