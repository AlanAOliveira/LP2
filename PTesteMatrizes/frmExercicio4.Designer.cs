namespace PTesteMatrizes
{
    partial class frmExercicio4
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
            btnExecutar = new Button();
            lstbxNomes = new ListBox();
            SuspendLayout();
            // 
            // btnExecutar
            // 
            btnExecutar.Location = new Point(117, 94);
            btnExecutar.Name = "btnExecutar";
            btnExecutar.Size = new Size(201, 157);
            btnExecutar.TabIndex = 0;
            btnExecutar.Text = "Executar";
            btnExecutar.UseVisualStyleBackColor = true;
            btnExecutar.Click += btnExecutar_Click;
            // 
            // lstbxNomes
            // 
            lstbxNomes.FormattingEnabled = true;
            lstbxNomes.ItemHeight = 25;
            lstbxNomes.Location = new Point(399, 56);
            lstbxNomes.Name = "lstbxNomes";
            lstbxNomes.Size = new Size(320, 229);
            lstbxNomes.TabIndex = 1;
            // 
            // frmExercicio4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstbxNomes);
            Controls.Add(btnExecutar);
            Name = "frmExercicio4";
            Text = "frmExercicio4";
            ResumeLayout(false);
        }

        #endregion

        private Button btnExecutar;
        private ListBox lstbxNomes;
    }
}