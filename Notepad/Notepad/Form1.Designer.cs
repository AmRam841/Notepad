using System.Windows.Forms;

namespace Notepad
{
    partial class Notepad_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notepad_Main));
            this.txt_Notepad = new System.Windows.Forms.RichTextBox();
            this.Menu_Strip = new System.Windows.Forms.MenuStrip();
            this.Menu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_File_New = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_File_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.spr1 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_File_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_File_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_File_Print = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_File_PrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_File_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Edit_Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Edit_Redo = new System.Windows.Forms.ToolStripMenuItem();
            this.spr = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_Edit_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Edit_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Edit_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Edit_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Edit_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_Edit_Find = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Edit_Replace = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Edit_GoTo = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Edit_TimeandData = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Format = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Format_Font = new System.Windows.Forms.ToolStripMenuItem();
            this.foreColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Format_WordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_View_ = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_View_StatusBar = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Help_Contents = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_Tools_About = new System.Windows.Forms.ToolStripMenuItem();
            this.Dialog_Save = new System.Windows.Forms.SaveFileDialog();
            this.StatusBar1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusbar_lbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.Dialog_font = new System.Windows.Forms.FontDialog();
            this.Dialog_color = new System.Windows.Forms.ColorDialog();
            this.Dialog_open = new System.Windows.Forms.OpenFileDialog();
            this.Dialog_print = new System.Windows.Forms.PrintDialog();
            this.Dialog_printdocument = new System.Drawing.Printing.PrintDocument();
            this.Dialog_printpreview = new System.Windows.Forms.PrintPreviewDialog();
            this.Menu_Strip.SuspendLayout();
            this.StatusBar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Notepad
            // 
            this.txt_Notepad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Notepad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Notepad.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Notepad.Location = new System.Drawing.Point(0, 24);
            this.txt_Notepad.Name = "txt_Notepad";
            this.txt_Notepad.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.txt_Notepad.Size = new System.Drawing.Size(480, 159);
            this.txt_Notepad.TabIndex = 0;
            this.txt_Notepad.Text = "";
            this.txt_Notepad.WordWrap = false;
            this.txt_Notepad.TextChanged += new System.EventHandler(this.Txt_changed);
            this.txt_Notepad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            this.txt_Notepad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_keyUp);
            // 
            // Menu_Strip
            // 
            this.Menu_Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_File,
            this.Menu_Edit,
            this.Menu_Format,
            this.Menu_View_,
            this.Menu_Help_Contents});
            this.Menu_Strip.Location = new System.Drawing.Point(0, 0);
            this.Menu_Strip.Name = "Menu_Strip";
            this.Menu_Strip.Size = new System.Drawing.Size(480, 24);
            this.Menu_Strip.TabIndex = 0;
            this.Menu_Strip.Text = "menuStrip1";
            // 
            // Menu_File
            // 
            this.Menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_File_New,
            this.Menu_File_Open,
            this.spr1,
            this.Menu_File_Save,
            this.Menu_File_SaveAs,
            this.toolStripSeparator7,
            this.Menu_File_Print,
            this.Menu_File_PrintPreview,
            this.toolStripSeparator8,
            this.Menu_File_Exit});
            this.Menu_File.Name = "Menu_File";
            this.Menu_File.Size = new System.Drawing.Size(37, 20);
            this.Menu_File.Text = "&File";
            this.Menu_File.DropDownOpening += new System.EventHandler(this.DropDownOpenning);
            // 
            // Menu_File_New
            // 
            this.Menu_File_New.Image = ((System.Drawing.Image)(resources.GetObject("Menu_File_New.Image")));
            this.Menu_File_New.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Menu_File_New.Name = "Menu_File_New";
            this.Menu_File_New.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.Menu_File_New.Size = new System.Drawing.Size(180, 22);
            this.Menu_File_New.Text = "&New";
            this.Menu_File_New.Click += new System.EventHandler(this.Menu_File_New_Click);
            // 
            // Menu_File_Open
            // 
            this.Menu_File_Open.Image = ((System.Drawing.Image)(resources.GetObject("Menu_File_Open.Image")));
            this.Menu_File_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Menu_File_Open.Name = "Menu_File_Open";
            this.Menu_File_Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.Menu_File_Open.Size = new System.Drawing.Size(180, 22);
            this.Menu_File_Open.Text = "&Open";
            this.Menu_File_Open.Click += new System.EventHandler(this.Menu_File_Open_Click);
            // 
            // spr1
            // 
            this.spr1.Name = "spr1";
            this.spr1.Size = new System.Drawing.Size(177, 6);
            // 
            // Menu_File_Save
            // 
            this.Menu_File_Save.Image = ((System.Drawing.Image)(resources.GetObject("Menu_File_Save.Image")));
            this.Menu_File_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Menu_File_Save.Name = "Menu_File_Save";
            this.Menu_File_Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.Menu_File_Save.Size = new System.Drawing.Size(180, 22);
            this.Menu_File_Save.Text = "&Save";
            this.Menu_File_Save.Click += new System.EventHandler(this.Menu_File_Save_Click);
            // 
            // Menu_File_SaveAs
            // 
            this.Menu_File_SaveAs.Name = "Menu_File_SaveAs";
            this.Menu_File_SaveAs.Size = new System.Drawing.Size(180, 22);
            this.Menu_File_SaveAs.Text = "Save &As";
            this.Menu_File_SaveAs.Click += new System.EventHandler(this.Menu_File_SaveAs_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(177, 6);
            // 
            // Menu_File_Print
            // 
            this.Menu_File_Print.Image = ((System.Drawing.Image)(resources.GetObject("Menu_File_Print.Image")));
            this.Menu_File_Print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Menu_File_Print.Name = "Menu_File_Print";
            this.Menu_File_Print.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.Menu_File_Print.Size = new System.Drawing.Size(180, 22);
            this.Menu_File_Print.Text = "&Print";
            this.Menu_File_Print.Click += new System.EventHandler(this.Menu_File_Print_Click);
            // 
            // Menu_File_PrintPreview
            // 
            this.Menu_File_PrintPreview.Image = ((System.Drawing.Image)(resources.GetObject("Menu_File_PrintPreview.Image")));
            this.Menu_File_PrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Menu_File_PrintPreview.Name = "Menu_File_PrintPreview";
            this.Menu_File_PrintPreview.Size = new System.Drawing.Size(180, 22);
            this.Menu_File_PrintPreview.Text = "Print Pre&view";
            this.Menu_File_PrintPreview.Click += new System.EventHandler(this.Menu_File_PrintPreview_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(177, 6);
            // 
            // Menu_File_Exit
            // 
            this.Menu_File_Exit.Name = "Menu_File_Exit";
            this.Menu_File_Exit.Size = new System.Drawing.Size(180, 22);
            this.Menu_File_Exit.Text = "E&xit";
            this.Menu_File_Exit.Click += new System.EventHandler(this.Menu_File_Exit_Click);
            // 
            // Menu_Edit
            // 
            this.Menu_Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Edit_Undo,
            this.Menu_Edit_Redo,
            this.spr,
            this.Menu_Edit_Cut,
            this.Menu_Edit_Copy,
            this.Menu_Edit_Paste,
            this.Menu_Edit_Delete,
            this.Menu_Edit_SelectAll,
            this.toolStripSeparator10,
            this.Menu_Edit_Find,
            this.Menu_Edit_Replace,
            this.Menu_Edit_GoTo,
            this.Menu_Edit_TimeandData});
            this.Menu_Edit.Name = "Menu_Edit";
            this.Menu_Edit.Size = new System.Drawing.Size(39, 20);
            this.Menu_Edit.Text = "&Edit";
            this.Menu_Edit.DropDownOpening += new System.EventHandler(this.DropDownOpenning);
            // 
            // Menu_Edit_Undo
            // 
            this.Menu_Edit_Undo.Name = "Menu_Edit_Undo";
            this.Menu_Edit_Undo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.Menu_Edit_Undo.Size = new System.Drawing.Size(180, 22);
            this.Menu_Edit_Undo.Text = "&Undo";
            this.Menu_Edit_Undo.Click += new System.EventHandler(this.Menu_Edit_Undo_Click);
            // 
            // Menu_Edit_Redo
            // 
            this.Menu_Edit_Redo.Name = "Menu_Edit_Redo";
            this.Menu_Edit_Redo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.Menu_Edit_Redo.Size = new System.Drawing.Size(180, 22);
            this.Menu_Edit_Redo.Text = "&Redo";
            this.Menu_Edit_Redo.Click += new System.EventHandler(this.Menu_Edit_Redo_Click);
            // 
            // spr
            // 
            this.spr.Name = "spr";
            this.spr.Size = new System.Drawing.Size(177, 6);
            // 
            // Menu_Edit_Cut
            // 
            this.Menu_Edit_Cut.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Edit_Cut.Image")));
            this.Menu_Edit_Cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Menu_Edit_Cut.Name = "Menu_Edit_Cut";
            this.Menu_Edit_Cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.Menu_Edit_Cut.Size = new System.Drawing.Size(180, 22);
            this.Menu_Edit_Cut.Text = "Cu&t";
            this.Menu_Edit_Cut.Click += new System.EventHandler(this.Menu_Edit_Cut_Click);
            // 
            // Menu_Edit_Copy
            // 
            this.Menu_Edit_Copy.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Edit_Copy.Image")));
            this.Menu_Edit_Copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Menu_Edit_Copy.Name = "Menu_Edit_Copy";
            this.Menu_Edit_Copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.Menu_Edit_Copy.Size = new System.Drawing.Size(180, 22);
            this.Menu_Edit_Copy.Text = "&Copy";
            this.Menu_Edit_Copy.Click += new System.EventHandler(this.Menu_Edit_Copy_Click);
            // 
            // Menu_Edit_Paste
            // 
            this.Menu_Edit_Paste.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Edit_Paste.Image")));
            this.Menu_Edit_Paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Menu_Edit_Paste.Name = "Menu_Edit_Paste";
            this.Menu_Edit_Paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.Menu_Edit_Paste.Size = new System.Drawing.Size(180, 22);
            this.Menu_Edit_Paste.Text = "&Paste";
            this.Menu_Edit_Paste.Click += new System.EventHandler(this.Menu_Edit_Paste_Click);
            // 
            // Menu_Edit_Delete
            // 
            this.Menu_Edit_Delete.Name = "Menu_Edit_Delete";
            this.Menu_Edit_Delete.Size = new System.Drawing.Size(180, 22);
            this.Menu_Edit_Delete.Text = "Delete";
            this.Menu_Edit_Delete.Click += new System.EventHandler(this.Menu_Edit_Delete_CLick);
            // 
            // Menu_Edit_SelectAll
            // 
            this.Menu_Edit_SelectAll.Name = "Menu_Edit_SelectAll";
            this.Menu_Edit_SelectAll.Size = new System.Drawing.Size(180, 22);
            this.Menu_Edit_SelectAll.Text = "Select All";
            this.Menu_Edit_SelectAll.Click += new System.EventHandler(this.Menu_Edit_SelectAll_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(177, 6);
            // 
            // Menu_Edit_Find
            // 
            this.Menu_Edit_Find.Name = "Menu_Edit_Find";
            this.Menu_Edit_Find.Size = new System.Drawing.Size(180, 22);
            this.Menu_Edit_Find.Text = "Find";
            this.Menu_Edit_Find.Click += new System.EventHandler(this.Menu_Edit_Find_Click);
            // 
            // Menu_Edit_Replace
            // 
            this.Menu_Edit_Replace.Name = "Menu_Edit_Replace";
            this.Menu_Edit_Replace.Size = new System.Drawing.Size(180, 22);
            this.Menu_Edit_Replace.Text = "Replace";
            this.Menu_Edit_Replace.Click += new System.EventHandler(this.Menu_Edit_Replace_Click);
            // 
            // Menu_Edit_GoTo
            // 
            this.Menu_Edit_GoTo.Name = "Menu_Edit_GoTo";
            this.Menu_Edit_GoTo.Size = new System.Drawing.Size(180, 22);
            this.Menu_Edit_GoTo.Text = "GoTo";
            this.Menu_Edit_GoTo.Click += new System.EventHandler(this.Menu_Edit_GoTo_Click);
            // 
            // Menu_Edit_TimeandData
            // 
            this.Menu_Edit_TimeandData.Name = "Menu_Edit_TimeandData";
            this.Menu_Edit_TimeandData.Size = new System.Drawing.Size(180, 22);
            this.Menu_Edit_TimeandData.Text = "Time/Data";
            this.Menu_Edit_TimeandData.Click += new System.EventHandler(this.Menu_Edit_TimeandData_Click);
            // 
            // Menu_Format
            // 
            this.Menu_Format.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Format_Font,
            this.foreColorToolStripMenuItem,
            this.Menu_Format_WordWrap});
            this.Menu_Format.Name = "Menu_Format";
            this.Menu_Format.Size = new System.Drawing.Size(57, 20);
            this.Menu_Format.Text = "Format";
            this.Menu_Format.DropDownOpening += new System.EventHandler(this.DropDownOpenning);
            // 
            // Menu_Format_Font
            // 
            this.Menu_Format_Font.Name = "Menu_Format_Font";
            this.Menu_Format_Font.Size = new System.Drawing.Size(134, 22);
            this.Menu_Format_Font.Text = "Font";
            this.Menu_Format_Font.Click += new System.EventHandler(this.Menu_Format_Font_Click);
            // 
            // foreColorToolStripMenuItem
            // 
            this.foreColorToolStripMenuItem.Name = "foreColorToolStripMenuItem";
            this.foreColorToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.foreColorToolStripMenuItem.Text = "Fore Color";
            this.foreColorToolStripMenuItem.Click += new System.EventHandler(this.foreColorToolStripMenuItem_Click);
            // 
            // Menu_Format_WordWrap
            // 
            this.Menu_Format_WordWrap.CheckOnClick = true;
            this.Menu_Format_WordWrap.Name = "Menu_Format_WordWrap";
            this.Menu_Format_WordWrap.Size = new System.Drawing.Size(134, 22);
            this.Menu_Format_WordWrap.Text = "Word Wrap";
            this.Menu_Format_WordWrap.Click += new System.EventHandler(this.Menu_Format_WordWrap_Click);
            // 
            // Menu_View_
            // 
            this.Menu_View_.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_View_StatusBar});
            this.Menu_View_.Name = "Menu_View_";
            this.Menu_View_.Size = new System.Drawing.Size(44, 20);
            this.Menu_View_.Text = "View";
            this.Menu_View_.DropDownOpening += new System.EventHandler(this.DropDownOpenning);
            // 
            // Menu_View_StatusBar
            // 
            this.Menu_View_StatusBar.CheckOnClick = true;
            this.Menu_View_StatusBar.Name = "Menu_View_StatusBar";
            this.Menu_View_StatusBar.Size = new System.Drawing.Size(126, 22);
            this.Menu_View_StatusBar.Text = "Status Bar";
            this.Menu_View_StatusBar.Click += new System.EventHandler(this.Menu_View_StatusBar_Click);
            // 
            // Menu_Help_Contents
            // 
            this.Menu_Help_Contents.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator11,
            this.Menu_Tools_About});
            this.Menu_Help_Contents.Name = "Menu_Help_Contents";
            this.Menu_Help_Contents.Size = new System.Drawing.Size(44, 20);
            this.Menu_Help_Contents.Text = "&Help";
            this.Menu_Help_Contents.DropDownOpening += new System.EventHandler(this.DropDownOpenning);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(113, 6);
            // 
            // Menu_Tools_About
            // 
            this.Menu_Tools_About.Name = "Menu_Tools_About";
            this.Menu_Tools_About.Size = new System.Drawing.Size(116, 22);
            this.Menu_Tools_About.Text = "&About...";
            // 
            // StatusBar1
            // 
            this.StatusBar1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statusbar_lbl});
            this.StatusBar1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.StatusBar1.Location = new System.Drawing.Point(0, 161);
            this.StatusBar1.Name = "StatusBar1";
            this.StatusBar1.Size = new System.Drawing.Size(480, 22);
            this.StatusBar1.TabIndex = 1;
            this.StatusBar1.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(84, 17);
            this.toolStripStatusLabel1.Text = "Ready to use :)";
            // 
            // statusbar_lbl
            // 
            this.statusbar_lbl.Name = "statusbar_lbl";
            this.statusbar_lbl.Size = new System.Drawing.Size(20, 17);
            this.statusbar_lbl.Text = "Ln";
            // 
            // Dialog_color
            // 
            this.Dialog_color.FullOpen = true;
            // 
            // Dialog_open
            // 
            this.Dialog_open.FileName = "openFileDialog1";
            // 
            // Dialog_print
            // 
            this.Dialog_print.UseEXDialog = true;
            // 
            // Dialog_printdocument
            // 
            this.Dialog_printdocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.Print_Page_doc);
            // 
            // Dialog_printpreview
            // 
            this.Dialog_printpreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.Dialog_printpreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.Dialog_printpreview.ClientSize = new System.Drawing.Size(400, 300);
            this.Dialog_printpreview.Enabled = true;
            this.Dialog_printpreview.Icon = ((System.Drawing.Icon)(resources.GetObject("Dialog_printpreview.Icon")));
            this.Dialog_printpreview.Name = "printPreviewDialog1";
            this.Dialog_printpreview.Visible = false;
            // 
            // Notepad_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(480, 183);
            this.Controls.Add(this.txt_Notepad);
            this.Controls.Add(this.StatusBar1);
            this.Controls.Add(this.Menu_Strip);
            this.KeyPreview = true;
            this.MainMenuStrip = this.Menu_Strip;
            this.Name = "Notepad_Main";
            this.Text = "Notepad";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Notepad_Main_FormClosed);
            this.Load += new System.EventHandler(this.Form_Loading);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.Menu_Strip.ResumeLayout(false);
            this.Menu_Strip.PerformLayout();
            this.StatusBar1.ResumeLayout(false);
            this.StatusBar1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip Menu_Strip;
        private System.Windows.Forms.SaveFileDialog Dialog_Save;
        private System.Windows.Forms.ToolStripMenuItem Menu_File;
        private System.Windows.Forms.ToolStripMenuItem Menu_File_New;
        private System.Windows.Forms.ToolStripMenuItem Menu_File_Open;
        private System.Windows.Forms.ToolStripSeparator spr1;
        private System.Windows.Forms.ToolStripMenuItem Menu_File_Save;
        private System.Windows.Forms.ToolStripMenuItem Menu_File_SaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem Menu_File_Print;
        private System.Windows.Forms.ToolStripMenuItem Menu_File_PrintPreview;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem Menu_File_Exit;
        private System.Windows.Forms.ToolStripMenuItem Menu_Edit;
        private System.Windows.Forms.ToolStripMenuItem Menu_Edit_Undo;
        private System.Windows.Forms.ToolStripMenuItem Menu_Edit_Redo;
        private System.Windows.Forms.ToolStripSeparator spr;
        private System.Windows.Forms.ToolStripMenuItem Menu_Edit_Cut;
        private System.Windows.Forms.ToolStripMenuItem Menu_Edit_Copy;
        private System.Windows.Forms.ToolStripMenuItem Menu_Edit_Paste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem Menu_Help_Contents;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem Menu_Tools_About;
        private System.Windows.Forms.ToolStripMenuItem Menu_Edit_Find;
        private System.Windows.Forms.ToolStripMenuItem Menu_Edit_SelectAll;
        private System.Windows.Forms.ToolStripMenuItem Menu_Edit_Replace;
        private System.Windows.Forms.ToolStripMenuItem Menu_View_;
        private System.Windows.Forms.ToolStripMenuItem Menu_View_StatusBar;
        private System.Windows.Forms.ToolStripMenuItem Menu_Format;
        private System.Windows.Forms.ToolStripMenuItem Menu_Format_WordWrap;
        private System.Windows.Forms.ToolStripMenuItem Menu_Format_Font;
        private System.Windows.Forms.ToolStripMenuItem foreColorToolStripMenuItem;
        protected System.Windows.Forms.StatusStrip StatusBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.FontDialog Dialog_font;
        private System.Windows.Forms.ColorDialog Dialog_color;
        private System.Windows.Forms.OpenFileDialog Dialog_open;
        private System.Windows.Forms.ToolStripMenuItem Menu_Edit_Delete;
        private System.Windows.Forms.RichTextBox txt_Notepad;
        private System.Windows.Forms.ToolStripMenuItem Menu_Edit_GoTo;
        private System.Windows.Forms.PrintDialog Dialog_print;
        private System.Windows.Forms.ToolStripStatusLabel statusbar_lbl;
        private System.Windows.Forms.ToolStripMenuItem Menu_Edit_TimeandData;
        private System.Drawing.Printing.PrintDocument Dialog_printdocument;
        private System.Windows.Forms.PrintPreviewDialog Dialog_printpreview;
    }
}

