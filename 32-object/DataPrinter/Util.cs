using System;
using System.Reflection.Metadata;

namespace DataPrinter {
    static internal class Util {
        private static int _intCount = 0;
        private static int _doubleCount = 0;
        private static int _stringCount = 0;
        private static int _boolCount = 0;
        private static int _unknownCount = 0;

        public static void PrintStatic() {
            Console.WriteLine($"정수 : {_intCount}개");
            Console.WriteLine($"실수 : {_doubleCount}개");
            Console.WriteLine($"문자열 : {_stringCount}개");
            Console.WriteLine($"논리값 : {_boolCount}개");
        }

        public static void PrintData(object data) {
            string tName = data.GetType().Name;
            
            switch (tName) {
                case "Int32":
                    Console.WriteLine($"정수 : {(int)data}");
                    _intCount++;
                    break;
                case "Double" :
                    Console.WriteLine($"실수 : {(double)data:F2}");
                    _doubleCount++;
                    break;
                case "String" :
                    Console.WriteLine($"문자열 : \"{(string)data}\" (길이 : {((string)data).Length})");
                    _stringCount++;
                    break;
                case "Boolean" :
                    Console.WriteLine($"논리값 : {(bool)data} -> {((bool)data == true ? "참" : "거짓")}");
                    _boolCount++;
                    break;
                default :
                    Console.WriteLine($"알 수 없는 타입 : {tName} - {data}");
                    _unknownCount++;
                    break;
            }   
        }
        
        public static void PrintAll(object[] data) {
            foreach ( object dataItem in data ) {
                PrintData( dataItem );
            }
        }
    }
}
