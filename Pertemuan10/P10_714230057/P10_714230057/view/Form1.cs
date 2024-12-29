﻿using P10_714230057.controler;
using P10_714230057.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P10_714230057
{
    public partial class Form1 : Form
    {
        Koneksi koneksi = new Koneksi();
        M_mahasiswa m_mhs = new M_mahasiswa();

        public void Tampil()
        {
            DataMahasiswa.DataSource = koneksi.ShowData("SELECT * FROM t_mahasiswa");
        }

        public void ResetForm()
        {
            textBoxNPM.Text = "";
            textBoxNama.Text = "";
            comboBoxAngkatan.SelectedIndex = -1;
            textBoxAlamat.Text = "";
            textBoxEmail.Text = "";
            textBoxNoHP.Text = "";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tampil();
            DataMahasiswa.Columns[0].HeaderText = "NPM";
            DataMahasiswa.Columns[1].HeaderText = "Nama";
            DataMahasiswa.Columns[2].HeaderText = "Angkatan";
            DataMahasiswa.Columns[3].HeaderText = "Alamat";
            DataMahasiswa.Columns[4].HeaderText = "Email";
            DataMahasiswa.Columns[5].HeaderText = "No Hp";
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (textBoxNPM.Text == "" || textBoxNama.Text == "" ||
                comboBoxAngkatan.SelectedIndex == -1 || textBoxAlamat.Text == "" ||
                textBoxEmail.Text == "" || textBoxNoHP.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Mahasiswa mhs = new Mahasiswa();
                m_mhs.Npm = textBoxNPM.Text;
                m_mhs.Nama = textBoxNama.Text;
                m_mhs.Angkatan = comboBoxAngkatan.Text;
                m_mhs.Alamat = textBoxAlamat.Text;
                m_mhs.Email = textBoxEmail.Text;
                m_mhs.Nohp = textBoxNoHP.Text;

                mhs.Insert(m_mhs);

                ResetForm();
                Tampil();
            }
        }

        private void DataMahasiswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxNPM.Text = DataMahasiswa.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxNama.Text = DataMahasiswa.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBoxAngkatan.Text = DataMahasiswa.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxAlamat.Text = DataMahasiswa.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxEmail.Text = DataMahasiswa.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxNoHP.Text = DataMahasiswa.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (textBoxNPM.Text == "" || textBoxNama.Text == "" ||
                comboBoxAngkatan.SelectedIndex == -1 || textBoxAlamat.Text == "" ||
                textBoxEmail.Text == "" || textBoxNoHP.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Mahasiswa mhs = new Mahasiswa();
                m_mhs.Npm = textBoxNPM.Text;
                m_mhs.Nama = textBoxNama.Text;
                m_mhs.Angkatan = comboBoxAngkatan.Text;
                m_mhs.Alamat = textBoxAlamat.Text;
                m_mhs.Email = textBoxEmail.Text;
                m_mhs.Nohp = textBoxNoHP.Text;

                mhs.Update(m_mhs, m_mhs.Npm);

                ResetForm();
                Tampil();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show(
                "Apakah yakin akan menghaous data ini?", 
                "Perhatian", 
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (pesan == DialogResult.Yes)
            {
                Mahasiswa mhs = new Mahasiswa();
                mhs.Delete(textBoxNPM.Text);
                ResetForm();
                Tampil();
            }
        }
    }
}
