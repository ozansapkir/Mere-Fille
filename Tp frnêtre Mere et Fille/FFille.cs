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
    public partial class FFille : Form
    {
        private string monNom;
        private FMere maMere;

        public FFille(FMere maMere,int numero)
        {
            InitializeComponent();
            this.Text = "Fille n°"+numero;
            this.monNom = this.Text;
            this.maMere = maMere;
        }

        private void btnMaMere_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.maMere.GetNomMere);
        }

        private void btnChanger_Click(object sender, EventArgs e)
        {
            monNom = tbChanger.Text;
            this.Text = tbChanger.Text;
            this.maMere.MaFilleChangeDeNom(this, monNom);
        }

    }
}
