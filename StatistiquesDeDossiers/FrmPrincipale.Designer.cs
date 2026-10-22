namespace StatistiquesDeDossiers
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
            BtnDossierExiste = new Button();
            TxtDossier = new TextBox();
            BtnNombreFichier = new Button();
            LblDossier = new Label();
            BtnNombreDossier = new Button();
            this.BtnListfichiertrieraz = new Button();
            BtnFichierTrierza = new Button();
            BtnCompte = new Button();
            TxtAfficheNbr = new TextBox();
            SuspendLayout();
            // 
            // BtnDossierExiste
            // 
            BtnDossierExiste.Location = new Point(12, 76);
            BtnDossierExiste.Name = "BtnDossierExiste";
            BtnDossierExiste.Size = new Size(178, 29);
            BtnDossierExiste.TabIndex = 0;
            BtnDossierExiste.Text = "Le dossier existe-t-il ?";
            BtnDossierExiste.UseVisualStyleBackColor = true;
            BtnDossierExiste.Click += BtnDossierExiste_Click;
            // 
            // TxtDossier
            // 
            TxtDossier.Location = new Point(12, 32);
            TxtDossier.Name = "TxtDossier";
            TxtDossier.Size = new Size(469, 27);
            TxtDossier.TabIndex = 1;
            // 
            // BtnNombreFichier
            // 
            BtnNombreFichier.Location = new Point(207, 76);
            BtnNombreFichier.Name = "BtnNombreFichier";
            BtnNombreFichier.Size = new Size(245, 29);
            BtnNombreFichier.TabIndex = 0;
            BtnNombreFichier.Text = "Nombre de fichier dans ce dossier ";
            BtnNombreFichier.UseVisualStyleBackColor = true;
            BtnNombreFichier.Click += BtnNombreFichier_Click;
            // 
            // LblDossier
            // 
            LblDossier.AutoSize = true;
            LblDossier.Location = new Point(12, 9);
            LblDossier.Name = "LblDossier";
            LblDossier.Size = new Size(65, 20);
            LblDossier.TabIndex = 2;
            LblDossier.Text = "Dossier :";
            // 
            // BtnNombreDossier
            // 
            BtnNombreDossier.Location = new Point(12, 111);
            BtnNombreDossier.Name = "BtnNombreDossier";
            BtnNombreDossier.Size = new Size(440, 29);
            BtnNombreDossier.TabIndex = 3;
            BtnNombreDossier.Text = "Nombre de dossier dans ce dossier ";
            BtnNombreDossier.UseVisualStyleBackColor = true;
            BtnNombreDossier.Click += button1_Click;
            // 
            // BtnListfichiertrieraz
            // 
            this.BtnListfichiertrieraz.Enabled = false;
            this.BtnListfichiertrieraz.Location = new Point(12, 152);
            this.BtnListfichiertrieraz.Name = "BtnListfichiertrieraz";
            this.BtnListfichiertrieraz.Size = new Size(230, 29);
            this.BtnListfichiertrieraz.TabIndex = 4;
            this.BtnListfichiertrieraz.Text = "Liste des fichiers (triés de A à Z) ";
            this.BtnListfichiertrieraz.UseVisualStyleBackColor = true;
            // 
            // BtnFichierTrierza
            // 
            BtnFichierTrierza.Enabled = false;
            BtnFichierTrierza.Location = new Point(248, 152);
            BtnFichierTrierza.Name = "BtnFichierTrierza";
            BtnFichierTrierza.Size = new Size(236, 29);
            BtnFichierTrierza.TabIndex = 4;
            BtnFichierTrierza.Text = "Liste des fichiers (triés de Z à A) ";
            BtnFichierTrierza.UseVisualStyleBackColor = true;
            // 
            // BtnCompte
            // 
            BtnCompte.Enabled = false;
            BtnCompte.Location = new Point(12, 187);
            BtnCompte.Name = "BtnCompte";
            BtnCompte.Size = new Size(384, 29);
            BtnCompte.TabIndex = 4;
            BtnCompte.Text = "Compter le nombre de fichier ayant cette extension :";
            BtnCompte.UseVisualStyleBackColor = true;
            // 
            // TxtAfficheNbr
            // 
            TxtAfficheNbr.Enabled = false;
            TxtAfficheNbr.Location = new Point(408, 192);
            TxtAfficheNbr.Name = "TxtAfficheNbr";
            TxtAfficheNbr.Size = new Size(76, 27);
            TxtAfficheNbr.TabIndex = 5;
            // 
            // FrmPrincipale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 248);
            Controls.Add(TxtAfficheNbr);
            Controls.Add(BtnCompte);
            Controls.Add(BtnFichierTrierza);
            Controls.Add(this.BtnListfichiertrieraz);
            Controls.Add(BtnNombreDossier);
            Controls.Add(LblDossier);
            Controls.Add(TxtDossier);
            Controls.Add(BtnNombreFichier);
            Controls.Add(BtnDossierExiste);
            Name = "FrmPrincipale";
            Text = "Statistiques de dossiers";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnDossierExiste;
        private TextBox TxtDossier;
        private Button BtnNombreFichier;
        private Label LblDossier;
        private Button BtnNombreDossier;
        private Button BtnListfichiertrieraz;
        private Button BtnFichierTrierza;
        private Button BtnCompte;
        private TextBox TxtAfficheNbr;
    }
}
