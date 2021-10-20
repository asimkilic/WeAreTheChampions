
namespace FormUI.Forms.MatchForms
{
    partial class FrmMatchEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dtpHour = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtScoreHome = new System.Windows.Forms.TextBox();
            this.txtScoreAway = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.lblAway = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tarih";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(127, 63);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(119, 23);
            this.dtpDate.TabIndex = 3;
            // 
            // dtpHour
            // 
            this.dtpHour.CustomFormat = "HH:mm";
            this.dtpHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpHour.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHour.Location = new System.Drawing.Point(127, 108);
            this.dtpHour.Name = "dtpHour";
            this.dtpHour.ShowUpDown = true;
            this.dtpHour.Size = new System.Drawing.Size(92, 23);
            this.dtpHour.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(19, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Saat";
            // 
            // txtScoreHome
            // 
            this.txtScoreHome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtScoreHome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtScoreHome.Location = new System.Drawing.Point(274, 19);
            this.txtScoreHome.Name = "txtScoreHome";
            this.txtScoreHome.Size = new System.Drawing.Size(50, 13);
            this.txtScoreHome.TabIndex = 1;
            this.txtScoreHome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtScoreHome_KeyPress);
            // 
            // txtScoreAway
            // 
            this.txtScoreAway.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtScoreAway.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtScoreAway.Location = new System.Drawing.Point(377, 19);
            this.txtScoreAway.Name = "txtScoreAway";
            this.txtScoreAway.Size = new System.Drawing.Size(50, 13);
            this.txtScoreAway.TabIndex = 2;
            this.txtScoreAway.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtScoreAway_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(343, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "vs";
            // 
            // lblHome
            // 
            this.lblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHome.Location = new System.Drawing.Point(15, 20);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(250, 17);
            this.lblHome.TabIndex = 6;
            this.lblHome.Text = "ÖZNUR KABLO YENİ MALATYASPOR";
            this.lblHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAway
            // 
            this.lblAway.AutoSize = true;
            this.lblAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAway.Location = new System.Drawing.Point(441, 20);
            this.lblAway.Name = "lblAway";
            this.lblAway.Size = new System.Drawing.Size(132, 17);
            this.lblAway.TabIndex = 6;
            this.lblAway.Text = "Aytemiz Alanyaspor";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(537, 123);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 43);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "İPTAL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(640, 123);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 43);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "KAYDET";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            this.panel1.Location = new System.Drawing.Point(274, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 2);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(124)))), ((int)(((byte)(105)))));
            this.panel2.Location = new System.Drawing.Point(377, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(50, 2);
            this.panel2.TabIndex = 7;
            // 
            // FrmMatchEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(762, 181);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblAway);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.txtScoreAway);
            this.Controls.Add(this.txtScoreHome);
            this.Controls.Add(this.dtpHour);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmMatchEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Galatasaray vs Aytemiz Alanyaspor";
            this.Load += new System.EventHandler(this.FrmMatchEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dtpHour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtScoreHome;
        private System.Windows.Forms.TextBox txtScoreAway;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label lblAway;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}