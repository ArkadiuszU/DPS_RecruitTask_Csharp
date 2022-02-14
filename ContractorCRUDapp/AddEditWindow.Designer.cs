
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
            this.error1_lb = new System.Windows.Forms.Label();
            this.error2_lb = new System.Windows.Forms.Label();
            this.error3_lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name_lb
            // 
            this.name_lb.AutoSize = true;
            this.name_lb.Location = new System.Drawing.Point(65, 115);
            this.name_lb.Name = "name_lb";
            this.name_lb.Size = new System.Drawing.Size(140, 20);
            this.name_lb.TabIndex = 0;
            this.name_lb.Text = "Nazwa kontrahenta:";
            // 
            // nipNumber_lb
            // 
            this.nipNumber_lb.AutoSize = true;
            this.nipNumber_lb.Location = new System.Drawing.Point(65, 185);
            this.nipNumber_lb.Name = "nipNumber_lb";
            this.nipNumber_lb.Size = new System.Drawing.Size(35, 20);
            this.nipNumber_lb.TabIndex = 1;
            this.nipNumber_lb.Text = "NIP:";
            // 
            // type_lb
            // 
            this.type_lb.AutoSize = true;
            this.type_lb.Location = new System.Drawing.Point(64, 260);
            this.type_lb.Name = "type_lb";
            this.type_lb.Size = new System.Drawing.Size(118, 20);
            this.type_lb.TabIndex = 2;
            this.type_lb.Text = "Typ kontrahenta:";
            // 
            // details_lb
            // 
            this.details_lb.AutoSize = true;
            this.details_lb.Location = new System.Drawing.Point(65, 311);
            this.details_lb.Name = "details_lb";
            this.details_lb.Size = new System.Drawing.Size(80, 20);
            this.details_lb.TabIndex = 3;
            this.details_lb.Text = "Opis firmy:";
            // 
            // active_lb
            // 
            this.active_lb.AutoSize = true;
            this.active_lb.Location = new System.Drawing.Point(64, 457);
            this.active_lb.Name = "active_lb";
            this.active_lb.Size = new System.Drawing.Size(138, 20);
            this.active_lb.TabIndex = 4;
            this.active_lb.Text = "Kontrakent aktywny";
            // 
            // title_lb
            // 
            this.title_lb.AutoSize = true;
            this.title_lb.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title_lb.Location = new System.Drawing.Point(64, 25);
            this.title_lb.Name = "title_lb";
            this.title_lb.Size = new System.Drawing.Size(303, 32);
            this.title_lb.TabIndex = 5;
            this.title_lb.Text = "Dodaj / edytuj kontrahenta";
            // 
            // confirm_button
            // 
            this.confirm_button.Location = new System.Drawing.Point(654, 534);
            this.confirm_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.confirm_button.Name = "confirm_button";
            this.confirm_button.Size = new System.Drawing.Size(86, 31);
            this.confirm_button.TabIndex = 6;
            this.confirm_button.Text = "Zatwierdź";
            this.confirm_button.UseVisualStyleBackColor = true;
            this.confirm_button.Click += new System.EventHandler(this.confirm_button_Click);
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(211, 108);
            this.name_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.name_textBox.MaxLength = 50;
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(340, 27);
            this.name_textBox.TabIndex = 7;
            this.name_textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.name_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            this.name_textBox.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // nipNumber_textBox
            // 
            this.nipNumber_textBox.Location = new System.Drawing.Point(211, 185);
            this.nipNumber_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nipNumber_textBox.MaxLength = 10;
            this.nipNumber_textBox.Name = "nipNumber_textBox";
            this.nipNumber_textBox.Size = new System.Drawing.Size(340, 27);
            this.nipNumber_textBox.TabIndex = 8;
            this.nipNumber_textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.nipNumber_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            this.nipNumber_textBox.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // details_textBox
            // 
            this.details_textBox.Location = new System.Drawing.Point(211, 311);
            this.details_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.details_textBox.MaxLength = 500;
            this.details_textBox.Multiline = true;
            this.details_textBox.Name = "details_textBox";
            this.details_textBox.Size = new System.Drawing.Size(340, 99);
            this.details_textBox.TabIndex = 9;
            this.details_textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.details_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            this.details_textBox.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // active_checkBox
            // 
            this.active_checkBox.AutoSize = true;
            this.active_checkBox.Location = new System.Drawing.Point(211, 457);
            this.active_checkBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.active_checkBox.Name = "active_checkBox";
            this.active_checkBox.Size = new System.Drawing.Size(15, 14);
            this.active_checkBox.TabIndex = 10;
            this.active_checkBox.UseVisualStyleBackColor = true;
            // 
            // type_comboBox
            // 
            this.type_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_comboBox.FormattingEnabled = true;
            this.type_comboBox.Location = new System.Drawing.Point(211, 257);
            this.type_comboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.type_comboBox.Name = "type_comboBox";
            this.type_comboBox.Size = new System.Drawing.Size(340, 28);
            this.type_comboBox.TabIndex = 11;
            // 
            // error1_lb
            // 
            this.error1_lb.AutoSize = true;
            this.error1_lb.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.error1_lb.ForeColor = System.Drawing.Color.Red;
            this.error1_lb.Location = new System.Drawing.Point(211, 139);
            this.error1_lb.Name = "error1_lb";
            this.error1_lb.Size = new System.Drawing.Size(401, 17);
            this.error1_lb.TabIndex = 12;
            this.error1_lb.Text = "pole nie moze pozostac puste i może mieć maksymalnie 50 znaków";
            this.error1_lb.Visible = false;
            // 
            // error2_lb
            // 
            this.error2_lb.AutoSize = true;
            this.error2_lb.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.error2_lb.ForeColor = System.Drawing.Color.Red;
            this.error2_lb.Location = new System.Drawing.Point(211, 216);
            this.error2_lb.Name = "error2_lb";
            this.error2_lb.Size = new System.Drawing.Size(222, 17);
            this.error2_lb.TabIndex = 13;
            this.error2_lb.Text = "pole musi mieć dokładnie 10 znaków";
            this.error2_lb.Visible = false;
            // 
            // error3_lb
            // 
            this.error3_lb.AutoSize = true;
            this.error3_lb.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.error3_lb.ForeColor = System.Drawing.Color.Red;
            this.error3_lb.Location = new System.Drawing.Point(211, 413);
            this.error3_lb.Name = "error3_lb";
            this.error3_lb.Size = new System.Drawing.Size(408, 17);
            this.error3_lb.TabIndex = 14;
            this.error3_lb.Text = "pole nie moze pozostac puste i może mieć maksymalnie 500 znaków";
            this.error3_lb.Visible = false;
            // 
            // AddEditWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 584);
            this.Controls.Add(this.error3_lb);
            this.Controls.Add(this.error2_lb);
            this.Controls.Add(this.error1_lb);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddEditWindow";
            this.Text = "AddEditWindow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddEditWindow_FormClosed);
            this.Load += new System.EventHandler(this.AddEditWindow_Load);
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
        private System.Windows.Forms.Label error1_lb;
        private System.Windows.Forms.Label error2_lb;
        private System.Windows.Forms.Label error3_lb;
    }
}