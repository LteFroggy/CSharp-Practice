using System;
using System.Diagnostics.Metrics;

class WhichService {
    private readonly string _serviceName;
    private static int _counter = 0;
    public WhichService(string serviceName) {
        _counter++;
        _serviceName = serviceName;
        Console.WriteLine($"[{_counter}] {_serviceName} 기능을 실행합니다.");
    }
}