namespace Activity2Windows
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
            label1 = new Label();
            txtlength = new TextBox();
            label2 = new Label();
            txtyard = new TextBox();
            txtfeet = new TextBox();
            txtinches = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(96, 88);
            label1.Name = "label1";
            label1.Size = new Size(199, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter Length (in centimeters)";
            label1.Click += label1_Click;
            // 
            // txtlength
            // 
            txtlength.Location = new Point(301, 88);
            txtlength.Name = "txtlength";
            txtlength.Size = new Size(64, 23);
            txtlength.TabIndex = 1;
            txtlength.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(96, 176);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 2;
            label2.Text = "Yard";
            // 
            // txtyard
            // 
            txtyard.Location = new Point(301, 173);
            txtyard.Name = "txtyard";
            txtyard.Size = new Size(41, 23);
            txtyard.TabIndex = 3;
            // 
            // txtfeet
            // 
            txtfeet.Location = new Point(301, 214);
            txtfeet.Name = "txtfeet";
            txtfeet.Size = new Size(41, 23);
            txtfeet.TabIndex = 4;
            // 
            // txtinches
            // 
            txtinches.Location = new Point(301, 255);
            txtinches.Name = "txtinches";
            txtinches.Size = new Size(41, 23);
            txtinches.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(96, 217);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 6;
            label3.Text = "Feet (Foot)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(96, 258);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 7;
            label4.Text = "Inches";
            // 
            // button1
            // 
            button1.Location = new Point(130, 126);
            button1.Name = "button1";
            button1.Size = new Size(177, 30);
            button1.TabIndex = 8;
            button1.Text = "Convert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 410);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtinches);
            Controls.Add(txtfeet);
            Controls.Add(txtyard);
            Controls.Add(label2);
            Controls.Add(txtlength);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtlength;
        private Label label2;
        private TextBox txtyard;
        private TextBox txtfeet;
        private TextBox txtinches;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}
