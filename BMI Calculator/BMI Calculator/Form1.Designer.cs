namespace BMI_Calculator
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
            this.Calcbutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.Weightlabel = new System.Windows.Forms.Label();
            this.Heightlabel = new System.Windows.Forms.Label();
            this.Addresslabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Resultlabel = new System.Windows.Forms.Label();
            this.Kilogramslabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Calcbutton
            // 
            this.Calcbutton.Location = new System.Drawing.Point(182, 151);
            this.Calcbutton.Name = "Calcbutton";
            this.Calcbutton.Size = new System.Drawing.Size(75, 30);
            this.Calcbutton.TabIndex = 0;
            this.Calcbutton.Text = "Calculate";
            this.Calcbutton.UseVisualStyleBackColor = true;
            this.Calcbutton.Click += new System.EventHandler(this.Calcbutton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.Location = new System.Drawing.Point(62, 151);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(92, 30);
            this.Deletebutton.TabIndex = 1;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(79, 110);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(97, 20);
            this.textBoxWeight.TabIndex = 2;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(79, 74);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(97, 20);
            this.textBoxHeight.TabIndex = 3;
            this.textBoxHeight.Text = "175";
            // 
            // Weightlabel
            // 
            this.Weightlabel.AutoSize = true;
            this.Weightlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weightlabel.Location = new System.Drawing.Point(10, 108);
            this.Weightlabel.Name = "Weightlabel";
            this.Weightlabel.Size = new System.Drawing.Size(63, 20);
            this.Weightlabel.TabIndex = 4;
            this.Weightlabel.Text = "Weight:";
            // 
            // Heightlabel
            // 
            this.Heightlabel.AutoSize = true;
            this.Heightlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heightlabel.Location = new System.Drawing.Point(13, 72);
            this.Heightlabel.Name = "Heightlabel";
            this.Heightlabel.Size = new System.Drawing.Size(60, 20);
            this.Heightlabel.TabIndex = 5;
            this.Heightlabel.Text = "Height:";
            // 
            // Addresslabel
            // 
            this.Addresslabel.AutoSize = true;
            this.Addresslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addresslabel.Location = new System.Drawing.Point(-3, 27);
            this.Addresslabel.Name = "Addresslabel";
            this.Addresslabel.Size = new System.Drawing.Size(369, 25);
            this.Addresslabel.TabIndex = 6;
            this.Addresslabel.Text = "Body Mass Index Calculator (BMI)";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Centimeter",
            "Meter"});
            this.comboBox1.Location = new System.Drawing.Point(182, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // Resultlabel
            // 
            this.Resultlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Resultlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultlabel.Location = new System.Drawing.Point(14, 199);
            this.Resultlabel.Name = "Resultlabel";
            this.Resultlabel.Size = new System.Drawing.Size(341, 155);
            this.Resultlabel.TabIndex = 8;
            this.Resultlabel.Text = "Result";
            this.Resultlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Kilogramslabel
            // 
            this.Kilogramslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kilogramslabel.Location = new System.Drawing.Point(182, 110);
            this.Kilogramslabel.Name = "Kilogramslabel";
            this.Kilogramslabel.Size = new System.Drawing.Size(100, 23);
            this.Kilogramslabel.TabIndex = 9;
            this.Kilogramslabel.Text = "Kilograms";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 379);
            this.Controls.Add(this.Kilogramslabel);
            this.Controls.Add(this.Resultlabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Addresslabel);
            this.Controls.Add(this.Heightlabel);
            this.Controls.Add(this.Weightlabel);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Calcbutton);
            this.Name = "Form1";
            this.Text = " حاسبة مؤشر كتلة الجسم (BMI)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calcbutton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label Weightlabel;
        private System.Windows.Forms.Label Heightlabel;
        private System.Windows.Forms.Label Addresslabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Resultlabel;
        private System.Windows.Forms.Label Kilogramslabel;
    }
}

