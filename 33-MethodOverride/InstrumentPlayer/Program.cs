using System;
using System.Text;
using InstrumentPlayer;

Console.OutputEncoding = Encoding.UTF8;

Instrument[] instruments = new Instrument[] {
    new Piano(),
    new Guitar(),
    new Drum()
};

Console.WriteLine($"=== 악기 연주회 ===");
foreach (var instrument in instruments) {
    instrument.Tune();
    instrument.Play();
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine();
