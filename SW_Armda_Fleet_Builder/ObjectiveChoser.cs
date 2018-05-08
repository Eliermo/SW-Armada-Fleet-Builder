using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace SW_Armda_Fleet_Builder
{
    public partial class ObjectiveChoser : Form
    {
        string objective;

        public ObjectiveChoser(string obj, out Image chosenOb)
        {
            InitializeComponent();
            VerticalScroll.Enabled = true;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RebelBuilder));

            objective = obj;

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=sw_armadadb;SslMode=none";
            string query = "SELECT CardPic FROM objectivestable WHERE Type = \"" + objective + "\"";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            ImageConverter converse = new ImageConverter();

            chosenOb = ((Image)(resources.GetObject("assaultPicBox.Image")));

            try
            {
                // Open the database
                databaseConnection.Open();

                // Execute the query
                reader = commandDatabase.ExecuteReader();

                // All succesfully executed, now do something

                // IMPORTANT : 
                // If your query returns result, use the following processor :

                if (reader.HasRows)
                {
                    int picArrSize = 20;
                    PictureBox[] picArray = new PictureBox[picArrSize];
                    int iii = 0;
                    int yyy = 1;
                    while (reader.Read())
                    {
                        picArray[iii] = new PictureBox();
                        //picArray[iii].Size = new Size(1,1);
                        picArray[iii].SizeMode = PictureBoxSizeMode.AutoSize;
                        picArray[iii].Location = new Point((iii * 250), yyy);
                        //picArray[iii].BackgroundImage = Properties.Resources.cardback;
                        //picArray[iii].BackgroundImageLayout = ImageLayout.Stretch;
                        picArray[iii].Image = converse.byteArrayToImage((byte[])(reader.GetValue(0)));
                        picArray[iii].Anchor = AnchorStyles.Left|AnchorStyles.Top;
                        picArray[iii].Visible = true;
                        this.Controls.Add(picArray[iii]);
                        if (iii % 3 == 0 && iii != 0) {
                            yyy += 340;
                            iii = -1;
                        };
                        iii++;
                        /*
                        int iii = 1;
                        picArray[iii] = new PictureBox();
                        picArray[iii].Visible = true;
                        picArray[iii].Anchor = AnchorStyles.Left;
                        picArray[iii].SizeMode = PictureBoxSizeMode.AutoSize;
                        picArray[iii].Location = new Point(iii * 196, 47);
                        picArray[iii].Image = convi.byteArrayToImage((byte[])(reader.GetValue(0)));
                        iii++;
                        pictureBox1.Image = convi.byteArrayToImage((byte[])(reader.GetValue(0)));
                        this.Controls.Add(picArray[iii]);
                        */
                        //chosenOb = converse.byteArrayToImage((byte[])(reader.GetValue(0)));
                        //pictureBox1.Image = chosenOb;
                        /* запрос возвращает нам массив, в нашем случае с одним эелементом (0)
                         * БЛОБ, который конвертится в картинку и выдаётся. Потом лупается "пока"
                         * и выдаётся новый массив, пока таблица не закончится
                         */
                    }
                }
                else
                {
                    Console.WriteLine("Nothing found.");
                }

                // Finally close the connection
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(objective);
            this.Close();
        }
    }
}
