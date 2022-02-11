
namespace ContractorCRUDapp
{
    partial class AddEditWindow
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
            this.name_lb = new System.Windows.Forms.Label();
            this.nipNumber_lb = new System.Windows.Forms.Label();
            this.type_lb = new System.Windows.Forms.Label();
            this.details_lb = new System.Windows.Forms.Label();
            this.active_lb = new System.Windows.Forms.Label();
            this.title_lb = new System.Windows.Forms.Label();
            this.confirm_button = new System.Windows.Forms.Button();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.nipNumber_textBox = new System.Windows.Forms.TextBox();
            this.details_textBox = new System.Windows.Forms.TextBox();
            this.active_checkBox = new System.Windows.Forms.CheckBox();
            this.type_comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // name_lb
            // 
            this.name_lb.AutoSize = true;
            this.name_lb.Location = new System.Drawing.Point(56, 132);
            this.name_lb.Name = "name_lb";
            this.name_lb.Size = new System.Drawing.Size(112, 15);
            this.name_lb.TabIndex = 0;
            this.name_lb.Text = "Nazwa kontrahenta:";
            // 
            // nipNumber_lb
            // 
            this.nipNumber_lb.AutoSize = true;
            this.nipNumber_lb.Location = new System.Drawing.Point(56, 162);
            this.nipNumber_lb.Name = "nipNumber_lb";
            this.nipNumber_lb.Size = new System.Drawing.Size(26, 15);
            this.nipNumber_lb.TabIndex = 1;
            this.nipNumber_lb.Text = "NIP";
            // 
            // type_lb
            // 
            this.type_lb.AutoSize = true;
            this.type_lb.Location = new System.Drawing.Point(56, 195);
            this.type_lb.Name = "type_lb";
            this.type_lb.Size = new System.Drawing.Size(96, 15);
            this.type_lb.TabIndex = 2;
            this.type_lb.Text = "Typ kontrahenta:";
            // 
            // details_lb
            // 
            this.details_lb.AutoSize = true;
            this.details_lb.Location = new System.Drawing.Point(56, 233);
            this.details_lb.Name = "details_lb";
            this.details_lb.Size = new System.Drawing.Size(65, 15);
            this.details_lb.TabIndex = 3;
            this.details_lb.Text = "Opis firmy:";
            // 
            // active_lb
            // 
            this.active_lb.AutoSize = true;
            this.active_lb.Location = new System.Drawing.Point(56, 328);
            this.active_lb.Name = "active_lb";
            this.active_lb.Size = new System.Drawing.Size(112, 15);
            this.active_lb.TabIndex = 4;
            this.active_lb.Text = "Kontrakent aktywny";
            // 
            // title_lb
            // 
            this.title_lb.AutoSize = true;
            this.title_lb.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title_lb.Location = new System.Drawing.Point(56, 19);
            this.title_lb.Name = "title_lb";
            this.title_lb.Size = new System.Drawing.Size(238, 25);
            this.title_lb.TabIndex = 5;
            this.title_lb.Text = "Dodaj / edytuj kontrahenta";
            // 
            // confirm_button
            // 
            this.confirm_button.Location = new System.Drawing.Point(713, 415);
            this.confirm_button.Name = "confirm_button";
            this.confirm_button.Size = new System.Drawing.Size(75, 23);
            this.confirm_button.TabIndex = 6;
            this.confirm_button.Text = "Zatwierdź";
            this.confirm_button.UseVisualStyleBackColor = true;
            this.confirm_button.Click += new System.EventHandler(this.confirm_button_Click);
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(185, 124);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(269, 23);
            this.name_textBox.TabIndex = 7;
            // 
            // nipNumber_textBox
            // 
            this.nipNumber_textBox.Location = new System.Drawing.Point(185, 159);
            this.nipNumber_textBox.Name = "nipNumber_textBox";
            this.nipNumber_textBox.Size = new System.Drawing.Size(269, 23);
            this.nipNumber_textBox.TabIndex = 8;
            // 
            // details_textBox
            // 
            this.details_textBox.Location = new System.Drawing.Point(185, 233);
            this.details_textBox.Multiline = true;
            this.details_textBox.Name = "details_textBox";
            this.details_textBox.Size = new System.Drawing.Size(269, 75);
            this.details_textBox.TabIndex = 9;
            // 
            // active_checkBox
            // 
            this.active_checkBox.AutoSize = true;
            this.active_checkBox.Location = new System.Drawing.Point(185, 328);
            this.active_checkBox.Name = "active_checkBox";
            this.active_checkBox.Size = new System.Drawing.Size(15, 14);
            this.active_checkBox.TabIndex = 10;
            this.active_checkBox.UseVisualStyleBackColor = true;
            // 
            // type_comboBox
            // 
            this.type_comboBox.FormattingEnabled = true;
            this.type_comboBox.Location = new System.Drawing.Point(185, 195);
            this.type_comboBox.Name = "type_comboBox";
            this.type_comboBox.Size = new System.Drawing.Size(269, 23);
            this.type_comboBox.TabIndex = 11;
            // 
            // AddEditWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.type_comboBox);
            this.Controls.Add(this.active_checkBox);
            this.Controls.Add(this.details_textBox);
            this.Controls.Add(this.nipNumber_textBox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.confirm_button);
            this.Controls.Add(this.title_lb);
            this.Controls.Add(this.active_lb);
            this.Controls.Add(this.details_lb);
            this.Controls.Add(this.type_lb);
            this.Controls.Add(this.nipNumber_lb);
            this.Controls.Add(this.name_lb);
            this.Name = "AddEditWindow";
            this.Text = "AddEditWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_lb;
        private System.Windows.Forms.Label nipNumber_lb;
        private System.Windows.Forms.Label type_lb;
        private System.Windows.Forms.Label details_lb;
        private System.Windows.Forms.Label active_lb;
        private System.Windows.Forms.Label title_lb;
        private System.Windows.Forms.Button confirm_button;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox nipNumber_textBox;
        private System.Windows.Forms.TextBox details_textBox;
        private System.Windows.Forms.CheckBox active_checkBox;
        private System.Windows.Forms.ComboBox type_comboBox;
    }
}