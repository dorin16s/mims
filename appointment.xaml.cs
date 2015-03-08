using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for appointment.xaml
    /// </summary>
    public partial class appointment : UserControl
    {
        string id;
        public appointment()
        {
            InitializeComponent();
        }

        public event EventHandler appointmentAvailable;
        protected virtual void OnappointmnenttDataAvailable(EventArgs e)
        {
            EventHandler eh = appointmentAvailable;
            if (eh != null)
            {
                eh(this, e);
            }
        }

        public void AddFields(string id1)
        {
            disappeardoctor();
            FieldList.Items.Clear();
            id = id1;
            DataTable dt = DataQueries.Getfields();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                FieldList.Items.Add(dr["specialization"].ToString());

            }
        }

        private void AddDoctors(string field)
        {
            DocList.Items.Clear();
            DataTable dt = DataQueries.GetDoctors(field);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                DocList.Items.Add(dr["name"].ToString());

            }
        }

        private void AddClinic()
        {
            list_Clinic.Items.Clear();
            DataTable dt = DataQueries.GetClinic(DocList.SelectedValue.ToString());

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                list_Clinic.Items.Add(dr["clinic"].ToString());

            }
        }
        private void Addhour()
        {
            list_hour.Items.Clear();
            DataTable dt = DataQueries.Gethours(DocList.SelectedValue.ToString(), list_day.SelectedValue.ToString());

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                list_hour.Items.Add(dr["hour"].ToString());

            }
        }
     

        private void Addday()
        {
            list_day.Items.Clear();
            DataTable dt = DataQueries.Getday(DocList.SelectedValue.ToString(), list_Clinic.SelectedValue.ToString());

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                list_day.Items.Add(dr["day"].ToString());

            }
        }



        private void FieldList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FieldList.SelectedItem != null)
            {
                disappeardoctor();
                AddDoctors(FieldList.SelectedItem.ToString());
                DocList.Visibility = System.Windows.Visibility.Visible;
                DocLabel.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void DocList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DocList.SelectedItem != null)
            {
                disappearClinic();
                lbl_Clinic.Visibility = System.Windows.Visibility.Visible;
                list_Clinic.Visibility = System.Windows.Visibility.Visible;
                AddClinic();
            }

        }

        private void list_day_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (list_day.SelectedItem != null)
            {
                disappearhour();
                lbl_hour.Visibility = System.Windows.Visibility.Visible;
                list_hour.Visibility = System.Windows.Visibility.Visible;
                Addhour();

            }
        }

        private void list_Clinic_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (list_Clinic.SelectedItem != null)
            {
                disappearday();
                lbl_day.Visibility = System.Windows.Visibility.Visible;
                list_day.Visibility = System.Windows.Visibility.Visible;
                Addday();
            }
        }


        private void disappearbtn()
        {
            btn_schedule.Visibility = System.Windows.Visibility.Hidden;
        }

        private void disappearhour()
        {
            disappearbtn();
            list_hour.SelectedValue=null;
            list_hour.Visibility = System.Windows.Visibility.Hidden;
            lbl_hour.Visibility = System.Windows.Visibility.Hidden;
            btn_schedule.Visibility= System.Windows.Visibility.Hidden;
        }

        private void disappearday()
        {
            disappearhour();
            list_day.SelectedValue = null;
            list_day.Visibility = System.Windows.Visibility.Hidden;
            lbl_day.Visibility = System.Windows.Visibility.Hidden;
        }

        private void disappearClinic()
        {
            disappearday();
            list_Clinic.SelectedValue = null;
            list_Clinic.Visibility = System.Windows.Visibility.Hidden;
            lbl_Clinic.Visibility = System.Windows.Visibility.Hidden;
        }

        private void disappeardoctor()
        {
            disappearClinic();
            DocList.SelectedValue = null;
            DocList.Visibility = System.Windows.Visibility.Hidden;
            DocLabel.Visibility = System.Windows.Visibility.Hidden;
        }

        private void list_hour_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btn_schedule.Visibility = System.Windows.Visibility.Visible;
        }

        private void btn_schedule_Click(object sender, RoutedEventArgs e)
        {
            DataQueries.insertappointment(id, DocList.SelectedValue.ToString(), list_day.SelectedValue.ToString(), list_hour.SelectedValue.ToString(), list_Clinic.SelectedValue.ToString());

            MessageBox.Show("Schedule Appointment success");
            OnappointmnenttDataAvailable(null);
          
        }
    }
}
