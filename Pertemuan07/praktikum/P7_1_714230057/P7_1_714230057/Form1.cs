using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P7_1_714230057
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Size = new Size(327, 224);
        }

        private void buttonCek_Click(object sender, EventArgs e)
        {
            StringBuilder errorMsg = new StringBuilder();

            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                errorMsg.Append("Nama harus diisi");
            }

            if (comboBoxAngkatan.SelectedIndex == -1)
            {
                errorMsg.Append("Angkatan harus diisi");
            }

            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                errorMsg.Append("Kelas harus diisi");
            }

            string errorMessage = errorMsg.ToString();

            if (string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(
                "Lengkap!!",
                "Impormasi Data Submit",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                Size = new Size(327, 414);
            }
            else
            {
                MessageBox.Show(
                errorMessage.Trim(),
                "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }

        private void buttonTutup_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButtonWeekDay_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonWeekDay.Checked)
            {
                checkBoxKuliah.Enabled = true;checkBoxKuliah.Checked = false;
                checkBoxTidur.Enabled = true; checkBoxTidur.Checked = false;
                checkBoxLiburan.Enabled = false; checkBoxLiburan.Checked = false;
            }
        }

        private void radioButtonWeekEnd_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonWeekEnd.Checked)
            {
                checkBoxKuliah.Enabled = false; checkBoxKuliah.Checked = false;
                checkBoxTidur.Enabled = true; checkBoxTidur.Checked = false;
                checkBoxLiburan.Enabled = true; checkBoxLiburan.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string hari = null;
            //string kegiatan = null;

            //foreach (Control control in Controls)
            //{
            //    if (control is RadioButton radioButton && radioButton.Checked)
            //    {
            //        hari = radioButton.Text;
            //        break;
            //    }
            //}

            //foreach (Control control in Controls)
            //{
            //    if (control is CheckBox checkBox && checkBox.Checked)
            //    {
            //        if (!string.IsNullOrEmpty()kegiatan)
            //                   {
            //            kegiatan += ", ";
            //        }
            //        kegiatan += checkBox.Checked.Text;
            //    }
            //}

            string hari = Controls.OfType<RadioButton>()
     .          FirstOrDefault(r => r.Checked)?.Text;

            string kegiatan = string.Join(", ",
                Controls.OfType<CheckBox>()
                .Where(cb => cb.Checked)
                .Select(cb => cb.Text));

            MessageBox.Show(
            "Nama: " + textBoxNama.Text + "\n" +
            "Angkatan: " + comboBoxAngkatan.Text + "\n" +
            "Kelas: " + textBoxKelas.Text + "\n" +
            "===================================\n" + 
            "Hari: " + hari + "\n" +
            "kegiatan:  " + kegiatan + "\n",
            "Informasi Data Submit",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            txtNama.Text = "";
            comboBoxAngkatan.SelectedIndex = -1;
            txtKelas.Text = "";
            radioButtonWeekDay.Checked = false;
            radioButtonWeekEnd.Checked = false;
            checkBoxKuliah.Checked = false;
            checkBoxTidur.Checked = false;
            checkBoxLiburan.Checked = false;

            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                    textBox.Text = "";
                else if (control is ComboBox comboBox)
                    comboBox.SelectedIndex = -1;
                else if (control is RadioButton radioButton)
                    radioButton.Checked = false;
                else if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                    checkBox.Enabled = true;
                }
                   
            }

            Size = new Size(327, 224);
            MessageBox.Show(
            "Data berhasil di reset",
            "Reset",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
