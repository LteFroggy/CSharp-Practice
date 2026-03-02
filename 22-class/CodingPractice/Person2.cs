using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice {
    internal class Person2 {

        private string _name;
        private int _age;

        public Person2(string name, int age) {
            this._name = name;
            this._age = age;
        }

        public void SetFriend(Person2 a) {
            a.PrintFriendInfo(this);
        }

        public void PrintFriendInfo(Person2 friend) {
            Console.WriteLine($"{this._name}의 친구는 {friend._name}입니다.");
        }

    }
}
