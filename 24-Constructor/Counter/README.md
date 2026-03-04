# Counter

개체 생성 횟수를 추적하는 `Counter` 클래스를 작성하시오.

**요구사항**

- 정적 필드
  - `_totalCount`: 지금까지 생성된 총 개체 수 (int)

- 인스턴스 필드
  - `_instanceNumber`: 해당 개체가 몇 번째로 생성되었는지 (int, readonly)

- 정적 생성자
  - `_totalCount`를 0으로 초기화
  - "Counter 클래스 초기화됨" 메시지 출력

- 인스턴스 생성자
  - `_totalCount`를 1 증가시킴
  - `_instanceNumber`에 현재 `_totalCount` 값을 저장
  - "개체 #{_instanceNumber} 생성됨" 메시지 출력

- 정적 메서드
  - `GetTotalCount()`: 총 개체 수를 반환

- 인스턴스 메서드
  - `GetInstanceNumber()`: 해당 개체의 번호를 반환

**테스트 코드**

```csharp
Console.WriteLine("===== 개체 생성 =====");
Counter c1 = new Counter();
Counter c2 = new Counter();
Counter c3 = new Counter();

Console.WriteLine("\n===== 결과 확인 =====");
Console.WriteLine($"c1은 {c1.GetInstanceNumber()}번째 개체");
Console.WriteLine($"c2는 {c2.GetInstanceNumber()}번째 개체");
Console.WriteLine($"c3은 {c3.GetInstanceNumber()}번째 개체");
Console.WriteLine($"총 생성된 개체 수: {Counter.GetTotalCount()}개");
```

## 예상 실행 결과

```
===== 개체 생성 =====
Counter 클래스 초기화됨
개체 #1 생성됨
개체 #2 생성됨
개체 #3 생성됨

===== 결과 확인 =====
c1은 1번째 개체
c2는 2번째 개체
c3은 3번째 개체
총 생성된 개체 수: 3개
```
