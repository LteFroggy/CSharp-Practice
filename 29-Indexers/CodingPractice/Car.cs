using System;

class Car {
    string[] strArr;
    public Car(int size) {
        strArr = new string[size];
    }

    public string this[int index] {
        get => strArr[index];
        set => strArr[index] = value;
    }
}