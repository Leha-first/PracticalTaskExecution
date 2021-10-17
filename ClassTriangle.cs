using System;

namespace CalculateAreaFigures
{
    public class ClassTriangle : AbstractClassFigures
    {
        /// <summary>
        /// Прямоугольный ли треугольник
        /// </summary>
        public bool IsRectangular { get => (Math.Pow(FirstSide, 2D) == Math.Pow(SecondSide, 2D) + Math.Pow(ThirdSide, 2D)) ||
                (Math.Pow(SecondSide, 2D) == Math.Pow(FirstSide, 2D) + Math.Pow(ThirdSide, 2D)) ||
                (Math.Pow(ThirdSide, 2D) == Math.Pow(FirstSide, 2D) + Math.Pow(SecondSide, 2D)); }

        private double firstSide;
        /// <summary>
        /// Первая сторона
        /// </summary>
        public double FirstSide { get => firstSide; set { if (firstSide != value) firstSide = value; } }

        private double secondSide;
        /// <summary>
        /// Вторая сторона
        /// </summary>
        public double SecondSide { get => secondSide; set { if (secondSide != value) secondSide = value; } }

        private double thirdSide;
        /// <summary>
        /// Третья сторона
        /// </summary>
        public double ThirdSide { get => thirdSide; set { if (thirdSide != value) thirdSide = value; } }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="firstSide"> Первая сторона </param>
        /// <param name="secondSide"> Вторая сторона </param>
        /// <param name="thirdSide"> Третья сторона </param>
        public ClassTriangle(double firstSide, double secondSide, double thirdSide) 
        {
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0) throw new Exception("Стороны должны быть положительными");
            var semiPerimeter = (firstSide + secondSide + thirdSide) / 2D;
            if (firstSide > semiPerimeter || secondSide > semiPerimeter || thirdSide > semiPerimeter)
                throw new Exception("Треугольник с такими сторонами невозможно создать");
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }
        /// <summary>
        /// Вычисление площади треугольника
        /// </summary>
        /// <returns> Площадь треугольника </returns>
        public override double CalculateArea()
        {
            double semiPerimeter = (FirstSide + SecondSide + ThirdSide) / 2D;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - FirstSide) * (semiPerimeter - SecondSide) * (semiPerimeter - ThirdSide));
        }
    }
}
