using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace highellyManage
{
    public partial class MultipleChoiceForm : MetroForm
    {

        public List<string> SelectedOptions { get; private set; }
        public string initYN { get; set; }
        public MultipleChoiceForm()
        {
            InitializeComponent();
            initYN = "N";
            rbListening.Checked = false;
            rbWord.Checked = false;

            // Initialize your controls here
            // Example: Add checkboxes for options
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SelectedOptions = new List<string>();

            // Check which checkboxes are checked and add to the list
            if (rbListening.Checked) SelectedOptions.Add(rbListening.Text);
            if (rbWord.Checked) SelectedOptions.Add(rbWord.Text);
            // ... Repeat for other options ...

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //this.DialogResult = DialogResult.Cancel;
            //this.Close();
        }

        private void MultipleChoiceForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                if (!(rbListening.Checked || rbWord.Checked))
                {
                    MessageBox.Show("제대로 선택");
                }
                else
                {
                    btnOK_Click(sender, e);
                }
            }
        }
    }
}
