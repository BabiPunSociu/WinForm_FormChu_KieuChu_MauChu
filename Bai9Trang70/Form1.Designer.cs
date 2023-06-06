namespace Bai9Trang70
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHienThi = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ckbUnderline = new System.Windows.Forms.CheckBox();
            this.ckbStrikeout = new System.Windows.Forms.CheckBox();
            this.ckbItalic = new System.Windows.Forms.CheckBox();
            this.ckbBold = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdoPink = new System.Windows.Forms.RadioButton();
            this.rdoYellow = new System.Windows.Forms.RadioButton();
            this.rdoOrange = new System.Windows.Forms.RadioButton();
            this.rdoRed = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdoTahoma = new System.Windows.Forms.RadioButton();
            this.rdoVnVgogue = new System.Windows.Forms.RadioButton();
            this.rdoVnUniverse = new System.Windows.Forms.RadioButton();
            this.rdoVnTime = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHienThi);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtHienThi
            // 
            this.txtHienThi.BackColor = System.Drawing.Color.White;
            this.txtHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHienThi.Location = new System.Drawing.Point(3, 18);
            this.txtHienThi.Multiline = true;
            this.txtHienThi.Name = "txtHienThi";
            this.txtHienThi.ReadOnly = true;
            this.txtHienThi.Size = new System.Drawing.Size(794, 56);
            this.txtHienThi.TabIndex = 0;
            this.txtHienThi.Text = "Nguyễn Văn Dũng";
            this.txtHienThi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 350);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(435, 33);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(333, 42);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(27, 33);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(333, 42);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 77);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(800, 273);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox6.Controls.Add(this.ckbUnderline);
            this.groupBox6.Controls.Add(this.ckbStrikeout);
            this.groupBox6.Controls.Add(this.ckbItalic);
            this.groupBox6.Controls.Add(this.ckbBold);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(255, 18);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox6.Size = new System.Drawing.Size(280, 252);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hiệu ứng";
            // 
            // ckbUnderline
            // 
            this.ckbUnderline.AutoSize = true;
            this.ckbUnderline.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbUnderline.Location = new System.Drawing.Point(38, 192);
            this.ckbUnderline.Name = "ckbUnderline";
            this.ckbUnderline.Size = new System.Drawing.Size(87, 20);
            this.ckbUnderline.TabIndex = 3;
            this.ckbUnderline.Text = "Underline";
            this.ckbUnderline.UseVisualStyleBackColor = true;
            this.ckbUnderline.CheckedChanged += new System.EventHandler(this.ckbUnderline_CheckedChanged);
            // 
            // ckbStrikeout
            // 
            this.ckbStrikeout.AutoSize = true;
            this.ckbStrikeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbStrikeout.Location = new System.Drawing.Point(38, 149);
            this.ckbStrikeout.Name = "ckbStrikeout";
            this.ckbStrikeout.Size = new System.Drawing.Size(81, 20);
            this.ckbStrikeout.TabIndex = 2;
            this.ckbStrikeout.Text = "Strikeout";
            this.ckbStrikeout.UseVisualStyleBackColor = true;
            this.ckbStrikeout.CheckedChanged += new System.EventHandler(this.ckbStrikeout_CheckedChanged);
            // 
            // ckbItalic
            // 
            this.ckbItalic.AutoSize = true;
            this.ckbItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbItalic.Location = new System.Drawing.Point(38, 97);
            this.ckbItalic.Name = "ckbItalic";
            this.ckbItalic.Size = new System.Drawing.Size(56, 20);
            this.ckbItalic.TabIndex = 1;
            this.ckbItalic.Text = "Italic";
            this.ckbItalic.UseVisualStyleBackColor = true;
            this.ckbItalic.CheckedChanged += new System.EventHandler(this.ckbItalic_CheckedChanged);
            // 
            // ckbBold
            // 
            this.ckbBold.AutoSize = true;
            this.ckbBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbBold.Location = new System.Drawing.Point(38, 55);
            this.ckbBold.Name = "ckbBold";
            this.ckbBold.Size = new System.Drawing.Size(61, 20);
            this.ckbBold.TabIndex = 0;
            this.ckbBold.Text = "Bold";
            this.ckbBold.UseVisualStyleBackColor = true;
            this.ckbBold.CheckedChanged += new System.EventHandler(this.ckbBold_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox5.Controls.Add(this.rdoPink);
            this.groupBox5.Controls.Add(this.rdoYellow);
            this.groupBox5.Controls.Add(this.rdoOrange);
            this.groupBox5.Controls.Add(this.rdoRed);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox5.Location = new System.Drawing.Point(535, 18);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox5.Size = new System.Drawing.Size(262, 252);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Màu chữ";
            // 
            // rdoPink
            // 
            this.rdoPink.AutoSize = true;
            this.rdoPink.ForeColor = System.Drawing.Color.Pink;
            this.rdoPink.Location = new System.Drawing.Point(30, 191);
            this.rdoPink.Name = "rdoPink";
            this.rdoPink.Size = new System.Drawing.Size(61, 20);
            this.rdoPink.TabIndex = 3;
            this.rdoPink.TabStop = true;
            this.rdoPink.Text = "Hồng";
            this.rdoPink.UseVisualStyleBackColor = true;
            this.rdoPink.CheckedChanged += new System.EventHandler(this.rdoRed_CheckedChanged);
            // 
            // rdoYellow
            // 
            this.rdoYellow.AutoSize = true;
            this.rdoYellow.ForeColor = System.Drawing.Color.Yellow;
            this.rdoYellow.Location = new System.Drawing.Point(30, 148);
            this.rdoYellow.Name = "rdoYellow";
            this.rdoYellow.Size = new System.Drawing.Size(60, 20);
            this.rdoYellow.TabIndex = 2;
            this.rdoYellow.TabStop = true;
            this.rdoYellow.Text = "Vàng";
            this.rdoYellow.UseVisualStyleBackColor = true;
            this.rdoYellow.CheckedChanged += new System.EventHandler(this.rdoRed_CheckedChanged);
            // 
            // rdoOrange
            // 
            this.rdoOrange.AutoSize = true;
            this.rdoOrange.ForeColor = System.Drawing.Color.Orange;
            this.rdoOrange.Location = new System.Drawing.Point(30, 96);
            this.rdoOrange.Name = "rdoOrange";
            this.rdoOrange.Size = new System.Drawing.Size(56, 20);
            this.rdoOrange.TabIndex = 1;
            this.rdoOrange.TabStop = true;
            this.rdoOrange.Text = "Cam";
            this.rdoOrange.UseVisualStyleBackColor = true;
            this.rdoOrange.CheckedChanged += new System.EventHandler(this.rdoRed_CheckedChanged);
            // 
            // rdoRed
            // 
            this.rdoRed.AutoSize = true;
            this.rdoRed.ForeColor = System.Drawing.Color.Red;
            this.rdoRed.Location = new System.Drawing.Point(30, 49);
            this.rdoRed.Name = "rdoRed";
            this.rdoRed.Size = new System.Drawing.Size(45, 20);
            this.rdoRed.TabIndex = 0;
            this.rdoRed.TabStop = true;
            this.rdoRed.Text = "Đỏ";
            this.rdoRed.UseVisualStyleBackColor = true;
            this.rdoRed.CheckedChanged += new System.EventHandler(this.rdoRed_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox4.Controls.Add(this.rdoTahoma);
            this.groupBox4.Controls.Add(this.rdoVnVgogue);
            this.groupBox4.Controls.Add(this.rdoVnUniverse);
            this.groupBox4.Controls.Add(this.rdoVnTime);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Location = new System.Drawing.Point(3, 18);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox4.Size = new System.Drawing.Size(252, 252);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kiểu Font";
            // 
            // rdoTahoma
            // 
            this.rdoTahoma.AutoSize = true;
            this.rdoTahoma.Location = new System.Drawing.Point(24, 191);
            this.rdoTahoma.Name = "rdoTahoma";
            this.rdoTahoma.Size = new System.Drawing.Size(79, 20);
            this.rdoTahoma.TabIndex = 3;
            this.rdoTahoma.TabStop = true;
            this.rdoTahoma.Text = "Tahoma";
            this.rdoTahoma.UseVisualStyleBackColor = true;
            // 
            // rdoVnVgogue
            // 
            this.rdoVnVgogue.AutoSize = true;
            this.rdoVnVgogue.Location = new System.Drawing.Point(24, 148);
            this.rdoVnVgogue.Name = "rdoVnVgogue";
            this.rdoVnVgogue.Size = new System.Drawing.Size(92, 20);
            this.rdoVnVgogue.TabIndex = 2;
            this.rdoVnVgogue.TabStop = true;
            this.rdoVnVgogue.Text = "VnVgogue";
            this.rdoVnVgogue.UseVisualStyleBackColor = true;
            // 
            // rdoVnUniverse
            // 
            this.rdoVnUniverse.AutoSize = true;
            this.rdoVnUniverse.Location = new System.Drawing.Point(24, 96);
            this.rdoVnUniverse.Name = "rdoVnUniverse";
            this.rdoVnUniverse.Size = new System.Drawing.Size(98, 20);
            this.rdoVnUniverse.TabIndex = 1;
            this.rdoVnUniverse.TabStop = true;
            this.rdoVnUniverse.Text = "VnUniverse";
            this.rdoVnUniverse.UseVisualStyleBackColor = true;
            // 
            // rdoVnTime
            // 
            this.rdoVnTime.AutoSize = true;
            this.rdoVnTime.Location = new System.Drawing.Point(24, 49);
            this.rdoVnTime.Name = "rdoVnTime";
            this.rdoVnTime.Size = new System.Drawing.Size(75, 20);
            this.rdoVnTime.TabIndex = 0;
            this.rdoVnTime.TabStop = true;
            this.rdoVnTime.Text = "VnTime";
            this.rdoVnTime.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Program of font";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHienThi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.CheckBox ckbUnderline;
        private System.Windows.Forms.CheckBox ckbStrikeout;
        private System.Windows.Forms.CheckBox ckbItalic;
        private System.Windows.Forms.CheckBox ckbBold;
        private System.Windows.Forms.RadioButton rdoPink;
        private System.Windows.Forms.RadioButton rdoYellow;
        private System.Windows.Forms.RadioButton rdoOrange;
        private System.Windows.Forms.RadioButton rdoRed;
        private System.Windows.Forms.RadioButton rdoTahoma;
        private System.Windows.Forms.RadioButton rdoVnVgogue;
        private System.Windows.Forms.RadioButton rdoVnUniverse;
        private System.Windows.Forms.RadioButton rdoVnTime;
    }
}

