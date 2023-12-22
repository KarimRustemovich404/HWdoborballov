using System;

namespace DoborBallov3
{
    internal class Array
    {
        #region Fields
        public int[] newArray;
        #endregion

        #region Constructors
        public Array(int[] arrayOfNumbers)
        {
            newArray = arrayOfNumbers;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Метод для возведения чисел из массива в квадрат
        /// </summary>
        public void Square()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i * i);
            }
        }
        /// <summary>
        /// Метод для возведения чисел из массива в куб
        /// </summary>
        public void Cube()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Math.Pow(i, 3));
            }
        }
        /// <summary>
        /// Метод для возвращения среднего значения из всех значений массива 
        /// </summary>
        /// <returns></returns>
        public double Avarage()
        {
            int sum = 0;
            foreach (int value in newArray)
            {
                sum += value;
            }
            return sum / newArray.Length;
        }
        /// <summary>
        /// Метод для нахождения суммы всех чисел из массива 
        /// </summary>
        /// <returns></returns>
        public int Sum(int[] newArray, int i = 0)
        {
            if (i >= newArray.Length)
                return 0;
            int result = Sum(newArray, i + 1);
            return newArray[i] + result;
        }
        /// <summary>
        /// Метод для возвращения всех чётных чисел из массива 
        /// </summary>
        public void Even()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i * i);
            }
        }
        /// <summary>
        /// Метод для нахождения всех нечётных чисел из массива 
        /// </summary>
        public void Odd()
        {

        }
        #endregion
    }
}
