using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NotePadEx
{
    public partial class FindDialog : Form
    {
        public FindDialog()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (this.Find.Text == string.Empty)
            {
                this.Find.Focus();
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        public string FindValue
        {
            get
            {
                return this.Find.Text;
            }
            set
            {
                this.Find.Text = value;
            }
        }
    }
}
