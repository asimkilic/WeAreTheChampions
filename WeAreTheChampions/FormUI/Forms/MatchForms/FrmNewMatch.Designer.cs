
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnClose = new KLCToolbox.KLCControls.KLCButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomeTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAwayTeam)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTodaysDate
            // 
            this.lblTodaysDate.AutoSize = true;
            this.lblTodaysDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTodaysDate.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTodaysDate.Location = new System.Drawing.Point(894, 65);
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
            this.label4.Location = new System.Drawing.Point(185, 147);
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
            this.label5.Location = new System.Drawing.Point(657, 147);
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
            this.dgvHomeTeam.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHomeTeam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHomeTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHomeTeam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeamName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHomeTeam.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHomeTeam.EnableHeadersVisualStyles = false;
            this.dgvHomeTeam.Location = new System.Drawing.Point(39, 185);
            this.dgvHomeTeam.MultiSelect = false;
            this.dgvHomeTeam.Name = "dgvHomeTeam";
            this.dgvHomeTeam.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHomeTeam.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            this.dgvAwayTeam.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAwayTeam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAwayTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAwayTeam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAwayTeam.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAwayTeam.EnableHeadersVisualStyles = false;
            this.dgvAwayTeam.Location = new System.Drawing.Point(530, 185);
            this.dgvAwayTeam.MultiSelect = false;
            this.dgvAwayTeam.Name = "dgvAwayTeam";
            this.dgvAwayTeam.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAwayTeam.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
            this.btnSaveMatch.Location = new System.Drawing.Point(736, 573);
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
            this.btnExit.Location = new System.Drawing.Point(560, 573);
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
            this.panel1.Location = new System.Drawing.Point(273, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 33);
            this.panel1.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel5.Controls.Add(this.lblWelcome);
            this.panel5.Controls.Add(this.btnClose);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(996, 47);
            this.panel5.TabIndex = 15;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblWelcome.Location = new System.Drawing.Point(13, 13);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 17);
            this.lblWelcome.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::FormUI.Properties.Resources.close;
            this.btnClose.KLCBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.btnClose.KLCBorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnClose.KLCBorderRadius = 40;
            this.btnClose.KLCBorderSize = 0;
            this.btnClose.KLCTextColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(944, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = " ";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmNewMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(996, 653);
            this.ControlBox = false;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSaveMatch);
            this.Controls.Add(this.dgvAwayTeam);
            this.Controls.Add(this.dgvHomeTeam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTodaysDate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmNewMatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Yeni Maç Ekle";
            this.Load += new System.EventHandler(this.FrmNewMatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHomeTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAwayTeam)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
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
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblWelcome;
        private KLCToolbox.KLCControls.KLCButton btnClose;
    }
}