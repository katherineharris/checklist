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

namespace MYCHECKLIST
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

        private void btnWORK_Click(object sender, RoutedEventArgs e)
        {
            if(chkdriving.IsChecked==true)
            {
                results.Items.Add("thx for not backseat driving luv") ;
            }
            else
            {
                MessageBox.Show("BACKSEAT DRIVER");
               
            }
            if (chkFUNNY.IsChecked == true)
            {
                results.Items.Add("thx for bein funny");
            }
            else
            {
                MessageBox.Show("boring and not funny");
            }
            if (chkHOT.IsChecked == true)
            {
                results.Items.Add("ur so hot");
            }
            else
            {
                MessageBox.Show("not hot ur cold");
            }
            if (chkLEAVEMEALONE.IsChecked == true)
            {
                results.Items.Add("luv u 4 leaving me b");
            }
            else
            {
                MessageBox.Show("leave me alone");
            }
            if (chkLOREN.IsChecked == true)
            {
                results.Items.Add("loren approved");
            }
            else
            {
                MessageBox.Show("loren said no");
            }
            if (chkCHEETOS.IsChecked == true)
            {
                results.Items.Add("luv u more than hot cheetos");
            }
            else
            {
                MessageBox.Show("no cheetos no luv");
            }
        }
    }
}
