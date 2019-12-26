using System;

namespace SqrtNewtonsMethod
{
    static class NewtonsMethod
    {
        /// <summary>
        /// Статический метод для нахождения квадратного корня методом Ньютона
        /// </summary>
        /// <param name="rootNumber">Число, квадратный корень из которого необходимо найти</param>
        /// <param name="epsilon">Погрешность</param>
        /// <param name="assumption">Начальное предположение. Чем ближе к истинному, тем меньшее количество итераций необходимо</param>
        /// <returns></returns>
        public static double Pow(double rootNumber, double epsilon, double assumption)
        {
            if (assumption < 0 || rootNumber < 0)
            {
                throw new Exception("Отрицательное значение подкоренного выражения недопустимо");
            }

            double result = assumption;

            while (AbsoluteValue(result * result - rootNumber) >= epsilon)
            {
                result = ((rootNumber / result) + result) / 2; 
            }

            return result;
        }
        /// <summary>
        /// Абсолютное значение численной переменной
        /// </summary>
        /// <param name="x">значение, модуль которого необходимо найти</param>
        /// <returns></returns>
        private static double AbsoluteValue(double x)
        {
            return x < 0 ? -x : x;
        }
    }
}
