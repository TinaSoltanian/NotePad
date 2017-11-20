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
    public partial class Form1 : Form
    {
        private bool HasChange;
        private List<string> AllowedExtensions;

        public Form1()
        {
            InitializeComponent();

            this.AllowedExtensions = new List<string>();
            this.AllowedExtensions.AddRange(new string[] { ".txt", ".sql", ".xml", ".log" });

        }

        private void FileExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit NotePad Ex?",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
                return;

            this.Close();
        }

        private void EditUndo_Click(object sender, EventArgs e)
        {
            this.TextBox.Undo();
        }

        private void EditCut_Click(object sender, EventArgs e)
        {
            this.TextBox.Cut();
        }

        private void EditCopy_Click(object sender, EventArgs e)
        {
            this.TextBox.Copy();
        }

        private void EditPaste_Click(object sender, EventArgs e)
        {
            this.TextBox.Paste();
        }

        private void EditDelete_Click(object sender, EventArgs e)
        {
            this.TextBox.SelectedText = string.Empty;
        }

        private void EditSelectAll_Click(object sender, EventArgs e)
        {
            this.TextBox.SelectAll();
        }

        private void FormatWordWrap_Click(object sender, EventArgs e)
        {
            this.TextBox.WordWrap = !this.TextBox.WordWrap;
        }

        private void ViewStatusbar_Click(object sender, EventArgs e)
        {
            this.StatusStrip.Visible = !this.StatusStrip.Visible;
        }

        private void EditInsertDateTime_Click(object sender, EventArgs e)
        {
            DateTimeDialog dialog = new DateTimeDialog();

            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.Cancel)
                return;

            //this.TextBox.SelectedText = dialog.Dates.SelectedItem.ToString();
            this.TextBox.SelectedText = dialog.SelectedValue;

        }

        private void HelpAbout_Click(object sender, EventArgs e)
        {
            AboutDialog dialog = new AboutDialog();
            dialog.ShowDialog();
        }

        private void ViewBackgroundColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog()
            {
                Color = this.TextBox.BackColor
            };

            if (dialog.ShowDialog() == DialogResult.Cancel)
                return;

            this.TextBox.BackColor = dialog.Color;
        }

        private void FormatFont_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog()
            {
                Font = this.TextBox.Font,
                ShowColor = true,
                Color = this.TextBox.ForeColor
            };

            if (dialog.ShowDialog() == DialogResult.Cancel)
                return;

            this.TextBox.Font = dialog.Font;
            this.TextBox.ForeColor = dialog.Color;
        }

        private void SetFileInformation(string path)
        {
            this.HasChange = false;

            if (string.IsNullOrEmpty(path))
            {
                this.FileName.Text = "Untitled";
                this.Text = "Untitled - NotePad Ex";
                return;
            }

            this.FileName.Text = path;
            this.Text = string.Format("{0} - NotePad Ex",
                System.IO.Path.GetFileName(path));
        }

        private void ReadFile(string path)
        {
            if (!System.IO.File.Exists(path))
                return;

            try
            {
                this.TextBox.Text = System.IO.File.ReadAllText(path);
                this.SetFileInformation(path);
            }
            catch
            {
            }

        }

        private const string DialogFilter = "Text Documents(*.txt)|*.txt|SQL Scripts(*.sql)|*.sql|Xml Documents(*.xml)|*.xml|All Supported Formats|*.txt;*.sql;*.xml|All Files(*.*)|*.*";

        private void WriteFile(string path)
        {

            try
            {
                System.IO.File.WriteAllText(path, this.TextBox.Text);
                this.SetFileInformation(path);
            }
            catch
            {
            }
        }

        private void FileOpen_Click(object sender, EventArgs e)
        {
            if (!this.CanContinue())
                return;

            OpenFileDialog dialog = new OpenFileDialog()
            {
                Filter = DialogFilter
            };

            if (dialog.ShowDialog() == DialogResult.Cancel)
                return;

            this.ReadFile(dialog.FileName);
        }

        private void FileSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog()
            {
                Filter = DialogFilter
            };

            if (dialog.ShowDialog() == DialogResult.Cancel)
                return;

            WriteFile(dialog.FileName);
        }

        private void FileSave_Click(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(this.FileName.Text))
            {
                this.FileSaveAs.PerformClick();
                //this.FileSaveAs_Click(sender, e);
                return;
            }

            WriteFile(this.FileName.Text);
        }

        private void FileNew_Click(object sender, EventArgs e)
        {
            if (!this.CanContinue())
                return;

            this.TextBox.Text = string.Empty;
            this.SetFileInformation(null);
        }

        private void EditFind_Click(object sender, EventArgs e)
        {
            FindDialog dialog = new FindDialog()
            {
                FindValue = this.TextBox.SelectedText
            };

            if (dialog.ShowDialog() == DialogResult.Cancel)
                return;

            this.FindFor(dialog.FindValue, 0);
        }

        private string FindText;
        private int StartIndex;

        private void FindFor(string text, int startIndex)
        {
            FindText = text;

            int index = this.TextBox.Text.IndexOf(text, startIndex);

            if (index < 0)
            {
                MessageBox.Show("Match not found!",
                    "Find",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                this.EditFindNext.Enabled = false;

                return;
            }

            this.StartIndex = index;
            this.TextBox.SelectionStart = index;
            this.TextBox.SelectionLength = text.Length;

            this.TextBox.ScrollToCaret();

            this.EditFindNext.Enabled = true;
        }

        private void EditFindNext_Click(object sender, EventArgs e)
        {
            this.FindFor(this.FindText, this.StartIndex + 1);
        }

        private void EditGoto_Click(object sender, EventArgs e)
        {
            GotoDialog dialog = new GotoDialog()
            {
                LineNumberValue = this.TextBox.GetLineFromCharIndex(this.TextBox.SelectionStart) + 1
            };

            if (dialog.ShowDialog() == DialogResult.Cancel)
                return;

            this.MoveCaretTo(dialog.LineNumberValue);
        }

        private void MoveCaretTo(int lineNumber)
        {
            int index = this.TextBox.GetFirstCharIndexFromLine(lineNumber - 1);

            if (index < 0)
                return;

            this.TextBox.SelectionStart = index;
            this.TextBox.SelectionLength = 0;

            this.TextBox.ScrollToCaret();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FileNew.PerformClick();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !this.CanContinue();
        }

        private bool CanContinue()
        {
            if (!this.HasChange)
                return true;

            DialogResult result = MessageBox.Show(string.Format("The text in the {0} file has changed.\r\n\r\nDo you want to save the changes?", System.IO.Path.GetFileNameWithoutExtension(this.FileName.Text)),
                "Save Changes",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning);

            switch (result)
            {
                case DialogResult.Yes:
                    this.FileSave.PerformClick();
                    return true;
                case DialogResult.No:
                    return true;
                default:

                    return false;
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            this.HasChange = true;
        }

        private void TextBox_DragEnter(object sender, DragEventArgs e)
        {
            try
            {
                this.DragAllowed.Visible = true;
                this.DragAllowed.BackColor = Color.Red;

                string[] files = (string[])e.Data.GetData("FileName");

                if (files.Length == 0)
                    return;

                if(!System.IO.File.Exists(files[0]))
                    return;

                string extension = System.IO.Path.GetExtension(files[0]).ToLower();
                if (!this.AllowedExtensions.Contains(extension))
                    return;

                // موافقت برنامه با عملیات در حال انجام
                e.Effect = DragDropEffects.Copy;
                this.DragAllowed.BackColor = Color.Green;
            }
            catch
            {
            }
        }

        private void TextBox_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] files = (string[])e.Data.GetData("FileName");

                if (files.Length == 0)
                    return;

                if (!System.IO.File.Exists(files[0]))
                    return;

                // انجام عملیات اصلی
                this.ReadFile(files[0]);

            }
            catch
            {

            }
            finally
            {
                this.DragAllowed.Visible = false;
            }
        }

        private void TextBox_DragLeave(object sender, EventArgs e)
        {
            this.DragAllowed.Visible = false;
        }

        private int CurrentPage;
        private Font PrintFont;
        private StringFormat PrintStringFormat;
        private System.Drawing.Brush PrintBrush;

        private void FilePrintPreview_Click(object sender, EventArgs e)
        {

            PrintPreviewDialog dialog = new PrintPreviewDialog()
            {
                Document = this.PrintDocument
            };

            dialog.ShowDialog();
        }

        private string StringToPrint = string.Empty;
        private void PrintDocument_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            CurrentPage = 1;
            PrintFont = new Font("Arial", 12.0f, FontStyle.Regular);
            PrintStringFormat = new StringFormat()
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Near
            };

            StringToPrint = this.TextBox.Text;

        }

        private void PrintDocument_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.PrintFont.Dispose();
            this.PrintStringFormat.Dispose();            
        }

        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int charactersOnPage = 0;
            int linesPerPage = 0;

            e.Graphics.MeasureString(StringToPrint,
                this.PrintFont,
                e.MarginBounds.Size,
                StringFormat.GenericTypographic,
                out charactersOnPage,
                out linesPerPage);

            e.Graphics.DrawString( StringToPrint,
                PrintFont,
                Brushes.Black,
                e.MarginBounds,
                StringFormat.GenericTypographic);

            StringToPrint = StringToPrint.Substring(charactersOnPage) ;
            e.HasMorePages = StringToPrint.Length > 0;

        }

        private void FilePrint_Click(object sender, EventArgs e)
        {
            PrintDialog dialog = new PrintDialog()
            {
                Document = this.PrintDocument
            };

            if (dialog.ShowDialog() == DialogResult.Cancel)
                return;

            this.PrintDocument.Print();
        }

        private void FilePageSetup_Click(object sender, EventArgs e)
        {
            PageSetupDialog dialog = new PageSetupDialog()
            {
                Document = this.PrintDocument
            };

            dialog.ShowDialog();
        }
    }
}
