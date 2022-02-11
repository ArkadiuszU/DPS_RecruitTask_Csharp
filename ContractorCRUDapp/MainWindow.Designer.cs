
namespace ContractorCRUDapp
{
    partial class MainWindow
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
            this.title_lb = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.table_panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // title_lb
            // 
            this.title_lb.AutoSize = true;
            this.title_lb.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title_lb.Location = new System.Drawing.Point(16, 19);
            this.title_lb.Name = "title_lb";
            this.title_lb.Size = new System.Drawing.Size(216, 32);
            this.title_lb.TabIndex = 0;
            this.title_lb.Text = "Lista kontrahentów";
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(16, 56);
            this.add_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(86, 31);
            this.add_button.TabIndex = 1;
            this.add_button.Text = "Dodaj";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(109, 56);
            this.edit_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(86, 31);
            this.edit_button.TabIndex = 2;
            this.edit_button.Text = "Edytuj";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // table_panel
            // 
            this.table_panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.table_panel.Location = new System.Drawing.Point(152, 185);
            this.table_panel.Name = "table_panel";
            this.table_panel.Size = new System.Drawing.Size(621, 235);
            this.table_panel.TabIndex = 3;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.table_panel);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.title_lb);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_lb;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Panel table_panel;
    }
}

