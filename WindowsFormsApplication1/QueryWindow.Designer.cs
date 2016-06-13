namespace WindowsFormsApplication1
{
    partial class QueryWindow
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
            this.queryTextBox1 = new System.Windows.Forms.RichTextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // queryTextBox1
            // 
            this.queryTextBox1.Location = new System.Drawing.Point(12, 23);
            this.queryTextBox1.Name = "queryTextBox1";
            this.queryTextBox1.Size = new System.Drawing.Size(694, 258);
            this.queryTextBox1.TabIndex = 0;
            this.queryTextBox1.Text = "";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(631, 288);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // QueryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 323);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.queryTextBox1);
            this.Name = "QueryWindow";
            this.Text = "Query Results";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button closeButton;
        public System.Windows.Forms.RichTextBox queryTextBox1;
    }
}