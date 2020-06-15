using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Kaarma
{
    class Triangle
    {
        public double a; // Первая сторона
        public double b; // Вторая сторона
        public double c; // Третья сторона 
        public double h; // Высота *не знаю, будет ли работать, так уж просто так добавил ради ЭКСПЕРЕМЕНТА!

        public Triangle(double A, double B, double C) // Обычный треугольник 
        {
            a = A;
            b = B;
            c = C;
        }
        public Triangle(double A, double B, double C, double H) //  Конструктор, который позволит вычислить высоту и стороны  
        {
            a = A;
            b = B; // Создаем с заданными длинами сторон и высоту согласно заданию 
            c = C;
            h = H;
        }
        public Triangle() // Конструктор, создаст без указания переменов
        {
        }
        public string outputA() // Выводим сторону А
        {
            return Convert.ToString(a); // а - Ссылка на внутреннее поле объекта класса 
        }
        public string outputB() // Выводим сторону B
        {
            return Convert.ToString(b); // b - Ссылка на внутреннее поле объекта класса 
        }
        public string outputC() // Выводим сторону C
        {
            return Convert.ToString(c); // c - Ссылка на внутреннее поле объекта класса 
        }
        public double Perimeter() // // Сумма всех сторон типа double
        {
            double p = 0; 
            p = a + b + c; // Формула периметра
            return p; // Выводим
        }
        public double Surface() // Альтернативный способ вычисление периметра и вычисление площади 
        {
            double s = 0;
            double p = 0;
            p = (a + b + c) / 2; // Формула 
            s = Math.Floor(Math.Sqrt((p * (p - a) * (p - b) * (p - c)))); // Формула
            return s; // Выводим площадь 
        }
        public double HalfPerimeter() // Для вычисление высоты мы разделяем на половину периметра
        {
            return Perimeter() / 2; // Формула
        }
        public double Height() // Вычисление высоты 
        {
            double p = HalfPerimeter();
            double h = Math.Floor(2 * Math.Sqrt(p * (p - a) * (p - b) * (p - c)) / a);
            return h;
        }
        public double GetSetA // Свойство позволяющее установить либо изменить сторону
        {
            get
            { return a; }
            set
            { a = value; }
        }
        public double GetSetB // Свойство позволяющее установить либо изменить сторону
        {
            get
            { return b; }
            set
            { b = value; }
        }
        public double GetSetC // Свойство позволяющее установить сторону
        {
            get
            { return c; }
            set
            { c = value; }
        }

        public bool ExistTriangle // Свойство позволяющее установить, существует ли треугольник с заданными сторонами
        {
            get
            {
                if ((a > b + c) && (b > a + c) && (c > a + b)) // Сумма двух сторон должна быть больше третьей
                    return true;
                else return false;
            }
        }
    }
}