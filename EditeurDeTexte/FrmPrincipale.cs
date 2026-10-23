using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace EditeurDeTexte
{
    public partial class FrmPrincipale : Form
    {
        OpenFileDialog dialogue = new OpenFileDialog();
        string Chemin
        {
            get 
            {
                return Txtchemin.Text;
            }
            set
            {
                Txtchemin.Text = value;
            }
        }
        string DossierSauvegarde
        {
            get
            {
                return Path.Combine(Path.GetDirectoryName(Chemin),"Sauvegarde");
            }
        }
        
        public FrmPrincipale()
        {
            InitializeComponent();
            Txtchemin.PlaceholderText = @"C:\cfai\informatique Licence\C#\CoursScharp";

        }
        private void BtnParcourir_Click(object sender, EventArgs e)
        {
            
            // OpenFileDialog dialogue = new OpenFileDialog();

            dialogue.CheckFileExists = false;
            dialogue.InitialDirectory = Chemin;

            if (dialogue.ShowDialog() == DialogResult.OK)
            {
                // MessageBox.Show("Fichier sélectionné : " + dialogue.FileName);
                Chemin = dialogue.FileName;
            }

        }

        private void BtnChargerContenu_Click(object sender, EventArgs e)
        {
            string donnees = File.ReadAllText(dialogue.FileName);
            TxtContenu.Text = donnees;
        }

        private void BtnSauvegardeFichier_Click(object sender, EventArgs e)
        {
     
            Directory.CreateDirectory(DossierSauvegarde);

            //création du nouveau nom de fichier 
            string dateHeure = DateTime.Now.ToString("yyyy.MM.dd.HH.mm.ss");
            string nouveauNom = dateHeure + ".BAK";

            //construction du chemin de destination +copie du fichier dans le dossier 
            string destination = Path.Combine(DossierSauvegarde, nouveauNom);
            File.Copy(Chemin, destination, false);
        }

        private void BtnEnregistrerContenu_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Chemin, TxtContenu.Text);
        }

        private void BtnSupprimerRepertoire_Click(object sender, EventArgs e)
        {
      
            if (!Directory.Exists(DossierSauvegarde))
            {
                MessageBox.Show("Aucun fichier de sauvegarde à été crée.");
                return;
            }

            DialogResult resultat = MessageBox.Show(
                "Voulez-vous vraiment supprimer le dossier sauvegarde et tout son contenu ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resultat == DialogResult.Yes)
            {
                Directory.Delete(DossierSauvegarde, true);
                MessageBox.Show("Le dossier sauvegarde a été supprimé.");
            }
        }

        private void BtnOurvirRepertoire_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Chemin))
            {
                MessageBox.Show("Veuillez sélectionner un fichier existant.");
                return;
            }
            Process.Start("explorer.exe", DossierSauvegarde);
        }
    }
}

