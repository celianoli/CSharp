namespace GesttionnaireDeProduits
{
    public partial class FrmGestionnaireDeProduits : Form
    {
        public FrmGestionnaireDeProduits()
        {
            InitializeComponent();
        }

        private void BtnAjouterPrdouit_Click(object sender, EventArgs e)
        {
            FrmProduits frmProduit = new FrmProduits();
            frmProduit.ShowDialog();
            if (frmProduit.SauvegardeNecessaire)
            {
                LsbListeProduits.Items.Add(frmProduit.GetProduit());

            }
        }

        private void BtnEditProduit_Click(object sender, EventArgs e)
        {
            Produit produit = (Produit)LsbListeProduits.Items[LsbListeProduits.SelectedIndex];
            FrmProduits frmProduit = new FrmProduits(produit);
            frmProduit.ShowDialog();
            if (frmProduit.SauvegardeNecessaire)
            {
                LsbListeProduits.Items[LsbListeProduits.SelectedIndex] = frmProduit.GetProduit();
            }

        }
    }
}
