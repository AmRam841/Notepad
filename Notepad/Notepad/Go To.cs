using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Go_To : Form
    {
        Notepad_Main FormMain_GOTO;
        public Go_To(Notepad_Main form)
        {
            FormMain_GOTO = form;
            InitializeComponent();
        }

        private void Go_To_Load(object sender, EventArgs e)
        {
            txtb_Line.Text = FormMain_GOTO.GetLines().ToString();
            txtb_Line.SelectAll();
        }

        private void btn_Go_To_Click(object sender, EventArgs e)
        {
            int Number;
            Number = Convert.ToInt16(txtb_Line.Text) - 1;
            if (Number > FormMain_GOTO.GetLines())
            {
                MessageBox.Show("Out of Range");
                txtb_Line.SelectAll();
                txtb_Line.Focus();
            }
            else
            {
                FormMain_GOTO.Go_TO_Funcation(Number);
                this.Close();
            }
        }
    }
}
