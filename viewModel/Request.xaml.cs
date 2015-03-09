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
    /// Interaction logic for Request.xaml
    /// </summary>
    public partial class Request : UserControl
    {
        string id;
        public Request()
        {
            InitializeComponent();
 
        }
        public event EventHandler RequestAvailable;
        protected virtual void OnrequestDataAvailable(EventArgs e)
        {
            EventHandler eh = RequestAvailable;
            if (eh != null)
            {
                eh(this, e);
            }
        }

        
        public void AddFields(string id1)
        {
            FieldList.Items.Clear();
            id = id1;
            DataTable dt = DataQueries.Getfields();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                FieldList.Items.Add(dr["specialization"].ToString());

            }
            Phone_list.Items.Add("050");
            Phone_list.Items.Add("052"); 
            Phone_list.Items.Add("054");
            Phone_list.Items.Add("057");

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

    
        private void FieldList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FieldList.SelectedItem != null)
            {
                
                AddDoctors(FieldList.SelectedItem.ToString());
                clearnofield();
                DocList.Visibility = System.Windows.Visibility.Visible;
                DocLabel.Visibility = System.Windows.Visibility.Visible;
            }
        }

       
        private void DocList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lbl_content.Visibility = System.Windows.Visibility.Visible;
            lbl_Phone.Visibility=System.Windows.Visibility.Visible;
            lbl_Phone.Visibility=System.Windows.Visibility.Visible;
            txt_content.Visibility=System.Windows.Visibility.Visible;
            txt_subject.Visibility=System.Windows.Visibility.Visible;
            Phone_list.Visibility = System.Windows.Visibility.Visible;
            txt_phone.Visibility = System.Windows.Visibility.Visible;
            lbl_Phone.Visibility = System.Windows.Visibility.Visible;
            btn_apply.Visibility = System.Windows.Visibility.Visible;
            lbl_subject.Visibility = System.Windows.Visibility.Visible;
            
        }

        private bool checkValid()
        {

            if (txt_subject.Text == "")
            {
                MessageBox.Show("Fill Subject");
                return false;
            }
            else
                if (txt_content.Text == "")
                {
                    MessageBox.Show("Fill Content");
                    return false;
                }
                else if (Phone_list.SelectedItem == null)
                {
                    MessageBox.Show("Choose area Phone code");
                    return false;
                }
                else
                {
                    int i = txt_phone.Text.Length;
                    if (i != 7)
                    {
                        MessageBox.Show("invalid number");
                        return false;
                    }
                    else
                        for (int j = 0; j < 7; j++)
                        {
                            if (!char.IsDigit(txt_phone.Text[j]))
                            {
                                MessageBox.Show("invalid number");
                                return false;
                            }
                        }
                }
            return true;
        }
        private void btn_apply_Click(object sender, RoutedEventArgs e)
        {
            if (checkValid())
            {
                DataQueries.insertrequest(txt_content.Text, id, txt_subject.Text, DocList.SelectedItem.ToString(), Phone_list.SelectedItem.ToString() + txt_phone.Text);

                MessageBox.Show("Request sent");
                OnrequestDataAvailable(null);
                clear();
            }
        }

        public void clear()
        {
            
            FieldList.SelectedItem = null;
            clearnofield();
           
        }

        private void clearnofield()
        {
            txt_content.Text = "";
            txt_subject.Text = "";
            txt_phone.Text = "";
            txt_phone.Text = "";
            Phone_list.SelectedItem = null;
            DocList.SelectedItem = null;
            DocList.Visibility = System.Windows.Visibility.Hidden;
            DocLabel.Visibility = System.Windows.Visibility.Hidden;
            lbl_content.Visibility = System.Windows.Visibility.Hidden;
            lbl_Phone.Visibility = System.Windows.Visibility.Hidden;
            lbl_Phone.Visibility = System.Windows.Visibility.Hidden;
            txt_content.Visibility = System.Windows.Visibility.Hidden;
            txt_subject.Visibility = System.Windows.Visibility.Hidden;
            Phone_list.Visibility = System.Windows.Visibility.Hidden;
            txt_phone.Visibility = System.Windows.Visibility.Hidden;
            lbl_Phone.Visibility = System.Windows.Visibility.Hidden;
            btn_apply.Visibility = System.Windows.Visibility.Hidden;
            lbl_subject.Visibility = System.Windows.Visibility.Hidden;
        }
      
    }
}
