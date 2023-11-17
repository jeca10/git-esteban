namespace app_subasta
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
            button1 = new Button();
            button2 = new Button();
            Username = new TextBox();
            Password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(66, 331);
            button1.Name = "button1";
            button1.Size = new Size(71, 38);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(158, 331);
            button2.Name = "button2";
            button2.Size = new Size(75, 38);
            button2.TabIndex = 1;
            button2.Text = "Sign UP";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Username
            // 
            Username.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            Username.Location = new Point(77, 136);
            Username.Name = "Username";
            Username.Size = new Size(156, 29);
            Username.TabIndex = 2;
            // 
            // Password
            // 
            Password.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            Password.Location = new Point(77, 198);
            Password.Name = "Password";
            Password.Size = new Size(156, 29);
            Password.TabIndex = 3;
            Password.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(81, 174);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 4;
            label1.Text = "Password:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(76, 112);
            label2.Name = "label2";
            label2.Size = new Size(84, 21);
            label2.TabIndex = 5;
            label2.Text = "Username:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(116, 59);
            label3.Name = "label3";
            label3.Size = new Size(67, 28);
            label3.TabIndex = 6;
            label3.Text = "Login";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(311, 419);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox Username;
        private TextBox Password;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}