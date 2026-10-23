namespace EditeurDeTexte
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
            LblFichierTravail = new Label();
            LblContenu = new Label();
            BtnParcourir = new Button();
            BtnChargerContenu = new Button();
            Txtchemin = new TextBox();
            TxtContenu = new TextBox();
            BtnEnregistrerContenu = new Button();
            BtnSauvegardeFichier = new Button();
            BtnSupprimerRepertoire = new Button();
            BtnOurvirRepertoire = new Button();
            SuspendLayout();
            // 
            // LblFichierTravail
            // 
            LblFichierTravail.AutoSize = true;
            LblFichierTravail.Location = new Point(12, 29);
            LblFichierTravail.Name = "LblFichierTravail";
            LblFichierTravail.Size = new Size(125, 20);
            LblFichierTravail.TabIndex = 0;
            LblFichierTravail.Text = "Fichier de travail :";
            // 
            // LblContenu
            // 
            LblContenu.AutoSize = true;
            LblContenu.Location = new Point(12, 121);
            LblContenu.Name = "LblContenu";
            LblContenu.Size = new Size(71, 20);
            LblContenu.TabIndex = 1;
            LblContenu.Text = "Contenu :";
            // 
            // BtnParcourir
            // 
            BtnParcourir.Location = new Point(386, 52);
            BtnParcourir.Name = "BtnParcourir";
            BtnParcourir.Size = new Size(94, 29);
            BtnParcourir.TabIndex = 3;
            BtnParcourir.Text = "Parcourir ...";
            BtnParcourir.UseVisualStyleBackColor = true;
            BtnParcourir.Click += BtnParcourir_Click;
            // 
            // BtnChargerContenu
            // 
            BtnChargerContenu.BackColor = SystemColors.ControlDark;
            BtnChargerContenu.FlatStyle = FlatStyle.Flat;
            BtnChargerContenu.Location = new Point(112, 85);
            BtnChargerContenu.Name = "BtnChargerContenu";
            BtnChargerContenu.Size = new Size(244, 29);
            BtnChargerContenu.TabIndex = 4;
            BtnChargerContenu.Text = "Charger le contenu du fichier";
            BtnChargerContenu.UseVisualStyleBackColor = false;
            BtnChargerContenu.Click += BtnChargerContenu_Click;
            // 
            // Txtchemin
            // 
            Txtchemin.Location = new Point(12, 52);
            Txtchemin.Name = "Txtchemin";
            Txtchemin.Size = new Size(368, 27);
            Txtchemin.TabIndex = 9;
            // 
            // TxtContenu
            // 
            TxtContenu.Location = new Point(12, 144);
            TxtContenu.Multiline = true;
            TxtContenu.Name = "TxtContenu";
            TxtContenu.Size = new Size(514, 119);
            TxtContenu.TabIndex = 10;
            // 
            // BtnEnregistrerContenu
            // 
            BtnEnregistrerContenu.BackColor = SystemColors.ControlDark;
            BtnEnregistrerContenu.Location = new Point(162, 276);
            BtnEnregistrerContenu.Name = "BtnEnregistrerContenu";
            BtnEnregistrerContenu.Size = new Size(194, 29);
            BtnEnregistrerContenu.TabIndex = 11;
            BtnEnregistrerContenu.Text = "Enregistrer le contenu";
            BtnEnregistrerContenu.UseVisualStyleBackColor = false;
            BtnEnregistrerContenu.Click += BtnEnregistrerContenu_Click;
            // 
            // BtnSauvegardeFichier
            // 
            BtnSauvegardeFichier.BackColor = SystemColors.ControlDark;
            BtnSauvegardeFichier.Location = new Point(12, 322);
            BtnSauvegardeFichier.Name = "BtnSauvegardeFichier";
            BtnSauvegardeFichier.Size = new Size(514, 29);
            BtnSauvegardeFichier.TabIndex = 11;
            BtnSauvegardeFichier.Text = "Faire une sauvegarde du fichier de travail dans un sous-dossier ";
            BtnSauvegardeFichier.UseVisualStyleBackColor = false;
            BtnSauvegardeFichier.Click += BtnSauvegardeFichier_Click;
            // 
            // BtnSupprimerRepertoire
            // 
            BtnSupprimerRepertoire.BackColor = SystemColors.ControlDark;
            BtnSupprimerRepertoire.Location = new Point(2, 357);
            BtnSupprimerRepertoire.Name = "BtnSupprimerRepertoire";
            BtnSupprimerRepertoire.Size = new Size(282, 29);
            BtnSupprimerRepertoire.TabIndex = 12;
            BtnSupprimerRepertoire.Text = "Supprimer le répertoire de sauvegarde";
            BtnSupprimerRepertoire.UseVisualStyleBackColor = false;
            BtnSupprimerRepertoire.Click += BtnSupprimerRepertoire_Click;
            // 
            // BtnOurvirRepertoire
            // 
            BtnOurvirRepertoire.BackColor = SystemColors.ControlDark;
            BtnOurvirRepertoire.Location = new Point(290, 357);
            BtnOurvirRepertoire.Name = "BtnOurvirRepertoire";
            BtnOurvirRepertoire.Size = new Size(260, 29);
            BtnOurvirRepertoire.TabIndex = 12;
            BtnOurvirRepertoire.Text = "ouvrir le répertoire de sauvegarde";
            BtnOurvirRepertoire.UseVisualStyleBackColor = false;
            BtnOurvirRepertoire.Click += BtnOurvirRepertoire_Click;
            // 
            // FrmPrincipale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnOurvirRepertoire);
            Controls.Add(BtnSupprimerRepertoire);
            Controls.Add(BtnSauvegardeFichier);
            Controls.Add(BtnEnregistrerContenu);
            Controls.Add(TxtContenu);
            Controls.Add(Txtchemin);
            Controls.Add(BtnChargerContenu);
            Controls.Add(BtnParcourir);
            Controls.Add(LblContenu);
            Controls.Add(LblFichierTravail);
            Name = "FrmPrincipale";
            Text = "Editeur de texte";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblFichierTravail;
        private Label LblContenu;
        private Button BtnParcourir;
        private Button BtnChargerContenu;
        private TextBox Txtchemin;
        private TextBox TxtContenu;
        private Button BtnEnregistrerContenu;
        private Button BtnSauvegardeFichier;
        private Button BtnSupprimerRepertoire;
        private Button BtnOurvirRepertoire;
    }
}
