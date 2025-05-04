using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_PBO_1
{
    public partial class Dash_Data : Form
    {
        public Dash_Data()
        {
            InitializeComponent();

            NpgsqlConnection conn = new NpgsqlConnection("Host = localhost; Username=postgres; Password=hafid123; Database=Perpustakaan_Biasa");
            conn.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "SELECT id, judul, penerbit, tahun_terbit, kategori FROM buku;";

            NpgsqlDataReader read = comm.ExecuteReader();
            DataTable data = new DataTable();
            data.Load(read);
            dataGridView1.DataSource = data;

            conn.Close();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            var caution = MessageBox.Show("Anda Yakin Ingin Menghapus Data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (caution == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Pilih Baris Yang Ingin Dihapus.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                else
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    int deleteindex = Convert.ToInt32(selectedRow.Cells["id"].Value);

                    NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=hafid123;Database=Perpustakaan_Biasa");
                    {
                        conn.Open();
                        string query = "DELETE FROM buku WHERE id = @id";
                        using (var cmd = new NpgsqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("id", deleteindex);
                            int affectedRows = cmd.ExecuteNonQuery();

                            MessageBox.Show("Data berhasil dihapus.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataGridView1.Rows.Remove(selectedRow);
                        }
                    }
                }
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih Salah Satu Baris Untuk Mengubah Data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var warn = MessageBox.Show("Yakin Ingin Merubah Data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (warn == DialogResult.Yes)
            {
                var row = dataGridView1.SelectedRows[0];

                int id = Convert.ToInt32(row.Cells["id"].Value);

                Form1 ubahForm = new Form1();
                ubahForm.Tag = id;
                ubahForm.Text = "Mode Edit"; // pakai judul form sebagai penanda mode

                ubahForm.Show();
                this.Hide();
            }
        }

        private void btnkembali_Click(object sender, EventArgs e)
        {
            Form1 formUtama = new Form1();
            formUtama.Show();
            this.Hide();
        }

        private void btnkeluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
