using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle_Kaarma
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                listView1.Items.Clear(); // Очистка формы от значений которые были до этого
            }
            if (num1.Text.Length > 0 && num2.Text.Length > 0 && num3.Text.Length > 0) // Проверка на введённые символы 
            {
                double a, b, c;
                a = Convert.ToDouble(num1.Text);
                b = Convert.ToDouble(num2.Text);
                c = Convert.ToDouble(num3.Text);
                Triangle triangle = new Triangle(a, b, c);
                listView1.Items.Add("Сторона a");
                listView1.Items.Add("Сторона b");
                listView1.Items.Add("Сторона c");
                listView1.Items.Add("Высота");
                listView1.Items.Add("Периметр");
                listView1.Items.Add("Площадь");
                listView1.Items.Add("Существует?");
                listView1.Items.Add("Спецификатор");
                listView1.Items[0].SubItems.Add(triangle.outputA());
                listView1.Items[1].SubItems.Add(triangle.outputB());
                listView1.Items[2].SubItems.Add(triangle.outputC());
                listView1.Items[3].SubItems.Add(Convert.ToString(triangle.Height())); // Выводим высоту 
                listView1.Items[4].SubItems.Add(Convert.ToString(triangle.Perimeter())); // Выводим периметр 
                listView1.Items[5].SubItems.Add(Convert.ToString(triangle.Surface())); // Выводим площадь 
                if (triangle.ExistTriangle) { listView1.Items[6].SubItems.Add("Cуществует"); }
                    if (a == b && b == c && c == b) { listView1.Items[7].SubItems.Add("Равносторонний"); pictureBox1.Image = Properties.Resources.ranvostor; } // Добавление типов треугольников (будет показывать есть ли такой)
                    else if (b == c) { listView1.Items[7].SubItems.Add("Равнобедренный"); pictureBox1.Image = Properties.Resources.ravnobed; } 
                    else if (a == b && a == c) { listView1.Items[7].SubItems.Add("Разносторонний"); pictureBox1.Image = Properties.Resources.raznostor; }
                else listView1.Items[6].SubItems.Add("Не существует");
            }
            else if (ClearBox.Checked == false)
            {
                listView1.Items.Clear();
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
