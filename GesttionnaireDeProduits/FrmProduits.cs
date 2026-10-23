using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GesttionnaireDeProduits
{
    public partial class FrmProduits : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool SauvegardeNecessaire
        {
            get;
            set;
        } = false;

        public FrmProduits()
        {
            InitializeComponent();
        }
        public FrmProduits(Produit produit)
        {
            InitializeComponent();
            TxtNom.Text = produit.Nom;
            TxtPrix.Text = produit.Prix.ToString();
        }
        public Produit GetProduit()
        {
            Produit retour = new Produit();

            retour.Nom = TxtNom.Text;
            retour.Prix = decimal.Parse(TxtPrix.Text);

            return retour;
        }
        private void BtnEnregistrer_Click(object sender, EventArgs e)
        {
            if (SaisieValide())
            {
                SauvegardeNecessaire = true;
                Close();
            }
        }

        private bool SaisieValide()
        {
            if (string.IsNullOrWhiteSpace(TxtNom.Text))
            {
                MessageBox.Show("Ce champ est obligatoire !");
                TxtNom.Focus();
                return false;
            }
            if (!decimal.TryParse(TxtPrix.Text, out decimal prix) || prix < 0)
            {
                MessageBox.Show("Veuillez saisir un prix valide et positif !");
                TxtPrix.Focus();
                return false;
            }

            return true;


        }
        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            SauvegardeNecessaire = false;
            Close();
        }
    }
}
