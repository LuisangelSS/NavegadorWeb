using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavegadorWed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //InitializeComponent();
            //webBrowser1.ScriptErrorsSuppressed = true; // Desactiva los errores de script
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            {
                // Verifica si la URL comienza con "http://" o "https://"
                if (!txtUrl.Text.StartsWith("http://") && !txtUrl.Text.StartsWith("https://"))
                {
                    txtUrl.Text = "https://" + txtUrl.Text;
                }

                // Navega a la URL ingresada en el WebBrowser
                webBrowser1.Navigate(txtUrl.Text);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }

}
