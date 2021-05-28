using System;
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
    /// Interaction logic for ModifyEmployeePage.xaml
    /// </summary>
    public partial class ModifyEmployeePage : Page
    {
        Object previousContent;
        Employee toView;
        public ModifyEmployeePage(Object _previousContent, Employee _toView)
        {
            InitializeComponent();
            previousContent = _previousContent;
            toView = _toView;
            PopulateData();
        }

        void PopulateData()
        {
            firstNameBlock.Text = toView.FirstName;
            lastNameBlock.Text = toView.LastName;
            listingTypeBlock.Text = toView.Type.ToString();
           
        }

        private void submit(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Content = previousContent;
        }
    }
}

namespace Employee_Manager_App
{
    /// <summary>
    /// Interaction logic for ModifyEmployeePage.xaml
    /// </summary>
    public partial class ModifyEmployeePage : Page
    {
        public ModifyEmployeePage()
        {
            InitializeComponent();
        }
    }
}