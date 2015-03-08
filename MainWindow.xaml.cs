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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string id;
        public MainWindow()
        {
            InitializeComponent();
            Loginwin.DataAvailable += new EventHandler(Login_DataAvailable);
            Docrequest.RequestAvailable += new EventHandler(request_DataAvailable);
            appointmentrequest.appointmentAvailable += new EventHandler(request_DataAvailable);
        }

        void Login_DataAvailable(object sender, EventArgs e)
        {
            load_main();
            id = Loginwin.idbox.Text;
            
        }

        void request_DataAvailable(object sender, EventArgs e)
        {
            load_main();
        }

        private void load_main()
        {
            disapere();
            btn_appointment.Visibility = System.Windows.Visibility.Visible;
            btn_request.Visibility = System.Windows.Visibility.Visible;
            btn_diconnect.Visibility = System.Windows.Visibility.Visible;
        }

        private void load_login()
        {
            disapere();
            Loginwin.Visibility = System.Windows.Visibility.Visible;
        }

        private void load_request()
        {
            disapere();
            Docrequest.Visibility = System.Windows.Visibility.Visible;
            Docrequest.AddFields(id);
        }

        private void load_appointment()
        {
            disapere();
            appointmentrequest.Visibility = System.Windows.Visibility.Visible;
            appointmentrequest.AddFields(id);
        }


        private void disapere()
        {
            Docrequest.clear();
            btn_appointment.Visibility = System.Windows.Visibility.Hidden;
            btn_request.Visibility = System.Windows.Visibility.Hidden;
            Loginwin.Visibility = System.Windows.Visibility.Hidden;
            Docrequest.Visibility = System.Windows.Visibility.Hidden;
            btn_home.Visibility = System.Windows.Visibility.Hidden;
            btn_diconnect.Visibility = System.Windows.Visibility.Hidden;
            appointmentrequest.Visibility = System.Windows.Visibility.Hidden;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            disapere();
            load_request();
            btn_diconnect.Visibility= System.Windows.Visibility.Visible;
            btn_home.Visibility = System.Windows.Visibility.Visible;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            disapere();
            load_appointment();
            btn_diconnect.Visibility = System.Windows.Visibility.Visible;
            btn_home.Visibility = System.Windows.Visibility.Visible;
        }

   

        private void btn_home_Click(object sender, RoutedEventArgs e)
        {
            disapere();
            load_main();
        }

        private void btn_diconnect_Click(object sender, RoutedEventArgs e)
        {
            disapere();
            load_login();
            Loginwin.idbox.Text = "";
            Loginwin.pasbox.Text = "";

        }

        

    }
}
