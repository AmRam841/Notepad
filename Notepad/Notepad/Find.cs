using System;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Find : Form
    {
        private Notepad_Main Mainformfind;

        public Find()
        {
            InitializeComponent();
        }

        public Find(Notepad_Main frm)
        {
            Mainformfind = frm;
            InitializeComponent();
        }

        private void btn_FindNext_Click(object sender, EventArgs e)
        {
            StringComparison StringComparison_FindNext = StringComparison.OrdinalIgnoreCase;
            if (CheckBox.Checked == true)
            {
                StringComparison_FindNext = StringComparison.Ordinal;
            }
            Mainformfind.FindNextFuncation(txtb_WhatFind.Text, StringComparison_FindNext, Radio_Down.Checked);
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            Mainformfind.FindFuncation(txtb_WhatFind.Text);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}