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
    /// Interaction logic for CancleAppointment.xaml
    /// </summary>
    public partial class CancleAppointment : UserControl
    {
        private string id;
        public int number;
        public CancleAppointment()
        {
            InitializeComponent();
           
        }

        public event EventHandler cancletAvailable;
        protected virtual void OncancleDataAvailable(EventArgs e)
        {
            EventHandler eh = cancletAvailable;
            if (eh != null)
            {
                eh(this, e);
            }
        }

        public void filltable(string id1)
        {
            clear();
            DataTable dt = DataQueries.Getappointment(id1);

            number=dt.Rows.Count;
            if (number == 0)
            {
                MessageBox.Show("you don't have any appointments");
                OncancleDataAvailable(null);

            }
                id = id1;
                table.DataContext = dt;
                btn_cancle.Visibility = System.Windows.Visibility.Visible;
            
        }

     
        private void btn_cancle_Click(object sender, RoutedEventArgs e)
        {
            if (table.SelectedItem == null)
                MessageBox.Show("no appointement was choosen");
            else
            {
                System.Windows.Forms.DialogResult dialogResult = System.Windows.Forms.MessageBox.Show("Are you sure?", "Delete Confirmation", System.Windows.Forms.MessageBoxButtons.YesNo);

                if (dialogResult == System.Windows.Forms.DialogResult.Yes)  // error is here
                {
                    System.Data.DataRowView selectedrow = (System.Data.DataRowView)table.SelectedItems[0];
                    string docname= selectedrow[0].ToString();
                    string day = selectedrow[1].ToString();
                    string hour = selectedrow[2].ToString();
                    string clinic = selectedrow[3].ToString();
                    DataQueries.deleteappointment(id, docname, day, hour, clinic);
                    MessageBox.Show("Appointment was canceled");
                    OncancleDataAvailable(null);

                }
                else
                {
                    System.Windows.MessageBox.Show("Delete operation Terminated");
                }
            }
        }

        public void clear()
        {
            table.DataContext = null;
            btn_cancle.Visibility = System.Windows.Visibility.Hidden;
        }
    }
}
