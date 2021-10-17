using System;

namespace CalculateAreaFigures
{
    /// <summary>
    /// Класс круга
    /// </summary>
    public class ClassCircle : AbstractClassFigures
    {
        private double perimeter;
        /// <summary>
        /// Периметр
        /// </summary>
        public double Perimeter
        {
            get => perimeter; 
            set
            {
                if (perimeter != value)
                    perimeter = value;
            }
        }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="perimeter"> Значение периметра </param>
        public ClassCircle(double perimeter)
        {
            if (perimeter <= 0) throw new Exception("Периметр должен быть положительным");
            Perimeter = perimeter;
        }

        /// <summary>
        /// Вычисление площади круга
        /// </summary>
        /// <returns> Площадь круга </returns>
        public override double CalculateArea() => Math.PI * Math.Pow(Perimeter, 2D);
    }
}
