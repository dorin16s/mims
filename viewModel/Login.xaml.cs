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
        public string type;
        public string name;
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
                if (pasbox.Password == "")
                    MessageBox.Show("Enter Password");

                else
                {
                    string[] array = DataQueries.CheckIDPassWord(idbox.Text, pasbox.Password);
                    if (array != null)
                    {
                         type = array[0];
                            name = array[1];
                            OnDataAvailable(null);                 
                    }
                    else
                    {
                        array = DataQueries.CheckIDPassWordDoctor(idbox.Text, pasbox.Password);
                        if (array != null)
                        {
                            type = array[0];
                            name = array[1];
                            OnDataAvailable(null);
                        }

                        else
                            MessageBox.Show("InValid ID or Password");
                    }
                }
        }

     


      
    }
}
