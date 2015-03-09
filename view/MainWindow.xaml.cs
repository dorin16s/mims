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
            disapere();
            load_login();
            Loginwin.DataAvailable += new EventHandler(Login_DataAvailable);
            Docrequest.RequestAvailable += new EventHandler(request_DataAvailable);
            appointmentrequest.appointmentAvailable += new EventHandler(request_DataAvailable);
            cancle.cancletAvailable += new EventHandler(request_DataAvailable);
        }

        void Login_DataAvailable(object sender, EventArgs e)
        {
           
            if(Loginwin.type=="paitent")
           
            load_main_paitent();
            else if (Loginwin.type=="doctor")
                load_main_doctor();
            else if (Loginwin.type == "nurse")
                load_main_doctor();
            else if (Loginwin.type == "secretary")
                load_main_sec();
            else if( Loginwin.type == "manager")
                load_main_man();
            id = Loginwin.idbox.Text;

            
        }

        void request_DataAvailable(object sender, EventArgs e)
        {
            load_main_paitent();
        }

        private void load_main_paitent()
        {
            disapere();
            lbl_hello.Content = "Hello " + Loginwin.type + ": " + Loginwin.name;
            lbl_hello.Visibility = System.Windows.Visibility.Visible;
            btn_appointment.Visibility = System.Windows.Visibility.Visible;
            btn_request.Visibility = System.Windows.Visibility.Visible;
            btn_diconnect.Visibility = System.Windows.Visibility.Visible;
            btn_aWatch_appointment.Visibility = System.Windows.Visibility.Visible;
            btn_aWatch_history.Visibility = System.Windows.Visibility.Visible;
            btn_Buying_Medicine.Visibility = System.Windows.Visibility.Visible;
            btn_Watch_test_result.Visibility = System.Windows.Visibility.Visible;
        }

        private void load_main_doctor()
        {
            disapere();
            lbl_hello.Content = "Hello " + Loginwin.type + ": " + Loginwin.name;
            lbl_hello.Visibility = System.Windows.Visibility.Visible;
            btn_diconnect.Visibility = System.Windows.Visibility.Visible;
            docView1.Visibility = System.Windows.Visibility.Visible;
        }

        private void load_main_sec()
        {
            disapere();
            lbl_hello.Content = "Hello " + Loginwin.type + ": " + Loginwin.name;
            lbl_hello.Visibility = System.Windows.Visibility.Visible;
            btn_diconnect.Visibility = System.Windows.Visibility.Visible;
            sec.Visibility = System.Windows.Visibility.Visible;
        }

        private void load_main_man()
        {
            disapere();
            lbl_hello.Content = "Hello " + Loginwin.type + ": " + Loginwin.name;
            lbl_hello.Visibility = System.Windows.Visibility.Visible;
            btn_diconnect.Visibility = System.Windows.Visibility.Visible;
            manager1.Visibility = System.Windows.Visibility.Visible;
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

        private void Loade_cancle()
        {
            disapere();
            cancle.Visibility = System.Windows.Visibility.Visible;
            cancle.filltable(id);
        }


        private void disapere()
        {
            cancle.Visibility = System.Windows.Visibility.Hidden;
            Docrequest.clear();
            cancle.clear();
            docView1.Visibility = System.Windows.Visibility.Hidden;
            sec.Visibility = System.Windows.Visibility.Hidden;
            manager1.Visibility = System.Windows.Visibility.Hidden;
            btn_appointment.Visibility = System.Windows.Visibility.Hidden;
            btn_request.Visibility = System.Windows.Visibility.Hidden;
            Loginwin.Visibility = System.Windows.Visibility.Hidden;
            Docrequest.Visibility = System.Windows.Visibility.Hidden;
            btn_home.Visibility = System.Windows.Visibility.Hidden;
            btn_diconnect.Visibility = System.Windows.Visibility.Hidden;
            appointmentrequest.Visibility = System.Windows.Visibility.Hidden;
            btn_aWatch_appointment.Visibility = System.Windows.Visibility.Hidden;
            btn_aWatch_history.Visibility = System.Windows.Visibility.Hidden;
            btn_Buying_Medicine.Visibility = System.Windows.Visibility.Hidden;
            btn_Watch_test_result.Visibility = System.Windows.Visibility.Hidden;
            lbl_hello.Visibility = System.Windows.Visibility.Hidden;
            

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


        private void btn_cacncle_Click(object sender, RoutedEventArgs e)
        {
            disapere();
            Loade_cancle();
                btn_diconnect.Visibility = System.Windows.Visibility.Visible;
               if (cancle.number != 0)
                btn_home.Visibility = System.Windows.Visibility.Visible;

        }
   

        private void btn_home_Click(object sender, RoutedEventArgs e)
        {
            disapere();
            if (Loginwin.type == "paitent")
                load_main_paitent();
            else if (Loginwin.type == "doctor")
                load_main_doctor();
            else if (Loginwin.type == "secretary")
                load_main_sec();
            else if(Loginwin.type == "manager")
                load_main_man();
        }

        private void btn_diconnect_Click(object sender, RoutedEventArgs e)
        {
            disapere();
            load_login();
            Loginwin.idbox.Text = "";
            Loginwin.pasbox.Password = "";

        }

        

    }
}
