using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.SqlClient;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cmbCont_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            if(selectedItem.Content.ToString() == "SqlClient")
            {
                string connectionString = tbText.Text;

                using (SqlConnection connection = new SqlConnection())
                {
                   connection.ConnectionString = connectionString;
                    try
                    {
                        connection.Open();
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                           MessageBox.Show($"{connection.State}");

                           MessageBox.Show("Connection properties");
                           MessageBox.Show($"\t connection string {connection.ConnectionString}");

                           MessageBox.Show($"\t data base {connection.Database}");

                           MessageBox.Show($"\t Server {connection.DataSource}");

                           MessageBox.Show($"\t server version {connection.ServerVersion}");
                    }


                }

            }

            if (selectedItem.Content.ToString() == "OleDb")
            {
                string connectionString = tbText.Text;

                using (OleDbConnection connection = new OleDbConnection())
                {
                    connection.ConnectionString = connectionString;
                    try
                    {
                        connection.Open();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        MessageBox.Show($"{connection.State}");

                        MessageBox.Show("Connection properties");
                        MessageBox.Show($"\t connection string {connection.ConnectionString}");

                        MessageBox.Show($"\t data base {connection.Database}");

                        MessageBox.Show($"\t Server {connection.DataSource}");

                       
                    }


                }

            }

            if (selectedItem.Content.ToString() == "Odbc")
            {
                string connectionString = tbText.Text;

                using (OdbcConnection connection = new OdbcConnection())
                {
                    connection.ConnectionString = connectionString;
                    try
                    {
                        connection.Open();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        MessageBox.Show($"{connection.State}");

                        MessageBox.Show("Connection properties");
                        MessageBox.Show($"\t connection string {connection.ConnectionString}");

                        MessageBox.Show($"\t data base {connection.Database}");

                        MessageBox.Show($"\t Server {connection.DataSource}");


                    }


                }

            }

        }


    
    }
}
