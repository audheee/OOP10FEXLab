using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FuegoOrderingSystem
{
    public partial class KioskForm : Form
    {
        private readonly string connStr = "server=172.16.24.11;port=3306;database=fastfooddb;uid=root;pwd=1234;";

        public KioskForm()
        {
            InitializeComponent();
        }

        private void KioskForm_Load(object sender, EventArgs e)
        {
            LoadPackages();
            LoadMenuImages();
        }

        private void LoadMenuImages()
        {
            string basePath = System.IO.Path.Combine(Application.StartupPath, "Images");
            try { pbItem1.ImageLocation = System.IO.Path.Combine(basePath, "WINGS.jpg"); } catch {}
            try { pbItem2.ImageLocation = System.IO.Path.Combine(basePath, "HUNGARIANSAUSAGE.jpg"); } catch {}
            try { pbItem3.ImageLocation = System.IO.Path.Combine(basePath, "PADKRAPAO.jpg"); } catch {}
            try { pbItem4.ImageLocation = System.IO.Path.Combine(basePath, "PORKRIBS.jpg"); } catch {}
            try { pbItem5.ImageLocation = System.IO.Path.Combine(basePath, "PORKBBQ.jpg"); } catch {}
        }

        private void LoadPackages()
        {
            try
            {
                using (var conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "SELECT package_name FROM package_tbl";
                    using (var cmd = new MySqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        cboPackage.Items.Clear();
                        while (reader.Read())
                        {
                            cboPackage.Items.Add(reader.GetString("package_name"));
                        }
                    }
                }
                if (cboPackage.Items.Count > 0)
                    cboPackage.SelectedIndex = 0;
            }
            catch (MySqlException)
            {
                // Silent catch so the UI remains usable even if the DB is unreachable during testing
            }
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            string itemName = "";
            if (sender == pbItem1 || sender == lblItem1) itemName = "Smoked BBQ Wings";
            else if (sender == pbItem2 || sender == lblItem2) itemName = "Hungarian Sausage";
            else if (sender == pbItem3 || sender == lblItem3) itemName = "Pad Krapao BBQ";
            else if (sender == pbItem4 || sender == lblItem4) itemName = "Low & Slow Pork Ribs";
            else if (sender == pbItem5 || sender == lblItem5) itemName = "Pork BBQ Skewers";
            
            if (!string.IsNullOrEmpty(itemName))
            {
                lstOrder.Items.Add(itemName);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboPackage.SelectedItem == null) return;
            lstOrder.Items.Add(cboPackage.SelectedItem.ToString());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lstOrder.Items.Count == 0) return;

            try
            {
                using (var conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        string sql = "INSERT INTO transactions_tbl (package_name, transaction_date) VALUES (@pkg, @date)";
                        foreach (var item in lstOrder.Items)
                        {
                            using (var cmd = new MySqlCommand(sql, conn, tran))
                            {
                                cmd.Parameters.AddWithValue("@pkg", item.ToString());
                                cmd.Parameters.AddWithValue("@date", DateTime.Now);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        tran.Commit();
                    }
                }
                MessageBox.Show("Saved " + lstOrder.Items.Count + " item(s).");
                lstOrder.Items.Clear();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }
    }
}
