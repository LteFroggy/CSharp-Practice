using System;

class Catalog {
    public string this[int idx] {
        get => (idx % 2 == 0) ? $"{idx} : 짝수 반환" : $"{idx} : 홀수 반환";
    }
}