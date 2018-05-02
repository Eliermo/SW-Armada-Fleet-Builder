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

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RebelBuilder));

            objective = obj;

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=sw_armadadb;SslMode=none";
            string query = "SELECT CardPic FROM objectivestable WHERE Type = \"" + objective + "\" and ID = 1";

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
                    while (reader.Read())
                    {
                        chosenOb = converse.byteArrayToImage((byte[])(reader.GetValue(0)));
                        pictureBox1.Image = chosenOb;
                        /* запрос возвращает нам строку с одним элементом (0)
                         * БЛОБ, который конвертится в картинку и выдаётся. Если делать так, как надо, то будет кучка строк,
                         * но тоже с ожним элементом.
                         * Комменты решают.
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
