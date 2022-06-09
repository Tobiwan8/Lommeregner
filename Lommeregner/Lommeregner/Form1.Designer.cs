namespace Lommeregner
{
    partial class Lommeregner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lommeregner));
            this.btn_1 = new System.Windows.Forms.Button();
            this.txt_tekst = new System.Windows.Forms.TextBox();
            this.lbl_currentOperation = new System.Windows.Forms.Label();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.btn_ce = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_multi = new System.Windows.Forms.Button();
            this.btn_c = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_equals = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_punct = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_1
            // 
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.Location = new System.Drawing.Point(12, 179);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(45, 45);
            this.btn_1.TabIndex = 11;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.Button_Click);
            // 
            // txt_tekst
            // 
            this.txt_tekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tekst.Location = new System.Drawing.Point(12, 42);
            this.txt_tekst.Name = "txt_tekst";
            this.txt_tekst.Size = new System.Drawing.Size(249, 29);
            this.txt_tekst.TabIndex = 0;
            this.txt_tekst.Text = "0";
            this.txt_tekst.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_currentOperation
            // 
            this.lbl_currentOperation.AutoSize = true;
            this.lbl_currentOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_currentOperation.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_currentOperation.Location = new System.Drawing.Point(12, 13);
            this.lbl_currentOperation.Name = "lbl_currentOperation";
            this.lbl_currentOperation.Size = new System.Drawing.Size(0, 24);
            this.lbl_currentOperation.TabIndex = 2;
            // 
            // btn_2
            // 
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.Location = new System.Drawing.Point(63, 179);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(45, 45);
            this.btn_2.TabIndex = 12;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_3
            // 
            this.btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.Location = new System.Drawing.Point(114, 179);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(45, 45);
            this.btn_3.TabIndex = 13;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_divide
            // 
            this.btn_divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_divide.Location = new System.Drawing.Point(165, 77);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(45, 45);
            this.btn_divide.TabIndex = 4;
            this.btn_divide.Text = "/";
            this.btn_divide.UseVisualStyleBackColor = true;
            this.btn_divide.Click += new System.EventHandler(this.Operator_click);
            // 
            // btn_ce
            // 
            this.btn_ce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ce.Location = new System.Drawing.Point(216, 77);
            this.btn_ce.Name = "btn_ce";
            this.btn_ce.Size = new System.Drawing.Size(45, 45);
            this.btn_ce.TabIndex = 5;
            this.btn_ce.Text = "CE";
            this.btn_ce.UseVisualStyleBackColor = true;
            this.btn_ce.Click += new System.EventHandler(this.ClearEverything);
            // 
            // btn_4
            // 
            this.btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4.Location = new System.Drawing.Point(12, 128);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(45, 45);
            this.btn_4.TabIndex = 6;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_5
            // 
            this.btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5.Location = new System.Drawing.Point(63, 128);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(45, 45);
            this.btn_5.TabIndex = 7;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_6
            // 
            this.btn_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_6.Location = new System.Drawing.Point(114, 128);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(45, 45);
            this.btn_6.TabIndex = 8;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_multi
            // 
            this.btn_multi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multi.Location = new System.Drawing.Point(165, 128);
            this.btn_multi.Name = "btn_multi";
            this.btn_multi.Size = new System.Drawing.Size(45, 45);
            this.btn_multi.TabIndex = 9;
            this.btn_multi.Text = "*";
            this.btn_multi.UseVisualStyleBackColor = true;
            this.btn_multi.Click += new System.EventHandler(this.Operator_click);
            // 
            // btn_c
            // 
            this.btn_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_c.Location = new System.Drawing.Point(216, 128);
            this.btn_c.Name = "btn_c";
            this.btn_c.Size = new System.Drawing.Size(45, 45);
            this.btn_c.TabIndex = 10;
            this.btn_c.Text = "C";
            this.btn_c.UseVisualStyleBackColor = true;
            this.btn_c.Click += new System.EventHandler(this.Clear);
            // 
            // btn_7
            // 
            this.btn_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_7.Location = new System.Drawing.Point(12, 77);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(45, 45);
            this.btn_7.TabIndex = 1;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_8
            // 
            this.btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_8.Location = new System.Drawing.Point(63, 77);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(45, 45);
            this.btn_8.TabIndex = 2;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_9
            // 
            this.btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_9.Location = new System.Drawing.Point(114, 77);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(45, 45);
            this.btn_9.TabIndex = 3;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minus.Location = new System.Drawing.Point(165, 179);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(45, 45);
            this.btn_minus.TabIndex = 14;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.Operator_click);
            // 
            // btn_equals
            // 
            this.btn_equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_equals.Location = new System.Drawing.Point(216, 179);
            this.btn_equals.Name = "btn_equals";
            this.btn_equals.Size = new System.Drawing.Size(45, 96);
            this.btn_equals.TabIndex = 15;
            this.btn_equals.Text = "=";
            this.btn_equals.UseVisualStyleBackColor = true;
            this.btn_equals.Click += new System.EventHandler(this.Operator_equals);
            // 
            // btn_0
            // 
            this.btn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_0.Location = new System.Drawing.Point(12, 230);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(96, 45);
            this.btn_0.TabIndex = 16;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_punct
            // 
            this.btn_punct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_punct.Location = new System.Drawing.Point(114, 230);
            this.btn_punct.Name = "btn_punct";
            this.btn_punct.Size = new System.Drawing.Size(45, 45);
            this.btn_punct.TabIndex = 17;
            this.btn_punct.Text = ",";
            this.btn_punct.UseVisualStyleBackColor = true;
            this.btn_punct.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_plus.Location = new System.Drawing.Point(165, 230);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(45, 45);
            this.btn_plus.TabIndex = 19;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.Operator_click);
            // 
            // Lommeregner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 293);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_punct);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_equals);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_c);
            this.Controls.Add(this.btn_multi);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_ce);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.lbl_currentOperation);
            this.Controls.Add(this.txt_tekst);
            this.Controls.Add(this.btn_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Lommeregner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lommeregner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.TextBox txt_tekst;
        private System.Windows.Forms.Label lbl_currentOperation;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Button btn_ce;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_multi;
        private System.Windows.Forms.Button btn_c;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_equals;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_punct;
        private System.Windows.Forms.Button btn_plus;
    }
}

