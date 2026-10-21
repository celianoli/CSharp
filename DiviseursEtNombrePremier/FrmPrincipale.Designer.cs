namespace DiviseursEtNombrePremier
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
            LblSaisieNombre = new Label();
            LblDiviseurTrouves = new Label();
            LblDiviseurTrouve = new Label();
            LblNomprePremier = new Label();
            BtnRechercheDiviseur = new Button();
            TxtNombreEntier = new TextBox();
            Rboui = new RadioButton();
            Rbnon = new RadioButton();
            SuspendLayout();
            // 
            // LblSaisieNombre
            // 
            LblSaisieNombre.AutoSize = true;
            LblSaisieNombre.Location = new Point(12, 24);
            LblSaisieNombre.Name = "LblSaisieNombre";
            LblSaisieNombre.Size = new Size(254, 20);
            LblSaisieNombre.TabIndex = 0;
            LblSaisieNombre.Text = "Saisissez un nombre entier et positif :";
            // 
            // LblDiviseurTrouves
            // 
            LblDiviseurTrouves.AutoSize = true;
            LblDiviseurTrouves.Location = new Point(12, 95);
            LblDiviseurTrouves.Name = "LblDiviseurTrouves";
            LblDiviseurTrouves.Size = new Size(127, 20);
            LblDiviseurTrouves.TabIndex = 1;
            LblDiviseurTrouves.Text = "Diviseurs trouvés :";
            // 
            // LblDiviseurTrouve
            // 
            LblDiviseurTrouve.AutoSize = true;
            LblDiviseurTrouve.Location = new Point(145, 95);
            LblDiviseurTrouve.Name = "LblDiviseurTrouve";
            LblDiviseurTrouve.Size = new Size(36, 20);
            LblDiviseurTrouve.TabIndex = 2;
            LblDiviseurTrouve.Text = "N/A";
            // 
            // LblNomprePremier
            // 
            LblNomprePremier.AutoSize = true;
            LblNomprePremier.Location = new Point(12, 127);
            LblNomprePremier.Name = "LblNomprePremier";
            LblNomprePremier.Size = new Size(166, 20);
            LblNomprePremier.TabIndex = 3;
            LblNomprePremier.Text = "Le nombre est premier :";
            // 
            // BtnRechercheDiviseur
            // 
            BtnRechercheDiviseur.BackColor = SystemColors.ControlDark;
            BtnRechercheDiviseur.Location = new Point(12, 54);
            BtnRechercheDiviseur.Name = "BtnRechercheDiviseur";
            BtnRechercheDiviseur.Size = new Size(309, 29);
            BtnRechercheDiviseur.TabIndex = 4;
            BtnRechercheDiviseur.Text = "Rechercher les diviseurs ";
            BtnRechercheDiviseur.UseVisualStyleBackColor = false;
            BtnRechercheDiviseur.Click += BtnRechercheDiviseur_Click;
            // 
            // TxtNombreEntier
            // 
            TxtNombreEntier.Location = new Point(272, 21);
            TxtNombreEntier.Name = "TxtNombreEntier";
            TxtNombreEntier.Size = new Size(49, 27);
            TxtNombreEntier.TabIndex = 5;
            // 
            // Rboui
            // 
            Rboui.AutoSize = true;
            Rboui.Enabled = false;
            Rboui.Location = new Point(192, 127);
            Rboui.Name = "Rboui";
            Rboui.Size = new Size(53, 24);
            Rboui.TabIndex = 6;
            Rboui.TabStop = true;
            Rboui.Text = "Oui";
            Rboui.UseVisualStyleBackColor = true;
            Rboui.CheckedChanged += RbVraiFaux_CheckedChanged;
            // 
            // Rbnon
            // 
            Rbnon.AutoSize = true;
            Rbnon.Enabled = false;
            Rbnon.Location = new Point(251, 125);
            Rbnon.Name = "Rbnon";
            Rbnon.Size = new Size(58, 24);
            Rbnon.TabIndex = 7;
            Rbnon.TabStop = true;
            Rbnon.Text = "Non";
            Rbnon.UseVisualStyleBackColor = true;
            Rbnon.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // FrmPrincipale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 168);
            Controls.Add(Rbnon);
            Controls.Add(Rboui);
            Controls.Add(TxtNombreEntier);
            Controls.Add(BtnRechercheDiviseur);
            Controls.Add(LblNomprePremier);
            Controls.Add(LblDiviseurTrouve);
            Controls.Add(LblDiviseurTrouves);
            Controls.Add(LblSaisieNombre);
            Name = "FrmPrincipale";
            Text = "Diviseur & Nombres premiers";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblSaisieNombre;
        private Label LblDiviseurTrouves;
        private Label LblDiviseurTrouve;
        private Label LblNomprePremier;
        private Button BtnRechercheDiviseur;
        private TextBox TxtNombreEntier;
        private RadioButton Rboui;
        private RadioButton Rbnon;
    }
}
