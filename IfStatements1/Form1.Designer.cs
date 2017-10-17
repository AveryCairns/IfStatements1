namespace IfStatements1
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
            this.integerLabel = new System.Windows.Forms.Label();
            this.intInput = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.polarityLabel = new System.Windows.Forms.Label();
            this.remainderLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // integerLabel
            // 
            this.integerLabel.AutoSize = true;
            this.integerLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integerLabel.Location = new System.Drawing.Point(54, 48);
            this.integerLabel.Name = "integerLabel";
            this.integerLabel.Size = new System.Drawing.Size(97, 16);
            this.integerLabel.TabIndex = 0;
            this.integerLabel.Text = "Input an integer";
            // 
            // intInput
            // 
            this.intInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intInput.Location = new System.Drawing.Point(157, 45);
            this.intInput.Name = "intInput";
            this.intInput.Size = new System.Drawing.Size(53, 22);
            this.intInput.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(157, 74);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(53, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // polarityLabel
            // 
            this.polarityLabel.AutoSize = true;
            this.polarityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polarityLabel.Location = new System.Drawing.Point(57, 118);
            this.polarityLabel.Name = "polarityLabel";
            this.polarityLabel.Size = new System.Drawing.Size(0, 16);
            this.polarityLabel.TabIndex = 3;
            // 
            // remainderLabel
            // 
            this.remainderLabel.AutoSize = true;
            this.remainderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainderLabel.Location = new System.Drawing.Point(57, 167);
            this.remainderLabel.Name = "remainderLabel";
            this.remainderLabel.Size = new System.Drawing.Size(0, 16);
            this.remainderLabel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.remainderLabel);
            this.Controls.Add(this.polarityLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.intInput);
            this.Controls.Add(this.integerLabel);
            this.Name = "Form1";
            this.Text = "If Statements";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label integerLabel;
        private System.Windows.Forms.TextBox intInput;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label polarityLabel;
        private System.Windows.Forms.Label remainderLabel;
    }
}

