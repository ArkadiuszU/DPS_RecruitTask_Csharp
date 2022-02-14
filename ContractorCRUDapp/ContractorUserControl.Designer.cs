
namespace ContractorCRUDapp
{
    partial class ContractorUserControl
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.labelNip = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IsActivepanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(76, 20);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(417, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "012345678901234567890123456789012345678901234567890";
            this.labelName.Click += new System.EventHandler(this.ContractorUserControl_Click);
            this.labelName.MouseEnter += new System.EventHandler(this.ContractorUserControl_MouseEnter);
            // 
            // labelNip
            // 
            this.labelNip.AutoSize = true;
            this.labelNip.Location = new System.Drawing.Point(544, 20);
            this.labelNip.Name = "labelNip";
            this.labelNip.Size = new System.Drawing.Size(89, 20);
            this.labelNip.TabIndex = 1;
            this.labelNip.Text = "1234567890";
            this.labelNip.Click += new System.EventHandler(this.ContractorUserControl_Click);
            this.labelNip.MouseEnter += new System.EventHandler(this.ContractorUserControl_MouseEnter);
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(687, 20);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(50, 20);
            this.labelType.TabIndex = 3;
            this.labelType.Text = "label1";
            this.labelType.Click += new System.EventHandler(this.ContractorUserControl_Click);
            this.labelType.MouseEnter += new System.EventHandler(this.ContractorUserControl_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nazwa:";
            this.label1.Click += new System.EventHandler(this.ContractorUserControl_Click);
            this.label1.MouseEnter += new System.EventHandler(this.ContractorUserControl_MouseEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(499, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "NIP:";
            this.label2.Click += new System.EventHandler(this.ContractorUserControl_Click);
            this.label2.MouseEnter += new System.EventHandler(this.ContractorUserControl_MouseEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(639, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Typ: ";
            this.label3.Click += new System.EventHandler(this.ContractorUserControl_Click);
            this.label3.MouseEnter += new System.EventHandler(this.ContractorUserControl_MouseEnter);
            // 
            // IsActivepanel
            // 
            this.IsActivepanel.Location = new System.Drawing.Point(832, 11);
            this.IsActivepanel.Name = "IsActivepanel";
            this.IsActivepanel.Size = new System.Drawing.Size(28, 29);
            this.IsActivepanel.TabIndex = 8;
            this.IsActivepanel.Click += new System.EventHandler(this.ContractorUserControl_Click);
            this.IsActivepanel.MouseEnter += new System.EventHandler(this.ContractorUserControl_MouseEnter);
            // 
            // ContractorUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.IsActivepanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelNip);
            this.Controls.Add(this.labelName);
            this.Name = "ContractorUserControl";
            this.Size = new System.Drawing.Size(873, 53);
            this.Click += new System.EventHandler(this.ContractorUserControl_Click);
            this.MouseEnter += new System.EventHandler(this.ContractorUserControl_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ContractorUserControl_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelNip;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel IsActivepanel;
    }
}
