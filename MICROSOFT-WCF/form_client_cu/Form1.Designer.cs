﻿namespace form_client_cu
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.click_validate = new System.Windows.Forms.Button();
            this.token = new System.Windows.Forms.Label();
            this.connect = new System.Windows.Forms.Label();
            this.file = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Email";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(105, 175);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(237, 22);
            this.password.TabIndex = 7;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(105, 130);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(237, 22);
            this.email.TabIndex = 6;
            // 
            // click_validate
            // 
            this.click_validate.Location = new System.Drawing.Point(105, 203);
            this.click_validate.Name = "click_validate";
            this.click_validate.Size = new System.Drawing.Size(237, 35);
            this.click_validate.TabIndex = 5;
            this.click_validate.Text = "Valider";
            this.click_validate.UseVisualStyleBackColor = true;
            this.click_validate.Click += new System.EventHandler(this.click_validate_Click);
            // 
            // token
            // 
            this.token.AutoSize = true;
            this.token.Location = new System.Drawing.Point(12, 21);
            this.token.Name = "token";
            this.token.Size = new System.Drawing.Size(52, 17);
            this.token.TabIndex = 10;
            this.token.Text = "Token:";
            // 
            // connect
            // 
            this.connect.AutoSize = true;
            this.connect.Location = new System.Drawing.Point(155, 241);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(0, 17);
            this.connect.TabIndex = 13;
            // 
            // file
            // 
            this.file.FormattingEnabled = true;
            this.file.ItemHeight = 16;
            this.file.Location = new System.Drawing.Point(105, 288);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(237, 68);
            this.file.TabIndex = 14;
            this.file.SelectedIndexChanged += new System.EventHandler(this.file_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 15;
            this.button1.Text = "Envoyer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 383);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.file);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.token);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Controls.Add(this.click_validate);
            this.Name = "Form1";
            this.Text = "Interface Client 2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button click_validate;
        private System.Windows.Forms.Label token;
        private System.Windows.Forms.Label connect;
        private System.Windows.Forms.ListBox file;
        private System.Windows.Forms.Button button1;
    }
}

