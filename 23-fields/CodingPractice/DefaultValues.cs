using System;

class DefaultValues {
    private int _iField;
    private bool _bField;
    private string _sField;

    public void ShowDefaults() {
        Console.WriteLine($"Number : {_iField}");
        Console.WriteLine($"flag: {_bField}");
        Console.WriteLine($"Number : {(_sField == null ? "null" : _sField)}");
    }
}