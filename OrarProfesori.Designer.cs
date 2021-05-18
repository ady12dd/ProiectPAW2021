
namespace Elaborare_orarii_profesori
{
    partial class OrarProfesoriForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrarProfesoriForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnAdProf = new System.Windows.Forms.Button();
            this.tbSex = new System.Windows.Forms.TextBox();
            this.tbVarsta = new System.Windows.Forms.TextBox();
            this.tbGrad = new System.Windows.Forms.TextBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvProfesori = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editeazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afiseazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editeazaProfesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.serializareBinaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializeazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializeazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.lvOrar = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.tbDragAndDrop = new System.Windows.Forms.TextBox();
            this.btIncarcareOrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnModif);
            this.groupBox1.Controls.Add(this.btnAdProf);
            this.groupBox1.Controls.Add(this.tbSex);
            this.groupBox1.Controls.Add(this.tbVarsta);
            this.groupBox1.Controls.Add(this.tbGrad);
            this.groupBox1.Controls.Add(this.tbNume);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(33, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adaugare Profesor";
            // 
            // btnModif
            // 
            this.btnModif.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModif.Location = new System.Drawing.Point(592, 96);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(135, 23);
            this.btnModif.TabIndex = 9;
            this.btnModif.Text = "Modificare";
            this.btnModif.UseVisualStyleBackColor = false;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnAdProf
            // 
            this.btnAdProf.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdProf.Location = new System.Drawing.Point(422, 96);
            this.btnAdProf.Name = "btnAdProf";
            this.btnAdProf.Size = new System.Drawing.Size(164, 23);
            this.btnAdProf.TabIndex = 8;
            this.btnAdProf.Text = "&AdaugareProfesor";
            this.btnAdProf.UseVisualStyleBackColor = false;
            this.btnAdProf.Click += new System.EventHandler(this.btnAdProf_Click);
            // 
            // tbSex
            // 
            this.tbSex.Location = new System.Drawing.Point(124, 96);
            this.tbSex.Name = "tbSex";
            this.tbSex.Size = new System.Drawing.Size(175, 20);
            this.tbSex.TabIndex = 7;
            this.tbSex.Validating += new System.ComponentModel.CancelEventHandler(this.tbSex_Validating);
            this.tbSex.Validated += new System.EventHandler(this.tbSex_Validated);
            // 
            // tbVarsta
            // 
            this.tbVarsta.Location = new System.Drawing.Point(124, 70);
            this.tbVarsta.Name = "tbVarsta";
            this.tbVarsta.Size = new System.Drawing.Size(175, 20);
            this.tbVarsta.TabIndex = 6;
            this.tbVarsta.Validating += new System.ComponentModel.CancelEventHandler(this.tbVarsta_Validating);
            this.tbVarsta.Validated += new System.EventHandler(this.tbVarsta_Validated);
            // 
            // tbGrad
            // 
            this.tbGrad.Location = new System.Drawing.Point(124, 45);
            this.tbGrad.Name = "tbGrad";
            this.tbGrad.Size = new System.Drawing.Size(175, 20);
            this.tbGrad.TabIndex = 5;
            this.tbGrad.Validating += new System.ComponentModel.CancelEventHandler(this.tbGrad_Validating);
            this.tbGrad.Validated += new System.EventHandler(this.tbGrad_Validated);
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(124, 19);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(175, 20);
            this.tbNume.TabIndex = 4;
            this.tbNume.Validating += new System.ComponentModel.CancelEventHandler(this.tbNume_Validating);
            this.tbNume.Validated += new System.EventHandler(this.tbNume_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sex :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Varsta :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume Profesor :";
            // 
            // lvProfesori
            // 
            this.lvProfesori.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvProfesori.BackColor = System.Drawing.Color.Snow;
            this.lvProfesori.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lvProfesori.BackgroundImage")));
            this.lvProfesori.BackgroundImageTiled = true;
            this.lvProfesori.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvProfesori.ContextMenuStrip = this.contextMenuStrip1;
            this.lvProfesori.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lvProfesori.ForeColor = System.Drawing.SystemColors.Info;
            this.lvProfesori.FullRowSelect = true;
            this.lvProfesori.GridLines = true;
            this.lvProfesori.HideSelection = false;
            this.lvProfesori.Location = new System.Drawing.Point(33, 252);
            this.lvProfesori.Name = "lvProfesori";
            this.lvProfesori.Size = new System.Drawing.Size(743, 270);
            this.lvProfesori.TabIndex = 1;
            this.lvProfesori.UseCompatibleStateImageBehavior = false;
            this.lvProfesori.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nume";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Grad";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Varsta";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Sex";
            this.columnHeader4.Width = 100;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editeazaToolStripMenuItem,
            this.stergeToolStripMenuItem,
            this.afiseazaToolStripMenuItem,
            this.editeazaProfesorToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(162, 92);
            // 
            // editeazaToolStripMenuItem
            // 
            this.editeazaToolStripMenuItem.Name = "editeazaToolStripMenuItem";
            this.editeazaToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.editeazaToolStripMenuItem.Text = "AdaugareOrar";
            this.editeazaToolStripMenuItem.Click += new System.EventHandler(this.editeazaToolStripMenuItem_Click);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.stergeToolStripMenuItem.Text = "Sterge";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem_Click);
            // 
            // afiseazaToolStripMenuItem
            // 
            this.afiseazaToolStripMenuItem.Name = "afiseazaToolStripMenuItem";
            this.afiseazaToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.afiseazaToolStripMenuItem.Text = "Afiseaza";
            this.afiseazaToolStripMenuItem.Click += new System.EventHandler(this.afiseazaToolStripMenuItem_Click);
            // 
            // editeazaProfesorToolStripMenuItem
            // 
            this.editeazaProfesorToolStripMenuItem.Name = "editeazaProfesorToolStripMenuItem";
            this.editeazaProfesorToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.editeazaProfesorToolStripMenuItem.Text = "EditeazaProfesor";
            this.editeazaProfesorToolStripMenuItem.Click += new System.EventHandler(this.editeazaProfesorToolStripMenuItem_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierToolStripMenuItem,
            this.serializareBinaraToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.printToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1171, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fisierToolStripMenuItem
            // 
            this.fisierToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.fisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit});
            this.fisierToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            this.fisierToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.fisierToolStripMenuItem.Text = "Aplicatie";
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 22);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // serializareBinaraToolStripMenuItem
            // 
            this.serializareBinaraToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.serializareBinaraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializeazaToolStripMenuItem,
            this.deserializeazaToolStripMenuItem});
            this.serializareBinaraToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serializareBinaraToolStripMenuItem.Name = "serializareBinaraToolStripMenuItem";
            this.serializareBinaraToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.serializareBinaraToolStripMenuItem.Text = "Serializare Binara";
            // 
            // serializeazaToolStripMenuItem
            // 
            this.serializeazaToolStripMenuItem.Name = "serializeazaToolStripMenuItem";
            this.serializeazaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.serializeazaToolStripMenuItem.Text = "Serializeaza";
            this.serializeazaToolStripMenuItem.Click += new System.EventHandler(this.serializeazaToolStripMenuItem_Click);
            // 
            // deserializeazaToolStripMenuItem
            // 
            this.deserializeazaToolStripMenuItem.Name = "deserializeazaToolStripMenuItem";
            this.deserializeazaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.deserializeazaToolStripMenuItem.Text = "Deserializeaza";
            this.deserializeazaToolStripMenuItem.Click += new System.EventHandler(this.deserializeazaToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem1});
            this.exportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.exportToolStripMenuItem.Text = "Salvare fisier";
            // 
            // exportToolStripMenuItem1
            // 
            this.exportToolStripMenuItem1.Name = "exportToolStripMenuItem1";
            this.exportToolStripMenuItem1.Size = new System.Drawing.Size(111, 22);
            this.exportToolStripMenuItem1.Text = "Export";
            this.exportToolStripMenuItem1.Click += new System.EventHandler(this.exportToolStripMenuItem1_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.printToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPrint,
            this.btnPrintPreview});
            this.printToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.printToolStripMenuItem.Text = "Imprimare";
            // 
            // btnPrint
            // 
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(152, 22);
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(152, 22);
            this.btnPrintPreview.Text = "Previzualizare";
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // lvOrar
            // 
            this.lvOrar.BackColor = System.Drawing.Color.Snow;
            this.lvOrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lvOrar.BackgroundImage")));
            this.lvOrar.BackgroundImageTiled = true;
            this.lvOrar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvOrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvOrar.ForeColor = System.Drawing.SystemColors.Info;
            this.lvOrar.FullRowSelect = true;
            this.lvOrar.GridLines = true;
            this.lvOrar.HideSelection = false;
            this.lvOrar.Location = new System.Drawing.Point(783, 252);
            this.lvOrar.Name = "lvOrar";
            this.lvOrar.Size = new System.Drawing.Size(376, 270);
            this.lvOrar.TabIndex = 3;
            this.lvOrar.UseCompatibleStateImageBehavior = false;
            this.lvOrar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Sala";
            this.columnHeader5.Width = 79;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Zi saptamana";
            this.columnHeader6.Width = 94;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Disciplina";
            this.columnHeader7.Width = 73;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "IntervalOrar";
            this.columnHeader8.Width = 86;
            // 
            // printDocument
            // 
            this.printDocument.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument_BeginPrint);
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(33, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Copiaza Profesor";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbDragAndDrop
            // 
            this.tbDragAndDrop.AllowDrop = true;
            this.tbDragAndDrop.Location = new System.Drawing.Point(33, 195);
            this.tbDragAndDrop.Name = "tbDragAndDrop";
            this.tbDragAndDrop.Size = new System.Drawing.Size(743, 20);
            this.tbDragAndDrop.TabIndex = 5;
            this.tbDragAndDrop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbDragAndDrop_MouseDown);
            // 
            // btIncarcareOrar
            // 
            this.btIncarcareOrar.BackColor = System.Drawing.Color.Lime;
            this.btIncarcareOrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIncarcareOrar.Location = new System.Drawing.Point(797, 193);
            this.btIncarcareOrar.Name = "btIncarcareOrar";
            this.btIncarcareOrar.Size = new System.Drawing.Size(202, 23);
            this.btIncarcareOrar.TabIndex = 6;
            this.btIncarcareOrar.Text = "IncarcareProfesorPremiu";
            this.btIncarcareOrar.UseVisualStyleBackColor = false;
            this.btIncarcareOrar.Click += new System.EventHandler(this.btIncarcareOrar_Click);
            // 
            // OrarProfesoriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1171, 568);
            this.Controls.Add(this.btIncarcareOrar);
            this.Controls.Add(this.tbDragAndDrop);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvOrar);
            this.Controls.Add(this.lvProfesori);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OrarProfesoriForm";
            this.Text = "OrarProfesori";
            this.Load += new System.EventHandler(this.OrarProfesoriForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdProf;
        private System.Windows.Forms.TextBox tbSex;
        private System.Windows.Forms.TextBox tbVarsta;
        private System.Windows.Forms.TextBox tbGrad;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvProfesori;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.ToolStripMenuItem serializareBinaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializeazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializeazaToolStripMenuItem;
        private System.Windows.Forms.ListView lvOrar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editeazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ToolStripMenuItem afiseazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editeazaProfesorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem1;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnPrint;
        private System.Windows.Forms.ToolStripMenuItem btnPrintPreview;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btIncarcareOrar;
        private System.Windows.Forms.TextBox tbDragAndDrop;
    }
}