using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;


namespace SW_Armda_Fleet_Builder
{
    public partial class ObjectiveChoser : Form
    {

        PictureBox[] picArray = new PictureBox[20];


        public ObjectiveChoser(string obj)
        {
            InitializeComponent();

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=sw_armadadb;SslMode=none";
            string query = "SELECT CardPic FROM objectivestable WHERE Type = \"" + obj + "\"";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            ImageConverter converse = new ImageConverter();
            
            try
            {
                // Open the database
                databaseConnection.Open();
                // Execute the query
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    
                    int iii = 0;
                    int xxx = 0;
                    int yyy = 1;
                    while (reader.Read())
                    {
                        picArray[iii] = new PictureBox();
                        picArray[iii].SizeMode = PictureBoxSizeMode.AutoSize;
                        picArray[iii].Location = new Point((xxx * 250), yyy);
                        picArray[iii].Image = converse.byteArrayToImage((byte[])(reader.GetValue(0)));
                        picArray[iii].Anchor = AnchorStyles.Left|AnchorStyles.Top;
                        picArray[iii].Visible = true;
                        this.Controls.Add(picArray[iii]);
                        if (xxx % 3 == 0 && xxx != 0) {
                            yyy += 340;
                            xxx = -1;
                        };
                        picArray[iii].Click += new EventHandler(PicArray_Click);

                        xxx++;
                        iii++;
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

        void PicArray_Click(object sender, EventArgs e)
        {
            PictureBox thisBox = sender as PictureBox;
            RebelBuilder.passer = thisBox.Image;
            this.Close();
        }

    }
}
