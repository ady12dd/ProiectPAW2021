
namespace Elaborare_orarii_profesori
{
    partial class FormCreareCont
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreareCont));
            this.btnSalvareInFisier = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUserNameCreate = new System.Windows.Forms.TextBox();
            this.tbUSerNamePass = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvareInFisier
            // 
            this.btnSalvareInFisier.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSalvareInFisier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalvareInFisier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvareInFisier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalvareInFisier.Location = new System.Drawing.Point(30, 376);
            this.btnSalvareInFisier.Name = "btnSalvareInFisier";
            this.btnSalvareInFisier.Size = new System.Drawing.Size(106, 23);
            this.btnSalvareInFisier.TabIndex = 0;
            this.btnSalvareInFisier.Text = "Salvare Utilizator";
            this.btnSalvareInFisier.UseVisualStyleBackColor = false;
            this.btnSalvareInFisier.Click += new System.EventHandler(this.btnSalvareInBazaDate_Click);
            this.btnSalvareInFisier.MouseLeave += new System.EventHandler(this.btnSalvareInFisier_MouseLeave);
            this.btnSalvareInFisier.MouseHover += new System.EventHandler(this.btnSalvareInFisier_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NumeUtilizator :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parola Utilizator :";
            // 
            // tbUserNameCreate
            // 
            this.tbUserNameCreate.Location = new System.Drawing.Point(147, 42);
            this.tbUserNameCreate.Name = "tbUserNameCreate";
            this.tbUserNameCreate.Size = new System.Drawing.Size(100, 20);
            this.tbUserNameCreate.TabIndex = 3;
            this.tbUserNameCreate.MouseLeave += new System.EventHandler(this.tbUserNameCreate_MouseLeave);
            this.tbUserNameCreate.MouseHover += new System.EventHandler(this.tbUserNameCreate_MouseHover);
            // 
            // tbUSerNamePass
            // 
            this.tbUSerNamePass.Location = new System.Drawing.Point(147, 69);
            this.tbUSerNamePass.Name = "tbUSerNamePass";
            this.tbUSerNamePass.Size = new System.Drawing.Size(100, 20);
            this.tbUSerNamePass.TabIndex = 4;
            this.tbUSerNamePass.MouseLeave += new System.EventHandler(this.tbUSerNamePass_MouseLeave);
            this.tbUSerNamePass.MouseHover += new System.EventHandler(this.tbUSerNamePass_MouseHover);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(499, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // FormCreareCont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(499, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tbUSerNamePass);
            this.Controls.Add(this.tbUserNameCreate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvareInFisier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormCreareCont";
            this.Text = "CreareCont";
            this.Load += new System.EventHandler(this.FormCreareCont_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvareInFisier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUserNameCreate;
        private System.Windows.Forms.TextBox tbUSerNamePass;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}