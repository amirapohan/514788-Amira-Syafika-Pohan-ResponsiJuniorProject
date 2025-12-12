using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace ResponsiJunpro
{
    public partial class Form1 : Form
    {
        private string connString = "Host=localhost;Port=5433;Username=amira1;Password=amira23;Database=ResponsiDB";
        private string selectedDevID = "";  // untuk update/delete

        public Form1()
        {
            InitializeComponent();
        }

        // ===== LOAD FORM =====
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProyek();
            LoadStatusKontak();
            LoadDataGrid();
        }

        // ==== LOAD COMBOBOX PROYEK ====
        private void LoadProyek()
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT id_proyek, nama_proyek FROM proyek";
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        cbProyek.Items.Add(new
                        {
                            Text = rd["nama_proyek"].ToString(),
                            Value = rd["id_proyek"].ToString()
                        });
                    }
                }
            }
            cbProyek.DisplayMember = "Text";
            cbProyek.ValueMember = "Value";
        }

        // ==== LOAD ENUM STATUS KONTRAK ====
        private void LoadStatusKontak()
        {
            cbKontak.Items.Add("freelance");
            cbKontak.Items.Add("fulltime");
        }

        // ==== LOAD DATA KE DATAGRIDVIEW ====
        private void LoadDataGrid()
        {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                string query = @"SELECT 
                                    d.id_dev,
                                    d.nama_dev,
                                    d.status_kontak,
                                    p.nama_proyek,
                                    d.fitur_selesai,
                                    d.jumlah_bug
                                 FROM developer d
                                 JOIN proyek p ON d.id_proyek = p.id_proyek
                                 ORDER BY d.id_dev ASC";

                using (var da = new NpgsqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }

            dataGridView1.Columns["id_dev"].Visible = false;  // disembunyikan
        }

        // ===== INSERT DATA =====
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (tbNameDev.Text == "" || cbProyek.SelectedItem == null || cbKontak.SelectedItem == null ||
                tbFitur.Text == "" || tbBug.Text == "")
            {
                MessageBox.Show("Semua field harus diisi!");
                return;
            }

            var proyek = cbProyek.SelectedItem as dynamic;

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = @"SELECT insert_developer(@p_id, @p_nama, @p_status, @p_fitur, @p_bug)";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@p_id", proyek.Value);
                    cmd.Parameters.AddWithValue("@p_nama", tbNameDev.Text);
                    cmd.Parameters.AddWithValue("@p_status", cbKontak.Text);
                    cmd.Parameters.AddWithValue("@p_fitur", tbFitur.Text);
                    cmd.Parameters.AddWithValue("@p_bug", tbBug.Text);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Data berhasil ditambahkan!");
            LoadDataGrid();
            ClearForm();
        }

        // ==== CLICK DATAGRID ====
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            selectedDevID = row.Cells["id_dev"].Value.ToString();
            tbNameDev.Text = row.Cells["nama_dev"].Value.ToString();
            cbKontak.Text = row.Cells["status_kontak"].Value.ToString();
            tbFitur.Text = row.Cells["fitur_selesai"].Value.ToString();
            tbBug.Text = row.Cells["jumlah_bug"].Value.ToString();

            cbProyek.Text = row.Cells["nama_proyek"].Value.ToString();
        }

        // ===== UPDATE DATA =====
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedDevID == "")
            {
                MessageBox.Show("Pilih data yang akan diupdate!");
                return;
            }

            var proyek = cbProyek.SelectedItem as dynamic;

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = @"SELECT update_developer(
                                    @id, @p_id, @p_nama, @p_status, @p_fitur, @p_bug
                                )";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", selectedDevID);
                    cmd.Parameters.AddWithValue("@p_id", proyek.Value);
                    cmd.Parameters.AddWithValue("@p_nama", tbNameDev.Text);
                    cmd.Parameters.AddWithValue("@p_status", cbKontak.Text);
                    cmd.Parameters.AddWithValue("@p_fitur", tbFitur.Text);
                    cmd.Parameters.AddWithValue("@p_bug", tbBug.Text);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Data berhasil diupdate!");
            LoadDataGrid();
            ClearForm();
        }

        // ===== DELETE DATA =====
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedDevID == "")
            {
                MessageBox.Show("Pilih data yang akan dihapus!");
                return;
            }

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = @"SELECT delete_developer(@id)";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", selectedDevID);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Data berhasil dihapus!");
            LoadDataGrid();
            ClearForm();
        }

        // ==== CLEAR FORM ====
        private void ClearForm()
        {
            tbNameDev.Clear();
            cbProyek.SelectedIndex = -1;
            cbKontak.SelectedIndex = -1;
            tbFitur.Clear();
            tbBug.Clear();
            selectedDevID = "";
        }

        // ===== EVENT DUMMY (dari designer, biarkan kosong) =====
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
    }
}
