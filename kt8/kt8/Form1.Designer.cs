﻿
namespace kt8
{
    partial class Form1
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
            this.UserName = new System.Windows.Forms.Label();
            this.textboxusername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxmatkhau = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(66, 75);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(100, 17);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "tên đăng nhập";
            // 
            // textboxusername
            // 
            this.textboxusername.Location = new System.Drawing.Point(250, 70);
            this.textboxusername.Name = "textboxusername";
            this.textboxusername.Size = new System.Drawing.Size(275, 22);
            this.textboxusername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mật khẩu";
            // 
            // textboxmatkhau
            // 
            this.textboxmatkhau.Location = new System.Drawing.Point(250, 131);
            this.textboxmatkhau.Name = "textboxmatkhau";
            this.textboxmatkhau.Size = new System.Drawing.Size(275, 22);
            this.textboxmatkhau.TabIndex = 3;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(290, 232);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(155, 23);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "login";
            this.btnlogin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 536);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.textboxmatkhau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxusername);
            this.Controls.Add(this.UserName);
            this.Name = "Form1";
            this.Text = "UserName";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.TextBox textboxusername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxmatkhau;
        private System.Windows.Forms.Button btnlogin;
    }
}

