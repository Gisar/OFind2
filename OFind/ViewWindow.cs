using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OFind
{
    public partial class ViewWindow : Form
    {
        public ViewWindow(List<string> file)
        {
            InitializeComponent();

            mainTextBox.Text = string.Join("", file);
        }

        private void ViewWindow_Load(object sender, EventArgs e)
        {

        }

        private void ToBufferButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(mainTextBox.Text);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
