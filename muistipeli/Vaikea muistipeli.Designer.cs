namespace muistipeli
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.GameTime = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnDiff = new System.Windows.Forms.Button();
            this.Vaikeustaso = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblMatch = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // GameTime
            // 
            this.GameTime.Interval = 1000;
            this.GameTime.Tick += new System.EventHandler(this.TimerEvent);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(22, 76);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Maximum = 30;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progressBar1.Size = new System.Drawing.Size(75, 19);
            this.progressBar1.TabIndex = 41;
            this.progressBar1.Value = 30;
            // 
            // btnDiff
            // 
            this.btnDiff.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDiff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiff.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDiff.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiff.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDiff.Location = new System.Drawing.Point(316, 379);
            this.btnDiff.Name = "btnDiff";
            this.btnDiff.Size = new System.Drawing.Size(125, 54);
            this.btnDiff.TabIndex = 40;
            this.btnDiff.Text = "Valitse vaikeustaso";
            this.btnDiff.UseVisualStyleBackColor = false;
            this.btnDiff.Click += new System.EventHandler(this.BtnDiff_Click);
            this.btnDiff.MouseHover += new System.EventHandler(this.BtnDiff_MouseHover);
            // 
            // Vaikeustaso
            // 
            this.Vaikeustaso.AutoSize = true;
            this.Vaikeustaso.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Vaikeustaso.Font = new System.Drawing.Font("Bahnschrift", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vaikeustaso.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Vaikeustaso.Location = new System.Drawing.Point(147, 9);
            this.Vaikeustaso.Name = "Vaikeustaso";
            this.Vaikeustaso.Size = new System.Drawing.Size(194, 30);
            this.Vaikeustaso.TabIndex = 39;
            this.Vaikeustaso.Text = "Vaikea muistipeli";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Silver;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSave.Location = new System.Drawing.Point(337, 328);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 44);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "Tallenna tuloksesi";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            this.btnSave.MouseHover += new System.EventHandler(this.BtnSave_MouseHover);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblStatus.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStatus.Location = new System.Drawing.Point(5, 294);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(98, 19);
            this.lblStatus.TabIndex = 37;
            this.lblStatus.Text = "Käännetyt kortit:";
            this.lblStatus.Click += new System.EventHandler(this.LblStatus_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LightGreen;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnStart.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F, System.Drawing.FontStyle.Bold);
            this.btnStart.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnStart.Location = new System.Drawing.Point(186, 370);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(124, 63);
            this.btnStart.TabIndex = 36;
            this.btnStart.Text = "Aloita";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.StartGameEvent);
            this.btnStart.MouseHover += new System.EventHandler(this.BtnStart_MouseHover_1);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.LightCoral;
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestart.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRestart.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F, System.Drawing.FontStyle.Bold);
            this.btnRestart.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnRestart.Location = new System.Drawing.Point(99, 389);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(81, 44);
            this.btnRestart.TabIndex = 35;
            this.btnRestart.Text = "Kokeile uudestaan";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.RestartGameEvent);
            this.btnRestart.MouseHover += new System.EventHandler(this.BtnRestart_MouseHover);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblTime.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTime.Location = new System.Drawing.Point(8, 46);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(83, 19);
            this.lblTime.TabIndex = 34;
            this.lblTime.Text = "Aikaa jäljellä:";
            // 
            // lblMatch
            // 
            this.lblMatch.AutoSize = true;
            this.lblMatch.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblMatch.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMatch.Location = new System.Drawing.Point(5, 332);
            this.lblMatch.Name = "lblMatch";
            this.lblMatch.Size = new System.Drawing.Size(84, 19);
            this.lblMatch.TabIndex = 33;
            this.lblMatch.Text = "Löydetyt parit:";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 250;
            this.toolTip1.ReshowDelay = 100;
            // 
            // Form3
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.CancelButton = this.btnDiff;
            this.ClientSize = new System.Drawing.Size(486, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnDiff);
            this.Controls.Add(this.Vaikeustaso);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblMatch);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(502, 489);
            this.MinimumSize = new System.Drawing.Size(502, 489);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vaikea Muistipeli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer GameTime;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnDiff;
        private System.Windows.Forms.Label Vaikeustaso;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblMatch;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}