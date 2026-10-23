using System.Diagnostics;
using System.Text;

namespace AnalyseFichiersTempo
{
    public partial class FrmPrincipale : Form
    {

        public FrmPrincipale()
        {
            InitializeComponent();
        }

        private void BtnGenerationInventaire_Click(object sender, EventArgs e)
        {
            string dossiertemp = Path.GetTempPath();
            string chemincsv = Path.Combine(@"C:\cfai\test", "fichierTemporaire.csv");
            using (StreamWriter ent = new StreamWriter(chemincsv))
            {
                ent.WriteLine("NomCompletFichier;TailleEnOctets;Creation;Ecriture;Acces;Extension");
                foreach (string fichier in Directory.GetFiles(dossiertemp))
                {
                    FileInfo info = new FileInfo(fichier);

                    ent.WriteLine($"{info.FullName};{info.Length};{info.CreationTime};{info.LastWriteTime};{info.LastAccessTime};{info.Extension}");

                }
            }
            BtnOuvrirInventaire.Enabled = true;
        }

        private void BtnOuvrirInventaire_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(@"C:\cfai\test\fichierTemporaire.csv"))
            {
            Process.Start("explorer.exe", @"C:\cfai\test\fichierTemporaire.csv");        
            }
            else
            {
                MessageBox.Show("veuillez chnager le repertoire dans le code");
            }
        }
    }
}
