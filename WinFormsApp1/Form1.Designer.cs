
namespace WinFormsApp1
{
    partial class Form1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.count_v2_tb = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.max_v2_tb = new System.Windows.Forms.TextBox();
            this.min_v2_tb = new System.Windows.Forms.TextBox();
            this.agv_v2_tb = new System.Windows.Forms.TextBox();
            this.count_v3_tb = new System.Windows.Forms.TextBox();
            this.max_v3_tb = new System.Windows.Forms.TextBox();
            this.min_v3_tb = new System.Windows.Forms.TextBox();
            this.agv_v3_tb = new System.Windows.Forms.TextBox();
            this.count_v2v3_tb = new System.Windows.Forms.TextBox();
            this.max_v2v3_tb = new System.Windows.Forms.TextBox();
            this.min_v2v3_tb = new System.Windows.Forms.TextBox();
            this.agv_v2v3_tb = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(29, 26);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(813, 761);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "最大值";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "最小值";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "平均值";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "数量";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.agv_v2_tb);
            this.groupBox1.Controls.Add(this.min_v2_tb);
            this.groupBox1.Controls.Add(this.max_v2_tb);
            this.groupBox1.Controls.Add(this.count_v2_tb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(866, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 185);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "v2";
            // 
            // count_v2_tb
            // 
            this.count_v2_tb.Location = new System.Drawing.Point(90, 33);
            this.count_v2_tb.Name = "count_v2_tb";
            this.count_v2_tb.ReadOnly = true;
            this.count_v2_tb.Size = new System.Drawing.Size(243, 27);
            this.count_v2_tb.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.agv_v3_tb);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.min_v3_tb);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.max_v3_tb);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.count_v3_tb);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(866, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 185);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "v3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "最大值";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "数量";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "平均值";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "最小值";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.agv_v2v3_tb);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.min_v2v3_tb);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.max_v2v3_tb);
            this.groupBox3.Controls.Add(this.count_v2v3_tb);
            this.groupBox3.Location = new System.Drawing.Point(866, 442);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(339, 185);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "v2_v3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "最大值";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "数量";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "平均值";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(28, 111);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 20);
            this.label16.TabIndex = 1;
            this.label16.Text = "最小值";
            // 
            // max_v2_tb
            // 
            this.max_v2_tb.Location = new System.Drawing.Point(90, 71);
            this.max_v2_tb.Name = "max_v2_tb";
            this.max_v2_tb.ReadOnly = true;
            this.max_v2_tb.Size = new System.Drawing.Size(243, 27);
            this.max_v2_tb.TabIndex = 2;
            // 
            // min_v2_tb
            // 
            this.min_v2_tb.Location = new System.Drawing.Point(90, 110);
            this.min_v2_tb.Name = "min_v2_tb";
            this.min_v2_tb.ReadOnly = true;
            this.min_v2_tb.Size = new System.Drawing.Size(243, 27);
            this.min_v2_tb.TabIndex = 2;
            // 
            // agv_v2_tb
            // 
            this.agv_v2_tb.Location = new System.Drawing.Point(90, 153);
            this.agv_v2_tb.Name = "agv_v2_tb";
            this.agv_v2_tb.ReadOnly = true;
            this.agv_v2_tb.Size = new System.Drawing.Size(243, 27);
            this.agv_v2_tb.TabIndex = 2;
            // 
            // count_v3_tb
            // 
            this.count_v3_tb.Location = new System.Drawing.Point(90, 33);
            this.count_v3_tb.Name = "count_v3_tb";
            this.count_v3_tb.ReadOnly = true;
            this.count_v3_tb.Size = new System.Drawing.Size(243, 27);
            this.count_v3_tb.TabIndex = 2;
            // 
            // max_v3_tb
            // 
            this.max_v3_tb.Location = new System.Drawing.Point(90, 71);
            this.max_v3_tb.Name = "max_v3_tb";
            this.max_v3_tb.ReadOnly = true;
            this.max_v3_tb.Size = new System.Drawing.Size(243, 27);
            this.max_v3_tb.TabIndex = 2;
            // 
            // min_v3_tb
            // 
            this.min_v3_tb.Location = new System.Drawing.Point(90, 110);
            this.min_v3_tb.Name = "min_v3_tb";
            this.min_v3_tb.ReadOnly = true;
            this.min_v3_tb.Size = new System.Drawing.Size(243, 27);
            this.min_v3_tb.TabIndex = 2;
            // 
            // agv_v3_tb
            // 
            this.agv_v3_tb.Location = new System.Drawing.Point(90, 153);
            this.agv_v3_tb.Name = "agv_v3_tb";
            this.agv_v3_tb.ReadOnly = true;
            this.agv_v3_tb.Size = new System.Drawing.Size(243, 27);
            this.agv_v3_tb.TabIndex = 2;
            // 
            // count_v2v3_tb
            // 
            this.count_v2v3_tb.Location = new System.Drawing.Point(88, 26);
            this.count_v2v3_tb.Name = "count_v2v3_tb";
            this.count_v2v3_tb.ReadOnly = true;
            this.count_v2v3_tb.Size = new System.Drawing.Size(243, 27);
            this.count_v2v3_tb.TabIndex = 2;
            // 
            // max_v2v3_tb
            // 
            this.max_v2v3_tb.Location = new System.Drawing.Point(88, 64);
            this.max_v2v3_tb.Name = "max_v2v3_tb";
            this.max_v2v3_tb.ReadOnly = true;
            this.max_v2v3_tb.Size = new System.Drawing.Size(243, 27);
            this.max_v2v3_tb.TabIndex = 2;
            // 
            // min_v2v3_tb
            // 
            this.min_v2v3_tb.Location = new System.Drawing.Point(88, 103);
            this.min_v2v3_tb.Name = "min_v2v3_tb";
            this.min_v2v3_tb.ReadOnly = true;
            this.min_v2v3_tb.Size = new System.Drawing.Size(243, 27);
            this.min_v2v3_tb.TabIndex = 2;
            // 
            // agv_v2v3_tb
            // 
            this.agv_v2v3_tb.Location = new System.Drawing.Point(88, 146);
            this.agv_v2v3_tb.Name = "agv_v2v3_tb";
            this.agv_v2v3_tb.ReadOnly = true;
            this.agv_v2v3_tb.Size = new System.Drawing.Size(243, 27);
            this.agv_v2v3_tb.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 810);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox count_v2_tb;
        private System.Windows.Forms.TextBox agv_v2_tb;
        private System.Windows.Forms.TextBox min_v2_tb;
        private System.Windows.Forms.TextBox max_v2_tb;
        private System.Windows.Forms.TextBox agv_v3_tb;
        private System.Windows.Forms.TextBox min_v3_tb;
        private System.Windows.Forms.TextBox max_v3_tb;
        private System.Windows.Forms.TextBox count_v3_tb;
        private System.Windows.Forms.TextBox agv_v2v3_tb;
        private System.Windows.Forms.TextBox min_v2v3_tb;
        private System.Windows.Forms.TextBox max_v2v3_tb;
        private System.Windows.Forms.TextBox count_v2v3_tb;
    }
}

