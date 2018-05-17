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
        public static Image picPasser;
        public static string side;

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

        public RebelBuilder(string sidePass)
        {
            InitializeComponent();
            side = sidePass;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string objective = "Assault";
            var objChoose = new ObjectiveChoser(objective);
            objChoose.ShowDialog(this); //Ждём закрытия ObjectiveChoser
            if (picPasser == null) { } else {
                assaultPicBox.Image = picPasser;
                assaultPicBox.Update();
                picPasser = null;
            }
            

            
        }

        private void defencePicBox_Click(object sender, EventArgs e)
        {
            string objective = "Defence";
            var objChoose = new ObjectiveChoser(objective);
            objChoose.ShowDialog(this); //Ждём закрытия ObjectiveChoser
            if (picPasser == null) { } else {
                defencePicBox.Image = picPasser;
                defencePicBox.Update();
                picPasser = null;
            }
        }

        private void navigationPicBox_Click(object sender, EventArgs e)
        {
            string objective = "Navigation";
            var objChoose = new ObjectiveChoser(objective);
            objChoose.ShowDialog(this); //Ждём закрытия ObjectiveChoser
            if (picPasser == null) { } else {
                navigationPicBox.Image = picPasser;
                navigationPicBox.Update();
                picPasser = null;
            }
        }

        private void testButt_Click(object sender, EventArgs e)
        {
            SWShip testShip = new SWShip();
            testShip.Ordnance = true;
            testShip.WeaponsTeam = true;
            
        }

        private void testingButton_Click(object sender, EventArgs e) {
            SWShip testShip = new SWShip();
            testShip.Location = new Point(18, 70);
            squadronsPanel.Location = new Point(33, 1250);
            panel1.Size = new Size(1129, 1342);
        }
    }
}
