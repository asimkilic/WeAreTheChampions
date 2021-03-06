
namespace FormUI.Forms.ColorForms
{
    partial class FrmNewColor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblValidateColors = new System.Windows.Forms.Label();
            this.btnAddNewColor = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtColorName = new System.Windows.Forms.TextBox();
            this.txtBlue = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtGreen = new System.Windows.Forms.TextBox();
            this.panelUnderlineRed = new System.Windows.Forms.Panel();
            this.txtRed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.labelRed = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvColors = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnClose = new KLCToolbox.KLCControls.KLCButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColors)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValidateColors
            // 
            this.lblValidateColors.AutoSize = true;
            this.lblValidateColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblValidateColors.ForeColor = System.Drawing.Color.Red;
            this.lblValidateColors.Location = new System.Drawing.Point(28, 61);
            this.lblValidateColors.Name = "lblValidateColors";
            this.lblValidateColors.Size = new System.Drawing.Size(187, 34);
            this.lblValidateColors.TabIndex = 29;
            this.lblValidateColors.Text = "RGB (0-255) Değeri Giriniz. \r\nRenk Adını Boş Bırakmayın.";
            this.lblValidateColors.Visible = false;
            // 
            // btnAddNewColor
            // 
            this.btnAddNewColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            this.btnAddNewColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddNewColor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddNewColor.Location = new System.Drawing.Point(28, 267);
            this.btnAddNewColor.Name = "btnAddNewColor";
            this.btnAddNewColor.Size = new System.Drawing.Size(168, 38);
            this.btnAddNewColor.TabIndex = 5;
            this.btnAddNewColor.Text = "YENİ RENK EKLE";
            this.btnAddNewColor.UseVisualStyleBackColor = false;
            this.btnAddNewColor.Click += new System.EventHandler(this.btnAddNewColor_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel3.Location = new System.Drawing.Point(96, 235);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(124, 2);
            this.panel3.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel2.Location = new System.Drawing.Point(91, 201);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(45, 2);
            this.panel2.TabIndex = 27;
            // 
            // txtColorName
            // 
            this.txtColorName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtColorName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtColorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtColorName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtColorName.Location = new System.Drawing.Point(96, 214);
            this.txtColorName.Name = "txtColorName";
            this.txtColorName.Size = new System.Drawing.Size(124, 16);
            this.txtColorName.TabIndex = 4;
            // 
            // txtBlue
            // 
            this.txtBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtBlue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBlue.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtBlue.Location = new System.Drawing.Point(91, 180);
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.Size = new System.Drawing.Size(45, 16);
            this.txtBlue.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(91, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(45, 2);
            this.panel1.TabIndex = 23;
            // 
            // txtGreen
            // 
            this.txtGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtGreen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGreen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtGreen.Location = new System.Drawing.Point(91, 144);
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.Size = new System.Drawing.Size(45, 16);
            this.txtGreen.TabIndex = 2;
            // 
            // panelUnderlineRed
            // 
            this.panelUnderlineRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            this.panelUnderlineRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelUnderlineRed.Location = new System.Drawing.Point(91, 128);
            this.panelUnderlineRed.Name = "panelUnderlineRed";
            this.panelUnderlineRed.Size = new System.Drawing.Size(45, 2);
            this.panelUnderlineRed.TabIndex = 21;
            // 
            // txtRed
            // 
            this.txtRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtRed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRed.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtRed.Location = new System.Drawing.Point(91, 107);
            this.txtRed.Name = "txtRed";
            this.txtRed.Size = new System.Drawing.Size(45, 16);
            this.txtRed.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(24, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Renk Adı:";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBlue.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBlue.Location = new System.Drawing.Point(24, 186);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(40, 17);
            this.lblBlue.TabIndex = 17;
            this.lblBlue.Text = "Blue:";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGreen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblGreen.Location = new System.Drawing.Point(24, 147);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(52, 17);
            this.lblGreen.TabIndex = 18;
            this.lblGreen.Text = "Green:";
            // 
            // labelRed
            // 
            this.labelRed.AutoSize = true;
            this.labelRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelRed.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelRed.Location = new System.Drawing.Point(24, 111);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(38, 17);
            this.labelRed.TabIndex = 19;
            this.labelRed.Text = "Red:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(279, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Mevcut Renkler";
            // 
            // dgvColors
            // 
            this.dgvColors.AllowUserToAddRows = false;
            this.dgvColors.AllowUserToDeleteRows = false;
            this.dgvColors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvColors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvColors.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvColors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvColors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvColors.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvColors.Location = new System.Drawing.Point(270, 94);
            this.dgvColors.MultiSelect = false;
            this.dgvColors.Name = "dgvColors";
            this.dgvColors.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvColors.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvColors.RowHeadersVisible = false;
            this.dgvColors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvColors.Size = new System.Drawing.Size(511, 300);
            this.dgvColors.TabIndex = 30;
            this.dgvColors.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvColors_KeyDown);
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
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel5.Controls.Add(this.lblWelcome);
            this.panel5.Controls.Add(this.btnClose);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(794, 47);
            this.panel5.TabIndex = 32;
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
            this.btnClose.Location = new System.Drawing.Point(741, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = " ";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmNewColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(794, 413);
            this.ControlBox = false;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvColors);
            this.Controls.Add(this.lblValidateColors);
            this.Controls.Add(this.btnAddNewColor);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtColorName);
            this.Controls.Add(this.txtBlue);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtGreen);
            this.Controls.Add(this.panelUnderlineRed);
            this.Controls.Add(this.txtRed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.labelRed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNewColor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Renk Ekle";
            this.Load += new System.EventHandler(this.FrmNewColor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColors)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValidateColors;
        private System.Windows.Forms.Button btnAddNewColor;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtColorName;
        private System.Windows.Forms.TextBox txtBlue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtGreen;
        private System.Windows.Forms.Panel panelUnderlineRed;
        private System.Windows.Forms.TextBox txtRed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label labelRed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvColors;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblWelcome;
        private KLCToolbox.KLCControls.KLCButton btnClose;
    }
}