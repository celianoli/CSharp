namespace GesttionnaireDeProduits
{
    partial class FrmProduits
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnEnregistrer = new Button();
            BtnAnnuler = new Button();
            LblNom = new Label();
            LblPrix = new Label();
            TxtNom = new TextBox();
            TxtPrix = new TextBox();
            LblDevise = new Label();
            SuspendLayout();
            // 
            // BtnEnregistrer
            // 
            BtnEnregistrer.FlatStyle = FlatStyle.Flat;
            BtnEnregistrer.Location = new Point(12, 109);
            BtnEnregistrer.Name = "BtnEnregistrer";
            BtnEnregistrer.Size = new Size(94, 29);
            BtnEnregistrer.TabIndex = 0;
            BtnEnregistrer.Text = "Enregistrer ";
            BtnEnregistrer.UseVisualStyleBackColor = true;
            BtnEnregistrer.Click += BtnEnregistrer_Click;
            // 
            // BtnAnnuler
            // 
            BtnAnnuler.FlatStyle = FlatStyle.Flat;
            BtnAnnuler.Location = new Point(112, 109);
            BtnAnnuler.Name = "BtnAnnuler";
            BtnAnnuler.Size = new Size(94, 29);
            BtnAnnuler.TabIndex = 0;
            BtnAnnuler.Text = "Annuler";
            BtnAnnuler.UseVisualStyleBackColor = true;
            BtnAnnuler.Click += BtnAnnuler_Click;
            // 
            // LblNom
            // 
            LblNom.AutoSize = true;
            LblNom.Location = new Point(12, 26);
            LblNom.Name = "LblNom";
            LblNom.Size = new Size(49, 20);
            LblNom.TabIndex = 1;
            LblNom.Text = "Nom :";
            // 
            // LblPrix
            // 
            LblPrix.AutoSize = true;
            LblPrix.Location = new Point(11, 61);
            LblPrix.Name = "LblPrix";
            LblPrix.Size = new Size(40, 20);
            LblPrix.TabIndex = 2;
            LblPrix.Text = "Prix :";
            // 
            // TxtNom
            // 
            TxtNom.Location = new Point(67, 26);
            TxtNom.Name = "TxtNom";
            TxtNom.Size = new Size(125, 27);
            TxtNom.TabIndex = 3;
            // 
            // TxtPrix
            // 
            TxtPrix.Location = new Point(67, 61);
            TxtPrix.Name = "TxtPrix";
            TxtPrix.Size = new Size(125, 27);
            TxtPrix.TabIndex = 4;
            // 
            // LblDevise
            // 
            LblDevise.AutoSize = true;
            LblDevise.Location = new Point(191, 68);
            LblDevise.Name = "LblDevise";
            LblDevise.Size = new Size(17, 20);
            LblDevise.TabIndex = 5;
            LblDevise.Text = "€";
            // 
            // FrmProduits
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(251, 165);
            Controls.Add(LblDevise);
            Controls.Add(TxtPrix);
            Controls.Add(TxtNom);
            Controls.Add(LblPrix);
            Controls.Add(LblNom);
            Controls.Add(BtnAnnuler);
            Controls.Add(BtnEnregistrer);
            Name = "FrmProduits";
            Text = "Edition de produit ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnEnregistrer;
        private Button BtnAnnuler;
        private Label LblNom;
        private Label LblPrix;
        private TextBox TxtNom;
        private TextBox TxtPrix;
        private Label LblDevise;
    }
}