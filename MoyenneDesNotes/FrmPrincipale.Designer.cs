namespace MoyenneDesNotes
{
    partial class FrmPrincipale
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LblSaisirnote = new Label();
            TxtSaisieNote = new TextBox();
            BtnAjouterTab = new Button();
            LblNombreNotes = new Label();
            LblNotesNb = new Label();
            LblObtenir = new Label();
            BtnMoyenne = new Button();
            BtnMediane = new Button();
            BtnClear = new Button();
            BtnAjoutList = new Button();
            LblListNbNotes = new Label();
            LblListNotes = new Label();
            LblListObtenir = new Label();
            BtnListMoyenne = new Button();
            BtnListMediane = new Button();
            BtnListClear = new Button();
            SuspendLayout();
            // 
            // LblSaisirnote
            // 
            LblSaisirnote.AutoSize = true;
            LblSaisirnote.Location = new Point(63, 9);
            LblSaisirnote.Name = "LblSaisirnote";
            LblSaisirnote.Size = new Size(178, 20);
            LblSaisirnote.TabIndex = 0;
            LblSaisirnote.Text = "Saisissez une note sur 20 :";
            // 
            // TxtSaisieNote
            // 
            TxtSaisieNote.Location = new Point(77, 43);
            TxtSaisieNote.Name = "TxtSaisieNote";
            TxtSaisieNote.Size = new Size(144, 27);
            TxtSaisieNote.TabIndex = 1;
            // 
            // BtnAjouterTab
            // 
            BtnAjouterTab.Location = new Point(12, 76);
            BtnAjouterTab.Name = "BtnAjouterTab";
            BtnAjouterTab.Size = new Size(129, 67);
            BtnAjouterTab.TabIndex = 2;
            BtnAjouterTab.Text = "Ajouter au tableau";
            BtnAjouterTab.UseVisualStyleBackColor = true;
            BtnAjouterTab.Click += BtnAjouterTab_Click;
            // 
            // LblNombreNotes
            // 
            LblNombreNotes.AutoSize = true;
            LblNombreNotes.Location = new Point(12, 146);
            LblNombreNotes.Name = "LblNombreNotes";
            LblNombreNotes.Size = new Size(132, 20);
            LblNombreNotes.TabIndex = 3;
            LblNombreNotes.Text = "Nombre de notes :";
            // 
            // LblNotesNb
            // 
            LblNotesNb.AutoSize = true;
            LblNotesNb.Location = new Point(62, 166);
            LblNotesNb.Name = "LblNotesNb";
            LblNotesNb.Size = new Size(17, 20);
            LblNotesNb.TabIndex = 4;
            LblNotesNb.Text = "0";
            // 
            // LblObtenir
            // 
            LblObtenir.AutoSize = true;
            LblObtenir.Location = new Point(37, 200);
            LblObtenir.Name = "LblObtenir";
            LblObtenir.Size = new Size(66, 20);
            LblObtenir.TabIndex = 5;
            LblObtenir.Text = "Obtenir :";
            // 
            // BtnMoyenne
            // 
            BtnMoyenne.Location = new Point(23, 223);
            BtnMoyenne.Name = "BtnMoyenne";
            BtnMoyenne.Size = new Size(94, 29);
            BtnMoyenne.TabIndex = 6;
            BtnMoyenne.Text = "la moyenne";
            BtnMoyenne.UseVisualStyleBackColor = true;
            BtnMoyenne.Click += BtnMoyenne_Click;
            // 
            // BtnMediane
            // 
            BtnMediane.Location = new Point(23, 258);
            BtnMediane.Name = "BtnMediane";
            BtnMediane.Size = new Size(94, 29);
            BtnMediane.TabIndex = 7;
            BtnMediane.Text = "la médiane";
            BtnMediane.UseVisualStyleBackColor = true;
            BtnMediane.Click += BtnMediane_Click_1;
            // 
            // BtnClear
            // 
            BtnClear.Location = new Point(23, 293);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(94, 29);
            BtnClear.TabIndex = 7;
            BtnClear.Text = "(clear)";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // BtnAjoutList
            // 
            BtnAjoutList.Location = new Point(159, 76);
            BtnAjoutList.Name = "BtnAjoutList";
            BtnAjoutList.Size = new Size(129, 67);
            BtnAjoutList.TabIndex = 2;
            BtnAjoutList.Text = "Ajouter au tableau";
            BtnAjoutList.UseVisualStyleBackColor = true;
            BtnAjoutList.Click += BtnAjoutList_Click;
            // 
            // LblListNbNotes
            // 
            LblListNbNotes.AutoSize = true;
            LblListNbNotes.Location = new Point(159, 146);
            LblListNbNotes.Name = "LblListNbNotes";
            LblListNbNotes.Size = new Size(132, 20);
            LblListNbNotes.TabIndex = 3;
            LblListNbNotes.Text = "Nombre de notes :";
            // 
            // LblListNotes
            // 
            LblListNotes.AutoSize = true;
            LblListNotes.Location = new Point(224, 166);
            LblListNotes.Name = "LblListNotes";
            LblListNotes.Size = new Size(17, 20);
            LblListNotes.TabIndex = 4;
            LblListNotes.Text = "0";
            // 
            // LblListObtenir
            // 
            LblListObtenir.AutoSize = true;
            LblListObtenir.Location = new Point(199, 200);
            LblListObtenir.Name = "LblListObtenir";
            LblListObtenir.Size = new Size(66, 20);
            LblListObtenir.TabIndex = 5;
            LblListObtenir.Text = "Obtenir :";
            // 
            // BtnListMoyenne
            // 
            BtnListMoyenne.Location = new Point(183, 223);
            BtnListMoyenne.Name = "BtnListMoyenne";
            BtnListMoyenne.Size = new Size(94, 29);
            BtnListMoyenne.TabIndex = 6;
            BtnListMoyenne.Text = "la moyenne";
            BtnListMoyenne.UseVisualStyleBackColor = true;
            BtnListMoyenne.Click += BtnListMoyenne_Click;
            // 
            // BtnListMediane
            // 
            BtnListMediane.Location = new Point(183, 258);
            BtnListMediane.Name = "BtnListMediane";
            BtnListMediane.Size = new Size(94, 29);
            BtnListMediane.TabIndex = 7;
            BtnListMediane.Text = "la médiane";
            BtnListMediane.UseVisualStyleBackColor = true;
            BtnListMediane.Click += BtnListMediane_Click;
            // 
            // BtnListClear
            // 
            BtnListClear.Location = new Point(183, 293);
            BtnListClear.Name = "BtnListClear";
            BtnListClear.Size = new Size(94, 29);
            BtnListClear.TabIndex = 7;
            BtnListClear.Text = "(clear)";
            BtnListClear.UseVisualStyleBackColor = true;
            BtnListClear.Click += BtnListClear_Click;
            // 
            // FrmPrincipale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 450);
            Controls.Add(BtnListClear);
            Controls.Add(BtnClear);
            Controls.Add(BtnListMediane);
            Controls.Add(BtnMediane);
            Controls.Add(BtnListMoyenne);
            Controls.Add(BtnMoyenne);
            Controls.Add(LblListObtenir);
            Controls.Add(LblObtenir);
            Controls.Add(LblListNotes);
            Controls.Add(LblNotesNb);
            Controls.Add(LblListNbNotes);
            Controls.Add(LblNombreNotes);
            Controls.Add(BtnAjoutList);
            Controls.Add(BtnAjouterTab);
            Controls.Add(TxtSaisieNote);
            Controls.Add(LblSaisirnote);
            Name = "FrmPrincipale";
            Text = "Moyenne des notes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblSaisirnote;
        private TextBox TxtSaisieNote;
        private Button BtnAjouterTab;
        private Label LblNombreNotes;
        private Label LblNotesNb;
        private Label LblObtenir;
        private Button BtnMoyenne;
        private Button BtnMediane;
        private Button BtnClear;
        private Button BtnAjoutList;
        private Label LblListNbNotes;
        private Label LblListNotes;
        private Label LblListObtenir;
        private Button BtnListMoyenne;
        private Button BtnListMediane;
        private Button BtnListClear;
    }
}
