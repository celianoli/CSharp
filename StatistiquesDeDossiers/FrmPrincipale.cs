namespace StatistiquesDeDossiers
{
    public partial class FrmPrincipale : Form
    {
        public FrmPrincipale()
        {
            InitializeComponent();
            TxtDossier.PlaceholderText = @"C:\cfai\informatique Licence\C#\CoursScharp";
            TxtDossier.TextChanged += TxtDossier_TextChanged;
        }

        private void TxtDossier_TextChanged(object sender, EventArgs e)
        {
            // Dès que le chemin change, on désactive les contrôles
            DesactiverControles();
        }

        private void BtnDossierExiste_Click(object sender, EventArgs e)
        {
            String chemindossier = TxtDossier.Text;
            if (TxtDossier.Text == "")
            {
                MessageBox.Show("Veuillez saisir le chemin d'un dossier.");
                return;
            }
            if (Directory.Exists(chemindossier))
            {
                MessageBox.Show("Le dossier \"" + chemindossier + "\" existe.");
                //deverouillage des bouton 
                BtnFichierTrierza.Enabled = true;
                BtnListfichiertrieraz.Enabled = true;
                BtnCompte.Enabled = true;
                TxtAfficheNbr.Enabled = true;
            }
            else
            {
                MessageBox.Show("Le dossier \"" + chemindossier + "\" n'existe pas.");
            }
          
        }
        private void DesactiverControles()
        {
            BtnFichierTrierza.Enabled = false;
            BtnListfichiertrieraz.Enabled = false;
            BtnCompte.Enabled = false;
            TxtAfficheNbr.Enabled = false;
        }
   
        private void BtnNombreFichier_Click(object sender, EventArgs e)
        {
            String chemindossier = TxtDossier.Text;
            if (TxtDossier.Text == "")
            {
                MessageBox.Show("Veuillez saisir le chemin d'un dossier.");
                return;
            }
            // On ne peut pas compter les fichiers d'un dossier qui n'existe pas
            if (!Directory.Exists(chemindossier))
            {
                MessageBox.Show("Le dossier \"" + chemindossier + "\" n'existe pas.");
                return;
            }

            try
            {
                // Directory.GetFiles renvoie la liste des fichiers du dossier
                // (uniquement ce dossier, pas les sous-dossiers = non récursif)
                // .Length donne le nombre d'éléments dans cette liste
                int nombreFichiers = Directory.GetFiles(chemindossier).Length;

                // Gestion du pluriel
                if (nombreFichiers <= 1)
                {
                    MessageBox.Show("Le dossier contient " + nombreFichiers + " fichier.");
                }
                else
                {
                    MessageBox.Show("Le dossier contient " + nombreFichiers + " fichiers.");
                }
            }
            catch (UnauthorizedAccessException)
            {
                // Certains dossiers sont protégés par Windows
                MessageBox.Show("Vous n'avez pas le droit d'accéder à ce dossier.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String chemindossier = TxtDossier.Text;
            if (TxtDossier.Text == "")
            {
                MessageBox.Show("Veuillez saisir le chemin d'un dossier.");
                return;
            }
            if (!Directory.Exists(chemindossier))
            {
                MessageBox.Show("Le dossier \"" + chemindossier + "\" n'existe pas.");
                return;
            }

            try
            {
                // Directory.GetFiles renvoie la liste des fichiers du dossier
                // (uniquement ce dossier, pas les sous-dossiers = non récursif)
                // .Length donne le nombre d'éléments dans cette liste
                int nombreDossier = Directory.GetDirectories(chemindossier).Length;

                // Gestion du pluriel
                if (nombreDossier <= 1)
                {
                    MessageBox.Show("Le dossier contient " + nombreDossier + " dossier.");
                }
                else
                {
                    MessageBox.Show("Le dossier contient " + nombreDossier + " dossiers.");
                }
            }
            catch (UnauthorizedAccessException)
            {
                // Certains dossiers sont protégés par Windows
                MessageBox.Show("Vous n'avez pas le droit d'accéder à ce dossier.");
            }
        }
    }
}
