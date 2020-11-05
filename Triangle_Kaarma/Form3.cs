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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        // Эта большая часть checkBox нужен для того, что при убирании галочки (бокс и/или текстбокс) был недоступен и наоборот.
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtA.Enabled = true;
                checkBox7.Enabled = false;
                bool a = txtA.Text != "";
            }
            else
            {
                txtA.Enabled = false;
                checkBox7.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                txtB.Enabled = true;
                checkBox8.Enabled = false;
                bool b = txtB.Text != "";
            }
            else
            {
                txtB.Enabled = false;
                checkBox8.Enabled = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                txtC.Enabled = true;
                checkBox9.Enabled = false;
                bool c = txtC.Text != "";
            }
            else
            {
                txtC.Enabled = false;
                checkBox9.Enabled = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                txtH.Enabled = true;
                checkBox10.Enabled = false;
            }
            else
            {
                txtH.Enabled = false;
                checkBox10.Enabled = true;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                txtS.Enabled = true;
                checkBox11.Enabled = false;
            }
            else
            {
                txtS.Enabled = false;
                checkBox11.Enabled = true;
            }
        }
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox7.Checked)
            {

            }
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                txtP.Enabled = true;
                checkBox12.Enabled = false;
            }
            else
            {
                txtP.Enabled = false;
                checkBox12.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                listView1.Items.Clear(); // Очистка формы от значений которые были до этого
            }
            if (txtA.Text.Length > 0 && txtB.Text.Length > 0 && txtC.Text.Length > 0) // Проверка на введённые символы 
            {
                double a, b, c;
                a = Convert.ToDouble(txtA.Text);
                b = Convert.ToDouble(txtB.Text);
                c = Convert.ToDouble(txtC.Text);
                Triangle triangle = new Triangle(a, b, c);
                listView1.Items.Add("Сторона a");
                listView1.Items.Add("Сторона b");
                listView1.Items.Add("Сторона c");
                listView1.Items.Add("Альфа");
                listView1.Items.Add("Бета");
                listView1.Items.Add("Гамма");
                listView1.Items.Add("Высота");
                listView1.Items.Add("Периметр");
                listView1.Items.Add("Площадь");
                listView1.Items.Add("Существует?");
                listView1.Items.Add("Спецификатор");
                listView1.Items[0].SubItems.Add(triangle.outputA());
                listView1.Items[1].SubItems.Add(triangle.outputB());
                listView1.Items[2].SubItems.Add(triangle.outputC());
                listView1.Items[3].SubItems.Add(Convert.ToString(triangle.Alpha()));
                listView1.Items[4].SubItems.Add(Convert.ToString(triangle.Beta()));
                listView1.Items[5].SubItems.Add(Convert.ToString(triangle.Gamma()));
                listView1.Items[6].SubItems.Add(Convert.ToString(triangle.Height())); // Выводим высоту 
                listView1.Items[7].SubItems.Add(Convert.ToString(triangle.Perimeter())); // Выводим периметр 
                listView1.Items[8].SubItems.Add(Convert.ToString(triangle.Surface())); // Выводим площадь
                if (triangle.ExistTriangle) { listView1.Items[9].SubItems.Add("Cуществует"); }
                if (a == b && b == c && c == b) { listView1.Items[10].SubItems.Add("Равносторонний"); } // Добавление типов треугольников (будет показывать есть ли такой)
                else if (b == c) { listView1.Items[10].SubItems.Add("Равнобедренный"); }
                else if (a == b && a == c) { listView1.Items[10].SubItems.Add("Разносторонний"); }
                else listView1.Items[9].SubItems.Add("Не существует");
            }
        }
    }
}
