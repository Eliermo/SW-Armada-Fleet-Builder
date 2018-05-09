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
    public partial class RebelBuilder : Form
    {
        public static Image passer;     
        public RebelBuilder()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string objective = "Assault";
            var objChoose = new ObjectiveChoser(objective);
            objChoose.ShowDialog(this); //Ждём закрытия ObjectiveChoser
            assaultPicBox.Image = passer;
            assaultPicBox.Update();

            
        }

        private void defencePicBox_Click(object sender, EventArgs e)
        {
            string objective = "Defence";
            var objChoose = new ObjectiveChoser(objective);
            objChoose.ShowDialog(this); //Ждём закрытия ObjectiveChoser
            defencePicBox.Image = passer;
            defencePicBox.Update();
        }

        private void navigationPicBox_Click(object sender, EventArgs e)
        {
            string objective = "Navigation";
            var objChoose = new ObjectiveChoser(objective);
            objChoose.ShowDialog(this); //Ждём закрытия ObjectiveChoser
            navigationPicBox.Image = passer;
            navigationPicBox.Update();
        }
    }
}
