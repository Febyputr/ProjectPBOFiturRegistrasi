namespace ProjectPBOFiturRegistrasi
{
    partial class Tampilanmasuk
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Group1;
            pictureBox1.Location = new Point(807, 326);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(313, 204);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nunito", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(879, 556);
            label1.Name = "label1";
            label1.Size = new Size(164, 28);
            label1.TabIndex = 1;
            label1.Text = "Selamat Datang";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nunito", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(899, 584);
            label2.Name = "label2";
            label2.Size = new Size(127, 28);
            label2.TabIndex = 2;
            label2.Text = "di EZBRARY";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nunito", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(899, 668);
            label3.Name = "label3";
            label3.Size = new Size(129, 20);
            label3.TabIndex = 3;
            label3.Text = "Masuk atau daftar";
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = SystemColors.HotTrack;
            button1.Font = new Font("Nunito", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(820, 701);
            button1.Name = "button1";
            button1.Size = new Size(285, 45);
            button1.TabIndex = 4;
            button1.Text = "Masuk";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Nunito", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(820, 752);
            button2.Name = "button2";
            button2.Size = new Size(285, 45);
            button2.TabIndex = 5;
            button2.Text = "Daftar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Tampilanmasuk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(1902, 1033);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Tampilanmasuk";
            Text = "Tampilanmasuk";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}