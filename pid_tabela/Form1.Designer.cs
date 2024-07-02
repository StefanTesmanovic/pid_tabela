namespace pid_tabela
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
            brojFaza = new NumericUpDown();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)brojFaza).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(125, 90);
            button1.Name = "button1";
            button1.Size = new Size(100, 39);
            button1.TabIndex = 1;
            button1.Text = "potvrdi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // brojFaza
            // 
            brojFaza.Font = new Font("Segoe UI", 15F);
            brojFaza.Location = new Point(125, 50);
            brojFaza.Name = "brojFaza";
            brojFaza.Size = new Size(100, 34);
            brojFaza.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(12, 52);
            label1.Name = "label1";
            label1.Size = new Size(96, 28);
            label1.TabIndex = 3;
            label1.Text = "Broj faza: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 479);
            Controls.Add(label1);
            Controls.Add(brojFaza);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)brojFaza).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        public NumericUpDown brojFaza;
        public Label label1;
    }
}
