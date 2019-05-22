using System;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class Find : Form
    {
        public Find()
        {
            InitializeComponent();
            
        }

        private int start = 0;

        private void Cancel_Find_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void find_furthr_Click(object sender, EventArgs e)
        {
            string substr = textBox1.Text;
            if (Application.OpenForms["Main_Form"] != null)
            {
                start = (Application.OpenForms["Main_Form"] as Main_Form).Finding(substr, start);
            }
        }
    }
}
