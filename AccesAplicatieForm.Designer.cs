﻿
namespace Elaborare_orarii_profesori
{
    partial class FormLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLog));
            this.lbUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAcces = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUserNameLog = new System.Windows.Forms.TextBox();
            this.tbPasswordLog = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbUserName.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbUserName.Location = new System.Drawing.Point(42, 39);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(156, 26);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "Nume utilizator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(45, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Parola Utilizator";
            // 
            // btnAcces
            // 
            this.btnAcces.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAcces.Location = new System.Drawing.Point(48, 143);
            this.btnAcces.Name = "btnAcces";
            this.btnAcces.Size = new System.Drawing.Size(75, 23);
            this.btnAcces.TabIndex = 2;
            this.btnAcces.Text = "Acces";
            this.btnAcces.UseVisualStyleBackColor = false;
            this.btnAcces.Click += new System.EventHandler(this.btnAcces_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(66, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Daca nu aveti cont, il puteti crea ";
            // 
            // tbUserNameLog
            // 
            this.tbUserNameLog.Location = new System.Drawing.Point(204, 42);
            this.tbUserNameLog.Name = "tbUserNameLog";
            this.tbUserNameLog.Size = new System.Drawing.Size(134, 20);
            this.tbUserNameLog.TabIndex = 4;
            // 
            // tbPasswordLog
            // 
            this.tbPasswordLog.Location = new System.Drawing.Point(204, 74);
            this.tbPasswordLog.Name = "tbPasswordLog";
            this.tbPasswordLog.Size = new System.Drawing.Size(134, 20);
            this.tbPasswordLog.TabIndex = 5;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.linkLabel1.Location = new System.Drawing.Point(236, 431);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(23, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "aici";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Copyright@ Neatu Adrian 2021";
            // 
            // FormLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(609, 471);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.tbPasswordLog);
            this.Controls.Add(this.tbUserNameLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAcces);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormLog";
            this.Text = "Pagina de inregistrare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAcces;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUserNameLog;
        private System.Windows.Forms.TextBox tbPasswordLog;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
    }
}

