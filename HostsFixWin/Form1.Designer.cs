namespace HostsFixWin {
    partial class Form1 {
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabExecucao = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabInstrucoes = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCopiar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabExecucao.SuspendLayout();
            this.tabInstrucoes.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabExecucao);
            this.tabControl1.Controls.Add(this.tabInstrucoes);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1076, 799);
            this.tabControl1.TabIndex = 7;
            // 
            // tabExecucao
            // 
            this.tabExecucao.Controls.Add(this.richTextBox1);
            this.tabExecucao.Location = new System.Drawing.Point(4, 46);
            this.tabExecucao.Name = "tabExecucao";
            this.tabExecucao.Padding = new System.Windows.Forms.Padding(3);
            this.tabExecucao.Size = new System.Drawing.Size(1068, 749);
            this.tabExecucao.TabIndex = 0;
            this.tabExecucao.Text = "Execução";
            this.tabExecucao.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(1062, 743);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // tabInstrucoes
            // 
            this.tabInstrucoes.Controls.Add(this.tableLayoutPanel1);
            this.tabInstrucoes.Location = new System.Drawing.Point(4, 46);
            this.tabInstrucoes.Name = "tabInstrucoes";
            this.tabInstrucoes.Padding = new System.Windows.Forms.Padding(3);
            this.tabInstrucoes.Size = new System.Drawing.Size(1068, 749);
            this.tabInstrucoes.TabIndex = 1;
            this.tabInstrucoes.Text = "Instruções";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1062, 743);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.buttonCopiar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonLast);
            this.panel1.Controls.Add(this.buttonNext);
            this.panel1.Controls.Add(this.buttonFirst);
            this.panel1.Controls.Add(this.buttonPrevious);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(6, 7);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 51);
            this.panel1.TabIndex = 6;
            // 
            // buttonCopiar
            // 
            this.buttonCopiar.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCopiar.Location = new System.Drawing.Point(858, 6);
            this.buttonCopiar.Name = "buttonCopiar";
            this.buttonCopiar.Size = new System.Drawing.Size(93, 40);
            this.buttonCopiar.TabIndex = 8;
            this.buttonCopiar.Text = "Copiar";
            this.buttonCopiar.UseVisualStyleBackColor = true;
            this.buttonCopiar.Click += new System.EventHandler(this.buttonCopiar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 38);
            this.label2.TabIndex = 7;
            this.label2.Text = "Serial:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(395, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(456, 43);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(103, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonLast
            // 
            this.buttonLast.Font = new System.Drawing.Font("Webdings", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonLast.Location = new System.Drawing.Point(253, 6);
            this.buttonLast.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(48, 40);
            this.buttonLast.TabIndex = 2;
            this.buttonLast.Text = ":";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Webdings", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonNext.Location = new System.Drawing.Point(205, 6);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(48, 40);
            this.buttonNext.TabIndex = 4;
            this.buttonNext.Text = "4";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Font = new System.Drawing.Font("Webdings", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonFirst.Location = new System.Drawing.Point(6, 6);
            this.buttonFirst.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(48, 40);
            this.buttonFirst.TabIndex = 1;
            this.buttonFirst.Text = "9";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Font = new System.Drawing.Font("Webdings", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonPrevious.Location = new System.Drawing.Point(54, 6);
            this.buttonPrevious.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(48, 40);
            this.buttonPrevious.TabIndex = 3;
            this.buttonPrevious.Text = "3";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1056, 672);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 799);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form1";
            this.Text = "Hosts Fix";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabExecucao.ResumeLayout(false);
            this.tabInstrucoes.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabExecucao;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabPage tabInstrucoes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonCopiar;
        private System.Windows.Forms.Label label2;
    }
}

