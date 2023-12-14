namespace muistipeli
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.btnDiff = new System.Windows.Forms.Button();
            this.Vaikeustaso = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblMatch = new System.Windows.Forms.Label();
            this.GameTime = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnDiff
            // 
            this.btnDiff.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDiff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiff.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDiff.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiff.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDiff.Location = new System.Drawing.Point(406, 486);
            this.btnDiff.Margin = new System.Windows.Forms.Padding(4);
            this.btnDiff.Name = "btnDiff";
            this.btnDiff.Size = new System.Drawing.Size(167, 67);
            this.btnDiff.TabIndex = 22;
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
            this.Vaikeustaso.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Vaikeustaso.Location = new System.Drawing.Point(182, 9);
            this.Vaikeustaso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Vaikeustaso.Name = "Vaikeustaso";
            this.Vaikeustaso.Size = new System.Drawing.Size(252, 37);
            this.Vaikeustaso.TabIndex = 21;
            this.Vaikeustaso.Text = "Helppo mustipeli";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Silver;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSave.Location = new System.Drawing.Point(434, 424);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 54);
            this.btnSave.TabIndex = 20;
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
            this.lblStatus.Location = new System.Drawing.Point(9, 360);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(120, 24);
            this.lblStatus.TabIndex = 19;
            this.lblStatus.Text = "Käännetyt kortit:";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LightGreen;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnStart.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F, System.Drawing.FontStyle.Bold);
            this.btnStart.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnStart.Location = new System.Drawing.Point(233, 475);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(165, 78);
            this.btnStart.TabIndex = 18;
            this.btnStart.Text = "Aloita";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.StartGameEvent);
            this.btnStart.MouseHover += new System.EventHandler(this.BtnStart_MouseHover_1);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.LightCoral;
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestart.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F, System.Drawing.FontStyle.Bold);
            this.btnRestart.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnRestart.Location = new System.Drawing.Point(117, 499);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(108, 54);
            this.btnRestart.TabIndex = 17;
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
            this.lblTime.Location = new System.Drawing.Point(13, 54);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(101, 24);
            this.lblTime.TabIndex = 16;
            this.lblTime.Text = "Aikaa jäljellä:";
            // 
            // lblMatch
            // 
            this.lblMatch.AutoSize = true;
            this.lblMatch.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblMatch.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMatch.Location = new System.Drawing.Point(9, 406);
            this.lblMatch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatch.Name = "lblMatch";
            this.lblMatch.Size = new System.Drawing.Size(105, 24);
            this.lblMatch.TabIndex = 15;
            this.lblMatch.Text = "Löydetyt parit:";
            // 
            // GameTime
            // 
            this.GameTime.Interval = 1000;
            this.GameTime.Tick += new System.EventHandler(this.TimerEvent);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(32, 91);
            this.progressBar1.Maximum = 30;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 23;
            this.progressBar1.Value = 30;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 250;
            this.toolTip1.ReshowDelay = 100;
            // 
            // Form4
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.btnDiff;
            this.ClientSize = new System.Drawing.Size(630, 566);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnDiff);
            this.Controls.Add(this.Vaikeustaso);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblMatch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(648, 613);
            this.MinimumSize = new System.Drawing.Size(648, 613);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Helppo Muistipeli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDiff;
        private System.Windows.Forms.Label Vaikeustaso;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblMatch;
        private System.Windows.Forms.Timer GameTime;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}