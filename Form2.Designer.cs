
namespace MiniProjeto
{
    partial class Form2
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
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_age = new System.Windows.Forms.TextBox();
            this.tb_secretID = new System.Windows.Forms.TextBox();
            this.lb_powerlist = new System.Windows.Forms.ListBox();
            this.Btn_editSP = new System.Windows.Forms.Button();
            this.Btn_addSP = new System.Windows.Forms.Button();
            this.Btn_deleteSP = new System.Windows.Forms.Button();
            this.tb_newpower = new System.Windows.Forms.TextBox();
            this.label_superpower = new System.Windows.Forms.Label();
            this.label_superpowers = new System.Windows.Forms.Label();
            this.Btn_back = new System.Windows.Forms.Button();
            this.Btn_save2 = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.label_age = new System.Windows.Forms.Label();
            this.label_secretid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(12, 27);
            this.tb_name.Name = "tb_name";
            this.tb_name.PlaceholderText = "Name";
            this.tb_name.Size = new System.Drawing.Size(100, 23);
            this.tb_name.TabIndex = 0;
            // 
            // tb_age
            // 
            this.tb_age.Location = new System.Drawing.Point(12, 75);
            this.tb_age.Name = "tb_age";
            this.tb_age.PlaceholderText = "Age";
            this.tb_age.Size = new System.Drawing.Size(100, 23);
            this.tb_age.TabIndex = 1;
            // 
            // tb_secretID
            // 
            this.tb_secretID.Location = new System.Drawing.Point(12, 123);
            this.tb_secretID.Name = "tb_secretID";
            this.tb_secretID.PlaceholderText = "Secret Id";
            this.tb_secretID.Size = new System.Drawing.Size(100, 23);
            this.tb_secretID.TabIndex = 2;
            // 
            // lb_powerlist
            // 
            this.lb_powerlist.FormattingEnabled = true;
            this.lb_powerlist.ItemHeight = 15;
            this.lb_powerlist.Location = new System.Drawing.Point(12, 223);
            this.lb_powerlist.Name = "lb_powerlist";
            this.lb_powerlist.Size = new System.Drawing.Size(100, 169);
            this.lb_powerlist.TabIndex = 3;
            this.lb_powerlist.SelectedIndexChanged += new System.EventHandler(this.lb_powerlist_SelectedIndexChanged);
            // 
            // Btn_editSP
            // 
            this.Btn_editSP.Location = new System.Drawing.Point(118, 341);
            this.Btn_editSP.Name = "Btn_editSP";
            this.Btn_editSP.Size = new System.Drawing.Size(75, 23);
            this.Btn_editSP.TabIndex = 4;
            this.Btn_editSP.Text = "Edit";
            this.Btn_editSP.UseVisualStyleBackColor = true;
            this.Btn_editSP.Click += new System.EventHandler(this.Btn_editSP_Click);
            // 
            // Btn_addSP
            // 
            this.Btn_addSP.Location = new System.Drawing.Point(118, 270);
            this.Btn_addSP.Name = "Btn_addSP";
            this.Btn_addSP.Size = new System.Drawing.Size(75, 23);
            this.Btn_addSP.TabIndex = 5;
            this.Btn_addSP.Text = "Add";
            this.Btn_addSP.UseVisualStyleBackColor = true;
            this.Btn_addSP.Click += new System.EventHandler(this.Btn_addSP_Click);
            // 
            // Btn_deleteSP
            // 
            this.Btn_deleteSP.Location = new System.Drawing.Point(118, 370);
            this.Btn_deleteSP.Name = "Btn_deleteSP";
            this.Btn_deleteSP.Size = new System.Drawing.Size(75, 23);
            this.Btn_deleteSP.TabIndex = 6;
            this.Btn_deleteSP.Text = "Delete";
            this.Btn_deleteSP.UseVisualStyleBackColor = true;
            this.Btn_deleteSP.Click += new System.EventHandler(this.Btn_deleteSP_Click);
            // 
            // tb_newpower
            // 
            this.tb_newpower.Location = new System.Drawing.Point(118, 241);
            this.tb_newpower.Name = "tb_newpower";
            this.tb_newpower.PlaceholderText = "Super Power";
            this.tb_newpower.Size = new System.Drawing.Size(75, 23);
            this.tb_newpower.TabIndex = 7;
            // 
            // label_superpower
            // 
            this.label_superpower.AutoSize = true;
            this.label_superpower.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_superpower.Location = new System.Drawing.Point(118, 223);
            this.label_superpower.Name = "label_superpower";
            this.label_superpower.Size = new System.Drawing.Size(72, 15);
            this.label_superpower.TabIndex = 8;
            this.label_superpower.Text = "New Power";
            // 
            // label_superpowers
            // 
            this.label_superpowers.AutoSize = true;
            this.label_superpowers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_superpowers.Location = new System.Drawing.Point(12, 205);
            this.label_superpowers.Name = "label_superpowers";
            this.label_superpowers.Size = new System.Drawing.Size(84, 15);
            this.label_superpowers.TabIndex = 9;
            this.label_superpowers.Text = "Super Powers";
            // 
            // Btn_back
            // 
            this.Btn_back.Location = new System.Drawing.Point(12, 415);
            this.Btn_back.Name = "Btn_back";
            this.Btn_back.Size = new System.Drawing.Size(75, 23);
            this.Btn_back.TabIndex = 10;
            this.Btn_back.Text = "Back";
            this.Btn_back.UseVisualStyleBackColor = true;
            this.Btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // Btn_save2
            // 
            this.Btn_save2.Location = new System.Drawing.Point(118, 415);
            this.Btn_save2.Name = "Btn_save2";
            this.Btn_save2.Size = new System.Drawing.Size(75, 23);
            this.Btn_save2.TabIndex = 11;
            this.Btn_save2.Text = "Save";
            this.Btn_save2.UseVisualStyleBackColor = true;
            this.Btn_save2.Click += new System.EventHandler(this.Btn_save2_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_name.Location = new System.Drawing.Point(12, 9);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(40, 15);
            this.label_name.TabIndex = 12;
            this.label_name.Text = "Name";
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_age.Location = new System.Drawing.Point(13, 57);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(29, 15);
            this.label_age.TabIndex = 13;
            this.label_age.Text = "Age";
            // 
            // label_secretid
            // 
            this.label_secretid.AutoSize = true;
            this.label_secretid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_secretid.Location = new System.Drawing.Point(13, 105);
            this.label_secretid.Name = "label_secretid";
            this.label_secretid.Size = new System.Drawing.Size(58, 15);
            this.label_secretid.TabIndex = 14;
            this.label_secretid.Text = "Secret Id";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_secretid);
            this.Controls.Add(this.label_age);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.Btn_save2);
            this.Controls.Add(this.Btn_back);
            this.Controls.Add(this.label_superpowers);
            this.Controls.Add(this.label_superpower);
            this.Controls.Add(this.tb_newpower);
            this.Controls.Add(this.Btn_deleteSP);
            this.Controls.Add(this.Btn_addSP);
            this.Controls.Add(this.Btn_editSP);
            this.Controls.Add(this.lb_powerlist);
            this.Controls.Add(this.tb_secretID);
            this.Controls.Add(this.tb_age);
            this.Controls.Add(this.tb_name);
            this.Name = "Form2";
            this.Text = "Mini Projeto";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_age;
        private System.Windows.Forms.TextBox tb_secretID;
        private System.Windows.Forms.ListBox lb_powerlist;
        private System.Windows.Forms.Button Btn_editSP;
        private System.Windows.Forms.Button Btn_back;
        private System.Windows.Forms.Button Btn_addSP;
        private System.Windows.Forms.Button Btn_deleteSP;
        private System.Windows.Forms.TextBox tb_newpower;
        private System.Windows.Forms.Label label_superpower;
        private System.Windows.Forms.Label label_superpowers;
        private System.Windows.Forms.Button Btn_save2;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_age;
        private System.Windows.Forms.Label label_secretid;
    }
}