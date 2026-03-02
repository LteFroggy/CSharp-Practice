using System;
using System.Threading.Channels;

class Player4 {
    private string _name;
    private int _id;

    public void SetInfo(string _name, int _id) {
        this._name = _name;
        this._id = _id;
    }

    public void PrintInfo() {
        Console.WriteLine($"이름 : {_name}");
        Console.WriteLine($"레벨 : {_id}");
    }
}