using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace Automated_Entrance_Exam.Pages.Main
{
    /// <summary>
    /// Interaction logic for Examinees.xaml
    /// </summary>
    public partial class Examinees : Page
    {
        private string connectionString = "Server=localhost;Database=automated_entrance_exam;Uid=root;Pwd=;";
        private string dbQuery;

        public Examinees()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            db_DisplayExaminees();
        }

        private void db_DisplayExaminees()
        {
            MySqlConnection dbConnection = new MySqlConnection(connectionString); ;
            dbQuery = "SELECT last_name AS 'Last Name', first_name AS 'First Name', examinee_number AS 'Examinee Number', previous_school AS 'Previous School', year_graduated 'Year Graduated', status AS 'Status' FROM examinees";

            MySqlCommand dbCommand = new MySqlCommand(dbQuery, dbConnection);

            dbConnection.ConnectionString = connectionString;

            dbConnection.Open();

            MySqlDataReader dbDataReader = dbCommand.ExecuteReader();

            dgv_Examinees.ItemsSource = dbDataReader;
        }
    }
}
