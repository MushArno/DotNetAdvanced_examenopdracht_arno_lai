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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace DotNetAdvanced_examenopdracht_arno_lai
{
    public partial class PostsForm : Form
    {
        BindingSource postsBindingSource = new BindingSource();
        PostDAO postDAO;
        string db_connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\laiar\\source\\repos\\.NET\\Huiswerk\\DotNetAdvanced_examenopdracht_arno_lai\\pretboek_db.mdf;Integrated Security=True;Connect Timeout=5";
        

        public PostsForm()
        {
            InitializeComponent();
        }

        private void PostsForm_Load(object sender, EventArgs e)
        {
            List<Post> posts = new List<Post>();
            string query = "SELECT post_id, post_title, post_category, post_date FROM Posts";
            var connection = new SqlConnection(db_connection);
            connection.Open();
            var command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {

                posts.Add(new()
                {

                    PostId = (int)reader["post_id"],
                    PostCategory = (string)reader["post_category"],
                    PostTitle = (string)reader["post_title"],
                    PostDate = (DateTime)reader["post_date"]//DateTime.Now.ToString("dd/MM/yyyy")

                }) ;
            }
            if (numeric_select_post.Value > 0)
            {
                posts = posts.Where(a => a.PostId ==(numeric_select_post.Value)).ToList();
            }
            

            PostsDataGridView.DataSource = posts;
            reader.Close();

        }

        
        private void PostsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Niet nodig momenteel
        }

        private void GetPosts(string selectie = "")
        {
            // Haal even de methode DataGridRowAdd uit de lijst van RowAdded eventhandlers
            //this.PostsDataGridView.RowsAdded -= new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DataGridRowAdd);
            postDAO = new PostDAO();
            postDAO.Posts = postDAO.getAllPosts(selectie);

            postsBindingSource.DataSource = postDAO.Posts;
            PostsDataGridView.DataSource = postsBindingSource;
            // Voeg toe de methode DataGridRowAdd in de lijst van RowAdded eventhandlers
            //this.PostsDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DataGridRowAdd);
        }

        private void btn_search_post_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(db_connection))
            {
                //if(numeric_select_post.Value < )
                string query = "SELECT post_title FROM Posts WHERE post_id = " + numeric_select_post.Value;
                string query2 = "SELECT post_category FROM Posts WHERE post_id = " + numeric_select_post.Value;
                string query3 = "SELECT post_date FROM Posts WHERE post_id = " + numeric_select_post.Value;

                using (var command = new SqlCommand(query, connection))
                {

                    connection.Open();
                    var result = command.ExecuteScalar();
                    lb_title.Text = result.ToString();
                    connection.Close();

                }

                using (var command2 = new SqlCommand(query2, connection))
                {

                    connection.Open();
                    var result2 = command2.ExecuteScalar();
                    lb_category.Text = result2.ToString();
                    connection.Close();

                }

                using (var command3 = new SqlCommand(query3, connection))
                {

                    connection.Open();
                    var result3 = command3.ExecuteScalar();
                    lb_date.Text = result3.ToString();
                    connection.Close();

                }

            }
            
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            decimal previous = numeric_select_post.Value;
            decimal data = previous - 1;
            using (var connection = new SqlConnection(db_connection))
            {
                string query = "SELECT post_title FROM Posts WHERE post_id = " + data;
                string query2 = "SELECT post_category FROM Posts WHERE post_id = " + data;
                string query3 = "SELECT post_date FROM Posts WHERE post_id = " + data;

                using (var command = new SqlCommand(query, connection))
                {

                    connection.Open();
                    var result = command.ExecuteScalar();
                    lb_title.Text = result.ToString();
                    connection.Close();

                }

                using (var command2 = new SqlCommand(query2, connection))
                {

                    connection.Open();
                    var result2 = command2.ExecuteScalar();
                    lb_category.Text = result2.ToString();
                    connection.Close();

                }

                using (var command3 = new SqlCommand(query3, connection))
                {

                    connection.Open();
                    var result3 = command3.ExecuteScalar();
                    lb_date.Text = result3.ToString();
                    connection.Close();

                }

            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            //Next werkt denk ik maar één keer, waarom geen idee...
            decimal next = numeric_select_post.Value;
            decimal data = next + 1;
            using (var connection = new SqlConnection(db_connection))
            {
                string query = "SELECT post_title FROM Posts WHERE post_id = " + data;
                string query2 = "SELECT post_category FROM Posts WHERE post_id = " + data;
                string query3 = "SELECT post_date FROM Posts WHERE post_id = " + data;

                using (var command = new SqlCommand(query, connection))
                {

                    connection.Open();
                    var result = command.ExecuteScalar();
                    lb_title.Text = result.ToString();
                    connection.Close();

                }

                using (var command2 = new SqlCommand(query2, connection))
                {

                    connection.Open();
                    var result2 = command2.ExecuteScalar();
                    lb_category.Text = result2.ToString();
                    connection.Close();

                }

                using (var command3 = new SqlCommand(query3, connection))
                {

                    connection.Open();
                    var result3 = command3.ExecuteScalar();
                    lb_date.Text = result3.ToString();
                    connection.Close();

                }

            }
        }
    }
}
