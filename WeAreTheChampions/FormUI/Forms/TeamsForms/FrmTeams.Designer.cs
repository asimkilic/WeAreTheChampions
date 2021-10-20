
namespace FormUI.Forms.TeamsForms
{
    partial class FrmTeams
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
            this.dgvTeams = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPlayers = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewTeam = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTeams
            // 
            this.dgvTeams.AllowUserToAddRows = false;
            this.dgvTeams.AllowUserToDeleteRows = false;
            this.dgvTeams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeams.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvTeams.Location = new System.Drawing.Point(12, 53);
            this.dgvTeams.MultiSelect = false;
            this.dgvTeams.Name = "dgvTeams";
            this.dgvTeams.ReadOnly = true;
            this.dgvTeams.RowHeadersVisible = false;
            this.dgvTeams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeams.Size = new System.Drawing.Size(301, 521);
            this.dgvTeams.TabIndex = 0;
            this.dgvTeams.SelectionChanged += new System.EventHandler(this.dgvTeams_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TeamName";
            this.Column1.HeaderText = "Takım Adı";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(97, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "TAKIMLAR";
            // 
            // dgvPlayers
            // 
            this.dgvPlayers.AllowUserToAddRows = false;
            this.dgvPlayers.AllowUserToDeleteRows = false;
            this.dgvPlayers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlayers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            this.dgvPlayers.Location = new System.Drawing.Point(396, 53);
            this.dgvPlayers.MultiSelect = false;
            this.dgvPlayers.Name = "dgvPlayers";
            this.dgvPlayers.ReadOnly = true;
            this.dgvPlayers.RowHeadersVisible = false;
            this.dgvPlayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlayers.Size = new System.Drawing.Size(307, 521);
            this.dgvPlayers.TabIndex = 2;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "PlayerName";
            this.Column2.HeaderText = "Oyuncu Adı";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(408, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "OYUNCULAR";
            // 
            // btnNewTeam
            // 
            this.btnNewTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnNewTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            this.btnNewTeam.Image = global::FormUI.Properties.Resources.add_16x16;
            this.btnNewTeam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewTeam.Location = new System.Drawing.Point(765, 53);
            this.btnNewTeam.Name = "btnNewTeam";
            this.btnNewTeam.Size = new System.Drawing.Size(182, 52);
            this.btnNewTeam.TabIndex = 3;
            this.btnNewTeam.Text = "YENİ TAKIM EKLE";
            this.btnNewTeam.UseVisualStyleBackColor = false;
            this.btnNewTeam.Click += new System.EventHandler(this.btnNewTeam_Click);
            // 
            // FrmTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1005, 742);
            this.Controls.Add(this.btnNewTeam);
            this.Controls.Add(this.dgvPlayers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTeams);
            this.Name = "FrmTeams";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TAKIMLAR";
            this.Load += new System.EventHandler(this.FrmTeams_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTeams;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPlayers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNewTeam;
    }
}