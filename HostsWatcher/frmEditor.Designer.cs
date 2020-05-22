namespace HostsWatcher {
    partial class frmEditor {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.textBoxEditor = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRead = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.textBoxEditor);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(965, 423);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(965, 450);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // textBoxEditor
            // 
            this.textBoxEditor.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBoxEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxEditor.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEditor.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxEditor.Location = new System.Drawing.Point(0, 0);
            this.textBoxEditor.Multiline = true;
            this.textBoxEditor.Name = "textBoxEditor";
            this.textBoxEditor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxEditor.Size = new System.Drawing.Size(965, 423);
            this.textBoxEditor.TabIndex = 0;
            this.textBoxEditor.TextChanged += new System.EventHandler(this.textBoxEditor_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSave,
            this.toolStripButtonRead});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(191, 27);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.Image = global::HostsWatcher.Properties.Resources.Disquete;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(73, 24);
            this.toolStripButtonSave.Text = "Salvar";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripButtonRead
            // 
            this.toolStripButtonRead.Image = global::HostsWatcher.Properties.Resources.Revert_24;
            this.toolStripButtonRead.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRead.Name = "toolStripButtonRead";
            this.toolStripButtonRead.Size = new System.Drawing.Size(67, 24);
            this.toolStripButtonRead.Text = "Reler";
            this.toolStripButtonRead.Click += new System.EventHandler(this.toolStripButtonRead_Click);
            // 
            // frmEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "frmEditor";
            this.Text = "frmEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEditor_FormClosing);
            this.Load += new System.EventHandler(this.frmEditor_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TextBox textBoxEditor;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonRead;
    }
}