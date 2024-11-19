namespace P7_1_714230057
{
    partial class Form1
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
            this.txtNama = new System.Windows.Forms.Label();
            this.txtAngkatan = new System.Windows.Forms.Label();
            this.txtKelas = new System.Windows.Forms.Label();
            this.textBoxKelas = new System.Windows.Forms.TextBox();
            this.comboBoxAngkatan = new System.Windows.Forms.ComboBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.buttonCek = new System.Windows.Forms.Button();
            this.buttonTutup = new System.Windows.Forms.Button();
            this.radioButtonWeekDay = new System.Windows.Forms.RadioButton();
            this.radioButtonWeekEnd = new System.Windows.Forms.RadioButton();
            this.checkBoxKuliah = new System.Windows.Forms.CheckBox();
            this.checkBoxTidur = new System.Windows.Forms.CheckBox();
            this.checkBoxLiburan = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCetak = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNama
            // 
            this.txtNama.AutoSize = true;
            this.txtNama.Location = new System.Drawing.Point(37, 35);
            this.txtNama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(35, 13);
            this.txtNama.TabIndex = 0;
            this.txtNama.Text = "Nama";
            // 
            // txtAngkatan
            // 
            this.txtAngkatan.AutoSize = true;
            this.txtAngkatan.Location = new System.Drawing.Point(37, 62);
            this.txtAngkatan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtAngkatan.Name = "txtAngkatan";
            this.txtAngkatan.Size = new System.Drawing.Size(53, 13);
            this.txtAngkatan.TabIndex = 1;
            this.txtAngkatan.Text = "Angkatan";
            // 
            // txtKelas
            // 
            this.txtKelas.AutoSize = true;
            this.txtKelas.Location = new System.Drawing.Point(37, 96);
            this.txtKelas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtKelas.Name = "txtKelas";
            this.txtKelas.Size = new System.Drawing.Size(33, 13);
            this.txtKelas.TabIndex = 2;
            this.txtKelas.Text = "Kelas";
            // 
            // textBoxKelas
            // 
            this.textBoxKelas.Location = new System.Drawing.Point(103, 94);
            this.textBoxKelas.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKelas.Multiline = true;
            this.textBoxKelas.Name = "textBoxKelas";
            this.textBoxKelas.Size = new System.Drawing.Size(157, 51);
            this.textBoxKelas.TabIndex = 5;
            // 
            // comboBoxAngkatan
            // 
            this.comboBoxAngkatan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAngkatan.FormattingEnabled = true;
            this.comboBoxAngkatan.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024"});
            this.comboBoxAngkatan.Location = new System.Drawing.Point(103, 62);
            this.comboBoxAngkatan.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxAngkatan.Name = "comboBoxAngkatan";
            this.comboBoxAngkatan.Size = new System.Drawing.Size(157, 21);
            this.comboBoxAngkatan.TabIndex = 4;
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(103, 35);
            this.textBoxNama.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(157, 20);
            this.textBoxNama.TabIndex = 3;
            // 
            // buttonCek
            // 
            this.buttonCek.Location = new System.Drawing.Point(103, 157);
            this.buttonCek.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCek.Name = "buttonCek";
            this.buttonCek.Size = new System.Drawing.Size(59, 22);
            this.buttonCek.TabIndex = 6;
            this.buttonCek.Text = "Cek";
            this.buttonCek.UseVisualStyleBackColor = true;
            this.buttonCek.Click += new System.EventHandler(this.buttonCek_Click);
            // 
            // buttonTutup
            // 
            this.buttonTutup.Location = new System.Drawing.Point(199, 157);
            this.buttonTutup.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTutup.Name = "buttonTutup";
            this.buttonTutup.Size = new System.Drawing.Size(59, 23);
            this.buttonTutup.TabIndex = 7;
            this.buttonTutup.Text = "Tutup";
            this.buttonTutup.UseVisualStyleBackColor = true;
            this.buttonTutup.Click += new System.EventHandler(this.buttonTutup_Click);
            // 
            // radioButtonWeekDay
            // 
            this.radioButtonWeekDay.AutoSize = true;
            this.radioButtonWeekDay.Location = new System.Drawing.Point(20, 227);
            this.radioButtonWeekDay.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonWeekDay.Name = "radioButtonWeekDay";
            this.radioButtonWeekDay.Size = new System.Drawing.Size(89, 17);
            this.radioButtonWeekDay.TabIndex = 9;
            this.radioButtonWeekDay.TabStop = true;
            this.radioButtonWeekDay.Text = "Senin - Jumat";
            this.radioButtonWeekDay.UseVisualStyleBackColor = true;
            this.radioButtonWeekDay.CheckedChanged += new System.EventHandler(this.radioButtonWeekDay_CheckedChanged);
            // 
            // radioButtonWeekEnd
            // 
            this.radioButtonWeekEnd.AutoSize = true;
            this.radioButtonWeekEnd.Location = new System.Drawing.Point(20, 247);
            this.radioButtonWeekEnd.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonWeekEnd.Name = "radioButtonWeekEnd";
            this.radioButtonWeekEnd.Size = new System.Drawing.Size(97, 17);
            this.radioButtonWeekEnd.TabIndex = 10;
            this.radioButtonWeekEnd.TabStop = true;
            this.radioButtonWeekEnd.Text = "Sabtu - Minggu";
            this.radioButtonWeekEnd.UseVisualStyleBackColor = true;
            this.radioButtonWeekEnd.CheckedChanged += new System.EventHandler(this.radioButtonWeekEnd_CheckedChanged);
            // 
            // checkBoxKuliah
            // 
            this.checkBoxKuliah.AutoSize = true;
            this.checkBoxKuliah.Location = new System.Drawing.Point(20, 283);
            this.checkBoxKuliah.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxKuliah.Name = "checkBoxKuliah";
            this.checkBoxKuliah.Size = new System.Drawing.Size(55, 17);
            this.checkBoxKuliah.TabIndex = 11;
            this.checkBoxKuliah.Text = "Kuliah";
            this.checkBoxKuliah.UseVisualStyleBackColor = true;
            // 
            // checkBoxTidur
            // 
            this.checkBoxTidur.AutoSize = true;
            this.checkBoxTidur.Location = new System.Drawing.Point(20, 306);
            this.checkBoxTidur.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxTidur.Name = "checkBoxTidur";
            this.checkBoxTidur.Size = new System.Drawing.Size(50, 17);
            this.checkBoxTidur.TabIndex = 12;
            this.checkBoxTidur.Text = "Tidur";
            this.checkBoxTidur.UseVisualStyleBackColor = true;
            // 
            // checkBoxLiburan
            // 
            this.checkBoxLiburan.AutoSize = true;
            this.checkBoxLiburan.Location = new System.Drawing.Point(20, 329);
            this.checkBoxLiburan.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxLiburan.Name = "checkBoxLiburan";
            this.checkBoxLiburan.Size = new System.Drawing.Size(61, 17);
            this.checkBoxLiburan.TabIndex = 13;
            this.checkBoxLiburan.Text = "Liburan";
            this.checkBoxLiburan.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(110, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kegiatan";
            // 
            // buttonCetak
            // 
            this.buttonCetak.Location = new System.Drawing.Point(103, 342);
            this.buttonCetak.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCetak.Name = "buttonCetak";
            this.buttonCetak.Size = new System.Drawing.Size(59, 22);
            this.buttonCetak.TabIndex = 14;
            this.buttonCetak.Text = "Cetak";
            this.buttonCetak.UseVisualStyleBackColor = true;
            this.buttonCetak.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(199, 342);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(59, 22);
            this.buttonReset.TabIndex = 15;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 375);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonCetak);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBoxLiburan);
            this.Controls.Add(this.checkBoxTidur);
            this.Controls.Add(this.checkBoxKuliah);
            this.Controls.Add(this.radioButtonWeekEnd);
            this.Controls.Add(this.radioButtonWeekDay);
            this.Controls.Add(this.buttonTutup);
            this.Controls.Add(this.buttonCek);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.comboBoxAngkatan);
            this.Controls.Add(this.textBoxKelas);
            this.Controls.Add(this.txtKelas);
            this.Controls.Add(this.txtAngkatan);
            this.Controls.Add(this.txtNama);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "78";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNama;
        private System.Windows.Forms.Label txtAngkatan;
        private System.Windows.Forms.Label txtKelas;
        private System.Windows.Forms.TextBox textBoxKelas;
        private System.Windows.Forms.ComboBox comboBoxAngkatan;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Button buttonCek;
        private System.Windows.Forms.Button buttonTutup;
        private System.Windows.Forms.RadioButton radioButtonWeekDay;
        private System.Windows.Forms.RadioButton radioButtonWeekEnd;
        private System.Windows.Forms.CheckBox checkBoxKuliah;
        private System.Windows.Forms.CheckBox checkBoxTidur;
        private System.Windows.Forms.CheckBox checkBoxLiburan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCetak;
        private System.Windows.Forms.Button buttonReset;
    }
}

