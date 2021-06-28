using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Notepad
{
    using System;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;
    using System.Collections.Generic;
    public partial class Notepad_Main : Form
    {
        private string fn;
        private Boolean saveflag;
        private Undo ObjUndo = new Undo();
        public Boolean Is_txt_notepad_empty;
        Undo mainundo;
        private IList<Keys> ignoreKeys = new List<Keys> { Keys.Control, Keys.Tab, Keys.Shift, Keys.ControlKey, Keys.ShiftKey, Keys.LShiftKey, Keys.RShiftKey };
        private IList<string> Words { get; set; }
        private int counter = 0;


        public Notepad_Main()
        {
            InitializeComponent();
            Words = new List<string>();
        }

        private void Menu_File_Exit_Click(object sender, EventArgs e)
        {
            Menu_File_Save_Click(null, null);
            Application.Exit();

        }

        private void Menu_View_StatusBar_Click(object sender, EventArgs e)
        {
            StatusBar1.Visible = Menu_View_StatusBar.Checked;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"c:\layout.txt") == true)
            {
                string s;
                s = System.IO.File.ReadAllText(@"C:\layout.txt");
            }
        }

        private void Menu_Format_Font_Click(object sender, EventArgs e)
        {
            Dialog_font.Font = txt_Notepad.Font;
            Dialog_font.ShowDialog();
            txt_Notepad.Font = Dialog_font.Font;
        }

        private void Menu_File_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fn))
            {
                DialogResult DialogResult_Save;
                Dialog_Save.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                DialogResult_Save = Dialog_Save.ShowDialog();
                fn = Dialog_Save.FileName;
                if (DialogResult_Save == DialogResult.Cancel)
                {
                    return;
                }
                fn = Dialog_Save.FileName;
            }
            File.WriteAllText(fn, txt_Notepad.Text);
            saveflag = true;
            this.Text = fn;
        }

        private void foreColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dialog_color.FullOpen = true;
            Dialog_color.ShowDialog();
            txt_Notepad.ForeColor = Dialog_color.Color;
        }

        private void Form_Loading(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"C:\layout.txt") == true)
            {
                string s;
                s = System.IO.File.ReadAllText(@"C:\layout.txt");
                ToolStripMenuItem temp = new ToolStripMenuItem();
                temp.Text = s;
            }
        }

        private void Menu_Format_WordWrap_Click(object sender, EventArgs e)
        {
            txt_Notepad.WordWrap = Menu_Format_WordWrap.Checked;//bug
        }

        private void Txt_changed(object sender, EventArgs e)
        {
            //if (Menu_Format_WordWrap.Checked == true)
            //{
            //    txt_Notepad.WordWrap = true;
            //}
            saveflag = false;
            Set_Row_Col();
        }

        private void Menu_File_New_Click(object sender, EventArgs e)
        {
            if (saveflag != true)
            {
                DialogResult DialogResult_NewFile;
                DialogResult_NewFile = MessageBox.Show("Do you want to save ?", "save ..", MessageBoxButtons.YesNo);
                if (DialogResult_NewFile == DialogResult.Yes)
                {
                    Menu_File_Save_Click(null, null);
                }
                txt_Notepad.Text = "";
                this.Text = "My Notepad";
                saveflag = true;
                fn = null;
            }
        }

        private void Menu_File_Open_Click(object sender, EventArgs e)
        {
            Menu_File_New_Click(null, null);
            Dialog_open.Filter = "Text File|*.txt|Document File|*.doc|All Files|*.*";
            if (Dialog_open.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            fn = Dialog_open.FileName;
            txt_Notepad.Text = System.IO.File.ReadAllText(fn);
            saveflag = true;
            this.Text = fn;
        }

        private void Notepad_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu_File_New_Click(null, null);
        }

        private void Menu_File_SaveAs_Click(object sender, EventArgs e)
        {
            fn = null;
            Menu_File_Save_Click(null, null);
        }

        private void Menu_Edit_Delete_CLick(object sender, EventArgs e)
        {
            txt_Notepad.SelectedText = "";
        }

        private void Menu_Edit_Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txt_Notepad.SelectedText);
        }

        private void Menu_Edit_Paste_Click(object sender, EventArgs e)
        {
            txt_Notepad.SelectedText = Clipboard.GetText();
        }

        private void Menu_Edit_Cut_Click(object sender, EventArgs e)
        {
            Menu_Edit_Copy_Click(null, null);
            Menu_Edit_Delete_CLick(null, null);
        }

        private void Menu_Edit_SelectAll_Click(object sender, EventArgs e)
        {
            txt_Notepad.SelectAll();
        }

        private void Menu_Edit_Find_Click(object sender, EventArgs e)
        {
            Find Find1 = new Find(this);
            Find1.Show(this);
        }

        private void Menu_Edit_Undo_Click(object sender, EventArgs e)
        {
            //txt_Notepad.Text = ObjUndo.UndoCons();
        }

        private void Menu_Edit_Redo_Click(object sender, EventArgs e)
        {
            //txt_Notepad.Text = ObjUndo.RedoCosns();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //  ObjUndo.Set_Text(txt_Notepad.Text);
        }

        private void Menu_Edit_Replace_Click(object sender, EventArgs e)
        {
            FormReplace f = new FormReplace(this);
            f.Show(this);
        }

        private void Menu_Edit_GoTo_Click(object sender, EventArgs e)
        {
            Go_To f = new Go_To(this);
            f.ShowDialog();
        }

        public int GetLines()
        {
            return txt_Notepad.Lines.Count();
        }

        public void Set_Row_Col()
        {
            int Row = txt_Notepad.GetLineFromCharIndex(txt_Notepad.SelectionStart) + 1;
            int Col = txt_Notepad.SelectionStart - txt_Notepad.GetFirstCharIndexOfCurrentLine() + 1;
            statusbar_lbl.Text = "Ln" + Row.ToString() + " , Col " + Col.ToString();
        }

        private void Menu_File_Print_Click(object sender, EventArgs e)
        {
            DialogResult DialogResult_Print;
            Dialog_print.Document = Dialog_printdocument;
            DialogResult_Print = Dialog_print.ShowDialog();
            if (DialogResult_Print == DialogResult.OK)
            {
                Dialog_printdocument.Print();
            }
        }

        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            Set_Row_Col();
        }

        public void Set_Enables()
        {
            Menu_Edit_Copy.Enabled = Convert.ToBoolean(txt_Notepad.SelectionLength);
            Menu_Edit_Cut.Enabled = txt_Notepad.SelectionStart > 0;
            Menu_Edit_Delete.Enabled = txt_Notepad.SelectionStart > 0;
            Menu_Edit_Paste.Enabled = Clipboard.ContainsText();
            Menu_Edit_Find.Enabled = txt_Notepad.SelectionStart > 0;
            Menu_Edit_GoTo.Enabled = txt_Notepad.SelectionStart > 0;
            Menu_File_Save.Enabled = !saveflag;
        }

        private void DropDownOpenning(object sender, EventArgs e)
        {
            Set_Enables();
        }

        private void Menu_Edit_TimeandData_Click(object sender, EventArgs e)
        {
            DateTime Date_Now = DateTime.Today;
            txt_Notepad.Text = txt_Notepad.Text + DateTime.Now.ToString();
        }

        private void Print_Page_doc(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txt_Notepad.Text, txt_Notepad.Font, Brushes.Black, 0, 0);
        }

        private void Menu_File_PrintPreview_Click(object sender, EventArgs e)
        {
            Dialog_printpreview.Document = Dialog_printdocument;
            Dialog_printpreview.ShowDialog();
        }

        /// Funcations
        public Boolean FindFuncation(string FindFuncation_string)
        {
            int i;
            i = txt_Notepad.Text.IndexOf(FindFuncation_string);
            if (i == -1)
            {
                MessageBox.Show("Not Found");
                return false;
            }
            else
            {
                txt_Notepad.SelectionStart = i;
                txt_Notepad.SelectionLength = FindFuncation_string.Length;
                txt_Notepad.Focus();
                return true;
            }
        }

        public Boolean FindNextFuncation(string s, StringComparison compeartype, Boolean Right_TO_Left)
        {
            int i = 0;
            if (Right_TO_Left)
            {
                i = txt_Notepad.Text.IndexOf(s, txt_Notepad.SelectionStart + 1, compeartype);
            }
            else
            {
                if (txt_Notepad.SelectionStart == 0)
                {
                    MessageBox.Show("Not found ");
                }
                else
                {
                    i = txt_Notepad.Text.LastIndexOf(s, txt_Notepad.SelectionStart - 1, compeartype);
                }
                /*so lets check this agin io wrote an algorithem for find here it works : prametrs detrmains is it 0 or -1 if -1 not found and return false . if 0 then selection start(where it start to select) from i aka 0 then we have to determain the selection length that  = s.leght
                  now we can focus on the result , but in the find next funcation . it will check if radio buttons is down or up with Right_ to left ===> if yes then everything is good and this will keep calculating for every click , but in this algorithm for "moving" to left you heve to use -1 there for to move left . but there wil be to bug one in else up and one in below  . its not i its about selection start  i this i have to use posion*/
            }
            //is it gonna work tho ?
            if (i == -1)// not found here
            {
                MessageBox.Show("Not Found");
                return false;
            }
            else
            {
                txt_Notepad.SelectionStart = i;
                txt_Notepad.SelectionLength = s.Length;
                txt_Notepad.Focus();
                return true;
            }
        }

        public void Go_TO_Funcation(int x)
        {
            txt_Notepad.SelectionStart = txt_Notepad.GetFirstCharIndexFromLine(x);
        }

        public void ReplaceFuncation(string SearchFor, string ReplaceWith)//string s
        {
            ////FindFuncation(txt_Notepad.SelectedText = s);
            //if (txt_Notepad.SelectionLength > 0)
            //{
            //    txt_Notepad.SelectedText = str;
            //}
            ////txt_Notepad.Text = txt_Notepad.Text.Replace(SearchFor, ReplaceWith);

            if (Is_txt_notepad_empty)
            {
                MessageBox.Show("Nothing to Replace");
            }
            else
            {
                Is_txt_notepad_empty = false;
            }

            FindFuncation(SearchFor);
            if (txt_Notepad.TextLength > 0)
            {
                if (Is_txt_notepad_empty == false)
                {
                    //if () {
                    txt_Notepad.SelectedText = ReplaceWith;

                    //}
                }
                else if (Is_txt_notepad_empty == true)
                {
                    MessageBox.Show("Not Found ");
                }
            }
            else
            {
                MessageBox.Show("There is nothing to search");
            }
            /*Replace Explaination : so i created my code : first of all we have the findfuncation i give 2 main string here : 1.searchFor 2. ReplaceWith so i can determain and majore there activeaties . i give findfuncation searchFor string  and then i said if txt_Notepad is empty ?  then i created a boolean that determains  if txtb_Findwhat is empty ? if yes then say not found . if not do your job and pass value to the this method if  */
        }

        public void ReplaceAllFuncation(string SearchFor, string ReplaceWith, StringComparison cmptype, Boolean Left_To_Right)
        {
            //while (FindNextFuncation(str, cmptype, Left_To_Right))
            //{
            //    ReplaceFuncation(str);
            //}
            txt_Notepad.Text = txt_Notepad.Text.Replace(SearchFor, ReplaceWith);
        }

        private void txt_keyUp(object sender, KeyEventArgs e)
        {/// i have learn more about this shit 
            
            if (e.Control)
            {
                if (e.KeyCode == Keys.Z)
                {
                    counter--;
                }

                if (e.KeyCode == Keys.Y)
                {
                    counter++;
                }

                txt_Notepad.Text = String.Join(" ", Words.Take(counter));
            }
            else if (!ignoreKeys.Any(ignoreKey => ignoreKey == e.KeyCode))
            {
                Words = txt_Notepad.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                counter = Words.Count;
            }

        } }
}