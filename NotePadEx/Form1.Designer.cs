namespace NotePadEx
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.FileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.FileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.FilePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.FilePrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.FilePageSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.FileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.EditUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.EditSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.EditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.EditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.EditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.EditDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.EditSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.EditSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.EditSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.EditFind = new System.Windows.Forms.ToolStripMenuItem();
            this.EditFindNext = new System.Windows.Forms.ToolStripMenuItem();
            this.EditReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.EditGoto = new System.Windows.Forms.ToolStripMenuItem();
            this.EditSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.EditInsertDateTime = new System.Windows.Forms.ToolStripMenuItem();
            this.Format = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatWordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatFont = new System.Windows.Forms.ToolStripMenuItem();
            this.View = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewStatusbar = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ViewBackgroundColor = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.FileName = new System.Windows.Forms.ToolStripStatusLabel();
            this.CursorPosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.DragAllowed = new System.Windows.Forms.ToolStripStatusLabel();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.PrintDocument = new System.Drawing.Printing.PrintDocument();
            this.MenuStrip.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Edit,
            this.Format,
            this.View,
            this.Help});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(548, 24);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileNew,
            this.FileSeparator1,
            this.FileOpen,
            this.FileSave,
            this.FileSaveAs,
            this.FileSeparator2,
            this.FilePrint,
            this.FilePrintPreview,
            this.FilePageSetup,
            this.FileSeparator3,
            this.FileExit});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(37, 20);
            this.File.Text = "&File";
            // 
            // FileNew
            // 
            this.FileNew.Name = "FileNew";
            this.FileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.FileNew.Size = new System.Drawing.Size(216, 22);
            this.FileNew.Text = "&New";
            this.FileNew.Click += new System.EventHandler(this.FileNew_Click);
            // 
            // FileSeparator1
            // 
            this.FileSeparator1.Name = "FileSeparator1";
            this.FileSeparator1.Size = new System.Drawing.Size(213, 6);
            // 
            // FileOpen
            // 
            this.FileOpen.Name = "FileOpen";
            this.FileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.FileOpen.Size = new System.Drawing.Size(216, 22);
            this.FileOpen.Text = "&Open";
            this.FileOpen.Click += new System.EventHandler(this.FileOpen_Click);
            // 
            // FileSave
            // 
            this.FileSave.Name = "FileSave";
            this.FileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.FileSave.Size = new System.Drawing.Size(216, 22);
            this.FileSave.Text = "&Save";
            this.FileSave.Click += new System.EventHandler(this.FileSave_Click);
            // 
            // FileSaveAs
            // 
            this.FileSaveAs.Name = "FileSaveAs";
            this.FileSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.S)));
            this.FileSaveAs.Size = new System.Drawing.Size(216, 22);
            this.FileSaveAs.Text = "Save &As...";
            this.FileSaveAs.Click += new System.EventHandler(this.FileSaveAs_Click);
            // 
            // FileSeparator2
            // 
            this.FileSeparator2.Name = "FileSeparator2";
            this.FileSeparator2.Size = new System.Drawing.Size(213, 6);
            // 
            // FilePrint
            // 
            this.FilePrint.Name = "FilePrint";
            this.FilePrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.FilePrint.Size = new System.Drawing.Size(216, 22);
            this.FilePrint.Text = "&Print";
            this.FilePrint.Click += new System.EventHandler(this.FilePrint_Click);
            // 
            // FilePrintPreview
            // 
            this.FilePrintPreview.Name = "FilePrintPreview";
            this.FilePrintPreview.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.P)));
            this.FilePrintPreview.Size = new System.Drawing.Size(216, 22);
            this.FilePrintPreview.Text = "Print P&review";
            this.FilePrintPreview.Click += new System.EventHandler(this.FilePrintPreview_Click);
            // 
            // FilePageSetup
            // 
            this.FilePageSetup.Name = "FilePageSetup";
            this.FilePageSetup.Size = new System.Drawing.Size(216, 22);
            this.FilePageSetup.Text = "Page Se&tup";
            this.FilePageSetup.Click += new System.EventHandler(this.FilePageSetup_Click);
            // 
            // FileSeparator3
            // 
            this.FileSeparator3.Name = "FileSeparator3";
            this.FileSeparator3.Size = new System.Drawing.Size(213, 6);
            // 
            // FileExit
            // 
            this.FileExit.Name = "FileExit";
            this.FileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.FileExit.Size = new System.Drawing.Size(216, 22);
            this.FileExit.Text = "E&xit";
            this.FileExit.Click += new System.EventHandler(this.FileExit_Click);
            // 
            // Edit
            // 
            this.Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditUndo,
            this.EditSeparator1,
            this.EditCut,
            this.EditCopy,
            this.EditPaste,
            this.EditDelete,
            this.EditSeparator2,
            this.EditSelectAll,
            this.EditSeparator3,
            this.EditFind,
            this.EditFindNext,
            this.EditReplace,
            this.EditGoto,
            this.EditSeparator4,
            this.EditInsertDateTime});
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(39, 20);
            this.Edit.Text = "&Edit";
            // 
            // EditUndo
            // 
            this.EditUndo.Name = "EditUndo";
            this.EditUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.EditUndo.Size = new System.Drawing.Size(181, 22);
            this.EditUndo.Text = "&Undo";
            this.EditUndo.Click += new System.EventHandler(this.EditUndo_Click);
            // 
            // EditSeparator1
            // 
            this.EditSeparator1.Name = "EditSeparator1";
            this.EditSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // EditCut
            // 
            this.EditCut.Name = "EditCut";
            this.EditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.EditCut.Size = new System.Drawing.Size(181, 22);
            this.EditCut.Text = "&Cut";
            this.EditCut.Click += new System.EventHandler(this.EditCut_Click);
            // 
            // EditCopy
            // 
            this.EditCopy.Name = "EditCopy";
            this.EditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.EditCopy.Size = new System.Drawing.Size(181, 22);
            this.EditCopy.Text = "C&opy";
            this.EditCopy.Click += new System.EventHandler(this.EditCopy_Click);
            // 
            // EditPaste
            // 
            this.EditPaste.Name = "EditPaste";
            this.EditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.EditPaste.Size = new System.Drawing.Size(181, 22);
            this.EditPaste.Text = "&Paste";
            this.EditPaste.Click += new System.EventHandler(this.EditPaste_Click);
            // 
            // EditDelete
            // 
            this.EditDelete.Name = "EditDelete";
            this.EditDelete.Size = new System.Drawing.Size(181, 22);
            this.EditDelete.Text = "&Delete";
            this.EditDelete.Click += new System.EventHandler(this.EditDelete_Click);
            // 
            // EditSeparator2
            // 
            this.EditSeparator2.Name = "EditSeparator2";
            this.EditSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // EditSelectAll
            // 
            this.EditSelectAll.Name = "EditSelectAll";
            this.EditSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.EditSelectAll.Size = new System.Drawing.Size(181, 22);
            this.EditSelectAll.Text = "&Select All";
            this.EditSelectAll.Click += new System.EventHandler(this.EditSelectAll_Click);
            // 
            // EditSeparator3
            // 
            this.EditSeparator3.Name = "EditSeparator3";
            this.EditSeparator3.Size = new System.Drawing.Size(178, 6);
            // 
            // EditFind
            // 
            this.EditFind.Name = "EditFind";
            this.EditFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.EditFind.Size = new System.Drawing.Size(181, 22);
            this.EditFind.Text = "&Find";
            this.EditFind.Click += new System.EventHandler(this.EditFind_Click);
            // 
            // EditFindNext
            // 
            this.EditFindNext.Enabled = false;
            this.EditFindNext.Name = "EditFindNext";
            this.EditFindNext.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.EditFindNext.Size = new System.Drawing.Size(181, 22);
            this.EditFindNext.Text = "Find &Next...";
            this.EditFindNext.Click += new System.EventHandler(this.EditFindNext_Click);
            // 
            // EditReplace
            // 
            this.EditReplace.Name = "EditReplace";
            this.EditReplace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.EditReplace.Size = new System.Drawing.Size(181, 22);
            this.EditReplace.Text = "&Replace";
            // 
            // EditGoto
            // 
            this.EditGoto.Name = "EditGoto";
            this.EditGoto.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.EditGoto.Size = new System.Drawing.Size(181, 22);
            this.EditGoto.Text = "&Goto...";
            this.EditGoto.Click += new System.EventHandler(this.EditGoto_Click);
            // 
            // EditSeparator4
            // 
            this.EditSeparator4.Name = "EditSeparator4";
            this.EditSeparator4.Size = new System.Drawing.Size(178, 6);
            // 
            // EditInsertDateTime
            // 
            this.EditInsertDateTime.Name = "EditInsertDateTime";
            this.EditInsertDateTime.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.EditInsertDateTime.Size = new System.Drawing.Size(181, 22);
            this.EditInsertDateTime.Text = "&Insert Date/Time";
            this.EditInsertDateTime.Click += new System.EventHandler(this.EditInsertDateTime_Click);
            // 
            // Format
            // 
            this.Format.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FormatWordWrap,
            this.FormatFont});
            this.Format.Name = "Format";
            this.Format.Size = new System.Drawing.Size(57, 20);
            this.Format.Text = "F&ormat";
            // 
            // FormatWordWrap
            // 
            this.FormatWordWrap.Checked = true;
            this.FormatWordWrap.CheckOnClick = true;
            this.FormatWordWrap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FormatWordWrap.Name = "FormatWordWrap";
            this.FormatWordWrap.Size = new System.Drawing.Size(134, 22);
            this.FormatWordWrap.Text = "&Word Wrap";
            this.FormatWordWrap.Click += new System.EventHandler(this.FormatWordWrap_Click);
            // 
            // FormatFont
            // 
            this.FormatFont.Name = "FormatFont";
            this.FormatFont.Size = new System.Drawing.Size(134, 22);
            this.FormatFont.Text = "&Font";
            this.FormatFont.Click += new System.EventHandler(this.FormatFont_Click);
            // 
            // View
            // 
            this.View.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewStatusbar,
            this.ViewSeparator1,
            this.ViewBackgroundColor});
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(44, 20);
            this.View.Text = "&View";
            // 
            // ViewStatusbar
            // 
            this.ViewStatusbar.Checked = true;
            this.ViewStatusbar.CheckOnClick = true;
            this.ViewStatusbar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ViewStatusbar.Name = "ViewStatusbar";
            this.ViewStatusbar.Size = new System.Drawing.Size(170, 22);
            this.ViewStatusbar.Text = "&Statusbar";
            this.ViewStatusbar.Click += new System.EventHandler(this.ViewStatusbar_Click);
            // 
            // ViewSeparator1
            // 
            this.ViewSeparator1.Name = "ViewSeparator1";
            this.ViewSeparator1.Size = new System.Drawing.Size(167, 6);
            // 
            // ViewBackgroundColor
            // 
            this.ViewBackgroundColor.Name = "ViewBackgroundColor";
            this.ViewBackgroundColor.Size = new System.Drawing.Size(170, 22);
            this.ViewBackgroundColor.Text = "&Background Color";
            this.ViewBackgroundColor.Click += new System.EventHandler(this.ViewBackgroundColor_Click);
            // 
            // Help
            // 
            this.Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpAbout});
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(44, 20);
            this.Help.Text = "&Help";
            // 
            // HelpAbout
            // 
            this.HelpAbout.Name = "HelpAbout";
            this.HelpAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.HelpAbout.Size = new System.Drawing.Size(135, 22);
            this.HelpAbout.Text = "&About...";
            this.HelpAbout.Click += new System.EventHandler(this.HelpAbout_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileName,
            this.CursorPosition,
            this.DragAllowed});
            this.StatusStrip.Location = new System.Drawing.Point(0, 416);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(548, 22);
            this.StatusStrip.TabIndex = 2;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // FileName
            // 
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(486, 17);
            this.FileName.Spring = true;
            this.FileName.Text = "Untitled";
            this.FileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CursorPosition
            // 
            this.CursorPosition.Name = "CursorPosition";
            this.CursorPosition.Size = new System.Drawing.Size(47, 17);
            this.CursorPosition.Text = "Ln | Col";
            // 
            // DragAllowed
            // 
            this.DragAllowed.AutoSize = false;
            this.DragAllowed.Name = "DragAllowed";
            this.DragAllowed.Size = new System.Drawing.Size(17, 17);
            this.DragAllowed.Visible = false;
            // 
            // TextBox
            // 
            this.TextBox.AcceptsReturn = true;
            this.TextBox.AcceptsTab = true;
            this.TextBox.AllowDrop = true;
            this.TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox.Location = new System.Drawing.Point(0, 24);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBox.Size = new System.Drawing.Size(548, 392);
            this.TextBox.TabIndex = 3;
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.TextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBox_DragDrop);
            this.TextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.TextBox_DragEnter);
            this.TextBox.DragLeave += new System.EventHandler(this.TextBox_DragLeave);
            // 
            // PrintDocument
            // 
            this.PrintDocument.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.PrintDocument_BeginPrint);
            this.PrintDocument.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.PrintDocument_EndPrint);
            this.PrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 438);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.MenuStrip);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NotePad Ex";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem FileNew;
        private System.Windows.Forms.ToolStripSeparator FileSeparator1;
        private System.Windows.Forms.ToolStripMenuItem FileOpen;
        private System.Windows.Forms.ToolStripMenuItem FileSave;
        private System.Windows.Forms.ToolStripMenuItem FileSaveAs;
        private System.Windows.Forms.ToolStripSeparator FileSeparator2;
        private System.Windows.Forms.ToolStripMenuItem FilePrint;
        private System.Windows.Forms.ToolStripMenuItem FilePrintPreview;
        private System.Windows.Forms.ToolStripMenuItem FilePageSetup;
        private System.Windows.Forms.ToolStripSeparator FileSeparator3;
        private System.Windows.Forms.ToolStripMenuItem FileExit;
        private System.Windows.Forms.ToolStripMenuItem Edit;
        private System.Windows.Forms.ToolStripMenuItem EditUndo;
        private System.Windows.Forms.ToolStripSeparator EditSeparator1;
        private System.Windows.Forms.ToolStripMenuItem EditCut;
        private System.Windows.Forms.ToolStripMenuItem EditCopy;
        private System.Windows.Forms.ToolStripMenuItem EditPaste;
        private System.Windows.Forms.ToolStripMenuItem EditDelete;
        private System.Windows.Forms.ToolStripSeparator EditSeparator2;
        private System.Windows.Forms.ToolStripMenuItem EditSelectAll;
        private System.Windows.Forms.ToolStripSeparator EditSeparator3;
        private System.Windows.Forms.ToolStripMenuItem EditFind;
        private System.Windows.Forms.ToolStripMenuItem EditFindNext;
        private System.Windows.Forms.ToolStripMenuItem EditReplace;
        private System.Windows.Forms.ToolStripMenuItem EditGoto;
        private System.Windows.Forms.ToolStripSeparator EditSeparator4;
        private System.Windows.Forms.ToolStripMenuItem EditInsertDateTime;
        private System.Windows.Forms.ToolStripMenuItem Format;
        private System.Windows.Forms.ToolStripMenuItem FormatFont;
        private System.Windows.Forms.ToolStripMenuItem FormatWordWrap;
        private System.Windows.Forms.ToolStripMenuItem View;
        private System.Windows.Forms.ToolStripMenuItem ViewStatusbar;
        private System.Windows.Forms.ToolStripMenuItem Help;
        private System.Windows.Forms.ToolStripMenuItem HelpAbout;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel FileName;
        private System.Windows.Forms.ToolStripStatusLabel CursorPosition;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.ToolStripSeparator ViewSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ViewBackgroundColor;
        private System.Windows.Forms.ToolStripStatusLabel DragAllowed;
        private System.Drawing.Printing.PrintDocument PrintDocument;
    }
}

