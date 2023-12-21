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
            this.labelResult = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.btnDiff = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Header.Font = new System.Drawing.Font("Bahnschrift", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Header.Location = new System.Drawing.Point(175, 58);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(108, 30);
            this.Header.TabIndex = 22;
            this.Header.Text = "Sanapeli";
            this.Header.Click += new System.EventHandler(this.Header_Click);
            // 
            // GuessLbl
            // 
            this.GuessLbl.AutoSize = true;
            this.GuessLbl.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.GuessLbl.Font = new System.Drawing.Font("Bahnschrift", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuessLbl.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.GuessLbl.Location = new System.Drawing.Point(139, 119);
            this.GuessLbl.Name = "GuessLbl";
            this.GuessLbl.Size = new System.Drawing.Size(181, 30);
            this.GuessLbl.TabIndex = 23;
            this.GuessLbl.Text = "Arvattava sana";
            // 
            // Word
            // 
            this.Word.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Word.Location = new System.Drawing.Point(95, 170);
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(262, 36);
            this.Word.TabIndex = 24;
            this.Word.TextChanged += new System.EventHandler(this.Word_TextChanged);
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStart.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F, System.Drawing.FontStyle.Bold);
            this.BtnStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnStart.Location = new System.Drawing.Point(159, 367);
            this.BtnStart.Margin = new System.Windows.Forms.Padding(2);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(142, 72);
            this.BtnStart.TabIndex = 25;
            this.BtnStart.Text = "Aloita";
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNext.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F, System.Drawing.FontStyle.Bold);
            this.BtnNext.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnNext.Location = new System.Drawing.Point(159, 253);
            this.BtnNext.Margin = new System.Windows.Forms.Padding(2);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(142, 72);
            this.BtnNext.TabIndex = 26;
            this.BtnNext.Text = "Seuraava";
            this.BtnNext.UseVisualStyleBackColor = false;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.labelResult.Font = new System.Drawing.Font("Bahnschrift", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelResult.Location = new System.Drawing.Point(357, 58);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 30);
            this.labelResult.TabIndex = 27;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelScore.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelScore.Location = new System.Drawing.Point(350, 9);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(112, 29);
            this.labelScore.TabIndex = 28;
            this.labelScore.Text = "Pisteet: 0 / 0";
            this.labelScore.Click += new System.EventHandler(this.LabelScore_Click);
            // 
            // btnDiff
            // 
            this.btnDiff.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDiff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiff.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDiff.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiff.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDiff.Location = new System.Drawing.Point(337, 381);
            this.btnDiff.Name = "btnDiff";
            this.btnDiff.Size = new System.Drawing.Size(125, 54);
            this.btnDiff.TabIndex = 29;
            this.btnDiff.Text = "Takaisin päävalikkoon";
            this.btnDiff.UseVisualStyleBackColor = false;
            this.btnDiff.Click += new System.EventHandler(this.BtnDiff_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Silver;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSave.Location = new System.Drawing.Point(12, 381);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 57);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Tallenna tuloksesi";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 29);
            this.label1.TabIndex = 31;
            this.label1.Text = "Viimeisin tulos:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Sanapeli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(474, 450);
            this.Controls.Add(this.label1);
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
            this.MaximumSize = new System.Drawing.Size(490, 489);
            this.MinimumSize = new System.Drawing.Size(490, 489);
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
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Button btnDiff;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}