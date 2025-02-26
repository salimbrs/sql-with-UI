using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace part1
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=studentınformation;Uid=root;Pwd=salim1990;");
        public Form1()
        {
            InitializeComponent();
        }

        private void ViewGrid_bt_Click(object sender, EventArgs e)  // view butonu
        {

            ViewDataGrid();

        }

        private void ViewDataGrid()
        {


            try
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM student", con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Insert_bt_Click(object sender, EventArgs e)
        {

            try
            {
                string query = "INSERT INTO student (RegNo, student, adress) VALUES (@RegNo, @Student, @Adress)";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@RegNo", RegNo_tx.Text);
                cmd.Parameters.AddWithValue("@Student", Name_tx.Text);
                cmd.Parameters.AddWithValue("@Adress", Adress_tx.Text);

                con.Open();  // Bağlantıyı aç
                cmd.ExecuteNonQuery();  // SQL komutunu çalıştır
                ViewDataGrid();
                ClearTextBox();
                con.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Kayıt eklenirken hata oluştu: " + ex.Message);
            }
        }

        void ClearTextBox()
        {
            RegNo_tx.Text = "";
            Name_tx.Text = "";
            // or use this one
            Adress_tx.Clear();
        }

        private void update_bt_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen güncellenecek bir satır seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int selectedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

                string query = "UPDATE student SET student = @Student, adress = @Adress, RegNo = @RegNo WHERE id = @id"; // updated acording to id
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", selectedId);
                cmd.Parameters.AddWithValue("@RegNo", RegNo_tx.Text);   
                cmd.Parameters.AddWithValue("@Student", Name_tx.Text);
                cmd.Parameters.AddWithValue("@Adress", Adress_tx.Text);

                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Kayıt başarıyla güncellendi!");
                    ViewDataGrid();
                    ClearTextBox();
                }
                else
                {
                    MessageBox.Show("Güncellenecek kayıt bulunamadı!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0) // Satır seçilmiş mi kontrol et
                {
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                    string query = "DELETE FROM student WHERE id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        con.Open();
                        int result = cmd.ExecuteNonQuery();
                        con.Close();

                        if (result > 0)
                        {
                            MessageBox.Show("✅ Kayıt başarıyla silindi!");
                            ViewDataGrid(); // Silme işleminden sonra tabloyu yenile
                        }
                        else
                        {
                            MessageBox.Show("⚠️ Kayıt bulunamadı!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("⚠️ Lütfen silmek için bir satır seçin!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Hata: " + ex.Message, "Silme Başarısız");
            }
        }

    }
}
