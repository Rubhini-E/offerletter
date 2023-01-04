using System;
using System.Collections.Generic;
using System.Collections.Immutable;
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

namespace offer_letter
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtname.Text = txtname.Text.ToUpper();
            string name= Convert.ToString(txtname.Text) ;
            txtdes.Text = txtdes.Text.ToUpper();
            string designation = Convert.ToString(txtdes.Text);
            int salary = Convert.ToInt32(txtsal.Text);
            string address = Convert.ToString(txtadd.Text);
            string final = "    We look forward to welcoming you on board";

            



            string content1 = string.Format("     Dear {0}" + "\n" +"\n"+ "\n"+ "               We are Pleased to offer you a position of {1} at our company with salary of {2}." + "\n"+"   we feel confidence that you will contribute your skills to growth of our company" + "\n" + "\n"  + "     please confirm your acceptance by signing and returning a copy of this letter", name, designation,salary);

            Window1 msg = new Window1();
            msg.lbladd.Content = address;
            msg.lblcontent.Content = content1;
            msg.lblfinal.Content = final;
            msg.Show();
        }
    }
}
