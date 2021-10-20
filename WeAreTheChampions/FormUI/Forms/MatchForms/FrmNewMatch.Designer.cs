
namespace FormUI.Forms.MatchForms
{
    partial class FrmNewMatch
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
            this.lblTodaysDate = new System.Windows.Forms.Label();
            this.dtpMatchDate = new System.Windows.Forms.DateTimePicker();
            this.dtpMatchHour = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvHomeTeam = new System.Windows.Forms.DataGridView();
            this.TeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAwayTeam = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSaveMatch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomeTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAwayTeam)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTodaysDate
            // 
            this.lblTodaysDate.AutoSize = true;
            this.lblTodaysDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTodaysDate.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTodaysDate.Location = new System.Drawing.Point(788, 9);
            this.lblTodaysDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTodaysDate.Name = "lblTodaysDate";
            this.lblTodaysDate.Size = new System.Drawing.Size(89, 20);
            this.lblTodaysDate.TabIndex = 1;
            this.lblTodaysDate.Text = "19.10.2021";
            // 
            // dtpMatchDate
            // 
            this.dtpMatchDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMatchDate.Location = new System.Drawing.Point(83, 4);
            this.dtpMatchDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpMatchDate.Name = "dtpMatchDate";
            this.dtpMatchDate.Size = new System.Drawing.Size(108, 23);
            this.dtpMatchDate.TabIndex = 2;
            // 
            // dtpMatchHour
            // 
            this.dtpMatchHour.CustomFormat = "HH:mm";
            this.dtpMatchHour.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMatchHour.Location = new System.Drawing.Point(287, 4);
            this.dtpMatchHour.Margin = new System.Windows.Forms.Padding(4);
            this.dtpMatchHour.Name = "dtpMatchHour";
            this.dtpMatchHour.ShowUpDown = true;
            this.dtpMatchHour.Size = new System.Drawing.Size(108, 23);
            this.dtpMatchHour.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tarih :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Saat :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(178, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ev Sahibi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(650, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Deplasman";
            // 
            // dgvHomeTeam
            // 
            this.dgvHomeTeam.AllowUserToAddRows = false;
            this.dgvHomeTeam.AllowUserToDeleteRows = false;
            this.dgvHomeTeam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHomeTeam.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHomeTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHomeTeam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeamName});
            this.dgvHomeTeam.Location = new System.Drawing.Point(32, 93);
            this.dgvHomeTeam.MultiSelect = false;
            this.dgvHomeTeam.Name = "dgvHomeTeam";
            this.dgvHomeTeam.ReadOnly = true;
            this.dgvHomeTeam.RowHeadersVisible = false;
            this.dgvHomeTeam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHomeTeam.Size = new System.Drawing.Size(391, 366);
            this.dgvHomeTeam.TabIndex = 9;
            this.dgvHomeTeam.SelectionChanged += new System.EventHandler(this.dgvHomeTeam_SelectionChanged);
            // 
            // TeamName
            // 
            this.TeamName.DataPropertyName = "TeamName";
            this.TeamName.HeaderText = "Ev Sahibi";
            this.TeamName.Name = "TeamName";
            this.TeamName.ReadOnly = true;
            // 
            // dgvAwayTeam
            // 
            this.dgvAwayTeam.AllowUserToAddRows = false;
            this.dgvAwayTeam.AllowUserToDeleteRows = false;
            this.dgvAwayTeam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAwayTeam.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAwayTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAwayTeam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvAwayTeam.Location = new System.Drawing.Point(523, 93);
            this.dgvAwayTeam.MultiSelect = false;
            this.dgvAwayTeam.Name = "dgvAwayTeam";
            this.dgvAwayTeam.ReadOnly = true;
            this.dgvAwayTeam.RowHeadersVisible = false;
            this.dgvAwayTeam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAwayTeam.Size = new System.Drawing.Size(398, 366);
            this.dgvAwayTeam.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TeamName";
            this.Column1.HeaderText = "Deplasman";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // btnSaveMatch
            // 
            this.btnSaveMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            this.btnSaveMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveMatch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSaveMatch.Location = new System.Drawing.Point(729, 481);
            this.btnSaveMatch.Name = "btnSaveMatch";
            this.btnSaveMatch.Size = new System.Drawing.Size(192, 52);
            this.btnSaveMatch.TabIndex = 10;
            this.btnSaveMatch.Text = "YENİ MAÇ OLUŞTUR";
            this.btnSaveMatch.UseVisualStyleBackColor = false;
            this.btnSaveMatch.Click += new System.EventHandler(this.btnSaveMatch_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnExit.Location = new System.Drawing.Point(553, 481);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(157, 52);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "İPTAL";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dtpMatchHour);
            this.panel1.Controls.Add(this.dtpMatchDate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(266, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 33);
            this.panel1.TabIndex = 11;
            // 
            // FrmNewMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(940, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSaveMatch);
            this.Controls.Add(this.dgvAwayTeam);
            this.Controls.Add(this.dgvHomeTeam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTodaysDate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmNewMatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Yeni Maç Ekle";
            this.Load += new System.EventHandler(this.FrmNewMatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomeTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAwayTeam)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTodaysDate;
        private System.Windows.Forms.DateTimePicker dtpMatchDate;
        private System.Windows.Forms.DateTimePicker dtpMatchHour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvHomeTeam;
        private System.Windows.Forms.DataGridView dgvAwayTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamName;
        private System.Windows.Forms.Button btnSaveMatch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
    }
}