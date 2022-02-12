
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
            this.labelDetails = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelActive = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(21, 21);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(50, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "label1";
            // 
            // labelNip
            // 
            this.labelNip.AutoSize = true;
            this.labelNip.Location = new System.Drawing.Point(77, 21);
            this.labelNip.Name = "labelNip";
            this.labelNip.Size = new System.Drawing.Size(50, 20);
            this.labelNip.TabIndex = 1;
            this.labelNip.Text = "label1";
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.Location = new System.Drawing.Point(133, 21);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(50, 20);
            this.labelDetails.TabIndex = 2;
            this.labelDetails.Text = "label1";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(189, 21);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(50, 20);
            this.labelType.TabIndex = 3;
            this.labelType.Text = "label1";
            // 
            // labelActive
            // 
            this.labelActive.AutoSize = true;
            this.labelActive.Location = new System.Drawing.Point(245, 21);
            this.labelActive.Name = "labelActive";
            this.labelActive.Size = new System.Drawing.Size(50, 20);
            this.labelActive.TabIndex = 4;
            this.labelActive.Text = "label1";
            // 
            // ContractorUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.labelActive);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelDetails);
            this.Controls.Add(this.labelNip);
            this.Controls.Add(this.labelName);
            this.Name = "ContractorUserControl";
            this.Size = new System.Drawing.Size(497, 53);
            this.Click += new System.EventHandler(this.ContractorUserControl_Click);
            this.MouseEnter += new System.EventHandler(this.ContractorUserControl_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ContractorUserControl_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelNip;
        private System.Windows.Forms.Label labelDetails;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelActive;
    }
}
