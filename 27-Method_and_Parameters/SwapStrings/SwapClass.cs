using System;
class SwapClass {
    public static void SwapSeats(ref string seat1, ref string seat2) {
        string tmp = seat1;
        seat1 = seat2;
        seat2 = tmp;
    }
    public static void CountSwap(ref int count) { count++; }
}