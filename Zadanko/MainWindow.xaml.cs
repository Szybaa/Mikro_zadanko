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

namespace Zadanko
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
        
       private void axt_TextChanged(object sender, TextChangedEventArgs e)
        {
            //string ax = axt.Text.ToString();
        }

        private void bxt_TextChanged(object sender, TextChangedEventArgs e)
        {
           //string bx = bxt.Text.ToString();
        }

        private void cxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            //string cx = cxt.Text.ToString();
        }

        private void dxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            //string dx = dxt.Text.ToString();
        }


        private void XCHG_Click(object sender, RoutedEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(axt.Text, @"\A\b[0-9a-fA-F]+\b\Z"))
            {
                MessageBox.Show("Value provided at field AX isn't hex");
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(bxt.Text, @"\A\b[0-9a-fA-F]+\b\Z"))
            {
                MessageBox.Show("Value provided at field BX isn't hex");
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(cxt.Text, @"\A\b[0-9a-fA-F]+\b\Z"))
            {
                MessageBox.Show("Value provided at field CX isn't hex");
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(dxt.Text, @"\A\b[0-9a-fA-F]+\b\Z"))
            {
                MessageBox.Show("Value provided at field DX isn't hex");
                return;
            }
            string ax = axt.Text.ToString();
            string bx = bxt.Text.ToString();
            string cx = cxt.Text.ToString();
            string dx = dxt.Text.ToString();
            string temp;

            if (axf.IsChecked == true)
            {
                if (axto.IsChecked == true)
                {
                    axt.Text = ax;
                }
                if (bxto.IsChecked == true)
                {
                    
                    temp = axt.Text;
                    axt.Text = bx;
                    bxt.Text= temp;

                    

                }
                if (cxto.IsChecked == true)
                {                  
                    temp = axt.Text;
                    axt.Text = cx;
                    cxt.Text = temp;
                }
                if (dxto.IsChecked == true)
                {
                    temp = axt.Text;
                    axt.Text = dx;
                    dxt.Text = temp;
                }
            }
            if (bxf.IsChecked == true)
            {
                if (axto.IsChecked == true)
                {
                    temp = bxt.Text;
                    bxt.Text = ax;
                    axt.Text = temp;
                }
                if (bxto.IsChecked == true)
                {
                    bxt.Text = bx;
                }
                if (cxto.IsChecked == true)
                {
                    temp = bxt.Text;
                    bxt.Text = cx;
                    cxt.Text = temp;
                }
                if (dxto.IsChecked == true)
                {
                    temp = bxt.Text;
                    bxt.Text = dx;
                    dxt.Text = temp;
                }
            }
            if (cxf.IsChecked == true)
            {
                if (axto.IsChecked == true)
                {
                    temp = cxt.Text;
                    cxt.Text = ax;
                    axt.Text = temp;
                }
                if (bxto.IsChecked == true)
                {
                    temp = cxt.Text;
                    cxt.Text = bx;
                    bxt.Text = temp;
                }
                if (cxto.IsChecked == true)
                {
                    cxt.Text = cx;
                }
                if (dxto.IsChecked == true)
                {
                    temp = cxt.Text;
                    cxt.Text = dx;
                    dxt.Text = temp;
                }
            }
            if (dxf.IsChecked == true)
            {
                if (axto.IsChecked == true)
                {
                    temp = dxt.Text;
                    dxt.Text = ax;
                    axt.Text = temp;
                }
                if (bxto.IsChecked == true)
                {
                    temp = dxt.Text;
                    dxt.Text = bx;
                    bxt.Text = temp;
                }
                if (cxto.IsChecked == true)
                {
                    temp = dxt.Text;
                    dxt.Text = cx;
                    cxt.Text = temp;
                }
                if (dxto.IsChecked == true)
                {
                    dxt.Text = dx;
                }
            }

        }

        private void MOV_Click(object sender, RoutedEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(axt.Text, @"\A\b[0-9a-fA-F]+\b\Z"))
            {
                MessageBox.Show("Value provided at field AX isn't hex");
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(bxt.Text, @"\A\b[0-9a-fA-F]+\b\Z"))
            {
                MessageBox.Show("Value provided at field BX isn't hex");
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(cxt.Text, @"\A\b[0-9a-fA-F]+\b\Z"))
            {
                MessageBox.Show("Value provided at field CX isn't hex");
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(dxt.Text, @"\A\b[0-9a-fA-F]+\b\Z"))
            {
                MessageBox.Show("Value provided at field DX isn't hex");
                return;
            }
            string ax = axt.Text.ToString();
            string bx = bxt.Text.ToString();
            string cx = cxt.Text.ToString();
            string dx = dxt.Text.ToString();
          
            if (axf.IsChecked == true)
            {
                if (axto.IsChecked == true)
                {
                    axt.Text = ax;
                }
                if (bxto.IsChecked == true)
                {
                    bxt.Text = ax;
                }
                if (cxto.IsChecked == true)
                {
                    cxt.Text = ax;
                }
                if (dxto.IsChecked == true)
                {
                    dxt.Text = ax;
                }
            }
            if (bxf.IsChecked == true)
            {
                if (axto.IsChecked == true)
                {
                    axt.Text = bx;
                }
                if (bxto.IsChecked == true)
                {
                    bxt.Text = bx;
                }
                if (cxto.IsChecked == true)
                {
                    cxt.Text = bx;
                }
                if (dxto.IsChecked == true)
                {
                    dxt.Text = bx;
                }
            }
            if (cxf.IsChecked == true)
            {
                if (axto.IsChecked == true)
                {
                    axt.Text = cx;
                }
                if (bxto.IsChecked == true)
                {
                    bxt.Text = cx;
                }
                if (cxto.IsChecked == true)
                {
                    cxt.Text = cx;
                }
                if (dxto.IsChecked == true)
                {
                    dxt.Text = cx;
                }
            }
            if (dxf.IsChecked == true)
            {
                if (axto.IsChecked == true)
                {
                    axt.Text = dx;
                }
                if (bxto.IsChecked == true)
                {
                    bxt.Text = dx;
                }
                if (cxto.IsChecked == true)
                {
                    cxt.Text = dx;
                }
                if (dxto.IsChecked == true)
                {
                    dxt.Text = dx;
                }
            }






        }

        private void WindowsFormsHost_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void ax_Checked(object sender, RoutedEventArgs e)
        {

        }

        public void axf_Checked(object sender, RoutedEventArgs e)
        {
            
 
        }
       
    }
}
