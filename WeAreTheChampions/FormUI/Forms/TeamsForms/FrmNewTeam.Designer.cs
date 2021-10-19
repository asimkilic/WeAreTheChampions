
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
            this.txtRed = new System.Windows.Forms.TextBox();
            this.panelUnderlineRed = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtGreen = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBlue = new System.Windows.Forms.TextBox();
            this.btnAddNewColor = new System.Windows.Forms.Button();
            this.dgvColors = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtColorName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTeamColors = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lblToolTipColors = new System.Windows.Forms.Label();
            this.lblValidateTeamName = new System.Windows.Forms.Label();
            this.btnNextToPlayers = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblValidateColors = new System.Windows.Forms.Label();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panelColors.Controls.Add(this.lblValidateColors);
            this.panelColors.Controls.Add(this.btnNextToPlayers);
            this.panelColors.Controls.Add(this.dgvTeamColors);
            this.panelColors.Controls.Add(this.label3);
            this.panelColors.Controls.Add(this.label2);
            this.panelColors.Controls.Add(this.dgvColors);
            this.panelColors.Controls.Add(this.btnAddNewColor);
            this.panelColors.Controls.Add(this.panel3);
            this.panelColors.Controls.Add(this.panel2);
            this.panelColors.Controls.Add(this.txtColorName);
            this.panelColors.Controls.Add(this.txtBlue);
            this.panelColors.Controls.Add(this.panel1);
            this.panelColors.Controls.Add(this.txtGreen);
            this.panelColors.Controls.Add(this.panelUnderlineRed);
            this.panelColors.Controls.Add(this.txtRed);
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
            this.labelRed.Location = new System.Drawing.Point(23, 57);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(43, 20);
            this.labelRed.TabIndex = 0;
            this.labelRed.Text = "Red:";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblGreen.Location = new System.Drawing.Point(23, 93);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(58, 20);
            this.lblGreen.TabIndex = 0;
            this.lblGreen.Text = "Green:";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBlue.Location = new System.Drawing.Point(23, 132);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(45, 20);
            this.lblBlue.TabIndex = 0;
            this.lblBlue.Text = "Blue:";
            // 
            // txtRed
            // 
            this.txtRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtRed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRed.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtRed.Location = new System.Drawing.Point(90, 29);
            this.txtRed.Name = "txtRed";
            this.txtRed.Size = new System.Drawing.Size(45, 19);
            this.txtRed.TabIndex = 1;
            this.txtRed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckKeyPress);
            // 
            // panelUnderlineRed
            // 
            this.panelUnderlineRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            this.panelUnderlineRed.Location = new System.Drawing.Point(90, 74);
            this.panelUnderlineRed.Name = "panelUnderlineRed";
            this.panelUnderlineRed.Size = new System.Drawing.Size(45, 2);
            this.panelUnderlineRed.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            this.panel1.Location = new System.Drawing.Point(90, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(45, 2);
            this.panel1.TabIndex = 4;
            // 
            // txtGreen
            // 
            this.txtGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtGreen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGreen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtGreen.Location = new System.Drawing.Point(90, 90);
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.Size = new System.Drawing.Size(45, 19);
            this.txtGreen.TabIndex = 3;
            this.txtGreen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckKeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            this.panel2.Location = new System.Drawing.Point(90, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(45, 2);
            this.panel2.TabIndex = 6;
            // 
            // txtBlue
            // 
            this.txtBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtBlue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBlue.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtBlue.Location = new System.Drawing.Point(90, 126);
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.Size = new System.Drawing.Size(45, 19);
            this.txtBlue.TabIndex = 5;
            this.txtBlue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckKeyPress);
            // 
            // btnAddNewColor
            // 
            this.btnAddNewColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            this.btnAddNewColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddNewColor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddNewColor.Location = new System.Drawing.Point(27, 213);
            this.btnAddNewColor.Name = "btnAddNewColor";
            this.btnAddNewColor.Size = new System.Drawing.Size(168, 38);
            this.btnAddNewColor.TabIndex = 8;
            this.btnAddNewColor.Text = "YENİ RENK EKLE";
            this.btnAddNewColor.UseVisualStyleBackColor = false;
            this.btnAddNewColor.Click += new System.EventHandler(this.btnAddNewColor_Click);
            // 
            // dgvColors
            // 
            this.dgvColors.AllowUserToAddRows = false;
            this.dgvColors.AllowUserToDeleteRows = false;
            this.dgvColors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvColors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvColors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvColors.Location = new System.Drawing.Point(305, 44);
            this.dgvColors.MultiSelect = false;
            this.dgvColors.Name = "dgvColors";
            this.dgvColors.ReadOnly = true;
            this.dgvColors.RowHeadersVisible = false;
            this.dgvColors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvColors.Size = new System.Drawing.Size(511, 151);
            this.dgvColors.TabIndex = 9;
            this.dgvColors.DoubleClick += new System.EventHandler(this.dgvColors_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(23, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Renk Adı:";
            // 
            // txtColorName
            // 
            this.txtColorName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtColorName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtColorName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtColorName.Location = new System.Drawing.Point(107, 165);
            this.txtColorName.Name = "txtColorName";
            this.txtColorName.Size = new System.Drawing.Size(124, 19);
            this.txtColorName.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            this.panel3.Location = new System.Drawing.Point(107, 186);
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
            this.dgvTeamColors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeamColors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTeamColors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeamColors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvTeamColors.Location = new System.Drawing.Point(305, 252);
            this.dgvTeamColors.MultiSelect = false;
            this.dgvTeamColors.Name = "dgvTeamColors";
            this.dgvTeamColors.ReadOnly = true;
            this.dgvTeamColors.RowHeadersVisible = false;
            this.dgvTeamColors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeamColors.Size = new System.Drawing.Size(511, 122);
            this.dgvTeamColors.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(314, 224);
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
            this.lblToolTipColors.Location = new System.Drawing.Point(49, 572);
            this.lblToolTipColors.Name = "lblToolTipColors";
            this.lblToolTipColors.Size = new System.Drawing.Size(801, 17);
            this.lblToolTipColors.TabIndex = 12;
            this.lblToolTipColors.Text = "ToolTip: Mevcut renkler bölümündeki renklere çift tıklayıp takımınıza atama yapab" +
    "ilir, DELETE tuşu ile atamayı geri alabilirsiniz.";
            this.lblToolTipColors.Visible = false;
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
            // Column1
            // 
            this.Column1.DataPropertyName = "ColorName";
            this.Column1.HeaderText = "Renk Adı";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Red";
            this.Column2.HeaderText = "Kırmızı";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Green";
            this.Column3.HeaderText = "Yeşil";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Blue";
            this.Column4.HeaderText = "Mavi";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // lblValidateColors
            // 
            this.lblValidateColors.AutoSize = true;
            this.lblValidateColors.ForeColor = System.Drawing.Color.Red;
            this.lblValidateColors.Location = new System.Drawing.Point(27, 7);
            this.lblValidateColors.Name = "lblValidateColors";
            this.lblValidateColors.Size = new System.Drawing.Size(207, 40);
            this.lblValidateColors.TabIndex = 15;
            this.lblValidateColors.Text = "RGB (0-255) Değeri Giriniz. \r\nRenk Adını Boş Bırakmayın.";
            this.lblValidateColors.Visible = false;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Color";
            this.Column9.HeaderText = "Renk Adı";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ColorName";
            this.Column5.HeaderText = "Renk Adı";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Red";
            this.Column6.HeaderText = "Kırmızı";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Green";
            this.Column7.HeaderText = "Yeşil";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Blue";
            this.Column8.HeaderText = "Mavi";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // FrmNewTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(976, 608);
            this.Controls.Add(this.panelColors);
            this.Controls.Add(this.lblToolTipColors);
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
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox txtBlue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtGreen;
        private System.Windows.Forms.Panel panelUnderlineRed;
        private System.Windows.Forms.TextBox txtRed;
        private System.Windows.Forms.Label lblToolTipColors;
        private System.Windows.Forms.DataGridView dgvTeamColors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddNewColor;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtColorName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValidateTeamName;
        private System.Windows.Forms.Button btnNextToPlayers;
        private System.Windows.Forms.DataGridView dgvColors;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lblValidateColors;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}