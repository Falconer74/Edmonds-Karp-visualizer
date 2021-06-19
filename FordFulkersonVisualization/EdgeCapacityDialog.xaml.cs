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
using System.Windows.Shapes;

namespace FordFulkersonVisualization
{
    /// <summary>
    /// Interaction logic for EdgeCapacityDialog.xaml
    /// </summary>
    public partial class EdgeCapacityDialog : Window
    {
        public EdgeCapacityDialog()
        {
            InitializeComponent();
        }

        public string ResponseText
        {
            get { return CapacityTextBox.Text; }
            set { CapacityTextBox.Text = value; }
        }

        private void CapacityTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                DialogResult = true;
            }
        }
    }
}
