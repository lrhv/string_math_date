using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //üçüncü harfi e ve beşinci harfi a olan kelimeleri arayan kod
            if (text1.Text.Length >= 5)
            {
                string cumle;
                int cnt = 0;
                string[] kelimeler = text1.Text.Split(' ');
                for (int i = 0; i < kelimeler.Length; i++)
                {
                    char[] arr = kelimeler[i].ToLower().ToCharArray();
                    if (arr.Length >= 5 && arr[2] == 'e' && arr[4] == 'a')
                    {

                        TextBox1.AppendText(kelimeler[i] + "\n");
                        cnt++;
                    }
                }
                text2.Text = cnt.ToString();
                text1.ReadOnly = true;
                text2.Visible = true;
                TextBox1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
            }
            else
            {
                MessageBox.Show("En az 5 karakterli kelime veya cümle giriniz");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            text1.ReadOnly = false;
            text2.Visible = false;
            TextBox1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            text1.Text = " ";
            TextBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
