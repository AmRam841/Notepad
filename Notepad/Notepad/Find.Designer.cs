namespace Notepad
{
    partial class Find
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
            this.lbl_WhatFind = new System.Windows.Forms.Label();
            this.txtb_WhatFind = new System.Windows.Forms.TextBox();
            this.btn_Find = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.GroupBox_DIrections = new System.Windows.Forms.GroupBox();
            this.Radio_Up = new System.Windows.Forms.RadioButton();
            this.Radio_Down = new System.Windows.Forms.RadioButton();
            this.CheckBox = new System.Windows.Forms.CheckBox();
            this.btn_FindNext = new System.Windows.Forms.Button();
            this.GroupBox_DIrections.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_WhatFind
            // 
            this.lbl_WhatFind.AutoSize = true;
            this.lbl_WhatFind.Location = new System.Drawing.Point(12, 15);
            this.lbl_WhatFind.Name = "lbl_WhatFind";
            this.lbl_WhatFind.Size = new System.Drawing.Size(65, 13);
            this.lbl_WhatFind.TabIndex = 0;
            this.lbl_WhatFind.Text = "What Find : ";
            // 
            // txtb_WhatFind
            // 
            this.txtb_WhatFind.Location = new System.Drawing.Point(83, 12);
            this.txtb_WhatFind.Name = "txtb_WhatFind";
            this.txtb_WhatFind.Size = new System.Drawing.Size(161, 20);
            this.txtb_WhatFind.TabIndex = 1;
            // 
            // btn_Find
            // 
            this.btn_Find.Location = new System.Drawing.Point(250, 12);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(75, 23);
            this.btn_Find.TabIndex = 2;
            this.btn_Find.Text = "Find";
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(250, 64);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // GroupBox_DIrections
            // 
            this.GroupBox_DIrections.Controls.Add(this.Radio_Up);
            this.GroupBox_DIrections.Controls.Add(this.Radio_Down);
            this.GroupBox_DIrections.Location = new System.Drawing.Point(146, 51);
            this.GroupBox_DIrections.Name = "GroupBox_DIrections";
            this.GroupBox_DIrections.Size = new System.Drawing.Size(98, 40);
            this.GroupBox_DIrections.TabIndex = 4;
            this.GroupBox_DIrections.TabStop = false;
            this.GroupBox_DIrections.Text = "Directions";
            // 
            // Radio_Up
            // 
            this.Radio_Up.AutoSize = true;
            this.Radio_Up.Location = new System.Drawing.Point(0, 17);
            this.Radio_Up.Name = "Radio_Up";
            this.Radio_Up.Size = new System.Drawing.Size(39, 17);
            this.Radio_Up.TabIndex = 6;
            this.Radio_Up.Text = "Up";
            this.Radio_Up.UseVisualStyleBackColor = true;
            // 
            // Radio_Down
            // 
            this.Radio_Down.AutoSize = true;
            this.Radio_Down.Checked = true;
            this.Radio_Down.Location = new System.Drawing.Point(39, 17);
            this.Radio_Down.Name = "Radio_Down";
            this.Radio_Down.Size = new System.Drawing.Size(53, 17);
            this.Radio_Down.TabIndex = 5;
            this.Radio_Down.TabStop = true;
            this.Radio_Down.Text = "Down";
            this.Radio_Down.UseVisualStyleBackColor = true;
            // 
            // CheckBox
            // 
            this.CheckBox.AutoSize = true;
            this.CheckBox.Location = new System.Drawing.Point(12, 68);
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.Size = new System.Drawing.Size(82, 17);
            this.CheckBox.TabIndex = 5;
            this.CheckBox.Text = "Match case";
            this.CheckBox.UseVisualStyleBackColor = true;
            // 
            // btn_FindNext
            // 
            this.btn_FindNext.Location = new System.Drawing.Point(250, 38);
            this.btn_FindNext.Name = "btn_FindNext";
            this.btn_FindNext.Size = new System.Drawing.Size(75, 23);
            this.btn_FindNext.TabIndex = 6;
            this.btn_FindNext.Text = "Find Next";
            this.btn_FindNext.UseVisualStyleBackColor = true;
            this.btn_FindNext.Click += new System.EventHandler(this.btn_FindNext_Click);
            // 
            // Find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 93);
            this.Controls.Add(this.btn_FindNext);
            this.Controls.Add(this.CheckBox);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.GroupBox_DIrections);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.txtb_WhatFind);
            this.Controls.Add(this.lbl_WhatFind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Find";
            this.Text = "Find";
            //this.Load += new System.EventHandler(this.Find_Load);
            this.GroupBox_DIrections.ResumeLayout(false);
            this.GroupBox_DIrections.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_WhatFind;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.Button btn_FindNext;
        protected System.Windows.Forms.TextBox txtb_WhatFind;
        protected System.Windows.Forms.Button btn_Cancel;
        protected System.Windows.Forms.GroupBox GroupBox_DIrections;
        protected System.Windows.Forms.CheckBox CheckBox;
        protected System.Windows.Forms.RadioButton Radio_Up;
        protected System.Windows.Forms.RadioButton Radio_Down;
    }
}