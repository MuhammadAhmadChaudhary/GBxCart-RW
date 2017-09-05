﻿namespace GBxCart_RW
{
    public partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.stopbutton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.readheaderbutton = new System.Windows.Forms.Button();
            this.saverambutton = new System.Windows.Forms.Button();
            this.writerambutton = new System.Windows.Forms.Button();
            this.readrombutton = new System.Windows.Forms.Button();
            this.openportbutton = new System.Windows.Forms.Button();
            this.baudtextBox = new System.Windows.Forms.TextBox();
            this.comPortTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.headerTextBox = new System.Windows.Forms.RichTextBox();
            this.closeportbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.readromlabel = new System.Windows.Forms.Label();
            this.saveramlabel = new System.Windows.Forms.Label();
            this.writeramlabel = new System.Windows.Forms.Label();
            this.modelabel = new System.Windows.Forms.Label();
            this.modeText = new System.Windows.Forms.Label();
            this.firmwareText = new System.Windows.Forms.Label();
            this.firmwarelabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsDefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetDefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.writerombutton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stopbutton
            // 
            this.stopbutton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.stopbutton.Location = new System.Drawing.Point(286, 220);
            this.stopbutton.Name = "stopbutton";
            this.stopbutton.Size = new System.Drawing.Size(75, 23);
            this.stopbutton.TabIndex = 23;
            this.stopbutton.Text = "Stop";
            this.stopbutton.UseVisualStyleBackColor = true;
            this.stopbutton.Click += new System.EventHandler(this.stopbutton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(5, 221);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(275, 21);
            this.progressBar1.TabIndex = 24;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // readheaderbutton
            // 
            this.readheaderbutton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.readheaderbutton.Location = new System.Drawing.Point(321, 105);
            this.readheaderbutton.Name = "readheaderbutton";
            this.readheaderbutton.Size = new System.Drawing.Size(90, 23);
            this.readheaderbutton.TabIndex = 30;
            this.readheaderbutton.Text = "Read Header";
            this.readheaderbutton.UseVisualStyleBackColor = true;
            this.readheaderbutton.Click += new System.EventHandler(this.readheaderbutton_Click);
            // 
            // saverambutton
            // 
            this.saverambutton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saverambutton.Location = new System.Drawing.Point(286, 162);
            this.saverambutton.Name = "saverambutton";
            this.saverambutton.Size = new System.Drawing.Size(75, 23);
            this.saverambutton.TabIndex = 31;
            this.saverambutton.Text = "Save RAM";
            this.saverambutton.UseVisualStyleBackColor = true;
            this.saverambutton.Click += new System.EventHandler(this.saverambutton_Click);
            // 
            // writerambutton
            // 
            this.writerambutton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.writerambutton.Location = new System.Drawing.Point(367, 162);
            this.writerambutton.Name = "writerambutton";
            this.writerambutton.Size = new System.Drawing.Size(75, 23);
            this.writerambutton.TabIndex = 32;
            this.writerambutton.Text = "Write RAM";
            this.writerambutton.UseVisualStyleBackColor = true;
            this.writerambutton.Click += new System.EventHandler(this.writerambutton_Click);
            // 
            // readrombutton
            // 
            this.readrombutton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.readrombutton.Location = new System.Drawing.Point(286, 134);
            this.readrombutton.Name = "readrombutton";
            this.readrombutton.Size = new System.Drawing.Size(75, 23);
            this.readrombutton.TabIndex = 33;
            this.readrombutton.Text = "Read ROM";
            this.readrombutton.UseVisualStyleBackColor = true;
            this.readrombutton.Click += new System.EventHandler(this.readrombutton_Click);
            // 
            // openportbutton
            // 
            this.openportbutton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.openportbutton.Location = new System.Drawing.Point(245, 31);
            this.openportbutton.Name = "openportbutton";
            this.openportbutton.Size = new System.Drawing.Size(70, 22);
            this.openportbutton.TabIndex = 42;
            this.openportbutton.Text = "Open Port";
            this.openportbutton.UseVisualStyleBackColor = true;
            this.openportbutton.Click += new System.EventHandler(this.openportbutton_Click);
            // 
            // baudtextBox
            // 
            this.baudtextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.baudtextBox.Location = new System.Drawing.Point(162, 31);
            this.baudtextBox.Name = "baudtextBox";
            this.baudtextBox.Size = new System.Drawing.Size(57, 23);
            this.baudtextBox.TabIndex = 43;
            this.baudtextBox.Text = "1000000";
            // 
            // comPortTextBox
            // 
            this.comPortTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.comPortTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comPortTextBox.Location = new System.Drawing.Point(69, 30);
            this.comPortTextBox.Name = "comPortTextBox";
            this.comPortTextBox.Size = new System.Drawing.Size(32, 23);
            this.comPortTextBox.TabIndex = 44;
            this.comPortTextBox.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 45;
            this.label6.Text = "COM Port";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(120, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 15);
            this.label7.TabIndex = 46;
            this.label7.Text = "Baud";
            // 
            // headerTextBox
            // 
            this.headerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerTextBox.Location = new System.Drawing.Point(5, 103);
            this.headerTextBox.Name = "headerTextBox";
            this.headerTextBox.Size = new System.Drawing.Size(275, 90);
            this.headerTextBox.TabIndex = 47;
            this.headerTextBox.Text = "";
            // 
            // closeportbutton
            // 
            this.closeportbutton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.closeportbutton.Location = new System.Drawing.Point(327, 31);
            this.closeportbutton.Name = "closeportbutton";
            this.closeportbutton.Size = new System.Drawing.Size(69, 23);
            this.closeportbutton.TabIndex = 48;
            this.closeportbutton.Text = "Close Port";
            this.closeportbutton.UseVisualStyleBackColor = true;
            this.closeportbutton.Click += new System.EventHandler(this.closeportbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 49;
            this.label1.Text = "Header";
            // 
            // readromlabel
            // 
            this.readromlabel.AutoSize = true;
            this.readromlabel.BackColor = System.Drawing.Color.Transparent;
            this.readromlabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.readromlabel.Location = new System.Drawing.Point(92, 202);
            this.readromlabel.Name = "readromlabel";
            this.readromlabel.Size = new System.Drawing.Size(89, 15);
            this.readromlabel.TabIndex = 51;
            this.readromlabel.Text = "Reading ROM...";
            this.readromlabel.Visible = false;
            // 
            // saveramlabel
            // 
            this.saveramlabel.AutoSize = true;
            this.saveramlabel.BackColor = System.Drawing.Color.Transparent;
            this.saveramlabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saveramlabel.Location = new System.Drawing.Point(92, 202);
            this.saveramlabel.Name = "saveramlabel";
            this.saveramlabel.Size = new System.Drawing.Size(80, 15);
            this.saveramlabel.TabIndex = 52;
            this.saveramlabel.Text = "Saving RAM...";
            this.saveramlabel.Visible = false;
            // 
            // writeramlabel
            // 
            this.writeramlabel.AutoSize = true;
            this.writeramlabel.BackColor = System.Drawing.Color.Transparent;
            this.writeramlabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.writeramlabel.Location = new System.Drawing.Point(92, 200);
            this.writeramlabel.Name = "writeramlabel";
            this.writeramlabel.Size = new System.Drawing.Size(84, 15);
            this.writeramlabel.TabIndex = 53;
            this.writeramlabel.Text = "Writing RAM...";
            this.writeramlabel.Visible = false;
            // 
            // modelabel
            // 
            this.modelabel.AutoSize = true;
            this.modelabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.modelabel.Location = new System.Drawing.Point(2, 56);
            this.modelabel.Name = "modelabel";
            this.modelabel.Size = new System.Drawing.Size(42, 15);
            this.modelabel.TabIndex = 67;
            this.modelabel.Text = "Mode:";
            this.modelabel.Click += new System.EventHandler(this.label11_Click);
            // 
            // modeText
            // 
            this.modeText.AutoSize = true;
            this.modeText.BackColor = System.Drawing.Color.Transparent;
            this.modeText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.modeText.Location = new System.Drawing.Point(44, 56);
            this.modeText.Name = "modeText";
            this.modeText.Size = new System.Drawing.Size(50, 15);
            this.modeText.TabIndex = 68;
            this.modeText.Text = "GB/GBC";
            this.modeText.Visible = false;
            // 
            // firmwareText
            // 
            this.firmwareText.AutoSize = true;
            this.firmwareText.BackColor = System.Drawing.Color.Transparent;
            this.firmwareText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.firmwareText.Location = new System.Drawing.Point(181, 56);
            this.firmwareText.Name = "firmwareText";
            this.firmwareText.Size = new System.Drawing.Size(20, 15);
            this.firmwareText.TabIndex = 70;
            this.firmwareText.Text = "R1";
            this.firmwareText.Visible = false;
            // 
            // firmwarelabel
            // 
            this.firmwarelabel.AutoSize = true;
            this.firmwarelabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.firmwarelabel.Location = new System.Drawing.Point(119, 56);
            this.firmwarelabel.Name = "firmwarelabel";
            this.firmwarelabel.Size = new System.Drawing.Size(63, 15);
            this.firmwarelabel.TabIndex = 69;
            this.firmwarelabel.Text = "Firmware:";
            this.firmwarelabel.Click += new System.EventHandler(this.label12_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(449, 24);
            this.menuStrip1.TabIndex = 71;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsDefaultToolStripMenuItem,
            this.resetDefaultToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.fileToolStripMenuItem.Text = "Cart Settings";
            // 
            // saveAsDefaultToolStripMenuItem
            // 
            this.saveAsDefaultToolStripMenuItem.Name = "saveAsDefaultToolStripMenuItem";
            this.saveAsDefaultToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.saveAsDefaultToolStripMenuItem.Text = "Specify Cart Info";
            this.saveAsDefaultToolStripMenuItem.Click += new System.EventHandler(this.saveAsDefaultToolStripMenuItem_Click);
            // 
            // resetDefaultToolStripMenuItem
            // 
            this.resetDefaultToolStripMenuItem.Name = "resetDefaultToolStripMenuItem";
            this.resetDefaultToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.resetDefaultToolStripMenuItem.Text = "Select ROM File to Write";
            this.resetDefaultToolStripMenuItem.Click += new System.EventHandler(this.resetDefaultToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.manualToolStripMenuItem.Text = "View Manual";
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.manualToolStripMenuItem_Click);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for Updates";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "*.gb";
            // 
            // writerombutton
            // 
            this.writerombutton.BackColor = System.Drawing.SystemColors.Control;
            this.writerombutton.Cursor = System.Windows.Forms.Cursors.Default;
            this.writerombutton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.writerombutton.ForeColor = System.Drawing.SystemColors.GrayText;
            this.writerombutton.Location = new System.Drawing.Point(367, 134);
            this.writerombutton.Name = "writerombutton";
            this.writerombutton.Size = new System.Drawing.Size(75, 23);
            this.writerombutton.TabIndex = 72;
            this.writerombutton.Text = "Write ROM";
            this.writerombutton.UseVisualStyleBackColor = true;
            this.writerombutton.Click += new System.EventHandler(this.writerombutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 254);
            this.Controls.Add(this.writerombutton);
            this.Controls.Add(this.firmwareText);
            this.Controls.Add(this.firmwarelabel);
            this.Controls.Add(this.modeText);
            this.Controls.Add(this.modelabel);
            this.Controls.Add(this.writeramlabel);
            this.Controls.Add(this.saveramlabel);
            this.Controls.Add(this.readromlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeportbutton);
            this.Controls.Add(this.headerTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comPortTextBox);
            this.Controls.Add(this.baudtextBox);
            this.Controls.Add(this.openportbutton);
            this.Controls.Add(this.readrombutton);
            this.Controls.Add(this.writerambutton);
            this.Controls.Add(this.saverambutton);
            this.Controls.Add(this.readheaderbutton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.stopbutton);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GBxCart RW v1.7 by insideGadgets";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button stopbutton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button readheaderbutton;
        private System.Windows.Forms.Button saverambutton;
        private System.Windows.Forms.Button writerambutton;
        private System.Windows.Forms.Button readrombutton;
        private System.Windows.Forms.Button openportbutton;
        private System.Windows.Forms.TextBox baudtextBox;
        private System.Windows.Forms.TextBox comPortTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox headerTextBox;
        private System.Windows.Forms.Button closeportbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label readromlabel;
        private System.Windows.Forms.Label saveramlabel;
        private System.Windows.Forms.Label writeramlabel;
        private System.Windows.Forms.Label modelabel;
        private System.Windows.Forms.Label modeText;
        private System.Windows.Forms.Label firmwareText;
        private System.Windows.Forms.Label firmwarelabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsDefaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetDefaultToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button writerombutton;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
    }
}
