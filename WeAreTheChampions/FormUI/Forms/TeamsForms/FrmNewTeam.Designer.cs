
namespace FormUI.Forms.TeamsForms
{
    partial class FrmNewTeam
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
            this.lblTeamName = new System.Windows.Forms.Label();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.panelUnderline = new System.Windows.Forms.Panel();
            this.lblCreateTeam = new System.Windows.Forms.Label();
            this.lblColors = new System.Windows.Forms.Label();
            this.lblPlayers = new System.Windows.Forms.Label();
            this.btnNextToColors = new System.Windows.Forms.Button();
            this.panelNewTeam = new System.Windows.Forms.Panel();
            this.panelColors = new System.Windows.Forms.Panel();
            this.labelRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panelUnderlineRed = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnNewColor = new System.Windows.Forms.Button();
            this.dgvColors = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTeamColors = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lblToolTipColors = new System.Windows.Forms.Label();
            this.lblValidateTeamName = new System.Windows.Forms.Label();
            this.btnNextToPlayers = new System.Windows.Forms.Button();
            this.panelNewTeam.SuspendLayout();
            this.panelColors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamColors)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTeamName.Location = new System.Drawing.Point(26, 44);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(86, 20);
            this.lblTeamName.TabIndex = 1;
            this.lblTeamName.Text = "Takım Adı :";
            // 
            // txtTeamName
            // 
            this.txtTeamName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtTeamName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTeamName.Location = new System.Drawing.Point(127, 44);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(265, 19);
            this.txtTeamName.TabIndex = 2;
            this.txtTeamName.TextChanged += new System.EventHandler(this.txtTeamName_TextChanged);
            // 
            // panelUnderline
            // 
            this.panelUnderline.BackColor = System.Drawing.Color.Pink;
            this.panelUnderline.Location = new System.Drawing.Point(127, 66);
            this.panelUnderline.Name = "panelUnderline";
            this.panelUnderline.Size = new System.Drawing.Size(265, 2);
            this.panelUnderline.TabIndex = 3;
            // 
            // lblCreateTeam
            // 
            this.lblCreateTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            this.lblCreateTeam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCreateTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCreateTeam.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCreateTeam.Location = new System.Drawing.Point(101, 18);
            this.lblCreateTeam.Name = "lblCreateTeam";
            this.lblCreateTeam.Size = new System.Drawing.Size(200, 45);
            this.lblCreateTeam.TabIndex = 0;
            this.lblCreateTeam.Text = "Takım Oluştur";
            this.lblCreateTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblColors
            // 
            this.lblColors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblColors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblColors.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblColors.Location = new System.Drawing.Point(301, 18);
            this.lblColors.Name = "lblColors";
            this.lblColors.Size = new System.Drawing.Size(200, 45);
            this.lblColors.TabIndex = 0;
            this.lblColors.Text = "Renkler";
            this.lblColors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayers
            // 
            this.lblPlayers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPlayers.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPlayers.Location = new System.Drawing.Point(501, 18);
            this.lblPlayers.Name = "lblPlayers";
            this.lblPlayers.Size = new System.Drawing.Size(200, 45);
            this.lblPlayers.TabIndex = 0;
            this.lblPlayers.Text = "Oyuncular";
            this.lblPlayers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNextToColors
            // 
            this.btnNextToColors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            this.btnNextToColors.Enabled = false;
            this.btnNextToColors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextToColors.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNextToColors.Location = new System.Drawing.Point(660, 412);
            this.btnNextToColors.Name = "btnNextToColors";
            this.btnNextToColors.Size = new System.Drawing.Size(156, 50);
            this.btnNextToColors.TabIndex = 4;
            this.btnNextToColors.Text = "İLERİ >>";
            this.btnNextToColors.UseVisualStyleBackColor = false;
            this.btnNextToColors.Click += new System.EventHandler(this.btnNextToColors_Click);
            // 
            // panelNewTeam
            // 
            this.panelNewTeam.Controls.Add(this.lblValidateTeamName);
            this.panelNewTeam.Controls.Add(this.btnNextToColors);
            this.panelNewTeam.Controls.Add(this.lblTeamName);
            this.panelNewTeam.Controls.Add(this.txtTeamName);
            this.panelNewTeam.Controls.Add(this.panelUnderline);
            this.panelNewTeam.Location = new System.Drawing.Point(34, 92);
            this.panelNewTeam.Name = "panelNewTeam";
            this.panelNewTeam.Size = new System.Drawing.Size(854, 477);
            this.panelNewTeam.TabIndex = 5;
            // 
            // panelColors
            // 
            this.panelColors.Controls.Add(this.btnNextToPlayers);
            this.panelColors.Controls.Add(this.lblToolTipColors);
            this.panelColors.Controls.Add(this.dgvTeamColors);
            this.panelColors.Controls.Add(this.label3);
            this.panelColors.Controls.Add(this.label2);
            this.panelColors.Controls.Add(this.dgvColors);
            this.panelColors.Controls.Add(this.btnNewColor);
            this.panelColors.Controls.Add(this.panel3);
            this.panelColors.Controls.Add(this.panel2);
            this.panelColors.Controls.Add(this.textBox5);
            this.panelColors.Controls.Add(this.textBox4);
            this.panelColors.Controls.Add(this.panel1);
            this.panelColors.Controls.Add(this.textBox3);
            this.panelColors.Controls.Add(this.panelUnderlineRed);
            this.panelColors.Controls.Add(this.textBox2);
            this.panelColors.Controls.Add(this.label1);
            this.panelColors.Controls.Add(this.lblBlue);
            this.panelColors.Controls.Add(this.lblGreen);
            this.panelColors.Controls.Add(this.labelRed);
            this.panelColors.Location = new System.Drawing.Point(34, 92);
            this.panelColors.Name = "panelColors";
            this.panelColors.Size = new System.Drawing.Size(854, 474);
            this.panelColors.TabIndex = 5;
            // 
            // labelRed
            // 
            this.labelRed.AutoSize = true;
            this.labelRed.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelRed.Location = new System.Drawing.Point(23, 33);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(43, 20);
            this.labelRed.TabIndex = 0;
            this.labelRed.Text = "Red:";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblGreen.Location = new System.Drawing.Point(23, 69);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(58, 20);
            this.lblGreen.TabIndex = 0;
            this.lblGreen.Text = "Green:";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBlue.Location = new System.Drawing.Point(23, 108);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(45, 20);
            this.lblBlue.TabIndex = 0;
            this.lblBlue.Text = "Blue:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox2.Location = new System.Drawing.Point(90, 29);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(45, 19);
            this.textBox2.TabIndex = 1;
            // 
            // panelUnderlineRed
            // 
            this.panelUnderlineRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            this.panelUnderlineRed.Location = new System.Drawing.Point(90, 50);
            this.panelUnderlineRed.Name = "panelUnderlineRed";
            this.panelUnderlineRed.Size = new System.Drawing.Size(45, 2);
            this.panelUnderlineRed.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            this.panel1.Location = new System.Drawing.Point(90, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(45, 2);
            this.panel1.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox3.Location = new System.Drawing.Point(90, 66);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(45, 19);
            this.textBox3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            this.panel2.Location = new System.Drawing.Point(90, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(45, 2);
            this.panel2.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox4.Location = new System.Drawing.Point(90, 102);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(45, 19);
            this.textBox4.TabIndex = 5;
            // 
            // btnNewColor
            // 
            this.btnNewColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNewColor.Location = new System.Drawing.Point(27, 189);
            this.btnNewColor.Name = "btnNewColor";
            this.btnNewColor.Size = new System.Drawing.Size(144, 29);
            this.btnNewColor.TabIndex = 8;
            this.btnNewColor.Text = "YENİ RENK EKLE";
            this.btnNewColor.UseVisualStyleBackColor = true;
            // 
            // dgvColors
            // 
            this.dgvColors.AllowUserToAddRows = false;
            this.dgvColors.AllowUserToDeleteRows = false;
            this.dgvColors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColors.Location = new System.Drawing.Point(305, 44);
            this.dgvColors.Name = "dgvColors";
            this.dgvColors.ReadOnly = true;
            this.dgvColors.Size = new System.Drawing.Size(199, 167);
            this.dgvColors.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(23, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Renk Adı:";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox5.Location = new System.Drawing.Point(107, 141);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(124, 19);
            this.textBox5.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            this.panel3.Location = new System.Drawing.Point(107, 162);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(124, 2);
            this.panel3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(314, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mevcut Renkler";
            // 
            // dgvTeamColors
            // 
            this.dgvTeamColors.AllowUserToAddRows = false;
            this.dgvTeamColors.AllowUserToDeleteRows = false;
            this.dgvTeamColors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeamColors.Location = new System.Drawing.Point(615, 44);
            this.dgvTeamColors.Name = "dgvTeamColors";
            this.dgvTeamColors.ReadOnly = true;
            this.dgvTeamColors.Size = new System.Drawing.Size(213, 167);
            this.dgvTeamColors.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(611, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Takıma Atanan Renkler";
            // 
            // lblToolTipColors
            // 
            this.lblToolTipColors.AutoSize = true;
            this.lblToolTipColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToolTipColors.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblToolTipColors.Location = new System.Drawing.Point(15, 321);
            this.lblToolTipColors.Name = "lblToolTipColors";
            this.lblToolTipColors.Size = new System.Drawing.Size(801, 17);
            this.lblToolTipColors.TabIndex = 12;
            this.lblToolTipColors.Text = "ToolTip: Mevcut renkler bölümündeki renklere çift tıklayıp takımınıza atama yapab" +
    "ilir, DELETE tuşu ile atamayı geri alabilirsiniz.";
            // 
            // lblValidateTeamName
            // 
            this.lblValidateTeamName.AutoSize = true;
            this.lblValidateTeamName.Location = new System.Drawing.Point(30, 87);
            this.lblValidateTeamName.Name = "lblValidateTeamName";
            this.lblValidateTeamName.Size = new System.Drawing.Size(165, 20);
            this.lblValidateTeamName.TabIndex = 5;
            this.lblValidateTeamName.Text = "TeamName Validation";
            this.lblValidateTeamName.Visible = false;
            // 
            // btnNextToPlayers
            // 
            this.btnNextToPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            this.btnNextToPlayers.Enabled = false;
            this.btnNextToPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextToPlayers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNextToPlayers.Location = new System.Drawing.Point(660, 412);
            this.btnNextToPlayers.Name = "btnNextToPlayers";
            this.btnNextToPlayers.Size = new System.Drawing.Size(156, 50);
            this.btnNextToPlayers.TabIndex = 14;
            this.btnNextToPlayers.Text = "İLERİ >>";
            this.btnNextToPlayers.UseVisualStyleBackColor = false;
            // 
            // FrmNewTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(976, 608);
            this.Controls.Add(this.panelColors);
            this.Controls.Add(this.panelNewTeam);
            this.Controls.Add(this.lblPlayers);
            this.Controls.Add(this.lblColors);
            this.Controls.Add(this.lblCreateTeam);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmNewTeam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNewTeam";
            this.Load += new System.EventHandler(this.FrmNewTeam_Load);
            this.panelNewTeam.ResumeLayout(false);
            this.panelNewTeam.PerformLayout();
            this.panelColors.ResumeLayout(false);
            this.panelColors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamColors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Panel panelUnderline;
        private System.Windows.Forms.Label lblCreateTeam;
        private System.Windows.Forms.Label lblColors;
        private System.Windows.Forms.Label lblPlayers;
        private System.Windows.Forms.Button btnNextToColors;
        private System.Windows.Forms.Panel panelNewTeam;
        private System.Windows.Forms.Panel panelColors;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label labelRed;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panelUnderlineRed;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblToolTipColors;
        private System.Windows.Forms.DataGridView dgvTeamColors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvColors;
        private System.Windows.Forms.Button btnNewColor;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValidateTeamName;
        private System.Windows.Forms.Button btnNextToPlayers;
    }
}