using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Takarakuji
{
    public partial class Form1 : Form
    {
        KujiCheck checker = new KujiCheck(123456,1234,12);

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(textBox1.Text, out number)) { 
                Kuji kuji = new Kuji(number);
                int kingaku = checker.check(kuji);

                Form2 form2 = new Form2();
                form2.kekka = kuji.Kekka;
                form2.kingaku = kingaku;
                form2.ShowDialog();

                labelTotal.Text = checker.Total + "円";
                textBox1.Text = "";

            }else{
                MessageBox.Show("数字を入力してください");
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            checker.reset();
            labelTotal.Text = checker.Total + "円";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
