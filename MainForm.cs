using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.IO;

namespace highellyManage
{
    public partial class MainForm : MetroFramework.Forms.MetroForm 
    {
        public MainForm()
        {
            InitializeComponent();
            // Create and configure the KryptonMan
        }


        private void btnGradeMng_Click(object sender, EventArgs e)
        {
            // Create an instance of the new form
            GradeMngForm gradeMngForm = new GradeMngForm();

            // Display the new form
            gradeMngForm.Show();
        }
    }
}
