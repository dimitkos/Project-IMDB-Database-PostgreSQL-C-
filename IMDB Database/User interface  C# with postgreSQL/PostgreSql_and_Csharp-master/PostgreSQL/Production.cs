﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PgSql
{
    public partial class Production : Form
    {
        public static String newname;
        public static String oldname;
        List<string> dataItems = new List<string>();

        public Production()
        {
            InitializeComponent();
        }

        private void Production_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PostGreSQL pgTest = new PostGreSQL();                  
            dataItems = pgTest.PostgreSQLtest14();                  //vale stin metavliti dataitems, oti exi epistrepsi to PostgreSQLtest2
            tbDataItems.Clear();                                   //katharise to periexomeno tou pinaka apo kato
            for (int i = 0; i < dataItems.Count; i++)              //Epanalipsi gia na ektiposume se diaforetikes grammes to output apo tin endoli pou stilame sti vasi
            {
                tbDataItems.Text += dataItems[i];                   //emfanise ston pinaka apo kato , ta apotelesmata tu query
                tbDataItems.ScrollToCaret();                        //Afu ektiposis ta dataitems tis siras i pou pernai apo tin loopa, alakse sira prin pas sto epomeno i
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbDataItems_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            oldname = textBox1.Text;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            newname = textBox2.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PostGreSQL pgTest = new PostGreSQL();                  
            dataItems = pgTest.PostgreSQLtest19();                  //vale stin metavliti dataitems, oti exi epistrepsi to PostgreSQLtest2
            tbDataItems.Clear();                                   //katharise to periexomeno tou pinaka apo kato
            for (int i = 0; i < dataItems.Count; i++)              //Epanalipsi gia na ektiposume se diaforetikes grammes to output apo tin endoli pou stilame sti vasi
            {
                tbDataItems.Text += dataItems[i];                   //emfanise ston pinaka apo kato , ta apotelesmata tu query
                tbDataItems.ScrollToCaret();                        //Afu ektiposis ta dataitems tis siras i pou pernai apo tin loopa, alakse sira prin pas sto epomeno i
            }
        }

        private void Production_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
