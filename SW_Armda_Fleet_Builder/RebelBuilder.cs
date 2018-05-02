﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace SW_Armda_Fleet_Builder
{
    public partial class RebelBuilder : Form
    {
             
        public RebelBuilder()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string objective = "Assault";
            Image chosenOb;
            var objChoose = new ObjectiveChoser(objective, out chosenOb);
            assaultPicBox.Image = chosenOb;
            objChoose.Show();

            //Не хватает блокировки.
        }
    }
}
