using System;

class Divider {
    public static void Divide(int dividend, int divisor, out int quotient, out int remainder) {
        quotient = dividend / divisor;
        remainder = dividend % divisor;
    }
}