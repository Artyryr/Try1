using DatabaseHandler;
using System;
using System.Windows.Forms;

namespace Try1
{
    public partial class CloseDialogForm : Form
    {
        public CloseDialogForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataContext.Instance.ForceClearDatabase();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
