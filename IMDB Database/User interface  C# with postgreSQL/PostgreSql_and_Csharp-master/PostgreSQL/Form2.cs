using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace PgSql
{
    public partial class Form2 : Form
    {
        List<string> dataItems = new List<string>();
        public String x;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Show();
            this.Hide();
        }

        private void actedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            acted acted = new acted();
            acted.Show();
            this.Hide();
        }

        private void actorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Actor actor = new Actor();
            actor.Show();
            this.Hide();
        }

        private void directorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Director director = new Director();
            director.Show();
            this.Hide();
        }

        private void favoritedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Favorited favorited = new Favorited();
            favorited.Show();
            this.Hide();
        }

        private void imdbuserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imdb_user imdb_user = new Imdb_user();
            imdb_user.Show();
            this.Hide();
        }

        private void movieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();
            movie.Show();
            this.Hide();
        }

        private void producedbyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produced_by produced_by = new Produced_by();
            produced_by.Show();
            this.Hide();
        }

        private void productionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Production production = new Production();
            production.Show();
            this.Hide();
        }

        private void επέλεξεToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //otan pame na klisoume thn efarmogh patwntas x,tha vgei ena mnm pou tha mas rwtaei ti theloume na kanoume
            //an pathsoume nai tote tha klisei alliws oxi tha meinei opws einai
            DialogResult dialogResult = MessageBox.Show("Are you sure want to exit?", "Question", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else if (dialogResult == DialogResult.No)
            {

                e.Cancel = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This project has been created within the DataBase subject by Post-Graduate students Dimitris Kosmas, Thedoris Kasseris and Aris Vangelis ");
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Press 'select table' and choose a table to read or update");
        }
    }
}
