namespace muistipeli
{
    partial class Sanapeli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sanapeli));
            this.Header = new System.Windows.Forms.Label();
            this.GuessLbl = new System.Windows.Forms.Label();
            this.Word = new System.Windows.Forms.TextBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.labelScore = new System.Windows.Forms.Label();
            this.btnDiff = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbltime = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Header.Font = new System.Drawing.Font("Bahnschrift", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Header.Location = new System.Drawing.Point(235, 11);
            this.Header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(136, 37);
            this.Header.TabIndex = 22;
            this.Header.Text = "Sanapeli";
            this.Header.Click += new System.EventHandler(this.Header_Click);
            // 
            // GuessLbl
            // 
            this.GuessLbl.BackColor = System.Drawing.Color.Black;
            this.GuessLbl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GuessLbl.Font = new System.Drawing.Font("Bahnschrift", 20F, System.Drawing.FontStyle.Bold);
            this.GuessLbl.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.GuessLbl.Location = new System.Drawing.Point(180, 222);
            this.GuessLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GuessLbl.Name = "GuessLbl";
            this.GuessLbl.Size = new System.Drawing.Size(241, 42);
            this.GuessLbl.TabIndex = 23;
            this.GuessLbl.Text = "Arvattava sana";
            this.GuessLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GuessLbl.Click += new System.EventHandler(this.GuessLbl_Click);
            // 
            // Word
            // 
            this.Word.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Word.Location = new System.Drawing.Point(133, 289);
            this.Word.Margin = new System.Windows.Forms.Padding(4);
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(348, 44);
            this.Word.TabIndex = 24;
            this.Word.TextChanged += new System.EventHandler(this.Word_TextChanged);
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.LightCoral;
            this.BtnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStart.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.BtnStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnStart.Location = new System.Drawing.Point(449, 407);
            this.BtnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(167, 55);
            this.BtnStart.TabIndex = 25;
            this.BtnStart.Text = "Aloita uudestaan";
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            this.BtnStart.MouseHover += new System.EventHandler(this.BtnStart_MouseHover);
            // 
            // BtnNext
            // 
            this.BtnNext.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNext.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F, System.Drawing.FontStyle.Bold);
            this.BtnNext.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnNext.Location = new System.Drawing.Point(213, 447);
            this.BtnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(189, 89);
            this.BtnNext.TabIndex = 26;
            this.BtnNext.Text = "Seuraava";
            this.BtnNext.UseVisualStyleBackColor = false;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            this.BtnNext.MouseHover += new System.EventHandler(this.BtnNext_MouseHover);
            // 
            // labelScore
            // 
            this.labelScore.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelScore.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelScore.Location = new System.Drawing.Point(16, 11);
            this.labelScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(164, 76);
            this.labelScore.TabIndex = 28;
            this.labelScore.Text = "Arvatut sanat: 0 / 0";
            this.labelScore.Click += new System.EventHandler(this.LabelScore_Click);
            // 
            // btnDiff
            // 
            this.btnDiff.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDiff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiff.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDiff.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiff.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDiff.Location = new System.Drawing.Point(449, 469);
            this.btnDiff.Margin = new System.Windows.Forms.Padding(4);
            this.btnDiff.Name = "btnDiff";
            this.btnDiff.Size = new System.Drawing.Size(167, 66);
            this.btnDiff.TabIndex = 29;
            this.btnDiff.Text = "Takaisin päävalikkoon";
            this.btnDiff.UseVisualStyleBackColor = false;
            this.btnDiff.Click += new System.EventHandler(this.BtnDiff_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSave.Location = new System.Drawing.Point(16, 469);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 70);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Tallenna tuloksesi";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            this.btnSave.MouseHover += new System.EventHandler(this.BtnSave_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.TimerEvent);
            // 
            // lbltime
            // 
            this.lbltime.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbltime.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbltime.Location = new System.Drawing.Point(16, 112);
            this.lbltime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(181, 110);
            this.lbltime.TabIndex = 32;
            this.lbltime.Text = "Aikaa mennyt:";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.labelResult.Font = new System.Drawing.Font("Bahnschrift", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelResult.Location = new System.Drawing.Point(483, 151);
            this.labelResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 37);
            this.labelResult.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(16, 382);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 80);
            this.button1.TabIndex = 33;
            this.button1.Text = "Katso viimeisin tulos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            this.button1.MouseHover += new System.EventHandler(this.Button1_MouseHover);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(484, 289);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 55);
            this.label1.TabIndex = 34;
            this.label1.Text = "Sana: 0 / 15";
            // 
            // Sanapeli
            // 
            this.AcceptButton = this.BtnNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(629, 544);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDiff);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.Word);
            this.Controls.Add(this.GuessLbl);
            this.Controls.Add(this.Header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(647, 591);
            this.MinimumSize = new System.Drawing.Size(647, 591);
            this.Name = "Sanapeli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sanapeli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Label GuessLbl;
        private System.Windows.Forms.TextBox Word;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Button btnDiff;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}