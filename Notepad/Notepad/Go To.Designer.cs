namespace Notepad
{
    partial class Go_To
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
            this.lbl_Line = new System.Windows.Forms.Label();
            this.txtb_Line = new System.Windows.Forms.TextBox();
            this.btn_Go_To = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Line
            // 
            this.lbl_Line.AutoSize = true;
            this.lbl_Line.Location = new System.Drawing.Point(11, 32);
            this.lbl_Line.Name = "lbl_Line";
            this.lbl_Line.Size = new System.Drawing.Size(27, 13);
            this.lbl_Line.TabIndex = 0;
            this.lbl_Line.Text = "Line";
            // 
            // txtb_Line
            // 
            this.txtb_Line.Location = new System.Drawing.Point(44, 29);
            this.txtb_Line.Name = "txtb_Line";
            this.txtb_Line.Size = new System.Drawing.Size(181, 20);
            this.txtb_Line.TabIndex = 0;
            // 
            // btn_Go_To
            // 
            this.btn_Go_To.Location = new System.Drawing.Point(69, 59);
            this.btn_Go_To.Name = "btn_Go_To";
            this.btn_Go_To.Size = new System.Drawing.Size(75, 25);
            this.btn_Go_To.TabIndex = 2;
            this.btn_Go_To.Text = "Go To";
            this.btn_Go_To.UseVisualStyleBackColor = true;
            this.btn_Go_To.Click += new System.EventHandler(this.btn_Go_To_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(150, 59);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 25);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // Go_To
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 90);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Go_To);
            this.Controls.Add(this.txtb_Line);
            this.Controls.Add(this.lbl_Line);
            this.Name = "Go_To";
            this.Text = "Go_To";
            this.Load += new System.EventHandler(this.Go_To_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Line;
        private System.Windows.Forms.TextBox txtb_Line;
        private System.Windows.Forms.Button btn_Go_To;
        private System.Windows.Forms.Button btn_Cancel;
    }
}