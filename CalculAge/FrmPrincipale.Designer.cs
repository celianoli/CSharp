namespace CalculAge
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
            BtnPremierAlgo = new Button();
            LblPrenom = new Label();
            LblDatenaissance = new Label();
            TxtPrenom = new TextBox();
            TxtDateAutre = new TextBox();
            TxtDateNaissance = new TextBox();
            LblDateAutre = new Label();
            SuspendLayout();
            // 
            // BtnPremierAlgo
            // 
            BtnPremierAlgo.Location = new Point(12, 185);
            BtnPremierAlgo.Name = "BtnPremierAlgo";
            BtnPremierAlgo.Size = new Size(147, 29);
            BtnPremierAlgo.TabIndex = 0;
            BtnPremierAlgo.Text = "PremierAlgo";
            BtnPremierAlgo.UseVisualStyleBackColor = true;
            BtnPremierAlgo.Click += button1_Click;
            // 
            // LblPrenom
            // 
            LblPrenom.AutoSize = true;
            LblPrenom.Location = new Point(12, 35);
            LblPrenom.Name = "LblPrenom";
            LblPrenom.Size = new Size(60, 20);
            LblPrenom.TabIndex = 1;
            LblPrenom.Text = "Prénom";
            LblPrenom.Click += LblPrenom_Click;
            // 
            // LblDatenaissance
            // 
            LblDatenaissance.AutoSize = true;
            LblDatenaissance.Location = new Point(12, 74);
            LblDatenaissance.Name = "LblDatenaissance";
            LblDatenaissance.Size = new Size(129, 20);
            LblDatenaissance.TabIndex = 1;
            LblDatenaissance.Text = "Date de naissance";
            // 
            // TxtPrenom
            // 
            TxtPrenom.Location = new Point(92, 32);
            TxtPrenom.Name = "TxtPrenom";
            TxtPrenom.Size = new Size(125, 27);
            TxtPrenom.TabIndex = 2;
            // 
            // TxtDateAutre
            // 
            TxtDateAutre.Location = new Point(99, 118);
            TxtDateAutre.Name = "TxtDateAutre";
            TxtDateAutre.Size = new Size(125, 27);
            TxtDateAutre.TabIndex = 3;
            TxtDateAutre.TextChanged += TxtDateAutre_TextChanged;
            // 
            // TxtDateNaissance
            // 
            TxtDateNaissance.Location = new Point(147, 74);
            TxtDateNaissance.Name = "TxtDateNaissance";
            TxtDateNaissance.Size = new Size(125, 27);
            TxtDateNaissance.TabIndex = 2;
            // 
            // LblDateAutre
            // 
            LblDateAutre.AutoSize = true;
            LblDateAutre.Location = new Point(12, 121);
            LblDateAutre.Name = "LblDateAutre";
            LblDateAutre.Size = new Size(81, 20);
            LblDateAutre.TabIndex = 4;
            LblDateAutre.Text = "Date Autre";
            // 
            // FrmPrincipale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 545);
            Controls.Add(LblDateAutre);
            Controls.Add(TxtDateNaissance);
            Controls.Add(TxtDateAutre);
            Controls.Add(TxtPrenom);
            Controls.Add(LblDatenaissance);
            Controls.Add(LblPrenom);
            Controls.Add(BtnPremierAlgo);
            Name = "FrmPrincipale";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnPremierAlgo;
        private Label LblPrenom;
        private Label LblDatenaissance;

        private Label label3;
        private TextBox TxtPrenom;
        private TextBox TxtDateAutre;
        private TextBox TxtDateNaissance;
        private Label LblDateAutre;
    }
}
