using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.DataFormats;


namespace CRUD_PBO_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (this.Text == "Mode Edit" && this.Tag != null)
            {
                int id = Convert.ToInt32(this.Tag);
                using (var conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=hafid123;Database=Perpustakaan_Biasa"))
                {
                    conn.Open();
                    string sql = "SELECT judul, penerbit, tahun_terbit, kategori FROM buku WHERE id = @id";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("id", id);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                tb_judul.Text = reader["judul"].ToString();
                                tb_penerbit.Text = reader["penerbit"].ToString();
                                tb_tahun.Text = reader["tahun_terbit"].ToString();
                                tb_kategori.Text = reader["kategori"].ToString();
                            }
                        }
                    }
                }
            }
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            string judul = tb_judul.Text;
            string penerbit = tb_penerbit.Text;
            string tahun = tb_tahun.Text;
            string kategori = tb_kategori.Text;

            using (NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=hafid123;Database=Perpustakaan_Biasa"))
            {
                conn.Open();

                if (this.Text == "Mode Edit" && this.Tag != null)
                {
                    string id = this.Tag.ToString();
                    string sql = @"UPDATE buku SET judul = @judul, penerbit = @penerbit, tahun_terbit = @tahun, kategori = @kategori WHERE id = @id";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("judul", judul);
                        cmd.Parameters.AddWithValue("penerbit", penerbit);
                        cmd.Parameters.AddWithValue("tahun", int.Parse(tahun));
                        cmd.Parameters.AddWithValue("kategori", kategori);
                        cmd.Parameters.AddWithValue("id", Convert.ToInt32(this.Tag));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data berhasil diperbarui!");
                    }
                }
                else
                {
                    string sql = @"INSERT INTO buku (judul, penerbit, tahun_terbit, kategori) VALUES (@judul, @penerbit, @tahun, @kategori)";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("judul", judul);
                        cmd.Parameters.AddWithValue("penerbit", penerbit);
                        cmd.Parameters.AddWithValue("tahun", int.Parse(tahun));
                        cmd.Parameters.AddWithValue("kategori", kategori);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data berhasil disimpan!");
                    }
                }
            }
        }

        private void btnlihat_Click(object sender, EventArgs e)
        {
            Dash_Data dashdata = new Dash_Data();
            dashdata.Show();
            this.Hide();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            tb_judul.Clear();
            tb_penerbit.Clear();
            tb_tahun.Clear();
            tb_kategori.Clear();
        }


    }
}
