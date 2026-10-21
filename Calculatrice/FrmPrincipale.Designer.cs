namespace Calculatrice
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
            CmbOperateur = new ComboBox();
            TxtPremierTerme = new TextBox();
            TxtSecondTerme = new TextBox();
            LblPremierTerme = new Label();
            LblOperateur = new Label();
            LblSecondTerme = new Label();
            BtnCalculer = new Button();
            CbArrondirResultat = new CheckBox();
            SuspendLayout();
            // 
            // CmbOperateur
            // 
            CmbOperateur.FormattingEnabled = true;
            CmbOperateur.Location = new Point(105, 61);
            CmbOperateur.Name = "CmbOperateur";
            CmbOperateur.Size = new Size(70, 28);
            CmbOperateur.TabIndex = 0;
            // 
            // TxtPremierTerme
            // 
            TxtPremierTerme.Location = new Point(144, 24);
            TxtPremierTerme.Name = "TxtPremierTerme";
            TxtPremierTerme.Size = new Size(125, 27);
            TxtPremierTerme.TabIndex = 1;
            // 
            // TxtSecondTerme
            // 
            TxtSecondTerme.Location = new Point(130, 100);
            TxtSecondTerme.Name = "TxtSecondTerme";
            TxtSecondTerme.Size = new Size(125, 27);
            TxtSecondTerme.TabIndex = 2;
            // 
            // LblPremierTerme
            // 
            LblPremierTerme.AutoSize = true;
            LblPremierTerme.Location = new Point(12, 31);
            LblPremierTerme.Name = "LblPremierTerme";
            LblPremierTerme.Size = new Size(114, 20);
            LblPremierTerme.TabIndex = 3;
            LblPremierTerme.Text = "Premier terme : ";
            // 
            // LblOperateur
            // 
            LblOperateur.AutoSize = true;
            LblOperateur.Location = new Point(12, 64);
            LblOperateur.Name = "LblOperateur";
            LblOperateur.Size = new Size(87, 20);
            LblOperateur.TabIndex = 4;
            LblOperateur.Text = "Opérateur : ";
            LblOperateur.Click += LblOperateur_Click;
            // 
            // LblSecondTerme
            // 
            LblSecondTerme.AutoSize = true;
            LblSecondTerme.Location = new Point(12, 103);
            LblSecondTerme.Name = "LblSecondTerme";
            LblSecondTerme.Size = new Size(112, 20);
            LblSecondTerme.TabIndex = 5;
            LblSecondTerme.Text = "Second terme : ";
            LblSecondTerme.Click += LblSecondTerme_Click;
            // 
            // BtnCalculer
            // 
            BtnCalculer.BackColor = SystemColors.ControlDark;
            BtnCalculer.Location = new Point(311, 103);
            BtnCalculer.Name = "BtnCalculer";
            BtnCalculer.Size = new Size(94, 29);
            BtnCalculer.TabIndex = 6;
            BtnCalculer.Text = "Calculer !";
            BtnCalculer.UseVisualStyleBackColor = false;
            BtnCalculer.Click += BtnCalculer_Click;
            // 
            // CbArrondirResultat
            // 
            CbArrondirResultat.AutoSize = true;
            CbArrondirResultat.Location = new Point(424, 106);
            CbArrondirResultat.Name = "CbArrondirResultat";
            CbArrondirResultat.Size = new Size(157, 24);
            CbArrondirResultat.TabIndex = 7;
            CbArrondirResultat.Text = "Arrondir le résulat :";
            CbArrondirResultat.UseVisualStyleBackColor = true;
            CbArrondirResultat.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // FrmPrincipale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 297);
            Controls.Add(CbArrondirResultat);
            Controls.Add(BtnCalculer);
            Controls.Add(LblSecondTerme);
            Controls.Add(LblOperateur);
            Controls.Add(LblPremierTerme);
            Controls.Add(TxtSecondTerme);
            Controls.Add(TxtPremierTerme);
            Controls.Add(CmbOperateur);
            Name = "FrmPrincipale";
            Text = "Calculatrice";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private ComboBox CmbOperateur;
        private TextBox TxtPremierTerme;
        private TextBox TxtSecondTerme;
        private Label LblPremierTerme;
        private Label LblOperateur;
        private Label LblSecondTerme;
        private Button BtnCalculer;
        private CheckBox CbArrondirResultat;
    }
}
