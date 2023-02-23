using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ado_lab1
{
    public partial class connectedMode : Form
    {
        SqlConnection connection;
        public connectedMode()
        {
            InitializeComponent();


            connection = new SqlConnection("Data Source=feezoo;Initial Catalog=ITI;Integrated Security=True");
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            //topic loading first
            showVisible(false);
            loadTopic();
            fillcourse();




        }

        private void fillcourse()
        {
            #region course

            //define query type
            SqlCommand command = new SqlCommand("select * from Course", connection);

            //open connection
            connection.Open();


            //excute command
            SqlDataReader dataReader = command.ExecuteReader();



            //prepare data

            List<Course> courses = new List<Course>();
            while (dataReader.Read())
            {
                Course course = new Course();
                course.Crs_Id = (int)dataReader[0];
                course.Crs_Name = dataReader[1].ToString();
                course.Crs_Duration = (int)dataReader[2];
                course.Top_Id = (int)dataReader[3];
                courses.Add(course);
            }

            //end connection

            connection.Close();
            dgv_course.DataSource = courses;
            #endregion
        }

        private void loadTopic()
        {
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
           combo.DataSource= topics;
            combo.DisplayMember = "Top_Name";
            combo.ValueMember = "Top_Id";
        }

        private int getId()
        {
            SqlCommand command = new SqlCommand("select max(Crs_Id) from Course", connection);
            connection.Open();
            var result = command.ExecuteScalar();
            int id = (int)result;
            connection.Close();
            return id;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int id= getId()+1;
            string commandText = "insert into Course values(@id,@Crs_ID,@Crs_Duration,@topic)";
            SqlCommand command= new SqlCommand(commandText, connection);
            command.Parameters.AddWithValue("id", id);
            command.Parameters.AddWithValue("Crs_ID", co_name.Text);
            command.Parameters.AddWithValue("Crs_Duration", num_duration.Value);
            command.Parameters.AddWithValue("topic", combo.SelectedValue);
            
            connection.Open();
            int result=command.ExecuteNonQuery();
            connection.Close();
            if(result>0)
            {
                MessageBox.Show("inserted done");
                fillcourse();
                clearData();


            }
        }
        private int id = 0;
        private void dgv_course_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            showVisible(true);
            id = (int)dgv_course.SelectedRows[0].Cells[0].Value;
            co_name.Text = dgv_course.SelectedRows[0].Cells[1].Value.ToString();
            num_duration.Value = (int)dgv_course.SelectedRows[0].Cells[2].Value;
            combo.SelectedValue = (int)dgv_course.SelectedRows[0].Cells[3].Value;

        }
        
        private void up_date_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("update Course set Crs_Name=@name,Crs_Duration=@dura,Top_Id=@topic where Crs_Id=@id", connection);
          
            command.Parameters.AddWithValue("id", id);
            command.Parameters.AddWithValue("name", co_name.Text);
            command.Parameters.AddWithValue("dura", num_duration.Value);
            command.Parameters.AddWithValue("topic", combo.SelectedValue);

            connection.Open();
            int result=command.ExecuteNonQuery();   
            connection.Close();

            if(result>0)
            {
                MessageBox.Show("updated done");
                fillcourse();
                showVisible(false);
                clearData();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("delete from Course where Crs_Id=@id", connection);
            command.Parameters.Add(new SqlParameter("id", id));
            connection.Open();
            int result=command.ExecuteNonQuery();
            connection.Close();
            if(result>0)
            {
                MessageBox.Show("deletion done");
                fillcourse();
                showVisible(false);
                clearData();
            }
        }

        private void showVisible(bool visiblity)
        {
            btn_delete.Visible = visiblity;
            up_date.Visible = visiblity;
            btn_add.Visible = !visiblity;
        }

        private void clearData()
        {
            co_name.Text = "";
            num_duration.Value = 0;
         

        }
    }
}
