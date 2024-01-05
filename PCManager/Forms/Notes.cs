using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;
using System.Linq;

namespace PCManager.Forms
{
    public partial class Notes : Form
    {
        string dbPath = @"E:\SQLite\BazyDanych\pcmanager.db";

        public Notes()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            int selectedID = int.Parse(tbID.Text);
            LoadDataFromDB(selectedID);
        }

        private void LoadDataFromDB(int selectedID)
        {
            string connectionString = $"Data Source={dbPath};Version=3;";
            // Próba otwarcia połączenia z bazą danych
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                try
                {
                    Console.WriteLine("Połączenie z bazą danych zostało otwarte.");

                    // Wyciągnij dane z kolumny "content" dla wybranego ID
                    string query = $"SELECT content, addedTime, category FROM notes WHERE ID = {selectedID}";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string content = reader.GetString(0);
                                rtbContent.Text = content;

                                string contentData = reader.GetString(1);
                                tbAddedTime.Text = contentData;

                                int categoryId = Int32.Parse(reader.GetString(2)) - 1;
                                lbCategory.SelectedIndex = categoryId;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Błąd");
                }
            }
        }
        private void LoadDataToListView()
        {
            string connectionString = $"Data Source={dbPath};Version=3;";
            // Próba otwarcia połączenia z bazą danych
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Zapytanie SQL do pobrania danych z tabeli "notes"
                    string query = "SELECT n.ID, addedTime, c.category, content FROM notes n LEFT JOIN category c ON n.category = c.id";

                    // Utwórz adapter danych i DataTable
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();

                        // Wypełnij DataTable danymi z bazy
                        adapter.Fill(dataTable);

                        // Ustaw źródło danych dla DataGridView
                        dgvNotes.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd wczytywania danych: " + ex.Message);
                }
                finally
                {
                    // Zamknij połączenie z bazą danych
                    connection.Close();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            LoadDataToListView();
        }
    }
}
