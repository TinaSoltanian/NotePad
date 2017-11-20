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
    public partial class GotoDialog : Form
    {
        public GotoDialog()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            try
            {
                int.Parse(this.LineNumber.Text);
            }
            catch
            {
                this.LineNumber.Focus();
                this.LineNumber.SelectAll();
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        public int LineNumberValue
        {
            get
            {
                return int.Parse(this.LineNumber.Text);
            }
            set
            {
                this.LineNumber.Text = value.ToString();
            }
        }
    }
}
