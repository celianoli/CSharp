
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MoyenneDesNotes
{
    public partial class FrmPrincipale : Form
    {
        // STOCKAGE AVEC UN TABLEAU
        private decimal[] tableaunotes = new decimal[50];
        private int nombredenotes = 0;

        // STOCKAGE AVEC UNE LISTE
        private List<decimal> listnotes = new List<decimal>();

        public FrmPrincipale()
        {
            InitializeComponent();
        }

        // =========================
        // AJOUT DANS LE TABLEAU
        // =========================
        private void BtnAjouterTab_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(TxtSaisieNote.Text, out decimal note))
            {
                MessageBox.Show("Veuillez saisir une note valide.");
                return;
            }

            if (note < 0 || note > 20)
            {
                MessageBox.Show("La note doit être comprise entre 0 et 20.");
                return;
            }

            if (nombredenotes >= tableaunotes.Length)
            {
                MessageBox.Show("Le tableau est plein.");
                return;
            }

            tableaunotes[nombredenotes] = note;
            nombredenotes++;

            LblNotesNb.Text = nombredenotes.ToString();

            TxtSaisieNote.Clear();
            TxtSaisieNote.Focus();
        }

        // =========================
        // MOYENNE DU TABLEAU
        // =========================
        private void BtnMoyenne_Click(object sender, EventArgs e)
        {
            if (nombredenotes == 0)
            {
                MessageBox.Show("Veuillez ajouter au moins une note au tableau.");
                return;
            }

            decimal somme = 0;

            for (int i = 0; i < nombredenotes; i++)
            {
                somme += tableaunotes[i];
            }

            decimal moyenne = somme / nombredenotes;

            MessageBox.Show("Moyenne du tableau : " + moyenne.ToString("0.00"));
        }

        // =========================
        // MEDIANE DU TABLEAU
        // =========================
        private void BtnMediane_Click_1(object sender, EventArgs e)
        {
            if (nombredenotes == 0)
            {
                MessageBox.Show("Veuillez ajouter au moins une note au tableau.");
                return;
            }

            decimal[] notesTriees = new decimal[nombredenotes];

            Array.Copy(tableaunotes, notesTriees, nombredenotes);
            Array.Sort(notesTriees);

            decimal mediane;

            if (nombredenotes % 2 != 0)
            {
                mediane = notesTriees[nombredenotes / 2];
            }
            else
            {
                mediane = (
                    notesTriees[nombredenotes / 2 - 1]
                    + notesTriees[nombredenotes / 2]
                ) / 2;
            }

            MessageBox.Show("Médiane du tableau : " + mediane.ToString("0.00"));
        }

        // =========================
        // EFFACER LE TABLEAU
        // =========================
        private void BtnClear_Click(object sender, EventArgs e)
        {
            Array.Clear(tableaunotes, 0, tableaunotes.Length);

            nombredenotes = 0;

            LblNotesNb.Text = "0";
            TxtSaisieNote.Clear();
        }

        // =========================
        // AJOUT DANS LA LISTE
        // =========================
        private void BtnAjoutList_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(TxtSaisieNote.Text, out decimal note))
            {
                MessageBox.Show("Veuillez saisir une note valide.");
                return;
            }

            if (note < 0 || note > 20)
            {
                MessageBox.Show("La note doit être comprise entre 0 et 20.");
                return;
            }

            listnotes.Add(note);

            LblListNotes.Text = listnotes.Count.ToString();

            TxtSaisieNote.Clear();
            TxtSaisieNote.Focus();
        }

        // =========================
        // MOYENNE DE LA LISTE
        // =========================
        private void BtnListMoyenne_Click(object sender, EventArgs e)
        {
            if (listnotes.Count == 0)
            {
                MessageBox.Show("Veuillez ajouter au moins une note à la liste.");
                return;
            }

            decimal somme = 0;

            for (int i = 0; i < listnotes.Count; i++)
            {
                somme += listnotes[i];
            }

            decimal moyenne = somme / listnotes.Count;

            MessageBox.Show("Moyenne de la liste : " + moyenne.ToString("0.00"));
        }

        // =========================
        // MEDIANE DE LA LISTE
        // =========================
        private void BtnListMediane_Click(object sender, EventArgs e)
        {
            if (listnotes.Count == 0)
            {
                MessageBox.Show("Veuillez ajouter au moins une note à la liste.");
                return;
            }

            List<decimal> notesTriees = new List<decimal>(listnotes);
            notesTriees.Sort();

            int nombre = notesTriees.Count;
            decimal mediane;

            if (nombre % 2 != 0)
            {
                mediane = notesTriees[nombre / 2];
            }
            else
            {
                mediane = (
                    notesTriees[nombre / 2 - 1]
                    + notesTriees[nombre / 2]
                ) / 2;
            }

            MessageBox.Show("Médiane de la liste : " + mediane.ToString("0.00"));
        }

        // =========================
        // EFFACER LA LISTE
        // =========================
        private void BtnListClear_Click(object sender, EventArgs e)
        {
            listnotes.Clear();

            LblListNotes.Text = "0";
            TxtSaisieNote.Clear();
        }
    }
}
