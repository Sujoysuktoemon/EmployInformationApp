namespace EmployInformationApp
{
    partial class EmployeeAppUI
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SalaryTextBox = new System.Windows.Forms.TextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.RetriveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Salary";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(48, 4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(157, 20);
            this.idTextBox.TabIndex = 0;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(48, 42);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(157, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Location = new System.Drawing.Point(48, 76);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(157, 20);
            this.SalaryTextBox.TabIndex = 2;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(48, 112);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 3;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // RetriveButton
            // 
            this.RetriveButton.Location = new System.Drawing.Point(130, 112);
            this.RetriveButton.Name = "RetriveButton";
            this.RetriveButton.Size = new System.Drawing.Size(75, 23);
            this.RetriveButton.TabIndex = 4;
            this.RetriveButton.Text = "Retrive";
            this.RetriveButton.UseVisualStyleBackColor = true;
            this.RetriveButton.Click += new System.EventHandler(this.RetriveButton_Click);
            // 
            // EmployeeAppUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 136);
            this.Controls.Add(this.RetriveButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.SalaryTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeAppUI";
            this.Text = "EmployeeAppUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SalaryTextBox;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button RetriveButton;
    }
}

