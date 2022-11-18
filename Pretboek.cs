using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetAdvanced_examenopdracht_arno_lai
{
    public partial class Pretboek : Form
    {
        PostsForm childform = new PostsForm();
        bool postsIsOpen = false;
        public Pretboek()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            childform.MdiParent = this;
        }

       

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void show_post_Click(object sender, EventArgs e)
        {
            if (postsIsOpen == false)
            {
                childform.Show();
                postsIsOpen = true;
            }

            else {
                childform.Hide();
                postsIsOpen = false;
            }

         
            
        }
        
    }
}
