using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ado_lab1
{
    public partial class disconnectedMode : Form
    {
        SqlConnection connection;
        public disconnectedMode()
        {
            InitializeComponent();
            //define connection
            connection = new SqlConnection("Data Source=feezoo;Initial Catalog=ITI;Integrated Security=True");
        }

        private void disconnectedMode_Load(object sender, EventArgs e)
        {
            loadCourse();


        }

        private void loadCourse()
        {
            #region course
            // 2- define command

            SqlCommand command = new SqlCommand("select * from Course", connection);

            // 3- define load by sqladapter link select command

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            // 4- define table
            DataTable dataTable = new DataTable();

            // 5-load data
            adapter.Fill(dataTable);

            dgv_course.DataSource = dataTable;


            #endregion
        }
        private void loadTopic()
        {
            #region topic
            SqlCommand command1 = new SqlCommand("select * from Topic", connection);
            connection.Open();
            SqlDataReader dataReader1 = command1.ExecuteReader();

            List<Topic> topics = new List<Topic>();
            while (dataReader1.Read())
            {
                Topic topic = new Topic();
                topic.Top_Id = (int)dataReader1[0];
                topic.Top_Name = dataReader1[1].ToString();
                topics.Add(topic);
            }
            connection.Close();
            //combo.DataSource = topics;
            //combo.DisplayMember = "Top_Name";
            //combo.ValueMember = "Top_Id";
            #endregion
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }
    }
}
