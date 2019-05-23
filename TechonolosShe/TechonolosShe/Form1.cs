using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechonolosShe
{
    public partial class Form1 : Form
    {
        private int contador;
        public Form1()
        {
            InitializeComponent();
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            Class1 clase = new Class1();

            await Task.Run(() =>
            {
                long c = clase.metodo();
            });
            
            label1.Text = c.ToString();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            contador += 1;
            label2.Text = contador.ToString();
        }
    }
}
