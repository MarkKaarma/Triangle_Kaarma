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

        public Triangle(double A, double B, double C, double H) // Конструктор 
        {
            a = A;
            b = B;  // Создаем с заданными длинами сторон согласно заданию 
            b = C;
            h = H;
        }
        public string outputA() // Выводим сторону а
        {
            return Convert.ToString(a); // а - Ссылка на внутреннее поле объекта класса 
        }
        public string outputB() // Выводим сторону b
        {
            return Convert.ToString(b); // b - Ссылка на внутреннее поле объекта класса 
        }
        public string outputC() // Выводим сторону c
        {
            return Convert.ToString(c); // c - Ссылка на внутреннее поле объекта класса 
        }
        public string outputH() // Выводим сторону h
        {
            return Convert.ToString(h); // h - Ссылка на внутреннее поле объекта класса 
        }
        public double Perimeter() // Сумма всех сторон типа double
        {
            double p = 0;
            p = a + b + c; // Формула периметра
            return p; // Выводим
        }
        public double Surface() // Альтернативный способ вычисления периметра
        {
            double s = 0;
            double p = 0;
            p = (a + b + c) / 2; // Формула
            s = Math.Sqrt((p * (p - a) * (p - b) - (p - c))); // Формула
            return s; // Выводим
        }
        public double Area() // Вычисление площади 
        {
            double s = 0;
            s = (a * h) / 2; // Формула 
            return s; // Выводим
        }
        public double GetSetA // Свойство позволяющее установить либо изменить сторону/высоту
        {
            get
            { return a; }
            set
            { a = value; }
        }
        public double GetSetB // Свойство позволяющее установить либо изменить сторону/высоту
        {
            get
            { return b; }
            set
            { b = value; }
        }
        public double GetSetC // Свойство позволяющее установить либо изменить сторону/высоту
        {
            get
            { return c; }
            set
            { c = value; }
        }
        public double GetSetH // Свойство позволяющее установить либо изменить сторону/высоту
        {
            get
            { return h; }
            set
            { h = value; }
        }
        public bool ExistTriangle // Свойство позволяющее установить, существует ли треугольник с заданными сторонами
        {
            get
            {
                if ((a > b + c) && (b > a + c) && (c > a + b)) // Сумма двух сторон должна быть больше третьей
                return false;
                else return true;
            }
        }
    }
}