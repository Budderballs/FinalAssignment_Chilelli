
namespace FinalAssignment_PresLayer
{
    partial class EditAddress
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
            this.streetText = new System.Windows.Forms.TextBox();
            this.zipText = new System.Windows.Forms.TextBox();
            this.stateText = new System.Windows.Forms.TextBox();
            this.cityText = new System.Windows.Forms.TextBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.streetLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.zipLabel = new System.Windows.Forms.Label();
            this.currentCust = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // streetText
            // 
            this.streetText.Location = new System.Drawing.Point(12, 71);
            this.streetText.Name = "streetText";
            this.streetText.Size = new System.Drawing.Size(100, 23);
            this.streetText.TabIndex = 0;
            // 
            // zipText
            // 
            this.zipText.Location = new System.Drawing.Point(12, 207);
            this.zipText.Name = "zipText";
            this.zipText.Size = new System.Drawing.Size(100, 23);
            this.zipText.TabIndex = 1;
            // 
            // stateText
            // 
            this.stateText.Location = new System.Drawing.Point(12, 159);
            this.stateText.Name = "stateText";
            this.stateText.Size = new System.Drawing.Size(100, 23);
            this.stateText.TabIndex = 2;
            // 
            // cityText
            // 
            this.cityText.Location = new System.Drawing.Point(12, 115);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(100, 23);
            this.cityText.TabIndex = 3;
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(13, 141);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(33, 15);
            this.stateLabel.TabIndex = 4;
            this.stateLabel.Text = "State";
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(12, 49);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(37, 15);
            this.streetLabel.TabIndex = 5;
            this.streetLabel.Text = "Street";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(12, 97);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(28, 15);
            this.cityLabel.TabIndex = 6;
            this.cityLabel.Text = "City";
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(13, 189);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(24, 15);
            this.zipLabel.TabIndex = 7;
            this.zipLabel.Text = "ZIP";
            // 
            // currentCust
            // 
            this.currentCust.AutoSize = true;
            this.currentCust.Location = new System.Drawing.Point(13, 13);
            this.currentCust.Name = "currentCust";
            this.currentCust.Size = new System.Drawing.Size(0, 15);
            this.currentCust.TabIndex = 8;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(118, 71);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(159, 67);
            this.updateButton.TabIndex = 9;
            this.updateButton.Text = "Update Address";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(118, 159);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(159, 71);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // EditAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 241);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.currentCust);
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.streetLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityText);
            this.Controls.Add(this.stateText);
            this.Controls.Add(this.zipText);
            this.Controls.Add(this.streetText);
            this.Name = "EditAddress";
            this.Text = "EditAddress";
            this.Shown += new System.EventHandler(this.EditAddress_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox streetText;
        private System.Windows.Forms.TextBox zipText;
        private System.Windows.Forms.TextBox stateText;
        private System.Windows.Forms.TextBox cityText;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.Label currentCust;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button cancelButton;
    }
}