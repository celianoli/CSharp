namespace CalculAge
{
    public partial class FrmPrincipale : Form
    {
        public FrmPrincipale()
        {

            InitializeComponent();
            //Ajouter un texte d'aide dans les champs de saisie
            TxtDateNaissance.PlaceholderText = "jj/mm/aaaa";
            TxtDateAutre.PlaceholderText = "jj/mm/aaaa";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Voici l'algorithme a importer dans votre projet.
            // ATTENTION à ne pas écraser le code généré par Visual Studio par cet algorithme
            // Vous devez le placer entre les accolades de la méthode "BtnPremierAlgo_Click"

            string résultat = "(texte vide)"; // On déclare une variable chaine contenant "(texte vide)"
            string prénom = TxtPrenom.Text; // On déclare une variable chaine contenant "Jean-Michel"
            //DateTime dateDeNaissance = DateTime.Parse(TxtDateNaissance.Text); // On déclare une variable date contenant la date de naissance saisie
            //DateTime uneAutreDate = DateTime.Parse(TxtDateAutre.Text); // On déclare une variable date contenant l'autre date saisie


            if (string.IsNullOrWhiteSpace(TxtPrenom.Text))
            {
                MessageBox.Show("Veuillez saisir un prénom.");
                return; // on arrête ici
            }
             // 2) La date de naissance
            if (string.IsNullOrWhiteSpace(TxtDateNaissance.Text))
            {
                MessageBox.Show("Veuillez saisir une date de naissance.");
                return;
            }
            DateTime dateDeNaissance;
            if (!DateTime.TryParse(TxtDateNaissance.Text, out dateDeNaissance))
            {
                MessageBox.Show("La date de naissance n'est pas valide (exemple : 20/07/1990).");
                return;
            }
            // 3) L'autre date
            if (string.IsNullOrWhiteSpace(TxtDateAutre.Text))
            {
                MessageBox.Show("Veuillez saisir l'autre date.");
                return;
            }
            DateTime uneAutreDate;
            if (!DateTime.TryParse(TxtDateAutre.Text, out uneAutreDate))
            {
                MessageBox.Show("L'autre date n'est pas valide (exemple : 22/08/2010).");
                return;
            }

            if (dateDeNaissance > uneAutreDate) // Si la date de naissance est supérieure à l'autre date
            {
                // Oui : la date de naissance EST supérieure à l'autre date !
                // On concatène une réponse pour dire que la personne n'était pas née
                résultat = prénom + " n'était même pas né(e) le " + uneAutreDate.ToString() + " !";
            }
            else
            {
                // Non : la date de naissance N'EST PAS supérieure à l'autre date !
                for (int i = 0; i < 99; i++) // On démarre une boucle, avec une variable i, de type entier (itérateur)
                {
                    if (dateDeNaissance.AddYears(i) > uneAutreDate) // Si la date de naissance + i année(s) est supérieure ou égale à l'autre date
                    {
                        int age = i - 1;
                        if (age <= 1)           
                        {
                            résultat = prénom + " avait " + age.ToString() + " an !"; // On indique l'age calculé (qui vaut la valeur de i)
                        }
                        else
                        {
                            résultat = prénom + " avait " + age.ToString() + " an(s) !"; // On indique l'age calculé (qui vaut la valeur de i)
                        }
                        // Oui : la date de naissance + i année(s) EST supérieure ou égale à l'autre date !
                      //  résultat = prénom + " avait " + age.ToString() + " an(s) !"; // On indique l'age calculé (qui vaut la valeur de i)
                        if (dateDeNaissance.Month == uneAutreDate.Month && dateDeNaissance.Day == uneAutreDate.Day)
                        {
                            résultat = résultat + " Et c'était pile le jour de son anniversaire !";
                        }
                        break;
                    }
                }
            }
            MessageBox.Show(résultat); // On affiche le résultat de l'algorithme dans une boite de message
        }

        private void LblPrenom_Click(object sender, EventArgs e)
        {

        }
        private void TxtDateAutre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
