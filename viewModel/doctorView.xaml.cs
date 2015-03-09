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
    /// Interaction logic for doctorView.xaml
    /// </summary>
    public partial class doctorView : UserControl
    {
        public doctorView()
        {
            InitializeComponent();
            btn_Buying_Medicine.Content = "schedule appointment" + Environment.NewLine + "       for today";
            btn_aWatch_history.Content = "schedule appointment" + Environment.NewLine + "      this week";
        }
    }
}
