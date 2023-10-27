
using System.Runtime.InteropServices;

namespace test {
    public class Program {
        static void Main(string[] args) {
            six("pene") ;
            Console.WriteLine(nine("Girafarig"));
        }
        private static int factorial(int x) {

            int result = 1;
            for (int i = 1; i <= x; i++) {
                result = i * result;
            }
            return result;
        }

        private static void average(float[] arr) {
            float average = 0;
            for (int i = 0; i < arr.Length; i++) {
                average = average + arr[i];
            }
            Console.WriteLine(average / arr.Length);
        }

        // Multiply
        private static int one(int x, int y) {
            return x * y;
        }

        private static String two(String name) {
            return "Hello, " + name;
        }
        // F = 1.8C + 32
        private static int three(int celsius) {
            return (int)(1.8 * celsius + 32);
        }
        private  static int four(int farenheit) {
            return (int)((farenheit - 32) / 1.8);
        }
        private static float five(int radius) {
            int val = radius ^ 2;
            return (float)(val * 3.14);
        }
        private static void six(String text) {
            for (int i = text.Length - 1; i >= 0; i--) {
                Console.Write(text[i]);
            }
        }
        private static int seven(int[] array) {
            int value = 0;
            foreach (int num in array) {
                value = value + num;
            }
            return value;
        }
        private static int eight(int[] array) {
            int value = array[0];
            foreach (int num in array){
                if (value < num) {
                    value = num;
                }
            }
            return value;
        }
        private static bool nine(String text) {
            String reverse = "";
            for (int i = text.Length - 1; i >= 0; i--) {
                reverse = reverse + text[i];
            }

           
            return text.ToLower() == reverse.ToLower();
        }

    }
}