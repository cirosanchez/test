
namespace test {
    public class Program {
        static void Main(string[] args) {
            float[] array = new float[3];
            array[0] = 4.6f;
            array[2] = 5.6f;
            array[1] = 7.0f;

            Console.WriteLine(factorial(3));
            average(array);
        }
       private static int factorial(int x) {

            int result = 1;
            for (int i = 1; i <= x; i++) {
                result = i*result;
            }
            return result;
        }
        
        private static void average(float[] arr) {
            float average = 0;
            for (int i = 0; i < arr.Length; i++) {
                average = average+ arr[i];
            }
            Console.WriteLine(average / arr.Length);
        }

    }
}