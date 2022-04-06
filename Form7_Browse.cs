using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlisWork
{
    public partial class Form7_Browse : Form
    {
        public Form7_Browse(string url)
        {
            InitializeComponent();
            try
            {
                open(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void open(string url)
        {
            try
            {
                webBrowser1.Navigate(new Uri(url));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
