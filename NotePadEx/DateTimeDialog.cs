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
    public partial class DateTimeDialog : Form
    {
        public DateTimeDialog()
        {
            InitializeComponent();

            string[] formats = new string[] { "F", "f", "D", "d", "T", "t" };
            DateTime now = DateTime.Now;

            foreach (string format in formats)
                this.Dates.Items.Add(now.ToString(format));
            
        }

        public string SelectedValue
        {
            get
            {
                if (this.Dates.SelectedIndex < 0)
                    return null;

                return this.Dates.SelectedItem.ToString();
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (this.Dates.SelectedIndex < 0)
                return;

            this.DialogResult = DialogResult.OK;
        }
    }
}
