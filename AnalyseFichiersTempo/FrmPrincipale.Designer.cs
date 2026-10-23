namespace AnalyseFichiersTempo
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
            BtnGenerationInventaire = new Button();
            BtnOuvrirInventaire = new Button();
            SuspendLayout();
            // 
            // BtnGenerationInventaire
            // 
            BtnGenerationInventaire.BackColor = SystemColors.ActiveCaption;
            BtnGenerationInventaire.Location = new Point(70, 12);
            BtnGenerationInventaire.Name = "BtnGenerationInventaire";
            BtnGenerationInventaire.Size = new Size(411, 29);
            BtnGenerationInventaire.TabIndex = 0;
            BtnGenerationInventaire.Text = "Génerer l'inventaire des fichiers temporaires (csv)";
            BtnGenerationInventaire.UseVisualStyleBackColor = false;
            BtnGenerationInventaire.Click += BtnGenerationInventaire_Click;
            // 
            // BtnOuvrirInventaire
            // 
            BtnOuvrirInventaire.BackColor = SystemColors.AppWorkspace;
            BtnOuvrirInventaire.Enabled = false;
            BtnOuvrirInventaire.Location = new Point(70, 47);
            BtnOuvrirInventaire.Name = "BtnOuvrirInventaire";
            BtnOuvrirInventaire.Size = new Size(411, 29);
            BtnOuvrirInventaire.TabIndex = 1;
            BtnOuvrirInventaire.Text = "Ouvrir l'inventaire des fichiers temporaires";
            BtnOuvrirInventaire.UseVisualStyleBackColor = false;
            BtnOuvrirInventaire.Click += BtnOuvrirInventaire_Click;
            // 
            // FrmPrincipale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 118);
            Controls.Add(BtnOuvrirInventaire);
            Controls.Add(BtnGenerationInventaire);
            Name = "FrmPrincipale";
            Text = "Analyse des fichiers temporaires";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnGenerationInventaire;
        private Button BtnOuvrirInventaire;
    }
}
