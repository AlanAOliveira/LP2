namespace PTesteMatrizes
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
            btnExercicio1 = new Button();
            btnExercicio2 = new Button();
            btnExercicio3 = new Button();
            btnExercicio4 = new Button();
            btnExercicio5 = new Button();
            SuspendLayout();
            // 
            // btnExercicio1
            // 
            btnExercicio1.Location = new Point(66, 82);
            btnExercicio1.Name = "btnExercicio1";
            btnExercicio1.Size = new Size(177, 133);
            btnExercicio1.TabIndex = 0;
            btnExercicio1.Text = "Exercicio 1";
            btnExercicio1.UseVisualStyleBackColor = true;
            btnExercicio1.Click += btnExercicio1_Click;
            // 
            // btnExercicio2
            // 
            btnExercicio2.Location = new Point(298, 82);
            btnExercicio2.Name = "btnExercicio2";
            btnExercicio2.Size = new Size(177, 133);
            btnExercicio2.TabIndex = 1;
            btnExercicio2.Text = "Exercicio 2";
            btnExercicio2.UseVisualStyleBackColor = true;
            btnExercicio2.Click += btnExercicio2_Click;
            // 
            // btnExercicio3
            // 
            btnExercicio3.Location = new Point(532, 82);
            btnExercicio3.Name = "btnExercicio3";
            btnExercicio3.Size = new Size(177, 133);
            btnExercicio3.TabIndex = 2;
            btnExercicio3.Text = "Exercicio 3";
            btnExercicio3.UseVisualStyleBackColor = true;
            btnExercicio3.Click += btnExercicio3_Click;
            // 
            // btnExercicio4
            // 
            btnExercicio4.Location = new Point(137, 271);
            btnExercicio4.Name = "btnExercicio4";
            btnExercicio4.Size = new Size(177, 133);
            btnExercicio4.TabIndex = 3;
            btnExercicio4.Text = "Exercicio 4";
            btnExercicio4.UseVisualStyleBackColor = true;
            btnExercicio4.Click += btnExercicio4_Click;
            // 
            // btnExercicio5
            // 
            btnExercicio5.Location = new Point(397, 271);
            btnExercicio5.Name = "btnExercicio5";
            btnExercicio5.Size = new Size(177, 133);
            btnExercicio5.TabIndex = 4;
            btnExercicio5.Text = "Exercicio 5";
            btnExercicio5.UseVisualStyleBackColor = true;
            btnExercicio5.Click += btnExercicio5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExercicio5);
            Controls.Add(btnExercicio4);
            Controls.Add(btnExercicio3);
            Controls.Add(btnExercicio2);
            Controls.Add(btnExercicio1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnExercicio1;
        private Button btnExercicio2;
        private Button btnExercicio3;
        private Button btnExercicio4;
        private Button btnExercicio5;
    }
}
