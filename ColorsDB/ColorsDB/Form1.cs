using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorsDB
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection connection;

        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["ColorsDB.Properties.Settings.ColorsConnectionString"].ConnectionString;
        }

        private void PopulatePetsTable()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM PrimaryColor", connection))
            {
                DataTable colorTable = new DataTable();
                adapter.Fill(colorTable);

                listColors.DisplayMember = "ColorTypeName";
                listColors.ValueMember = "Id";
                listColors.DataSource = colorTable;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulatePetsTable();
        }

        private void PopulatePetNames()
        {
            string query = "SELECT PrimaryColor.Name FROM Shades INNER JOIN PrimaryColor ON PrimaryColor.TypeId WHERE Shades.Id = @TypeId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@TypeId", listColors.SelectedValue);
                DataTable colorNameTable = new DataTable();
                adapter.Fill(colorNameTable);

                ListColorNames.DisplayMember = "Name";
                ListColorNames.ValueMember = "Id";
                ListColorNames.DataSource = colorNameTable;
            }
        }
        


        private void listColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulatePetNames();
        }
    }
}
