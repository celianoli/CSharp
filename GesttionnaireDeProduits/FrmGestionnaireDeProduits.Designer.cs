namespace GesttionnaireDeProduits
{
    partial class FrmGestionnaireDeProduits
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
            BtnAjouterPrdouit = new Button();
            BtnEditProduit = new Button();
            LblListeProduits = new Label();
            LsbListeProduits = new ListBox();
            SuspendLayout();
            // 
            // BtnAjouterPrdouit
            // 
            BtnAjouterPrdouit.FlatStyle = FlatStyle.Flat;
            BtnAjouterPrdouit.Location = new Point(168, 189);
            BtnAjouterPrdouit.Name = "BtnAjouterPrdouit";
            BtnAjouterPrdouit.Size = new Size(192, 29);
            BtnAjouterPrdouit.TabIndex = 0;
            BtnAjouterPrdouit.Text = "Ajouter un produit";
            BtnAjouterPrdouit.UseVisualStyleBackColor = true;
            BtnAjouterPrdouit.Click += BtnAjouterPrdouit_Click;
            // 
            // BtnEditProduit
            // 
            BtnEditProduit.FlatStyle = FlatStyle.Flat;
            BtnEditProduit.Location = new Point(168, 224);
            BtnEditProduit.Name = "BtnEditProduit";
            BtnEditProduit.Size = new Size(192, 29);
            BtnEditProduit.TabIndex = 1;
            BtnEditProduit.Text = "Editer un produit";
            BtnEditProduit.UseVisualStyleBackColor = true;
            BtnEditProduit.Click += BtnEditProduit_Click;
            // 
            // LblListeProduits
            // 
            LblListeProduits.AutoSize = true;
            LblListeProduits.FlatStyle = FlatStyle.Flat;
            LblListeProduits.Location = new Point(12, 9);
            LblListeProduits.Name = "LblListeProduits";
            LblListeProduits.Size = new Size(132, 20);
            LblListeProduits.TabIndex = 2;
            LblListeProduits.Text = "Liste des produits :";
            // 
            // LsbListeProduits
            // 
            LsbListeProduits.FormattingEnabled = true;
            LsbListeProduits.Location = new Point(12, 49);
            LsbListeProduits.Name = "LsbListeProduits";
            LsbListeProduits.Size = new Size(150, 204);
            LsbListeProduits.TabIndex = 3;
            // 
            // FrmGestionnaireDeProduits
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 302);
            Controls.Add(LsbListeProduits);
            Controls.Add(LblListeProduits);
            Controls.Add(BtnEditProduit);
            Controls.Add(BtnAjouterPrdouit);
            Name = "FrmGestionnaireDeProduits";
            Text = "Gestionnaire de produits";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAjouterPrdouit;
        private Button BtnEditProduit;
        private Label LblListeProduits;
        private ListBox LsbListeProduits;
    }
}
