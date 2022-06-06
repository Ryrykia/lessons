using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;


namespace проверка_пароля
{
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Ok_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text.Length < 6)
             {
                label2.Text = "Пароль должен содержать минимум 6 символов";
             }
            
            if (textBox1.Text.Any(c => char.IsLower(c)))
            {
                label3.Text = " ";
            }
            else
            {                
                label3.Text = "Пароль должен содержать минимум 1 пропусную букву";
            }
            if (textBox1.Text.Any(c => char.IsDigit(c)))
            {
                label4.Text = " ";
            }
            else
            {
                label4.Text = "Пароль должен содержать минимум 1 цифру";
            }
            if (textBox1.Text.Any(c => char.IsPunctuation(c)))
            {
                label5.Text = " ";
            }
            else
            {              
                label5.Text = "Пароль должен содержать минимум 1 из специальных символов ! @ # $ % ^";
            }
            if (textBox1.Text.Length >= 6 && textBox1.Text.Any(c => char.IsLower(c))&& textBox1.Text.Any(c => char.IsDigit(c))&& textBox1.Text.Any(c => char.IsPunctuation(c)))
            {               
                FileStream file = new FileStream(@"F:text.txt", FileMode.OpenOrCreate);
                StreamWriter writer = new StreamWriter(file);
                writer.WriteLine(textBox1.Text);
                writer.Close();
                label6.Text = "Пароль успешно сохранен";
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
     
