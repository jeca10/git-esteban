namespace app_subasta
{
    partial class Form3
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
            button1 = new Button();
            button3 = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(637, 24);
            button1.Name = "button1";
            button1.Size = new Size(105, 39);
            button1.TabIndex = 1;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(653, 380);
            button3.Name = "button3";
            button3.Size = new Size(135, 43);
            button3.TabIndex = 3;
            button3.Text = "Vender";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(28, 85);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 4;
            label1.Text = "Productos";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 109);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(610, 314);
            dataGridView1.TabIndex = 5;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(421, 25);
            button2.Name = "button2";
            button2.Size = new Size(125, 30);
            button2.TabIndex = 7;
            button2.Text = "Buscar Fecha";
            button2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(87, 32);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(278, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            button4.Location = new Point(653, 328);
            button4.Name = "button4";
            button4.Size = new Size(135, 46);
            button4.TabIndex = 9;
            button4.Text = "Buscar Clientes";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button3;
        private Label label1;
        private DataGridView dataGridView1;
        private Button button2;
        private DateTimePicker dateTimePicker1;
        private Button button4;
    }
}