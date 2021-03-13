
namespace FinalAssignment_PresLayer
{
    partial class EditCustomer
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
            this.fNameText = new System.Windows.Forms.TextBox();
            this.lNameText = new System.Windows.Forms.TextBox();
            this.fNameLabel = new System.Windows.Forms.Label();
            this.lNameLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fNameText
            // 
            this.fNameText.Location = new System.Drawing.Point(12, 34);
            this.fNameText.Name = "fNameText";
            this.fNameText.Size = new System.Drawing.Size(100, 23);
            this.fNameText.TabIndex = 0;
            // 
            // lNameText
            // 
            this.lNameText.Location = new System.Drawing.Point(12, 93);
            this.lNameText.Name = "lNameText";
            this.lNameText.Size = new System.Drawing.Size(100, 23);
            this.lNameText.TabIndex = 1;
            // 
            // fNameLabel
            // 
            this.fNameLabel.AutoSize = true;
            this.fNameLabel.Location = new System.Drawing.Point(12, 9);
            this.fNameLabel.Name = "fNameLabel";
            this.fNameLabel.Size = new System.Drawing.Size(64, 15);
            this.fNameLabel.TabIndex = 2;
            this.fNameLabel.Text = "First Name";
            // 
            // lNameLabel
            // 
            this.lNameLabel.AutoSize = true;
            this.lNameLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lNameLabel.Location = new System.Drawing.Point(12, 75);
            this.lNameLabel.Name = "lNameLabel";
            this.lNameLabel.Size = new System.Drawing.Size(63, 15);
            this.lNameLabel.TabIndex = 3;
            this.lNameLabel.Text = "Last Name";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(134, 9);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(110, 52);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Update Customer";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(134, 75);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(110, 52);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // EditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 141);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.lNameLabel);
            this.Controls.Add(this.fNameLabel);
            this.Controls.Add(this.lNameText);
            this.Controls.Add(this.fNameText);
            this.Name = "EditCustomer";
            this.Text = "EditCustomer";
            this.Shown += new System.EventHandler(this.EditCustomer_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fNameText;
        private System.Windows.Forms.TextBox lNameText;
        private System.Windows.Forms.Label fNameLabel;
        private System.Windows.Forms.Label lNameLabel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button cancelButton;
    }
}