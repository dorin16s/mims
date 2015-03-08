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

namespace MIMS
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : UserControl
    {

        public event EventHandler DataAvailable;
        protected virtual void OnDataAvailable(EventArgs e)
        {
            EventHandler eh = DataAvailable;
            if (eh != null)
            {
                eh(this, e);
            }
        }
        public Login()
        {
            InitializeComponent();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (idbox.Text == "")
                MessageBox.Show("Enter ID");
            else
                if (pasbox.Text == "")
                    MessageBox.Show("Enter Password");

                else
                    if (DataQueries.CheckIDPassWord(idbox.Text, pasbox.Text))
                        OnDataAvailable(null);
                    else
                        MessageBox.Show("InValid ID or Password");
        }

     


      
    }
}
