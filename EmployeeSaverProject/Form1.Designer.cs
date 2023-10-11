namespace EmployeeSaverProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lvEmployee = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            btnChoosePicture = new Button();
            dtpWorkStart = new DateTimePicker();
            dtpBirthDate = new DateTimePicker();
            rtxtAddress = new RichTextBox();
            mtxtPhone = new MaskedTextBox();
            txtEmail = new TextBox();
            txtSurname = new TextBox();
            txtName = new TextBox();
            txtEmpId = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lvEmployee
            // 
            lvEmployee.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            lvEmployee.FullRowSelect = true;
            lvEmployee.GridLines = true;
            lvEmployee.Location = new Point(37, 323);
            lvEmployee.Name = "lvEmployee";
            lvEmployee.Size = new Size(847, 270);
            lvEmployee.TabIndex = 11;
            lvEmployee.UseCompatibleStateImageBehavior = false;
            lvEmployee.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Personel ID";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ad";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Soyad";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Doğum Tarihi";
            columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Telefon";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Email";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Resim Yolu";
            columnHeader7.Width = 150;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(btnChoosePicture);
            groupBox1.Controls.Add(dtpWorkStart);
            groupBox1.Controls.Add(dtpBirthDate);
            groupBox1.Controls.Add(rtxtAddress);
            groupBox1.Controls.Add(mtxtPhone);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtSurname);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtEmpId);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(37, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(847, 299);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personel Bilgileri";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(461, 154);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(704, 254);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(108, 27);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(704, 220);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(108, 27);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(704, 187);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(108, 27);
            btnSave.TabIndex = 17;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnChoosePicture
            // 
            btnChoosePicture.Location = new Point(704, 154);
            btnChoosePicture.Name = "btnChoosePicture";
            btnChoosePicture.Size = new Size(108, 27);
            btnChoosePicture.TabIndex = 16;
            btnChoosePicture.Text = "Resim Seç";
            btnChoosePicture.UseVisualStyleBackColor = true;
            // 
            // dtpWorkStart
            // 
            dtpWorkStart.Location = new Point(645, 115);
            dtpWorkStart.Name = "dtpWorkStart";
            dtpWorkStart.Size = new Size(167, 27);
            dtpWorkStart.TabIndex = 15;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(163, 149);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(167, 27);
            dtpBirthDate.TabIndex = 14;
            // 
            // rtxtAddress
            // 
            rtxtAddress.Location = new Point(645, 16);
            rtxtAddress.Name = "rtxtAddress";
            rtxtAddress.Size = new Size(167, 81);
            rtxtAddress.TabIndex = 13;
            rtxtAddress.Text = "";
            // 
            // mtxtPhone
            // 
            mtxtPhone.Location = new Point(163, 188);
            mtxtPhone.Mask = "(999) 000-0000";
            mtxtPhone.Name = "mtxtPhone";
            mtxtPhone.Size = new Size(167, 27);
            mtxtPhone.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(163, 233);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(167, 27);
            txtEmail.TabIndex = 11;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(163, 112);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(167, 27);
            txtSurname.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.Location = new Point(163, 70);
            txtName.Name = "txtName";
            txtName.Size = new Size(167, 27);
            txtName.TabIndex = 9;
            // 
            // txtEmpId
            // 
            txtEmpId.Location = new Point(163, 31);
            txtEmpId.Name = "txtEmpId";
            txtEmpId.Size = new Size(167, 27);
            txtEmpId.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(461, 115);
            label8.Name = "label8";
            label8.Size = new Size(99, 20);
            label8.TabIndex = 7;
            label8.Text = "İşe Giriş Tarihi";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(461, 16);
            label7.Name = "label7";
            label7.Size = new Size(47, 20);
            label7.TabIndex = 6;
            label7.Text = "Adres";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 236);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 5;
            label6.Text = "E-Mail";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 191);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 4;
            label5.Text = "Telefon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 154);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 3;
            label4.Text = "Doğum Tarihi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 115);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "Soyad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 73);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 1;
            label2.Text = "Ad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "Personel ID";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 608);
            Controls.Add(lvEmployee);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Çalışan Kaydetme Programı";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListView lvEmployee;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
        private Button btnChoosePicture;
        private DateTimePicker dtpWorkStart;
        private DateTimePicker dtpBirthDate;
        private RichTextBox rtxtAddress;
        private MaskedTextBox mtxtPhone;
        private TextBox txtEmail;
        private TextBox txtSurname;
        private TextBox txtName;
        private TextBox txtEmpId;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}