namespace TextEditor
{
    partial class Find
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Cancel_Find = new System.Windows.Forms.Button();
            this.find_furthr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "What:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(332, 22);
            this.textBox1.TabIndex = 1;
            // 
            // Cancel_Find
            // 
            this.Cancel_Find.Location = new System.Drawing.Point(466, 76);
            this.Cancel_Find.Name = "Cancel_Find";
            this.Cancel_Find.Size = new System.Drawing.Size(104, 28);
            this.Cancel_Find.TabIndex = 3;
            this.Cancel_Find.Text = "Cancel";
            this.Cancel_Find.UseVisualStyleBackColor = true;
            this.Cancel_Find.Click += new System.EventHandler(this.Cancel_Find_Click);
            // 
            // find_furthr
            // 
            this.find_furthr.Location = new System.Drawing.Point(466, 33);
            this.find_furthr.Name = "find_furthr";
            this.find_furthr.Size = new System.Drawing.Size(104, 28);
            this.find_furthr.TabIndex = 4;
            this.find_furthr.Text = "Find_Further";
            this.find_furthr.UseVisualStyleBackColor = true;
            this.find_furthr.Click += new System.EventHandler(this.find_furthr_Click);
            // 
            // Find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 129);
            this.Controls.Add(this.find_furthr);
            this.Controls.Add(this.Cancel_Find);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Find";
            this.Text = "Find";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Cancel_Find;
        private System.Windows.Forms.Button find_furthr;
    }
}