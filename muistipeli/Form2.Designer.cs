namespace muistipeli
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.btnMed = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Vaikeustaso = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblMatch = new System.Windows.Forms.Label();
            this.lblStatus2 = new System.Windows.Forms.Label();
            this.lblTime2 = new System.Windows.Forms.Label();
            this.lblMatch2 = new System.Windows.Forms.Label();
            this.lblStatus3 = new System.Windows.Forms.Label();
            this.lblTime3 = new System.Windows.Forms.Label();
            this.lblMatch3 = new System.Windows.Forms.Label();
            this.Tulostaulu = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(40, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 161);
            this.button1.TabIndex = 0;
            this.button1.Text = "Helppo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            this.button1.MouseHover += new System.EventHandler(this.Button1_MouseHover);
            // 
            // btnMed
            // 
            this.btnMed.BackColor = System.Drawing.Color.LightYellow;
            this.btnMed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMed.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMed.Location = new System.Drawing.Point(309, 125);
            this.btnMed.Name = "btnMed";
            this.btnMed.Size = new System.Drawing.Size(189, 161);
            this.btnMed.TabIndex = 1;
            this.btnMed.Text = "Keskitaso";
            this.btnMed.UseVisualStyleBackColor = false;
            this.btnMed.Click += new System.EventHandler(this.Button2_Click);
            this.btnMed.MouseHover += new System.EventHandler(this.BtnMed_MouseHover);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightCoral;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Bahnschrift Condensed", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(570, 125);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 161);
            this.button3.TabIndex = 2;
            this.button3.Text = "Vaikea";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            this.button3.MouseHover += new System.EventHandler(this.Button3_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(96, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 41);
            this.label2.TabIndex = 4;
            this.label2.Text = "2x5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(370, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 41);
            this.label3.TabIndex = 5;
            this.label3.Text = "3x4";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(628, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 41);
            this.label4.TabIndex = 6;
            this.label4.Text = "4x4";
            // 
            // Vaikeustaso
            // 
            this.Vaikeustaso.AutoSize = true;
            this.Vaikeustaso.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Vaikeustaso.Font = new System.Drawing.Font("Bahnschrift", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vaikeustaso.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Vaikeustaso.Location = new System.Drawing.Point(175, 49);
            this.Vaikeustaso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Vaikeustaso.Name = "Vaikeustaso";
            this.Vaikeustaso.Size = new System.Drawing.Size(445, 37);
            this.Vaikeustaso.TabIndex = 22;
            this.Vaikeustaso.Text = "Valitse muistipelin vaikeustaso";
            this.Vaikeustaso.Click += new System.EventHandler(this.Vaikeustaso_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblStatus.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStatus.Location = new System.Drawing.Point(36, 524);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(120, 24);
            this.lblStatus.TabIndex = 31;
            this.lblStatus.Text = "Käännetyt kortit:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblTime.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTime.Location = new System.Drawing.Point(36, 479);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(101, 24);
            this.lblTime.TabIndex = 30;
            this.lblTime.Text = "Aikaa jäljellä:";
            // 
            // lblMatch
            // 
            this.lblMatch.AutoSize = true;
            this.lblMatch.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblMatch.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMatch.Location = new System.Drawing.Point(36, 570);
            this.lblMatch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatch.Name = "lblMatch";
            this.lblMatch.Size = new System.Drawing.Size(105, 24);
            this.lblMatch.TabIndex = 29;
            this.lblMatch.Text = "Löydetyt parit:";
            // 
            // lblStatus2
            // 
            this.lblStatus2.AutoSize = true;
            this.lblStatus2.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblStatus2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStatus2.Location = new System.Drawing.Point(305, 524);
            this.lblStatus2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus2.Name = "lblStatus2";
            this.lblStatus2.Size = new System.Drawing.Size(120, 24);
            this.lblStatus2.TabIndex = 34;
            this.lblStatus2.Text = "Käännetyt kortit:";
            // 
            // lblTime2
            // 
            this.lblTime2.AutoSize = true;
            this.lblTime2.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblTime2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTime2.Location = new System.Drawing.Point(305, 479);
            this.lblTime2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime2.Name = "lblTime2";
            this.lblTime2.Size = new System.Drawing.Size(101, 24);
            this.lblTime2.TabIndex = 33;
            this.lblTime2.Text = "Aikaa jäljellä:";
            // 
            // lblMatch2
            // 
            this.lblMatch2.AutoSize = true;
            this.lblMatch2.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblMatch2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatch2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMatch2.Location = new System.Drawing.Point(305, 570);
            this.lblMatch2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatch2.Name = "lblMatch2";
            this.lblMatch2.Size = new System.Drawing.Size(105, 24);
            this.lblMatch2.TabIndex = 32;
            this.lblMatch2.Text = "Löydetyt parit:";
            // 
            // lblStatus3
            // 
            this.lblStatus3.AutoSize = true;
            this.lblStatus3.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblStatus3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStatus3.Location = new System.Drawing.Point(566, 524);
            this.lblStatus3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus3.Name = "lblStatus3";
            this.lblStatus3.Size = new System.Drawing.Size(120, 24);
            this.lblStatus3.TabIndex = 37;
            this.lblStatus3.Text = "Käännetyt kortit:";
            // 
            // lblTime3
            // 
            this.lblTime3.AutoSize = true;
            this.lblTime3.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblTime3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTime3.Location = new System.Drawing.Point(566, 479);
            this.lblTime3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime3.Name = "lblTime3";
            this.lblTime3.Size = new System.Drawing.Size(101, 24);
            this.lblTime3.TabIndex = 36;
            this.lblTime3.Text = "Aikaa jäljellä:";
            // 
            // lblMatch3
            // 
            this.lblMatch3.AutoSize = true;
            this.lblMatch3.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblMatch3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatch3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMatch3.Location = new System.Drawing.Point(566, 570);
            this.lblMatch3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatch3.Name = "lblMatch3";
            this.lblMatch3.Size = new System.Drawing.Size(105, 24);
            this.lblMatch3.TabIndex = 35;
            this.lblMatch3.Text = "Löydetyt parit:";
            // 
            // Tulostaulu
            // 
            this.Tulostaulu.AutoSize = true;
            this.Tulostaulu.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Tulostaulu.Font = new System.Drawing.Font("Bahnschrift", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tulostaulu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Tulostaulu.Location = new System.Drawing.Point(146, 414);
            this.Tulostaulu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Tulostaulu.Name = "Tulostaulu";
            this.Tulostaulu.Size = new System.Drawing.Size(474, 37);
            this.Tulostaulu.TabIndex = 38;
            this.Tulostaulu.Text = "Viimeisimmät tallenetut tulokset:";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 250;
            this.toolTip1.ReshowDelay = 100;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 635);
            this.Controls.Add(this.Tulostaulu);
            this.Controls.Add(this.lblStatus3);
            this.Controls.Add(this.lblTime3);
            this.Controls.Add(this.lblMatch3);
            this.Controls.Add(this.lblStatus2);
            this.Controls.Add(this.lblTime2);
            this.Controls.Add(this.lblMatch2);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblMatch);
            this.Controls.Add(this.Vaikeustaso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnMed);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(818, 682);
            this.MinimumSize = new System.Drawing.Size(818, 682);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vaikeustaso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMed;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Vaikeustaso;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblMatch;
        private System.Windows.Forms.Label lblStatus2;
        private System.Windows.Forms.Label lblTime2;
        private System.Windows.Forms.Label lblMatch2;
        private System.Windows.Forms.Label lblStatus3;
        private System.Windows.Forms.Label lblTime3;
        private System.Windows.Forms.Label lblMatch3;
        private System.Windows.Forms.Label Tulostaulu;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}