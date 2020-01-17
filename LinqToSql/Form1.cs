using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;


namespace LinqToSql
{
    
    public partial class Form1 : MetroForm
    {
        EcoleDataContext db = new EcoleDataContext(@"C:\Users\Med-Fnissis\source\repos\LinqToSql\LinqToSql\Ecole.mdf");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            STAGIAIRE table = new STAGIAIRE();
            table.CIN = txtcin.Text;
            table.NOM = txtnom.Text;
            table.PRENOM = txtprenom.Text;
            txtcin.Clear();
            txtnom.Clear();
            txtprenom.Clear();
            db.STAGIAIRE.InsertOnSubmit(table);
            db.SubmitChanges();
            MessageBox.Show("Les Info à été Ajouter");
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var liststagiaire = from itm in db.STAGIAIRE
                                select itm;
            dataGridView1.DataSource = liststagiaire;
        }

        private void butrechercher_Click(object sender, EventArgs e)
        {
            var re = (from itm in db.STAGIAIRE
                     where itm.CIN == rech.Text
                     select itm).Single();

            recin.Text = re.CIN;
            renom.Text = re.NOM;
            reprenom.Text = re.PRENOM;
        }
    }
}


