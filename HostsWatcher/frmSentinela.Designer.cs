namespace HostsWatcher {
    partial class frmSentinela {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSentinela));
            this.RTB = new System.Windows.Forms.RichTextBox();
            this.FSW_Hosts = new System.IO.FileSystemWatcher();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemShow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOnOff = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxOnOff = new System.Windows.Forms.CheckBox();
            this.buttonCheckNow = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonEditLog = new System.Windows.Forms.Button();
            this.pictureBoxMode = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.FSW_License = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.FSW_Hosts)).BeginInit();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FSW_License)).BeginInit();
            this.SuspendLayout();
            // 
            // RTB
            // 
            this.RTB.BackColor = System.Drawing.SystemColors.ControlText;
            this.RTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTB.Location = new System.Drawing.Point(6, 98);
            this.RTB.Name = "RTB";
            this.RTB.Size = new System.Drawing.Size(768, 343);
            this.RTB.TabIndex = 0;
            this.RTB.Text = "";
            // 
            // FSW_Hosts
            // 
            this.FSW_Hosts.EnableRaisingEvents = true;
            this.FSW_Hosts.SynchronizingObject = this;
            this.FSW_Hosts.Changed += new System.IO.FileSystemEventHandler(this.OnChangedHosts);
            this.FSW_Hosts.Created += new System.IO.FileSystemEventHandler(this.OnChangedHosts);
            this.FSW_Hosts.Deleted += new System.IO.FileSystemEventHandler(this.OnDeletedLHosts);
            this.FSW_Hosts.Renamed += new System.IO.RenamedEventHandler(this.OnRenamedHosts);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipTitle = "Sentinela";
            this.notifyIcon.ContextMenuStrip = this.menu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Sentinela";
            this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemShow,
            this.toolStripMenuItemOnOff,
            this.toolStripMenuItemExit});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(138, 82);
            // 
            // toolStripMenuItemShow
            // 
            this.toolStripMenuItemShow.Image = global::HostsWatcher.Properties.Resources.Program_icon32;
            this.toolStripMenuItemShow.Name = "toolStripMenuItemShow";
            this.toolStripMenuItemShow.Size = new System.Drawing.Size(137, 26);
            this.toolStripMenuItemShow.Text = "Exibir";
            this.toolStripMenuItemShow.Click += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // toolStripMenuItemOnOff
            // 
            this.toolStripMenuItemOnOff.Image = global::HostsWatcher.Properties.Resources.switch_off_icon32;
            this.toolStripMenuItemOnOff.Name = "toolStripMenuItemOnOff";
            this.toolStripMenuItemOnOff.Size = new System.Drawing.Size(137, 26);
            this.toolStripMenuItemOnOff.Text = "Desligar";
            this.toolStripMenuItemOnOff.Click += new System.EventHandler(this.toolStripMenuItemOnOff_Click);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Image = global::HostsWatcher.Properties.Resources.exit_icon32;
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(137, 26);
            this.toolStripMenuItemExit.Text = "Sair";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // checkBoxOnOff
            // 
            this.checkBoxOnOff.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxOnOff.AutoSize = true;
            this.checkBoxOnOff.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxOnOff.BackgroundImage = global::HostsWatcher.Properties.Resources.Black_background;
            this.checkBoxOnOff.Checked = true;
            this.checkBoxOnOff.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOnOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxOnOff.FlatAppearance.BorderSize = 0;
            this.checkBoxOnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxOnOff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOnOff.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxOnOff.Image = global::HostsWatcher.Properties.Resources.switch_on_icon64;
            this.checkBoxOnOff.Location = new System.Drawing.Point(91, 4);
            this.checkBoxOnOff.Name = "checkBoxOnOff";
            this.checkBoxOnOff.Size = new System.Drawing.Size(70, 70);
            this.checkBoxOnOff.TabIndex = 1;
            this.toolTip.SetToolTip(this.checkBoxOnOff, "Liga/Desliga monitor");
            this.checkBoxOnOff.UseVisualStyleBackColor = false;
            this.checkBoxOnOff.CheckedChanged += new System.EventHandler(this.checkBoxOnOff_CheckedChanged);
            // 
            // buttonCheckNow
            // 
            this.buttonCheckNow.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonCheckNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckNow.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckNow.Image = global::HostsWatcher.Properties.Resources.Police_icon_24;
            this.buttonCheckNow.Location = new System.Drawing.Point(224, 22);
            this.buttonCheckNow.Name = "buttonCheckNow";
            this.buttonCheckNow.Size = new System.Drawing.Size(178, 52);
            this.buttonCheckNow.TabIndex = 2;
            this.buttonCheckNow.Text = "Testar";
            this.buttonCheckNow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCheckNow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.buttonCheckNow, "Testar manualmente");
            this.buttonCheckNow.UseVisualStyleBackColor = false;
            this.buttonCheckNow.Click += new System.EventHandler(this.buttonCheckNow_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.LightBlue;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Image = global::HostsWatcher.Properties.Resources.hosts_icon32;
            this.buttonEdit.Location = new System.Drawing.Point(592, 22);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(178, 52);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Editar \'hosts\'";
            this.buttonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.buttonEdit, "Ver/editar arquivo hosts");
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonEditLog
            // 
            this.buttonEditLog.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonEditLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditLog.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditLog.Image = global::HostsWatcher.Properties.Resources.log_icon32;
            this.buttonEditLog.Location = new System.Drawing.Point(408, 22);
            this.buttonEditLog.Name = "buttonEditLog";
            this.buttonEditLog.Size = new System.Drawing.Size(178, 52);
            this.buttonEditLog.TabIndex = 4;
            this.buttonEditLog.Text = "Editar Log";
            this.buttonEditLog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEditLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.buttonEditLog, "Ver/editar arquivo de Log");
            this.buttonEditLog.UseVisualStyleBackColor = false;
            this.buttonEditLog.Click += new System.EventHandler(this.buttonEditLog_Click);
            // 
            // pictureBoxMode
            // 
            this.pictureBoxMode.Image = global::HostsWatcher.Properties.Resources.Administrator_icon96;
            this.pictureBoxMode.Location = new System.Drawing.Point(7, 22);
            this.pictureBoxMode.Name = "pictureBoxMode";
            this.pictureBoxMode.Size = new System.Drawing.Size(61, 52);
            this.pictureBoxMode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMode.TabIndex = 5;
            this.pictureBoxMode.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBoxMode, "Administrador: poderá fazer alterações");
            // 
            // FSW_License
            // 
            this.FSW_License.EnableRaisingEvents = true;
            this.FSW_License.SynchronizingObject = this;
            this.FSW_License.Changed += new System.IO.FileSystemEventHandler(this.OnChangedLicense);
            this.FSW_License.Created += new System.IO.FileSystemEventHandler(this.OnChangedLicense);
            this.FSW_License.Deleted += new System.IO.FileSystemEventHandler(this.OnDeletedLicense);
            this.FSW_License.Renamed += new System.IO.RenamedEventHandler(this.OnRenamedLicense);
            // 
            // frmSentinela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.pictureBoxMode);
            this.Controls.Add(this.buttonEditLog);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonCheckNow);
            this.Controls.Add(this.checkBoxOnOff);
            this.Controls.Add(this.RTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSentinela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sentinela";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Shown += new System.EventHandler(this.Form_Shown);
            this.Resize += new System.EventHandler(this.Form_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.FSW_Hosts)).EndInit();
            this.menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FSW_License)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTB;
        private System.IO.FileSystemWatcher FSW_Hosts;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShow;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.CheckBox checkBoxOnOff;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOnOff;
        private System.Windows.Forms.Button buttonCheckNow;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonEditLog;
        private System.Windows.Forms.PictureBox pictureBoxMode;
        private System.Windows.Forms.ToolTip toolTip;
        private System.IO.FileSystemWatcher FSW_License;
    }
}

