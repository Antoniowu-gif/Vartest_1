namespace Vartest_1
{
    partial class S11501020A91
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblname = new Label();
            lblint = new Label();
            lblfloat = new Label();
            lblstring = new Label();
            lbltime = new Label();
            lblintshow = new Label();
            lblfloatshow = new Label();
            lblstringshow = new Label();
            lbltimeshow = new Label();
            txtname = new TextBox();
            btnclick = new Button();
            SuspendLayout();
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Location = new Point(48, 49);
            lblname.Name = "lblname";
            lblname.Size = new Size(70, 24);
            lblname.TabIndex = 0;
            lblname.Text = "姓名:";
            // 
            // lblint
            // 
            lblint.AutoSize = true;
            lblint.Location = new Point(72, 108);
            lblint.Name = "lblint";
            lblint.Size = new Size(46, 24);
            lblint.TabIndex = 1;
            lblint.Text = "int";
            // 
            // lblfloat
            // 
            lblfloat.AutoSize = true;
            lblfloat.Location = new Point(48, 159);
            lblfloat.Name = "lblfloat";
            lblfloat.Size = new Size(70, 24);
            lblfloat.TabIndex = 2;
            lblfloat.Text = "float";
            // 
            // lblstring
            // 
            lblstring.AutoSize = true;
            lblstring.Location = new Point(36, 206);
            lblstring.Name = "lblstring";
            lblstring.Size = new Size(82, 24);
            lblstring.TabIndex = 3;
            lblstring.Text = "string";
            // 
            // lbltime
            // 
            lbltime.AutoSize = true;
            lbltime.Location = new Point(60, 254);
            lbltime.Name = "lbltime";
            lbltime.Size = new Size(58, 24);
            lbltime.TabIndex = 4;
            lbltime.Text = "time";
            // 
            // lblintshow
            // 
            lblintshow.BorderStyle = BorderStyle.Fixed3D;
            lblintshow.Location = new Point(138, 107);
            lblintshow.Name = "lblintshow";
            lblintshow.Size = new Size(92, 34);
            lblintshow.TabIndex = 5;
            // 
            // lblfloatshow
            // 
            lblfloatshow.BorderStyle = BorderStyle.Fixed3D;
            lblfloatshow.Location = new Point(138, 158);
            lblfloatshow.Name = "lblfloatshow";
            lblfloatshow.Size = new Size(92, 34);
            lblfloatshow.TabIndex = 6;
            // 
            // lblstringshow
            // 
            lblstringshow.BorderStyle = BorderStyle.Fixed3D;
            lblstringshow.Location = new Point(138, 205);
            lblstringshow.Name = "lblstringshow";
            lblstringshow.Size = new Size(294, 34);
            lblstringshow.TabIndex = 7;
            // 
            // lbltimeshow
            // 
            lbltimeshow.BorderStyle = BorderStyle.Fixed3D;
            lbltimeshow.Location = new Point(138, 254);
            lbltimeshow.Name = "lbltimeshow";
            lbltimeshow.Size = new Size(381, 34);
            lbltimeshow.TabIndex = 8;
            // 
            // txtname
            // 
            txtname.Location = new Point(138, 46);
            txtname.Name = "txtname";
            txtname.Size = new Size(150, 36);
            txtname.TabIndex = 9;
            // 
            // btnclick
            // 
            btnclick.Location = new Point(320, 49);
            btnclick.Name = "btnclick";
            btnclick.Size = new Size(112, 34);
            btnclick.TabIndex = 10;
            btnclick.Text = "確定";
            btnclick.UseVisualStyleBackColor = true;
            btnclick.Click += btnclick_Click;
            // 
            // S11501020A91
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 470);
            Controls.Add(btnclick);
            Controls.Add(txtname);
            Controls.Add(lbltimeshow);
            Controls.Add(lblstringshow);
            Controls.Add(lblfloatshow);
            Controls.Add(lblintshow);
            Controls.Add(lbltime);
            Controls.Add(lblstring);
            Controls.Add(lblfloat);
            Controls.Add(lblint);
            Controls.Add(lblname);
            Font = new Font("標楷體", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Name = "S11501020A91";
            Text = "S11501020A91";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblname;
        private Label lblint;
        private Label lblfloat;
        private Label lblstring;
        private Label lbltime;
        private Label lblintshow;
        private Label lblfloatshow;
        private Label lblstringshow;
        private Label lbltimeshow;
        private TextBox txtname;
        private Button btnclick;
    }
}
