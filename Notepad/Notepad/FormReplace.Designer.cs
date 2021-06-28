namespace Notepad
{
    partial class FormReplace
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
            this.btn_Replace = new System.Windows.Forms.Button();
            this.btn_ReplaceAll = new System.Windows.Forms.Button();
            this.lbl_Replace = new System.Windows.Forms.Label();
            this.txtb_Replace = new System.Windows.Forms.TextBox();
            this.GroupBox_DIrections.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(250, 124);
            // 
            // GroupBox_DIrections
            // 
            this.GroupBox_DIrections.Location = new System.Drawing.Point(146, 95);
            // 
            // CheckBox
            // 
            this.CheckBox.Location = new System.Drawing.Point(12, 112);
            // 
            // btn_Replace
            // 
            this.btn_Replace.Location = new System.Drawing.Point(250, 67);
            this.btn_Replace.Name = "btn_Replace";
            this.btn_Replace.Size = new System.Drawing.Size(75, 23);
            this.btn_Replace.TabIndex = 7;
            this.btn_Replace.Text = "Replace";
            this.btn_Replace.UseVisualStyleBackColor = true;
            this.btn_Replace.Click += new System.EventHandler(this.btn_Replace_Click);
            // 
            // btn_ReplaceAll
            // 
            this.btn_ReplaceAll.Location = new System.Drawing.Point(250, 96);
            this.btn_ReplaceAll.Name = "btn_ReplaceAll";
            this.btn_ReplaceAll.Size = new System.Drawing.Size(75, 23);
            this.btn_ReplaceAll.TabIndex = 8;
            this.btn_ReplaceAll.Text = "Replace All";
            this.btn_ReplaceAll.UseVisualStyleBackColor = true;
            this.btn_ReplaceAll.Click += new System.EventHandler(this.btn_ReplaceAll_Click);
            // 
            // lbl_Replace
            // 
            this.lbl_Replace.AutoSize = true;
            this.lbl_Replace.Location = new System.Drawing.Point(12, 48);
            this.lbl_Replace.Name = "lbl_Replace";
            this.lbl_Replace.Size = new System.Drawing.Size(47, 13);
            this.lbl_Replace.TabIndex = 9;
            this.lbl_Replace.Text = "Replace";
            // 
            // txtb_Replace
            // 
            this.txtb_Replace.Location = new System.Drawing.Point(83, 41);
            this.txtb_Replace.Name = "txtb_Replace";
            this.txtb_Replace.Size = new System.Drawing.Size(161, 20);
            this.txtb_Replace.TabIndex = 10;
            // 
            // FormReplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(337, 147);
            this.Controls.Add(this.txtb_Replace);
            this.Controls.Add(this.lbl_Replace);
            this.Controls.Add(this.btn_ReplaceAll);
            this.Controls.Add(this.btn_Replace);
            this.Name = "FormReplace";
            this.Text = "Replace";
            //this.Load += new System.EventHandler(this.Replace_Formload);
            this.Controls.SetChildIndex(this.txtb_WhatFind, 0);
            this.Controls.SetChildIndex(this.GroupBox_DIrections, 0);
            this.Controls.SetChildIndex(this.btn_Cancel, 0);
            this.Controls.SetChildIndex(this.CheckBox, 0);
            this.Controls.SetChildIndex(this.btn_Replace, 0);
            this.Controls.SetChildIndex(this.btn_ReplaceAll, 0);
            this.Controls.SetChildIndex(this.lbl_Replace, 0);
            this.Controls.SetChildIndex(this.txtb_Replace, 0);
            this.GroupBox_DIrections.ResumeLayout(false);
            this.GroupBox_DIrections.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Replace;
        private System.Windows.Forms.Button btn_ReplaceAll;
        private System.Windows.Forms.Label lbl_Replace;
        private System.Windows.Forms.TextBox txtb_Replace;
    }
}
