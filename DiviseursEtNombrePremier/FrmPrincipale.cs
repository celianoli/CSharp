namespace DiviseursEtNombrePremier
{
    public partial class FrmPrincipale : Form
    {
        public FrmPrincipale()
        {
            InitializeComponent();

        }

        private void BtnRechercheDiviseur_Click(object sender, EventArgs e)
        {
            // Le champ ne doit pas être vide
            if (TxtNombreEntier.Text == "")
            {
                MessageBox.Show("Veuillez saisir un nombre.");
                return;
            }
            // Le texte doit être un nombre entier
            int nombre;
            if (!int.TryParse(TxtNombreEntier.Text, out nombre))
            {
                MessageBox.Show("Veuillez saisir un nombre entier (exemple : 12).");
                return;
            }
            //nombre positif
            if (nombre <= 0)
            {
                MessageBox.Show("Le nombre doit être strictement positif.");
                return;
            }
            string listeDiviseurs = "";
            int nombreDeDiviseurs = 0;

            for (int diviseurteste = 1; diviseurteste <= nombre; diviseurteste++)
            {
                if (nombre % diviseurteste == 0)
                {
                    if (listeDiviseurs != "")
                    {
                        listeDiviseurs = listeDiviseurs + ", ";
                    }
                    listeDiviseurs = listeDiviseurs + diviseurteste;
                    nombreDeDiviseurs++;
                }
            }
            // On affiche les diviseurs dans le label
            LblDiviseurTrouve.Text = "Diviseurs : " + listeDiviseurs;
            // Un nombre premier a exactement 2 diviseurs : 1 et lui-même
            if (nombreDeDiviseurs == 2)
            {
                Rboui.Checked = true;
            }
            else
            {
                Rbnon.Checked = true;
            }
        }

        private void RbVraiFaux_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
