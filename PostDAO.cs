using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvanced_examenopdracht_arno_lai
{
    internal class PostDAO
    {
        string db_connection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\laiar\\source\\repos\\.NET\\Huiswerk\\DotNetAdvanced_examenopdracht_arno_lai\\pretboek_db.mdf;Integrated Security=True;Connect Timeout=5";
        public List<Post> Posts { get; set; }


        public List<Post> getAllPosts(string selectie)
        {
            List<Post> posts = new List<Post>();

            //Heb het hier denk ik niet meer nodig maar laat het nog staan.

            //posts.Add(new Post() { PostId = 1, PostCategory = "meme", PostTitle = "Arno", PostDate = DateTime.Now});
            //posts.Add(new Post() { PostId = 2, PostCategory = "meme", PostTitle = "Robin", PostDate = DateTime.Now });
            //posts.Add(new Post() { PostId = 3, PostCategory = "meme", PostTitle = "Joran", PostDate = DateTime.Now });

            SqlConnection connection = new SqlConnection(db_connection);
            SqlCommand command = new SqlCommand("SELECT post_id, post_category, post_title, post_date FROM Posts", connection); //WHERE post_approved = 1
            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    posts.Add(new Post()
                    {
                        PostId = reader.GetInt32(0), // index komt uit de query!
                        PostCategory = reader.GetString(1),
                        PostTitle = reader.GetString(2)
                    });
                }
            }
            if (selectie != "")
            {
                posts = posts.Where(a =>  a.PostTitle.Contains(selectie)).ToList();
            }
            connection.Close();
            return posts;
        }
    }
}
