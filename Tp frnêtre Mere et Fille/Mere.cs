using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tp_frnêtre_Mere_et_Fille
{
    public partial class FMere : Form
    {
        private List<FFille> lesFilles;
        private int nombreFille=0;
        private string nomMere;

        public FMere()
        {
            InitializeComponent();
            this.Text="Mere";
            
            this.nomMere = "Mere";
            lesFilles=new List<FFille>();
            btnNew.Click +=new EventHandler(btnNew_Click);
            btnNew.Click += new EventHandler(btnNew_Click_Message);
            btnShow.Click +=new EventHandler(btnShow_Click);
            btnHide.Click += new EventHandler(btnHide_Click);
            btnShowDialog.Click += new EventHandler(btnShowDialog_Click);
            btnClose.Click += new EventHandler(btnClose_Click);
        }
        
        void btnNew_Click(object sender,EventArgs e)
        {
            FFille nouvelleFille;
            nombreFille=nombreFille+1;
            nouvelleFille=new FFille(this,nombreFille);
            lesFilles.Add(nouvelleFille);
            lbLesFilles.Items.Add("Fille n°"+ this.nombreFille);

        }


        void btnNew_Click_Message(object sender, EventArgs e)
        {
            MessageBox.Show("Une fenetre fille a ete instanciee");
        }



        public string GetNomMere { get { return this.nomMere; } }
        
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (lbLesFilles.SelectedIndex != -1)
            {
                this.lesFilles[lbLesFilles.SelectedIndex].Close();
                lesFilles.RemoveAt(lbLesFilles.SelectedIndex);
                lbLesFilles.Items.RemoveAt(lbLesFilles.SelectedIndex);
            }
        }

        void btnShow_Click(object sender, EventArgs e)
        {
            if (lbLesFilles.SelectedIndex != -1)
            {
                this.lesFilles[lbLesFilles.SelectedIndex].Show();
            }

        }
        
         void btnHide_Click(object sender, EventArgs e)
        {
            if (lbLesFilles.SelectedIndex != -1)
            {
                this.lesFilles[lbLesFilles.SelectedIndex].Hide();
            }
        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            if (lbLesFilles.SelectedIndex != -1)
            {
                this.lesFilles[lbLesFilles.SelectedIndex].ShowDialog();
            }
        }


        public void MaFilleChangeDeNom(FFille ffille, string nouveauNom)
        {
            int position = lesFilles.IndexOf(ffille);
                if(position != -1)
                {
                    lesFilles[position]=ffille;
                    lbLesFilles.Items[position]=nouveauNom;
                }
        }
    }
}
