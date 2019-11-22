namespace WindowFormCalcApp
{
    partial class Calc
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calc));
            this.btnperiod = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btndivide = new System.Windows.Forms.Button();
            this.btnmultiply = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnsub = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnplus = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btneq = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.numpreview1 = new System.Windows.Forms.Label();
            this.operatorpreview1 = new System.Windows.Forms.Label();
            this.timelabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnperiod
            // 
            this.btnperiod.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnperiod.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnperiod.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnperiod.Location = new System.Drawing.Point(17, 299);
            this.btnperiod.Margin = new System.Windows.Forms.Padding(0);
            this.btnperiod.Name = "btnperiod";
            this.btnperiod.Size = new System.Drawing.Size(60, 40);
            this.btnperiod.TabIndex = 0;
            this.btnperiod.Text = ".";
            this.btnperiod.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnperiod.UseVisualStyleBackColor = false;
            this.btnperiod.Click += new System.EventHandler(this.btnperiod_Click);
            this.btnperiod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyDown);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnclear.Location = new System.Drawing.Point(17, 89);
            this.btnclear.Margin = new System.Windows.Forms.Padding(0);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(192, 40);
            this.btnclear.TabIndex = 2;
            this.btnclear.Text = "C";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            this.btnclear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyDown);
            // 
            // btndivide
            // 
            this.btndivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btndivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndivide.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndivide.Location = new System.Drawing.Point(215, 89);
            this.btndivide.Margin = new System.Windows.Forms.Padding(0);
            this.btndivide.Name = "btndivide";
            this.btndivide.Size = new System.Drawing.Size(60, 40);
            this.btndivide.TabIndex = 3;
            this.btndivide.Text = "/";
            this.btndivide.UseVisualStyleBackColor = false;
            this.btndivide.Click += new System.EventHandler(this.btndivide_Click);
            this.btndivide.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyDown);
            // 
            // btnmultiply
            // 
            this.btnmultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnmultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmultiply.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnmultiply.Location = new System.Drawing.Point(215, 145);
            this.btnmultiply.Margin = new System.Windows.Forms.Padding(0);
            this.btnmultiply.Name = "btnmultiply";
            this.btnmultiply.Size = new System.Drawing.Size(60, 40);
            this.btnmultiply.TabIndex = 4;
            this.btnmultiply.Text = "x";
            this.btnmultiply.UseVisualStyleBackColor = false;
            this.btnmultiply.Click += new System.EventHandler(this.btnmultiply_Click);
            this.btnmultiply.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyDown);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn9.Location = new System.Drawing.Point(149, 145);
            this.btn9.Margin = new System.Windows.Forms.Padding(0);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(60, 40);
            this.btn9.TabIndex = 5;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            this.btn9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyDown);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn8.Location = new System.Drawing.Point(83, 145);
            this.btn8.Margin = new System.Windows.Forms.Padding(0);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(60, 40);
            this.btn8.TabIndex = 6;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            this.btn8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyDown);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn7.Location = new System.Drawing.Point(17, 145);
            this.btn7.Margin = new System.Windows.Forms.Padding(0);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(60, 40);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            this.btn7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyDown);
            // 
            // btnsub
            // 
            this.btnsub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsub.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsub.Location = new System.Drawing.Point(215, 199);
            this.btnsub.Margin = new System.Windows.Forms.Padding(0);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(60, 40);
            this.btnsub.TabIndex = 8;
            this.btnsub.Text = "-";
            this.btnsub.UseVisualStyleBackColor = false;
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            this.btnsub.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyDown);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn6.Location = new System.Drawing.Point(149, 199);
            this.btn6.Margin = new System.Windows.Forms.Padding(0);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(60, 40);
            this.btn6.TabIndex = 9;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            this.btn6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyDown);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn5.Location = new System.Drawing.Point(83, 199);
            this.btn5.Margin = new System.Windows.Forms.Padding(0);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(60, 40);
            this.btn5.TabIndex = 10;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            this.btn5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyDown);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn4.Location = new System.Drawing.Point(17, 199);
            this.btn4.Margin = new System.Windows.Forms.Padding(0);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(60, 40);
            this.btn4.TabIndex = 11;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            this.btn4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyDown);
            // 
            // btnplus
            // 
            this.btnplus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnplus.Location = new System.Drawing.Point(215, 250);
            this.btnplus.Margin = new System.Windows.Forms.Padding(0);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(60, 40);
            this.btnplus.TabIndex = 12;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = false;
            this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
            this.btnplus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyDown);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn3.Location = new System.Drawing.Point(149, 250);
            this.btn3.Margin = new System.Windows.Forms.Padding(0);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(60, 40);
            this.btn3.TabIndex = 13;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            this.btn3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyDown);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn2.Location = new System.Drawing.Point(83, 250);
            this.btn2.Margin = new System.Windows.Forms.Padding(0);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(60, 40);
            this.btn2.TabIndex = 14;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            this.btn2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyDown);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn1.Location = new System.Drawing.Point(17, 250);
            this.btn1.Margin = new System.Windows.Forms.Padding(0);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(60, 40);
            this.btn1.TabIndex = 15;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            this.btn1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyDown);
            // 
            // btneq
            // 
            this.btneq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btneq.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneq.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btneq.Location = new System.Drawing.Point(149, 299);
            this.btneq.Margin = new System.Windows.Forms.Padding(0);
            this.btneq.Name = "btneq";
            this.btneq.Size = new System.Drawing.Size(126, 40);
            this.btneq.TabIndex = 16;
            this.btneq.Text = "=";
            this.btneq.UseVisualStyleBackColor = false;
            this.btneq.Click += new System.EventHandler(this.btneq_Click);
            this.btneq.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyDown);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn0.Location = new System.Drawing.Point(83, 299);
            this.btn0.Margin = new System.Windows.Forms.Padding(0);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(60, 40);
            this.btn0.TabIndex = 17;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            this.btn0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn0_KeyDown);
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.result.Location = new System.Drawing.Point(17, 29);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(258, 51);
            this.result.TabIndex = 18;
            this.result.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // numpreview1
            // 
            this.numpreview1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.numpreview1.Location = new System.Drawing.Point(17, 8);
            this.numpreview1.Name = "numpreview1";
            this.numpreview1.Size = new System.Drawing.Size(208, 23);
            this.numpreview1.TabIndex = 19;
            this.numpreview1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // operatorpreview1
            // 
            this.operatorpreview1.AutoSize = true;
            this.operatorpreview1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.operatorpreview1.Location = new System.Drawing.Point(229, 18);
            this.operatorpreview1.Name = "operatorpreview1";
            this.operatorpreview1.Size = new System.Drawing.Size(0, 13);
            this.operatorpreview1.TabIndex = 20;
            // 
            // timelabel
            // 
            this.timelabel.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelabel.ForeColor = System.Drawing.Color.Teal;
            this.timelabel.Location = new System.Drawing.Point(48, 356);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(192, 16);
            this.timelabel.TabIndex = 21;
            this.timelabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(295, 381);
            this.Controls.Add(this.timelabel);
            this.Controls.Add(this.operatorpreview1);
            this.Controls.Add(this.numpreview1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btneq);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btnsub);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnmultiply);
            this.Controls.Add(this.btndivide);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnperiod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calc";
            this.Opacity = 0.75D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Calc_FormClosing);
            this.Load += new System.EventHandler(this.Calc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnperiod;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btndivide;
        private System.Windows.Forms.Button btnmultiply;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btneq;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label numpreview1;
        private System.Windows.Forms.Label operatorpreview1;
        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.Timer timer1;
    }
}

