namespace Calculatrice
{
    public partial class FrmPrincipale : Form
    {
        public FrmPrincipale()
        {
            InitializeComponent();
            CmbOperateur.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbOperateur.Items.Add("+");
            CmbOperateur.Items.Add("-");
            CmbOperateur.Items.Add("*");
            CmbOperateur.Items.Add("/");
            CmbOperateur.Items.Add("%");
        }

        private void BtnCalculer_Click(object sender, EventArgs e)
        {
            //Le premier terme ne doit pas être vide
            if (TxtPremierTerme.Text == "")
            {
                MessageBox.Show("Veuillez saisir le premier terme.");
                return;
            }

            // Le premier terme doit être un nombre décimal
            decimal premierTerme;
            if (!decimal.TryParse(TxtPremierTerme.Text, out premierTerme))
            {
                MessageBox.Show("Le premier terme doit être un nombre (exemple : 12,5).");
                return;
            }

            // Un opérateur doit être choisi (-1 = rien de sélectionné)
            if (CmbOperateur.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez choisir un opérateur.");
                return;
            }

            //Le premier terme ne doit pas être vide
            if (TxtSecondTerme.Text == "")
            {
                MessageBox.Show("Veuillez saisir le second terme.");
                return;
            }

            // Le second terme doit être un nombre décimal
            decimal secondTerme;
            if (!decimal.TryParse(TxtSecondTerme.Text, out secondTerme))
            {
                MessageBox.Show("Le second terme doit être un nombre (exemple : 12,5).");
                return;
            }
            // On récupère l'opérateur choisi
            string operateur = CmbOperateur.Text;

            // Interdiction de diviser par zéro (vaut aussi pour le modulo)
            if ((operateur == "/" || operateur == "%") && secondTerme == 0)
            {
                MessageBox.Show("Impossible de diviser par zéro.");
                return;
            }
            //Calcul du résultat
            decimal resultat = 0;

            switch (operateur)
            {
                case "+":
                    resultat = premierTerme + secondTerme;   // addition
                    break;

                case "-":
                    resultat = premierTerme - secondTerme;   // soustraction
                    break;

                case "*":
                    resultat = premierTerme * secondTerme;   // multiplication
                    break;

                case "/":
                    resultat = premierTerme / secondTerme;   // division
                    break;

                case "%":
                    resultat = premierTerme % secondTerme;   // modulo (reste de la division)
                    break;
            }

            if (CbArrondirResultat.Checked)
            {
                resultat = Math.Round(resultat, 2);
                MessageBox.Show(premierTerme + " " + operateur + " " + secondTerme + " = " + resultat.ToString("0.00"));
            }
            else
            {
                MessageBox.Show(premierTerme + " " + operateur + " " + secondTerme + " = " + resultat);
            }

        }
        private void LblSecondTerme_Click(object sender, EventArgs e)
        {

        }

        private void LblOperateur_Click(object sender, EventArgs e)
        {

        }

        private void TxtSecondTerme_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
