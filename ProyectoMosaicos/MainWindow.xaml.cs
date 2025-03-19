using System.Windows;
using MySql.Data.MySqlClient;
using ProyectoMosaicos.Models;

namespace ProyectoMosaicos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string connectionString = "Server=localhost;Database=mosaicos;Uid=root;";

        public MainWindow()
        {
            InitializeComponent();
            getPaletsCombobox();
        }

        private void getPaletsCombobox() {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Realizamos la consulta
                string query = "SELECT * FROM palet";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Guardamos los palets
                var listaPalets = new List<Pale>();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Pale item = new Pale
                    {
                        Id = reader.GetInt32(0),
                        Tipo = reader.GetString(1),
                        Ancho = reader.GetInt32(2),
                        Alto = reader.GetInt32(3)
                    };

                    listaPalets.Add(item);
                    cbPalet.Items.Add(item.Tipo);
                }

                conn.Close();
            }
        }

    }
}
