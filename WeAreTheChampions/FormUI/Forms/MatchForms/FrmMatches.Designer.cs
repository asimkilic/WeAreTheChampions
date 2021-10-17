
namespace FormUI.Forms
{
    partial class FrmMatches
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
            this.dgvMatches = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditMatch = new System.Windows.Forms.Button();
            this.btnDeleteMatch = new System.Windows.Forms.Button();
            this.cbxHidePlayedMatches = new System.Windows.Forms.CheckBox();
            this.btnNewMatch = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.klcDatePicker1 = new KLCToolbox.KLCControls.KLCDatePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMatches
            // 
            this.dgvMatches.AllowUserToAddRows = false;
            this.dgvMatches.AllowUserToDeleteRows = false;
            this.dgvMatches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatches.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvMatches.Location = new System.Drawing.Point(12, 106);
            this.dgvMatches.MultiSelect = false;
            this.dgvMatches.Name = "dgvMatches";
            this.dgvMatches.ReadOnly = true;
            this.dgvMatches.RowHeadersVisible = false;
            this.dgvMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatches.Size = new System.Drawing.Size(766, 277);
            this.dgvMatches.TabIndex = 0;
            this.dgvMatches.DoubleClick += new System.EventHandler(this.dgvMatches_DoubleClick);
            this.dgvMatches.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvMatches_KeyDown);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "HomeTeam";
            this.Column1.HeaderText = "Ev Sahibi";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "AwayTeam";
            this.Column2.HeaderText = "Deplasman";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DateText";
            this.Column3.HeaderText = "Tarih";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "HourText";
            this.Column4.HeaderText = "Saat";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ResultText";
            this.Column5.HeaderText = "Sonuç";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Karşılaşmalar";
            // 
            // btnEditMatch
            // 
            this.btnEditMatch.Location = new System.Drawing.Point(15, 400);
            this.btnEditMatch.Name = "btnEditMatch";
            this.btnEditMatch.Size = new System.Drawing.Size(169, 38);
            this.btnEditMatch.TabIndex = 2;
            this.btnEditMatch.Text = "SEÇİLİYİ DÜZENLE";
            this.btnEditMatch.UseVisualStyleBackColor = true;
            // 
            // btnDeleteMatch
            // 
            this.btnDeleteMatch.Location = new System.Drawing.Point(237, 400);
            this.btnDeleteMatch.Name = "btnDeleteMatch";
            this.btnDeleteMatch.Size = new System.Drawing.Size(147, 38);
            this.btnDeleteMatch.TabIndex = 2;
            this.btnDeleteMatch.Text = "SEÇİLİYİ SİL";
            this.btnDeleteMatch.UseVisualStyleBackColor = true;
            this.btnDeleteMatch.Click += new System.EventHandler(this.btnDeleteMatch_Click);
            // 
            // cbxHidePlayedMatches
            // 
            this.cbxHidePlayedMatches.AutoSize = true;
            this.cbxHidePlayedMatches.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxHidePlayedMatches.Location = new System.Drawing.Point(603, 400);
            this.cbxHidePlayedMatches.Name = "cbxHidePlayedMatches";
            this.cbxHidePlayedMatches.Size = new System.Drawing.Size(175, 21);
            this.cbxHidePlayedMatches.TabIndex = 3;
            this.cbxHidePlayedMatches.Text = "Oynanmış Maçları Gizle";
            this.cbxHidePlayedMatches.UseVisualStyleBackColor = true;
            this.cbxHidePlayedMatches.CheckedChanged += new System.EventHandler(this.cbxHidePlayedMatches_CheckedChanged);
            // 
            // btnNewMatch
            // 
            this.btnNewMatch.BackColor = System.Drawing.Color.Black;
            this.btnNewMatch.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.btnNewMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewMatch.ForeColor = System.Drawing.Color.White;
            this.btnNewMatch.Image = global::FormUI.Properties.Resources.add_16x16;
            this.btnNewMatch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewMatch.Location = new System.Drawing.Point(598, 51);
            this.btnNewMatch.Name = "btnNewMatch";
            this.btnNewMatch.Size = new System.Drawing.Size(180, 41);
            this.btnNewMatch.TabIndex = 2;
            this.btnNewMatch.Text = " YENİ KARŞILAŞMA";
            this.btnNewMatch.UseVisualStyleBackColor = false;
            this.btnNewMatch.Click += new System.EventHandler(this.btnNewMatch_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(36, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(256, 12);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // klcDatePicker1
            // 
            this.klcDatePicker1.CustomFormat = "HH:mm";
            this.klcDatePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.klcDatePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.klcDatePicker1.KLCBorderColor = System.Drawing.Color.PaleVioletRed;
            this.klcDatePicker1.KLCBorderSize = 0;
            this.klcDatePicker1.KLCSkinColor = System.Drawing.Color.MediumSlateBlue;
            this.klcDatePicker1.KLCTextColor = System.Drawing.Color.White;
            this.klcDatePicker1.Location = new System.Drawing.Point(237, 47);
            this.klcDatePicker1.MinimumSize = new System.Drawing.Size(0, 35);
            this.klcDatePicker1.Name = "klcDatePicker1";
            this.klcDatePicker1.ShowUpDown = true;
            this.klcDatePicker1.Size = new System.Drawing.Size(88, 35);
            this.klcDatePicker1.TabIndex = 5;
            // 
            // FrmMatches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.klcDatePicker1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbxHidePlayedMatches);
            this.Controls.Add(this.btnNewMatch);
            this.Controls.Add(this.btnDeleteMatch);
            this.Controls.Add(this.btnEditMatch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMatches);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMatches";
            this.Text = "FrmMatches";
            this.Load += new System.EventHandler(this.FrmMatches_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMatches;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditMatch;
        private System.Windows.Forms.Button btnDeleteMatch;
        private System.Windows.Forms.Button btnNewMatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.CheckBox cbxHidePlayedMatches;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private KLCToolbox.KLCControls.KLCDatePicker klcDatePicker1;
    }
}