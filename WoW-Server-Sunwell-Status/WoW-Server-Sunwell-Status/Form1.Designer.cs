namespace WoW_Server_Sunwell_Status
{
    partial class Form1
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
            this.pictureBoxAlliance = new System.Windows.Forms.PictureBox();
            this.pictureBoxHorde = new System.Windows.Forms.PictureBox();
            this.labelAllianceOnline = new System.Windows.Forms.Label();
            this.labelHordeOnline = new System.Windows.Forms.Label();
            this.labelAllianceOnlinePercent = new System.Windows.Forms.Label();
            this.labelAlliancePercent = new System.Windows.Forms.Label();
            this.labelHordeOnlinePercent = new System.Windows.Forms.Label();
            this.labelHordePercent = new System.Windows.Forms.Label();
            this.timerGeneral = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlliance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHorde)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAlliance
            // 
            this.pictureBoxAlliance.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAlliance.Name = "pictureBoxAlliance";
            this.pictureBoxAlliance.Size = new System.Drawing.Size(80, 100);
            this.pictureBoxAlliance.TabIndex = 0;
            this.pictureBoxAlliance.TabStop = false;
            // 
            // pictureBoxHorde
            // 
            this.pictureBoxHorde.Location = new System.Drawing.Point(135, 12);
            this.pictureBoxHorde.Name = "pictureBoxHorde";
            this.pictureBoxHorde.Size = new System.Drawing.Size(80, 100);
            this.pictureBoxHorde.TabIndex = 1;
            this.pictureBoxHorde.TabStop = false;
            // 
            // labelAllianceOnline
            // 
            this.labelAllianceOnline.AutoSize = true;
            this.labelAllianceOnline.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAllianceOnline.Location = new System.Drawing.Point(30, 115);
            this.labelAllianceOnline.Name = "labelAllianceOnline";
            this.labelAllianceOnline.Size = new System.Drawing.Size(40, 16);
            this.labelAllianceOnline.TabIndex = 2;
            this.labelAllianceOnline.Text = "label1";
            // 
            // labelHordeOnline
            // 
            this.labelHordeOnline.AutoSize = true;
            this.labelHordeOnline.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHordeOnline.Location = new System.Drawing.Point(161, 115);
            this.labelHordeOnline.Name = "labelHordeOnline";
            this.labelHordeOnline.Size = new System.Drawing.Size(40, 16);
            this.labelHordeOnline.TabIndex = 3;
            this.labelHordeOnline.Text = "label1";
            // 
            // labelAllianceOnlinePercent
            // 
            this.labelAllianceOnlinePercent.AutoSize = true;
            this.labelAllianceOnlinePercent.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAllianceOnlinePercent.Location = new System.Drawing.Point(9, 135);
            this.labelAllianceOnlinePercent.Name = "labelAllianceOnlinePercent";
            this.labelAllianceOnlinePercent.Size = new System.Drawing.Size(40, 16);
            this.labelAllianceOnlinePercent.TabIndex = 4;
            this.labelAllianceOnlinePercent.Text = "label1";
            // 
            // labelAlliancePercent
            // 
            this.labelAlliancePercent.AutoSize = true;
            this.labelAlliancePercent.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAlliancePercent.Location = new System.Drawing.Point(53, 135);
            this.labelAlliancePercent.Name = "labelAlliancePercent";
            this.labelAlliancePercent.Size = new System.Drawing.Size(17, 16);
            this.labelAlliancePercent.TabIndex = 5;
            this.labelAlliancePercent.Text = "%";
            // 
            // labelHordeOnlinePercent
            // 
            this.labelHordeOnlinePercent.AutoSize = true;
            this.labelHordeOnlinePercent.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHordeOnlinePercent.Location = new System.Drawing.Point(132, 135);
            this.labelHordeOnlinePercent.Name = "labelHordeOnlinePercent";
            this.labelHordeOnlinePercent.Size = new System.Drawing.Size(40, 16);
            this.labelHordeOnlinePercent.TabIndex = 6;
            this.labelHordeOnlinePercent.Text = "label1";
            // 
            // labelHordePercent
            // 
            this.labelHordePercent.AutoSize = true;
            this.labelHordePercent.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHordePercent.Location = new System.Drawing.Point(178, 135);
            this.labelHordePercent.Name = "labelHordePercent";
            this.labelHordePercent.Size = new System.Drawing.Size(17, 16);
            this.labelHordePercent.TabIndex = 7;
            this.labelHordePercent.Text = "%";
            // 
            // timerGeneral
            // 
            this.timerGeneral.Interval = 60000;
            this.timerGeneral.Tick += new System.EventHandler(this.timerGeneral_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 230);
            this.Controls.Add(this.labelHordePercent);
            this.Controls.Add(this.labelHordeOnlinePercent);
            this.Controls.Add(this.labelAlliancePercent);
            this.Controls.Add(this.labelAllianceOnlinePercent);
            this.Controls.Add(this.labelHordeOnline);
            this.Controls.Add(this.labelAllianceOnline);
            this.Controls.Add(this.pictureBoxHorde);
            this.Controls.Add(this.pictureBoxAlliance);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlliance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHorde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAlliance;
        private System.Windows.Forms.PictureBox pictureBoxHorde;
        private System.Windows.Forms.Label labelAllianceOnline;
        private System.Windows.Forms.Label labelHordeOnline;
        private System.Windows.Forms.Label labelAllianceOnlinePercent;
        private System.Windows.Forms.Label labelAlliancePercent;
        private System.Windows.Forms.Label labelHordeOnlinePercent;
        private System.Windows.Forms.Label labelHordePercent;
        private System.Windows.Forms.Timer timerGeneral;
    }
}

