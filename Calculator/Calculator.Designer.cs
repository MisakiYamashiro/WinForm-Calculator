namespace Calculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.btn_percent = new System.Windows.Forms.Button();
            this.tb_mainCalc = new System.Windows.Forms.TextBox();
            this.btn_deleteEverything = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.btn_multipy = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_equals = new System.Windows.Forms.Button();
            this.btn_decimal = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_percent
            // 
            this.btn_percent.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_percent.Location = new System.Drawing.Point(22, 62);
            this.btn_percent.Name = "btn_percent";
            this.btn_percent.Size = new System.Drawing.Size(75, 47);
            this.btn_percent.TabIndex = 0;
            this.btn_percent.Text = "%";
            this.btn_percent.UseVisualStyleBackColor = true;
            // 
            // tb_mainCalc
            // 
            this.tb_mainCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mainCalc.Location = new System.Drawing.Point(22, 12);
            this.tb_mainCalc.Name = "tb_mainCalc";
            this.tb_mainCalc.Size = new System.Drawing.Size(318, 44);
            this.tb_mainCalc.TabIndex = 1;
            this.tb_mainCalc.Text = "0";
            this.tb_mainCalc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_deleteEverything
            // 
            this.btn_deleteEverything.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteEverything.Location = new System.Drawing.Point(103, 62);
            this.btn_deleteEverything.Name = "btn_deleteEverything";
            this.btn_deleteEverything.Size = new System.Drawing.Size(75, 47);
            this.btn_deleteEverything.TabIndex = 0;
            this.btn_deleteEverything.Text = "C";
            this.btn_deleteEverything.UseVisualStyleBackColor = true;
            this.btn_deleteEverything.Click += new System.EventHandler(this.btn_deleteEverythingClicked);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(265, 62);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 47);
            this.btn_delete.TabIndex = 0;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_deleteClicked);
            // 
            // btn_divide
            // 
            this.btn_divide.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_divide.Location = new System.Drawing.Point(184, 62);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(75, 47);
            this.btn_divide.TabIndex = 0;
            this.btn_divide.Text = "/";
            this.btn_divide.UseVisualStyleBackColor = true;
            this.btn_divide.Click += new System.EventHandler(this.btn_fourOperation_Clicked);
            // 
            // btn_multipy
            // 
            this.btn_multipy.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multipy.Location = new System.Drawing.Point(265, 115);
            this.btn_multipy.Name = "btn_multipy";
            this.btn_multipy.Size = new System.Drawing.Size(75, 47);
            this.btn_multipy.TabIndex = 0;
            this.btn_multipy.Text = "X";
            this.btn_multipy.UseVisualStyleBackColor = true;
            this.btn_multipy.Click += new System.EventHandler(this.btn_fourOperation_Clicked);
            // 
            // btn_minus
            // 
            this.btn_minus.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minus.Location = new System.Drawing.Point(265, 168);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(75, 47);
            this.btn_minus.TabIndex = 0;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.btn_fourOperation_Clicked);
            // 
            // btn_plus
            // 
            this.btn_plus.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_plus.Location = new System.Drawing.Point(265, 221);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(75, 47);
            this.btn_plus.TabIndex = 0;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.btn_fourOperation_Clicked);
            // 
            // btn_equals
            // 
            this.btn_equals.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_equals.Location = new System.Drawing.Point(265, 274);
            this.btn_equals.Name = "btn_equals";
            this.btn_equals.Size = new System.Drawing.Size(75, 47);
            this.btn_equals.TabIndex = 0;
            this.btn_equals.Text = "=";
            this.btn_equals.UseVisualStyleBackColor = true;
            this.btn_equals.Click += new System.EventHandler(this.btn_Equals_Clicked);
            // 
            // btn_decimal
            // 
            this.btn_decimal.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_decimal.Location = new System.Drawing.Point(184, 274);
            this.btn_decimal.Name = "btn_decimal";
            this.btn_decimal.Size = new System.Drawing.Size(75, 47);
            this.btn_decimal.TabIndex = 0;
            this.btn_decimal.Text = ".";
            this.btn_decimal.UseVisualStyleBackColor = true;
            this.btn_decimal.Click += new System.EventHandler(this.btn_dotClicked);
            // 
            // btn_0
            // 
            this.btn_0.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_0.Location = new System.Drawing.Point(103, 274);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(75, 47);
            this.btn_0.TabIndex = 0;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_number_clicked);
            // 
            // btn_2
            // 
            this.btn_2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.Location = new System.Drawing.Point(103, 221);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(75, 47);
            this.btn_2.TabIndex = 0;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_number_clicked);
            // 
            // btn_5
            // 
            this.btn_5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5.Location = new System.Drawing.Point(103, 168);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(75, 47);
            this.btn_5.TabIndex = 0;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_number_clicked);
            // 
            // btn_8
            // 
            this.btn_8.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_8.Location = new System.Drawing.Point(103, 115);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(75, 47);
            this.btn_8.TabIndex = 0;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_number_clicked);
            // 
            // btn_9
            // 
            this.btn_9.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_9.Location = new System.Drawing.Point(184, 115);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(75, 47);
            this.btn_9.TabIndex = 0;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_number_clicked);
            // 
            // btn_6
            // 
            this.btn_6.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_6.Location = new System.Drawing.Point(184, 168);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(75, 47);
            this.btn_6.TabIndex = 0;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_number_clicked);
            // 
            // btn_3
            // 
            this.btn_3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.Location = new System.Drawing.Point(184, 221);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(75, 47);
            this.btn_3.TabIndex = 0;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_number_clicked);
            // 
            // btn_1
            // 
            this.btn_1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.Location = new System.Drawing.Point(22, 221);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(75, 47);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_number_clicked);
            // 
            // btn_4
            // 
            this.btn_4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4.Location = new System.Drawing.Point(22, 168);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(75, 47);
            this.btn_4.TabIndex = 0;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_number_clicked);
            // 
            // btn_7
            // 
            this.btn_7.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_7.Location = new System.Drawing.Point(22, 115);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(75, 47);
            this.btn_7.TabIndex = 0;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_number_clicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 270);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(365, 332);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tb_mainCalc);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_decimal);
            this.Controls.Add(this.btn_equals);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_multipy);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_deleteEverything);
            this.Controls.Add(this.btn_percent);
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_percent;
        private System.Windows.Forms.TextBox tb_mainCalc;
        private System.Windows.Forms.Button btn_deleteEverything;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Button btn_multipy;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_equals;
        private System.Windows.Forms.Button btn_decimal;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}