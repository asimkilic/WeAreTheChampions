
namespace FormUI.Forms.PlayerForms
{
    partial class FrmNewPlayer
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
            this.btnAddNewPlayer = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtNewPlayerName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvAllPlayers = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnClose = new KLCToolbox.KLCControls.KLCButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPlayers)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddNewPlayer
            // 
            this.btnAddNewPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            this.btnAddNewPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddNewPlayer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddNewPlayer.Location = new System.Drawing.Point(812, 367);
            this.btnAddNewPlayer.Name = "btnAddNewPlayer";
            this.btnAddNewPlayer.Size = new System.Drawing.Size(93, 38);
            this.btnAddNewPlayer.TabIndex = 19;
            this.btnAddNewPlayer.Text = "EKLE";
            this.btnAddNewPlayer.UseVisualStyleBackColor = false;
            this.btnAddNewPlayer.Click += new System.EventHandler(this.btnAddNewPlayer_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel4.Location = new System.Drawing.Point(756, 167);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(124, 2);
            this.panel4.TabIndex = 18;
            // 
            // txtNewPlayerName
            // 
            this.txtNewPlayerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtNewPlayerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNewPlayerName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNewPlayerName.Location = new System.Drawing.Point(756, 146);
            this.txtNewPlayerName.Name = "txtNewPlayerName";
            this.txtNewPlayerName.Size = new System.Drawing.Size(124, 16);
            this.txtNewPlayerName.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(699, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Yeni Oyuncu Oluştur";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(648, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Oyuncu Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(249, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mevcut Oyuncular";
            // 
            // dgvAllPlayers
            // 
            this.dgvAllPlayers.AllowUserToAddRows = false;
            this.dgvAllPlayers.AllowUserToDeleteRows = false;
            this.dgvAllPlayers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllPlayers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAllPlayers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllPlayers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAllPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column5});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllPlayers.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvAllPlayers.EnableHeadersVisualStyles = false;
            this.dgvAllPlayers.Location = new System.Drawing.Point(39, 89);
            this.dgvAllPlayers.MultiSelect = false;
            this.dgvAllPlayers.Name = "dgvAllPlayers";
            this.dgvAllPlayers.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllPlayers.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvAllPlayers.RowHeadersVisible = false;
            this.dgvAllPlayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllPlayers.Size = new System.Drawing.Size(561, 497);
            this.dgvAllPlayers.TabIndex = 13;
            this.dgvAllPlayers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvAllPlayers_KeyDown);
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "PlayerName";
            this.Column10.HeaderText = "Oyuncu Adı";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Team";
            this.Column5.HeaderText = "Oynadığı Takım";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel5.Controls.Add(this.lblWelcome);
            this.panel5.Controls.Add(this.btnClose);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(939, 47);
            this.panel5.TabIndex = 20;
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
            this.btnClose.Location = new System.Drawing.Point(886, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = " ";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmNewPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(939, 608);
            this.ControlBox = false;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnAddNewPlayer);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtNewPlayerName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvAllPlayers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNewPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNewPlayer";
            this.Load += new System.EventHandler(this.FrmNewPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPlayers)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewPlayer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtNewPlayerName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvAllPlayers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblWelcome;
        private KLCToolbox.KLCControls.KLCButton btnClose;
    }
}