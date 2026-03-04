# BankAccount

은행 계좌를 나타내는 `BankAccount` 클래스를 작성하시오.

**요구사항**

- 비공개 필드
  - `_owner`: 계좌 소유자 이름 (string)
  - `_balance`: 잔액 (int)

- 생성자
  - 기본 생성자: 소유자를 "익명"으로, 잔액을 0으로 초기화
  - 매개변수가 있는 생성자: 소유자 이름과 초기 잔액을 받아 초기화

- 메서드
  - `Deposit(int amount)`: 입금 메서드 - 잔액에 금액을 더함
  - `Withdraw(int amount)`: 출금 메서드 - 잔액에서 금액을 뺌 (잔액 부족 시 "잔액이 부족합니다." 출력 후 출금하지 않음)
  - `PrintInfo()`: 계좌 정보를 출력

**테스트 코드**

```csharp
// 기본 생성자로 계좌 생성
BankAccount account1 = new BankAccount();
account1.PrintInfo();

// 매개변수가 있는 생성자로 계좌 생성
BankAccount account2 = new BankAccount("홍길동", 10000);
account2.PrintInfo();

// 입금 테스트
account2.Deposit(5000);
account2.PrintInfo();

// 출금 테스트
account2.Withdraw(3000);
account2.PrintInfo();

// 잔액 부족 테스트
account2.Withdraw(20000);
account2.PrintInfo();
```

## 예상 실행 결과
c
```
[익명] 잔액: 0원
[홍길동] 잔액: 10,000원
[홍길동] 잔액: 15,000원
[홍길동] 잔액: 12,000원
잔액이 부족합니다.
[홍길동] 잔액: 12,000원
```
