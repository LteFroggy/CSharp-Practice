using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount {
    internal class BankAccount {
        public string AccountNumber { get;}
        public string OwnerName  {get;}
        public int Balance { get; private set; }

        public BankAccount(string accountNumber, string ownerName) {
            AccountNumber = accountNumber;
            OwnerName = ownerName;
            Balance = 0;
        }

        public void Deposit(int amount) {
            if (amount <= 0) {
                Console.WriteLine($"입금 금액은 0보다 커야 합니다.");
            } else {
                Balance += amount;
                Console.WriteLine($"{amount:N0}원 입금 완료. 잔액 : {Balance:N0}원");
            }
        }

        public void Withdraw(int amount) {
            if (amount <= 0) {
                Console.WriteLine($"출금 금액은 0보다 커야 합니다");
            } else if (amount > Balance) {
                Console.WriteLine($"잔액이 부족합니다.");
            } else {
                Balance -= amount;
                Console.WriteLine($"{amount:N0}원 출금 완료. 잔액 : {Balance:N0}원");
            }
        }

        public void ShowInfo() {
            Console.WriteLine($"[계좌 정보] {AccountNumber} ({OwnerName}) - 잔액 : {Balance:N0}원");
        }
    }
}
