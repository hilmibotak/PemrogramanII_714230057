using P10_714230057.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace P10_714230057.controller
{
    internal class Mahasiswa
    {
        Koneksi Koneksi = new Koneksi();
    }

    public bool Insert(M_mahasiswa mahasiswa)
    {
        Boolean status = false;
        try
        {
            koneksi.OpenConnection();
            koneksi.ExecuteQuery("INSERT INTO t_mahasiswa
            (npm, nama, angkatan, alamat, email, nohp) VALUES('" + mahasiswa.Npm + "', '" +
            mahasiswa.Nama + "','" + mahasiswa.Angkatan + "','" + mahasiswa.Alamat +
            "','" + mahasiswa.Email + "','" + mahasiswa.Nohp + "')");
            status = true;
            MessageBox.Show("Data berhasil ditambahkan", "Informasi",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            koneksi.CloseConnection();
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message, "Gagal Insetr", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return status;
    }
}
