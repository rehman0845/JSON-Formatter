using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var str = richTextBox2.Text;
            var txt=TextGen(str.Replace('\"', '\''));
            //textBox2.Text = txt.Replace('\'', '\"');
            //richTextBox1.Text = "string1"+ Environment.NewLine +'\t'+ "string2";
           richTextBox1.Text = txt.Replace('\'', '\"');
            //using (StreamWriter sw = new System.IO.StreamWriter(File.OpenWrite(@"G:\rehman\test\programs\MVC\Console\WindowsFormsApp1\text.txt")))
            //{
            //    sw.Write(str);
            //}
        }

        private string TextGen(string str)
        {
            int cnt = 0;
            var strBul = string.Empty;
            foreach(var c in str)
            {
                if(c == '{' || c == ',')
                {

                    if (c == '{')
                        ++cnt;
                    //appendText(strBul,cnt);
                    strBul = strBul + c;
                    strBul = strBul + Environment.NewLine;

                    for (int i = cnt; i > 0; i--)
                    {
                        strBul = strBul + '\t';
                    }
                }
                if(c == '}')
                {
                    --cnt;
                    //appendText(strBul,cnt);
                    strBul = strBul + Environment.NewLine;

                    strBul.Insert(strBul.Length - 1, Environment.NewLine);
                    for (int i = cnt; i > 0; i--)
                    {
                        strBul = strBul + '\t';
                    }
                    strBul = strBul + c;

                }
                if (c != '{' && c != ',' && c!='}')
                    strBul = strBul + c;



            }
            return strBul;
        }
        private void appendText(string strBul, int cnt)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
