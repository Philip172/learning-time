using System;
using System.Windows.Forms;

namespace Месяцы
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }



        int rand;
        public void newMonth()
        {
            textBox1.Text = "";
            rand = new Random().Next(12) + 1;
            label2.Text = rand.ToString();
        }
        public void checkMonth()
        {
            switch (rand)
            {
                case 1:
                    if (textBox1.Text.Replace(" ", "") == "Январь" || textBox1.Text.Replace(" ", "") == "январь")
                        newMonth();
                    else
                        MessageBox.Show($"{rand} месяц - январь");
                    break;

                case 2:
                    if (textBox1.Text.Replace(" ", "") == "Февраль" || textBox1.Text.Replace(" ", "") == "февраль")
                        newMonth();
                    else
                        MessageBox.Show($"{rand} месяц - февраль");
                    break;

                case 3:
                    if (textBox1.Text.Replace(" ", "") == "Март" || textBox1.Text.Replace(" ", "") == "март")
                        newMonth();
                    else
                        MessageBox.Show($"{rand} месяц - март");
                    break;

                case 4:
                    if (textBox1.Text.Replace(" ", "") == "Апрель" || textBox1.Text.Replace(" ", "") == "апрель")
                        newMonth();
                    else
                        MessageBox.Show($"{rand} месяц - апрель");
                    break;

                case 5:
                    if (textBox1.Text.Replace(" ", "") == "Май" || textBox1.Text.Replace(" ", "") == "май")
                        newMonth();
                    else
                        MessageBox.Show($"{rand} месяц - май");
                    break;

                case 6:
                    if (textBox1.Text.Replace(" ", "") == "Июнь" || textBox1.Text.Replace(" ", "") == "июнь")
                        newMonth();
                    else
                        MessageBox.Show($"{rand} месяц - июнь");
                    break;

                case 7:
                    if (textBox1.Text.Replace(" ", "") == "Июль" || textBox1.Text.Replace(" ", "") == "июль")
                        newMonth();
                    else
                        MessageBox.Show($"{rand} месяц - июль");
                    break;

                case 8:
                    if (textBox1.Text.Replace(" ", "") == "Август" || textBox1.Text.Replace(" ", "") == "август")
                        newMonth();
                    else
                        MessageBox.Show($"{rand} месяц - август");
                    break;

                case 9:
                    if (textBox1.Text.Replace(" ", "") == "Сентябрь" || textBox1.Text.Replace(" ", "") == "сентябрь")
                        newMonth();
                    else
                        MessageBox.Show($"{rand} месяц - сентябрь");
                    break;

                case 10:
                    if (textBox1.Text.Replace(" ", "") == "Октябрь" || textBox1.Text.Replace(" ", "") == "октябрь")
                        newMonth();
                    else
                        MessageBox.Show($"{rand} месяц - октябрь");
                    break;

                case 11:
                    if (textBox1.Text.Replace(" ", "") == "Ноябрь" || textBox1.Text.Replace(" ", "") == "ноябрь")
                        newMonth();
                    else
                        MessageBox.Show($"{rand} месяц - ноябрь");
                    break;

                case 12:
                    if (textBox1.Text.Replace(" ", "") == "Декабрь" || textBox1.Text.Replace(" ", "") == "декабрь")
                        newMonth();
                    else
                        MessageBox.Show($"{rand} месяц - декабрь");
                    break;
            }
        }

        public void newTimeOfAge()
        {
            textBox2.Text = "";
            rand = new Random().Next(4) + 1;
            label3.Text = rand.ToString();
        }
        public void checkTimeOfAge()
        {
            switch (rand)
            {
                case 1:
                    if (textBox2.Text.Replace(" ", "") == "Зима" || textBox2.Text.Replace(" ", "") == "зима")
                        newTimeOfAge();
                    else
                        MessageBox.Show($"{rand} время года - зима");
                    break;

                case 2:
                    if (textBox2.Text.Replace(" ", "") == "Весна" || textBox2.Text.Replace(" ", "") == "весна")
                        newTimeOfAge();
                    else
                        MessageBox.Show($"{rand} время года - весна");
                    break;

                case 3:
                    if (textBox2.Text.Replace(" ", "") == "Лето" || textBox2.Text.Replace(" ", "") == "лето")
                        newTimeOfAge();
                    else
                        MessageBox.Show($"{rand} время года - лето");
                    break;

                case 4:
                    if (textBox2.Text.Replace(" ", "") == "Осень" || textBox2.Text.Replace(" ", "") == "осень")
                        newTimeOfAge();
                    else
                        MessageBox.Show($"{rand} время года - осень");
                    break;
            }
        }

        public void newAlphabet()
        {
            textBox3.Text = "";
            rand = new Random().Next(33) + 1;
            label6.Text = rand.ToString();
        }
        private void checkAlphabet()
        {
            switch (rand)
            {
                case 1:
                    if (textBox3.Text.Replace(" ", "") == "А" || textBox3.Text.Replace(" ", "") == "а")
                        newAlphabet();
                    else
                        MessageBox.Show($"{rand} буква алфавита - А");
                    break;

                case 2:
                    if (textBox3.Text.Replace(" ", "") == "Б" || textBox3.Text.Replace(" ", "") == "б")
                        newAlphabet();
                    else
                        MessageBox.Show($"{rand} буква алфавита - Б");
                    break;

                case 3:
                    if (textBox3.Text.Replace(" ", "") == "В" || textBox3.Text.Replace(" ", "") == "в")
                        newAlphabet();
                    else
                        MessageBox.Show($"{rand} буква алфавита - В");
                    break;

                case 4:
                    if (textBox3.Text.Replace(" ", "") == "Г" || textBox3.Text.Replace(" ", "") == "г")
                        newAlphabet();
                    else
                        MessageBox.Show($"{rand} буква алфавита - Г");
                    break;

                case 5:
                    if (textBox3.Text.Replace(" ", "") == "Д" || textBox3.Text.Replace(" ", "") == "д")
                        newAlphabet();
                    else
                        MessageBox.Show($"{rand} буква алфавита - Д");
                    break;

                case 6:
                    if (textBox3.Text.Replace(" ", "") == "Е" || textBox3.Text.Replace(" ", "") == "е")
                        newAlphabet();
                    else
                        MessageBox.Show($"{rand} буква алфавита - Е");
                    break;

                case 7:
                    if (textBox3.Text.Replace(" ", "") == "Ё" || textBox3.Text.Replace(" ", "") == "ё")
                        newAlphabet();
                    else
                        MessageBox.Show($"{rand} буква алфавита - Ё");
                    break;

                case 8:
                    if (textBox3.Text.Replace(" ", "") == "Ж" || textBox3.Text.Replace(" ", "") == "ж")
                        newAlphabet();
                    else
                        MessageBox.Show($"{rand} буква алфавита - Ж");
                    break;

                case 9:
                    if (textBox3.Text.Replace(" ", "") == "З" || textBox3.Text.Replace(" ", "") == "з")
                        newAlphabet();
                    else
                        MessageBox.Show($"{rand} буква алфавита - З");
                    break;

                case 10:
                    if (textBox3.Text.Replace(" ", "") == "И" || textBox3.Text.Replace(" ", "") == "и")
                        newAlphabet();
                    else
                        MessageBox.Show($"{rand} буква алфавита - И");
                    break;

                case 11:
                    if (textBox3.Text.Replace(" ", "") == "Й" || textBox3.Text.Replace(" ", "") == "и")
                        newAlphabet();
                    else
                        MessageBox.Show($"{rand} буква алфавита - И");
                    break;

                case 12:
                    if (textBox3.Text.Replace(" ", "") == "К" || textBox3.Text.Replace(" ", "") == "к")
                        newAlphabet();
                    else
                        MessageBox.Show($"{rand} буква алфавита - К");
                    break;

                case 13:
                    if (textBox3.Text.Replace(" ", "") == "Л" || textBox3.Text.Replace(" ", "") == "л")
                        newAlphabet();
                    else
                        MessageBox.Show($"{rand} буква алфавита - Л");
                    break;

                case 14:
                    if (textBox3.Text.Replace(" ", "") == "М" || textBox3.Text.Replace(" ", "") == "м")
                        newAlphabet();
                    else
                        MessageBox.Show($"{rand} буква алфавита - М");
                    break;

                case 15:
                    if (textBox3.Text.Replace(" ", "") == "Н" || textBox3.Text.Replace(" ", "") == "н")
                        newAlphabet();
                    else
                        MessageBox.Show($"{rand} буква алфавита - Н");
                    break;

                case 16:
                    if (textBox3.Text.Replace(" ", "") == "О" || textBox3.Text.Replace(" ", "") == "о")
                        newAlphabet();
                    else
                        MessageBox.Show($"{rand} буква алфавита - О");
                    break;

                case 17:
                    if (textBox3.Text.Replace(" ", "") == "П" || textBox3.Text.Replace(" ", "") == "п")
                        newAlphabet();
                    else
                        MessageBox.Show($"{rand} буква алфавита - П");
                    break;

                case 18:
                    if (textBox3.Text.Replace(" ", "") == "Р" || textBox3.Text.Replace(" ", "") == "р")
                        newAlphabet();
                    else
                        MessageBox.Show($"{rand} буква алфавита - Р");
                    break;

                case 19:
                    if (textBox3.Text.Replace(" ", "") == "С" || textBox3.Text.Replace(" ", "") == "с")
                        newAlphabet();
                    else
                        MessageBox.Show($"{rand} буква алфавита - С");
                    break;

                case 20:
                    if (textBox3.Text.Replace(" ", "") == "Т" || textBox3.Text.Replace(" ", "") == "т")
                        newAlphabet();
                    else
                        MessageBox.Show($"{rand} буква алфавита - Т");
                    break;

                case 21:
                    if (textBox3.Text.Replace(" ", "") == "У" || textBox3.Text.Replace(" ", "") == "у")
                        newAlphabet();
                    else
                        MessageBox.Show($"{rand} буква алфавита - У");
                    break;

                case 22:
                    if (textBox3.Text.Replace(" ", "") == "Ф" || textBox3.Text.Replace(" ", "") == "ф")
                        newAlphabet();
                    else
                        MessageBox.Show($"{rand} буква алфавита - Ф");
                    break;

                case 23:
                    if (textBox3.Text.Replace(" ", "") == "Х" || textBox3.Text.Replace(" ", "") == "х")
                        newAlphabet();
                    else
                        MessageBox.Show($"{rand} буква алфавита - Х");
                    break;

                case 24:
                    if (textBox3.Text.Replace(" ", "") == "Ц" || textBox3.Text.Replace(" ", "") == "ц")
                        newAlphabet();
                    else
                        MessageBox.Show($"{rand} буква алфавита - Ц");
                    break;

                case 25:
                    if (textBox3.Text.Replace(" ", "") == "Ч" || textBox3.Text.Replace(" ", "") == "ч")
                        newAlphabet();
                    else
                        MessageBox.Show($"{rand} буква алфавита - Ч");
                    break;

                case 26:
                    if (textBox3.Text.Replace(" ", "") == "Ш" || textBox3.Text.Replace(" ", "") == "ш")
                        newAlphabet();
                    else
                        MessageBox.Show($"{rand} буква алфавита - Ш");
                    break;

                case 27:
                    if (textBox3.Text.Replace(" ", "") == "Щ" || textBox3.Text.Replace(" ", "") == "щ")
                        newAlphabet();
                    else
                        MessageBox.Show($"{rand} буква алфавита - Щ");
                    break;

                case 28:
                    if (textBox3.Text.Replace(" ", "") == "Ъ" || textBox3.Text.Replace(" ", "") == "ъ")
                        newAlphabet();
                    else
                        MessageBox.Show($"{rand} буква алфавита - Ъ");
                    break;

                case 29:
                    if (textBox3.Text.Replace(" ", "") == "Ы" || textBox3.Text.Replace(" ", "") == "ы")
                        newAlphabet();
                    else
                        MessageBox.Show($"{rand} буква алфавита - Ы");
                    break;

                case 30:
                    if (textBox3.Text.Replace(" ", "") == "Ь" || textBox3.Text.Replace(" ", "") == "ь")
                        newAlphabet();
                    else
                        MessageBox.Show($"{rand} буква алфавита - Ь");
                    break;

                case 31:
                    if (textBox3.Text.Replace(" ", "") == "Э" || textBox3.Text.Replace(" ", "") == "э")
                        newAlphabet();
                    else
                        MessageBox.Show($"{rand} буква алфавита - Э");
                    break;

                case 32:
                    if (textBox3.Text.Replace(" ", "") == "Ю" || textBox3.Text.Replace(" ", "") == "ю")
                        newAlphabet();
                    else
                        MessageBox.Show($"{rand} буква алфавита - Ю");
                    break;

                case 33:
                    if (textBox3.Text.Replace(" ", "") == "Я" || textBox3.Text.Replace(" ", "") == "я")
                        newAlphabet();
                    else
                        MessageBox.Show($"{rand} буква алфавита - Я");
                    break;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            gb1.Visible = true;
            newTimeOfAge();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gb2.Visible = true;
            newMonth();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gb3.Visible = true;
            newAlphabet();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkAlphabet();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkMonth();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkTimeOfAge();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            checkTimeOfAge();
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                newAlphabet();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            checkAlphabet();
        }
    }
}
