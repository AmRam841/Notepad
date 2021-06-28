using System;
using System.Windows.Forms;

namespace Notepad
{
    public partial class FormReplace : Notepad.Find
    {
        public Boolean Is_txt_whatFind_empty;
        private Notepad_Main MainForm;
        public Boolean Is_txtb_Replace_empty;
        
        public FormReplace()
        {
            InitializeComponent();
        }

        public FormReplace(Notepad_Main x) : base(x)
        {
            MainForm = x;
            InitializeComponent();
        }

        private void btn_Replace_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtb_Replace.Text))
            {
                Is_txtb_Replace_empty = true;
            }
            else
            {
                Is_txtb_Replace_empty = false;
            }
            //if (string.IsNullOrEmpty(txtb_WhatFind.Text)==true)
            //txtb_WhatFind.Text == ""
            if (string.IsNullOrEmpty(txtb_WhatFind.Text))
            {
                Is_txt_whatFind_empty = true;
            }
            else
            {
                Is_txt_whatFind_empty = false;//true or false ?
            }

            if (Is_txt_whatFind_empty == false)
            {
                if (Is_txtb_Replace_empty == false)
                {
                    MainForm.ReplaceFuncation(txtb_WhatFind.Text, txtb_Replace.Text);
                    
                }
                else if(Is_txtb_Replace_empty == true)
                {
                    MessageBox.Show("Not found");

                }
            }
            else if (Is_txt_whatFind_empty == true)
            {
                MessageBox.Show("Not found");
            }
        }

        private void btn_ReplaceAll_Click(object sender, EventArgs e)
        {
            StringComparison StringComparison_ReplaceAll = StringComparison.OrdinalIgnoreCase;
            if (CheckBox.Checked == true)
            {
                StringComparison_ReplaceAll = StringComparison.Ordinal;
            }
            MainForm.ReplaceAllFuncation(txtb_WhatFind.Text, txtb_Replace.Text, StringComparison_ReplaceAll, Radio_Down.Checked);
        }
    }
}