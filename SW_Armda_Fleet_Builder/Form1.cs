using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SW_Armda_Fleet_Builder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Этот кусок позволяет переключиться на форму2, а по её закрытии -- назад.
            var frm = new RebelBuilder();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Эта функция ещё не релизована");
        }

        
    }
}
