using System.Windows;
using System.Windows.Controls;
using MySql.Data.MySqlClient;

namespace Automated_Entrance_Exam.Pages.Main
{
    /// <summary>
    /// Interaction logic for Overview.xaml
    /// </summary>
    public partial class Overview : Page
    {
        private string connectionString = "Server=localhost;Database=automated_entrance_exam;Uid=root;Pwd=;";
        private string dbQuery;

        public Overview()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            db_DisplayTotalExaminees();
            db_DisplayPassed();
            db_DisplayFailed();
            db_DisplayMostPreferredCourse();
            db_DisplayPreferredCourses();
            db_DisplayGraduatedSchools();
        }

        private void db_DisplayTotalExaminees()
        {
            MySqlConnection dbConnection = new MySqlConnection(connectionString);

            dbQuery = "SELECT COUNT(verification_code) FROM examinees";
            MySqlCommand dbCommand = new MySqlCommand(dbQuery, dbConnection);

            try
            {
                dbConnection.Open();
                MySqlDataReader dbDataReader = dbCommand.ExecuteReader();

                if (dbDataReader.Read() == true)
                {
                    lbl_TotalExaminees.Text = dbDataReader.GetValue(0).ToString();

                    dbConnection.Close();
                }

                else
                {
                    dbConnection.Close();
                }
            }

            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                dbConnection.Close();
            }

            finally
            {
                dbConnection.Close();
            }
        }

        private void db_DisplayPassed()
        {
            MySqlConnection dbConnection = new MySqlConnection(connectionString);

            dbQuery = "SELECT COUNT(status) FROM examinees WHERE status = 'Passed'";
            MySqlCommand dbCommand = new MySqlCommand(dbQuery, dbConnection);

            try
            {
                dbConnection.Open();
                MySqlDataReader dbDataReader = dbCommand.ExecuteReader();

                if (dbDataReader.Read() == true)
                {
                    lbl_Passed.Text = dbDataReader.GetValue(0).ToString();

                    dbConnection.Close();
                }

                else
                {
                    dbConnection.Close();
                }
            }

            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                dbConnection.Close();
            }

            finally
            {
                dbConnection.Close();
            }
        }

        private void db_DisplayFailed()
        {
            MySqlConnection dbConnection = new MySqlConnection(connectionString);

            dbQuery = "SELECT COUNT(status) FROM examinees WHERE status = 'Failed'";
            MySqlCommand dbCommand = new MySqlCommand(dbQuery, dbConnection);

            try
            {
                dbConnection.Open();
                MySqlDataReader dbDataReader = dbCommand.ExecuteReader();

                if (dbDataReader.Read() == true)
                {
                    lbl_Failed.Text = dbDataReader.GetValue(0).ToString();

                    dbConnection.Close();
                }

                else
                {
                    dbConnection.Close();
                }
            }

            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                dbConnection.Close();
            }

            finally
            {
                dbConnection.Close();
            }
        }

        private void db_DisplayMostPreferredCourse()
        {
            MySqlConnection dbConnection = new MySqlConnection(connectionString);

            dbQuery = "SELECT MAX(course)FROM preferred_courses";
            MySqlCommand dbCommand = new MySqlCommand(dbQuery, dbConnection);

            try
            {
                dbConnection.Open();
                MySqlDataReader dbDataReader = dbCommand.ExecuteReader();

                if (dbDataReader.Read() == true)
                {
                    lbl_MostPreferredCourse.Text = dbDataReader.GetValue(0).ToString();

                    dbConnection.Close();
                }

                else
                {
                    dbConnection.Close();
                }
            }

            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                dbConnection.Close();
            }

            finally
            {
                dbConnection.Close();
            }
        }

        private void db_DisplayPreferredCourses()
        {
            MySqlConnection dbConnection = new MySqlConnection(connectionString); ;
            dbQuery = "SELECT course AS 'Course', COUNT(examinee_number) AS 'Examinees' FROM preferred_courses GROUP BY course ORDER BY `Examinees` DESC";

            MySqlCommand dbCommand = new MySqlCommand(dbQuery, dbConnection);

            dbConnection.ConnectionString = connectionString;

            dbConnection.Open();

            MySqlDataReader dbDataReader = dbCommand.ExecuteReader();

            dgv_PreferredCourses.ItemsSource = dbDataReader;
        }

        private void db_DisplayGraduatedSchools()
        {
            MySqlConnection dbConnection = new MySqlConnection(connectionString); ;
            dbQuery = "SELECT DISTINCT examinees.previous_school AS 'Graduated Schools', examinees.year_graduated AS 'Graduation Year' FROM examinees";

            MySqlCommand dbCommand = new MySqlCommand(dbQuery, dbConnection);

            dbConnection.ConnectionString = connectionString;

            dbConnection.Open();

            MySqlDataReader dbDataReader = dbCommand.ExecuteReader();

            dgv_GraduatedSchools.ItemsSource = dbDataReader;
        }
    }
}
