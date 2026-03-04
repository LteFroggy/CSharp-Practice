# 장바구니 클래스

장바구니를 나타내는 `ShoppingCart` 클래스를 작성하시오. `this()` 생성자를 사용하여 코드 중복을 최소화하시오.

**요구사항**

- 비공개 필드
  - `_storeName`: 상점 이름 (string)
  - `_discount`: 할인율 % (int)
  - `_totalPrice`: 총 가격 (int)
  - `_itemCount`: 아이템 수 (int)

- 생성자 (3개)
  - 기본 생성자: 상점 이름을 "온라인몰"로 초기화 (`this()` 사용하여 다른 생성자 호출)
  - 상점명 생성자: 상점 이름을 받아 할인율 0으로 초기화 (`this()` 사용)
  - 핵심 생성자: 상점 이름과 할인율을 받아 모든 필드 초기화 (총 가격 0, 아이템 수 0)

- 메서드
  - `AddItem(string itemName, int price)`: 아이템 추가 - 총 가격에 금액을 더하고 아이템 수 증가, "[아이템명] 추가 ([가격]원)" 출력
  - `GetFinalPrice()`: 할인 적용 최종 가격 반환 (총 가격 * (100 - 할인율) / 100)
  - `PrintInfo()`: 장바구니 정보를 출력

**테스트 코드**

```csharp
// 기본 생성자
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
```

## 예상 실행 결과

```
연필 추가 (500원)
노트 추가 (1,500원)
[온라인몰] 아이템 2개, 합계: 2,000원, 할인 적용: 2,000원

볼펜 추가 (1,000원)
[문구점] 아이템 1개, 합계: 1,000원, 할인 적용: 1,000원

과자 추가 (3,000원)
음료 추가 (2,000원)
빵 추가 (1,500원)
[할인마트] 아이템 3개, 합계: 6,500원, 할인 적용: 5,200원
```
