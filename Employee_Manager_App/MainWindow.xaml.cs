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

namespace Employee_Manager_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            employeeGrid.ItemsSource = EmployeeManager.entries;
            listingTypeBox.ItemsSource = (typeof(EmployeeType)).GetEnumValues();
        }
        void RefreshDataGrid()
        {
            employeeGrid.ItemsSource = null;
            employeeGrid.ItemsSource = EmployeeManager.entries;
        }
        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            if (listingTypeBox.SelectedItem != null)
            {
                EmployeeManager.entries.Add(new Employee(lastNameBox.Text, firstNameBox.Text, (EmployeeType)listingTypeBox.SelectedItem));
                MessageBox.Show("Employee added successfully");
                RefreshDataGrid();
            }
            else
                MessageBox.Show(" Select a Employee Type");

        }

        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            bool successFulRemove = EmployeeManager.entries.Remove((Employee)employeeGrid.SelectedItem);
            if (successFulRemove)
                MessageBox.Show("employee removed ");
            else
                MessageBox.Show("Please Select Employe From List");
            RefreshDataGrid();
        }

        private void modifyButton_Click(object sender, RoutedEventArgs e)
        {
            if (employeeGrid.SelectedItem != null)
                this.Content = new ModifyEmployeePage(this.Content, (Employee)employeeGrid.SelectedItem);
            else
                MessageBox.Show("You must select a employee in order to modify the employee detail");

        }

    }
}
