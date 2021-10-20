
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.panelMainBackground = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOpenTeams = new KLCToolbox.KLCControls.KLCButton();
            this.btnOpenColors = new KLCToolbox.KLCControls.KLCButton();
            this.btnOpenPlayers = new KLCToolbox.KLCControls.KLCButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).BeginInit();
            this.panelMainBackground.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMatches
            // 
            this.dgvMatches.AllowUserToAddRows = false;
            this.dgvMatches.AllowUserToDeleteRows = false;
            this.dgvMatches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatches.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMatches.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMatches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMatches.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvMatches.EnableHeadersVisualStyles = false;
            this.dgvMatches.Location = new System.Drawing.Point(12, 76);
            this.dgvMatches.MultiSelect = false;
            this.dgvMatches.Name = "dgvMatches";
            this.dgvMatches.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMatches.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvMatches.RowHeadersVisible = false;
            this.dgvMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatches.Size = new System.Drawing.Size(766, 307);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(306, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Karşılaşmalar";
            // 
            // btnEditMatch
            // 
            this.btnEditMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            this.btnEditMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditMatch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditMatch.Location = new System.Drawing.Point(15, 400);
            this.btnEditMatch.Name = "btnEditMatch";
            this.btnEditMatch.Size = new System.Drawing.Size(169, 38);
            this.btnEditMatch.TabIndex = 2;
            this.btnEditMatch.Text = "SEÇİLİYİ DÜZENLE";
            this.btnEditMatch.UseVisualStyleBackColor = false;
            this.btnEditMatch.Click += new System.EventHandler(this.btnEditMatch_Click);
            // 
            // btnDeleteMatch
            // 
            this.btnDeleteMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            this.btnDeleteMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMatch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteMatch.Location = new System.Drawing.Point(237, 400);
            this.btnDeleteMatch.Name = "btnDeleteMatch";
            this.btnDeleteMatch.Size = new System.Drawing.Size(147, 38);
            this.btnDeleteMatch.TabIndex = 2;
            this.btnDeleteMatch.Text = "SEÇİLİYİ SİL";
            this.btnDeleteMatch.UseVisualStyleBackColor = false;
            this.btnDeleteMatch.Click += new System.EventHandler(this.btnDeleteMatch_Click);
            // 
            // cbxHidePlayedMatches
            // 
            this.cbxHidePlayedMatches.AutoSize = true;
            this.cbxHidePlayedMatches.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxHidePlayedMatches.ForeColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.btnNewMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            this.btnNewMatch.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.btnNewMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewMatch.ForeColor = System.Drawing.Color.White;
            this.btnNewMatch.Image = global::FormUI.Properties.Resources.add_16x16;
            this.btnNewMatch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewMatch.Location = new System.Drawing.Point(598, 12);
            this.btnNewMatch.Name = "btnNewMatch";
            this.btnNewMatch.Size = new System.Drawing.Size(180, 41);
            this.btnNewMatch.TabIndex = 2;
            this.btnNewMatch.Text = " YENİ KARŞILAŞMA";
            this.btnNewMatch.UseVisualStyleBackColor = false;
            this.btnNewMatch.Click += new System.EventHandler(this.btnNewMatch_Click);
            // 
            // panelMainBackground
            // 
            this.panelMainBackground.Controls.Add(this.cbxHidePlayedMatches);
            this.panelMainBackground.Controls.Add(this.btnNewMatch);
            this.panelMainBackground.Controls.Add(this.btnDeleteMatch);
            this.panelMainBackground.Controls.Add(this.btnEditMatch);
            this.panelMainBackground.Controls.Add(this.label1);
            this.panelMainBackground.Controls.Add(this.dgvMatches);
            this.panelMainBackground.Location = new System.Drawing.Point(-2, 77);
            this.panelMainBackground.Name = "panelMainBackground";
            this.panelMainBackground.Size = new System.Drawing.Size(807, 465);
            this.panelMainBackground.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOpenPlayers);
            this.panel1.Controls.Add(this.btnOpenColors);
            this.panel1.Controls.Add(this.btnOpenTeams);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 71);
            this.panel1.TabIndex = 5;
            // 
            // btnOpenTeams
            // 
            this.btnOpenTeams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.btnOpenTeams.FlatAppearance.BorderSize = 0;
            this.btnOpenTeams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenTeams.ForeColor = System.Drawing.Color.White;
            this.btnOpenTeams.KLCBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.btnOpenTeams.KLCBorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOpenTeams.KLCBorderRadius = 40;
            this.btnOpenTeams.KLCBorderSize = 0;
            this.btnOpenTeams.KLCTextColor = System.Drawing.Color.White;
            this.btnOpenTeams.Location = new System.Drawing.Point(114, 12);
            this.btnOpenTeams.Name = "btnOpenTeams";
            this.btnOpenTeams.Size = new System.Drawing.Size(150, 40);
            this.btnOpenTeams.TabIndex = 0;
            this.btnOpenTeams.Text = "TAKIMLAR";
            this.btnOpenTeams.UseVisualStyleBackColor = false;
            this.btnOpenTeams.Click += new System.EventHandler(this.btnOpenTeams_Click);
            // 
            // btnOpenColors
            // 
            this.btnOpenColors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.btnOpenColors.FlatAppearance.BorderSize = 0;
            this.btnOpenColors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenColors.ForeColor = System.Drawing.Color.White;
            this.btnOpenColors.KLCBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.btnOpenColors.KLCBorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOpenColors.KLCBorderRadius = 40;
            this.btnOpenColors.KLCBorderSize = 0;
            this.btnOpenColors.KLCTextColor = System.Drawing.Color.White;
            this.btnOpenColors.Location = new System.Drawing.Point(297, 12);
            this.btnOpenColors.Name = "btnOpenColors";
            this.btnOpenColors.Size = new System.Drawing.Size(150, 40);
            this.btnOpenColors.TabIndex = 0;
            this.btnOpenColors.Text = "RENKLER";
            this.btnOpenColors.UseVisualStyleBackColor = false;
            this.btnOpenColors.Click += new System.EventHandler(this.btnOpenColors_Click);
            // 
            // btnOpenPlayers
            // 
            this.btnOpenPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.btnOpenPlayers.FlatAppearance.BorderSize = 0;
            this.btnOpenPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenPlayers.ForeColor = System.Drawing.Color.White;
            this.btnOpenPlayers.KLCBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.btnOpenPlayers.KLCBorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOpenPlayers.KLCBorderRadius = 40;
            this.btnOpenPlayers.KLCBorderSize = 0;
            this.btnOpenPlayers.KLCTextColor = System.Drawing.Color.White;
            this.btnOpenPlayers.Location = new System.Drawing.Point(484, 12);
            this.btnOpenPlayers.Name = "btnOpenPlayers";
            this.btnOpenPlayers.Size = new System.Drawing.Size(150, 40);
            this.btnOpenPlayers.TabIndex = 0;
            this.btnOpenPlayers.Text = "OYUNCULAR";
            this.btnOpenPlayers.UseVisualStyleBackColor = false;
            // 
            // FrmMatches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMainBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMatches";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KARŞILAŞMALAR";
            this.Load += new System.EventHandler(this.FrmMatches_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).EndInit();
            this.panelMainBackground.ResumeLayout(false);
            this.panelMainBackground.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panelMainBackground;
        private System.Windows.Forms.Panel panel1;
        private KLCToolbox.KLCControls.KLCButton btnOpenPlayers;
        private KLCToolbox.KLCControls.KLCButton btnOpenColors;
        private KLCToolbox.KLCControls.KLCButton btnOpenTeams;
    }
}