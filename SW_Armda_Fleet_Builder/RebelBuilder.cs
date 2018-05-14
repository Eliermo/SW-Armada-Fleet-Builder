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
        
        public class SWShip : PictureBox {
            public int Cost;
            public bool Defencive;
            public bool FleetSupport;
            public bool FleetCommand;
            public bool IonCannons;
            public bool Offensive;
            public bool Officer;
            public bool Ordnance;
            public bool SupportTeam;
            public bool Turbolasers;
            public bool WeaponsTeam;
            public bool HasBoarders (bool WeaponsTeam, bool Ordnance)
            {
                if (WeaponsTeam == true &&  Ordnance == true) return true;
                else return false;
            }

        }

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

        private void testButt_Click(object sender, EventArgs e)
        {
            SWShip testShip = new SWShip();
            testShip.Ordnance = true;
            testShip.WeaponsTeam = true;
            
        }
    }
}
