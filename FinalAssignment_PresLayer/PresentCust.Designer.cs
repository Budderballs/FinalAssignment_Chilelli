
namespace FinalAssignment_PresLayer
{
    partial class PresentCust
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
            this.summaryGrid = new System.Windows.Forms.DataGridView();
            this.editCusts = new System.Windows.Forms.Button();
            this.editAdds = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.summaryGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // summaryGrid
            // 
            this.summaryGrid.AllowUserToAddRows = false;
            this.summaryGrid.AllowUserToDeleteRows = false;
            this.summaryGrid.AllowUserToResizeColumns = false;
            this.summaryGrid.AllowUserToResizeRows = false;
            this.summaryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.summaryGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.summaryGrid.Location = new System.Drawing.Point(0, 178);
            this.summaryGrid.MultiSelect = false;
            this.summaryGrid.Name = "summaryGrid";
            this.summaryGrid.ReadOnly = true;
            this.summaryGrid.RowTemplate.Height = 25;
            this.summaryGrid.Size = new System.Drawing.Size(504, 402);
            this.summaryGrid.TabIndex = 0;
            this.summaryGrid.TabStop = false;
            this.summaryGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.summaryGrid_CellClick);
            // 
            // editCusts
            // 
            this.editCusts.Enabled = false;
            this.editCusts.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editCusts.Location = new System.Drawing.Point(12, 12);
            this.editCusts.Name = "editCusts";
            this.editCusts.Size = new System.Drawing.Size(238, 160);
            this.editCusts.TabIndex = 1;
            this.editCusts.Text = "EDIT CUSTOMERS";
            this.editCusts.UseVisualStyleBackColor = true;
            this.editCusts.Click += new System.EventHandler(this.editCusts_Click);
            // 
            // editAdds
            // 
            this.editAdds.Enabled = false;
            this.editAdds.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editAdds.Location = new System.Drawing.Point(256, 12);
            this.editAdds.Name = "editAdds";
            this.editAdds.Size = new System.Drawing.Size(236, 160);
            this.editAdds.TabIndex = 2;
            this.editAdds.Text = "Edit Addresses";
            this.editAdds.UseVisualStyleBackColor = true;
            this.editAdds.Click += new System.EventHandler(this.editAdds_Click);
            // 
            // PresentCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 580);
            this.Controls.Add(this.editAdds);
            this.Controls.Add(this.editCusts);
            this.Controls.Add(this.summaryGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PresentCust";
            this.Text = "Present Customers";
            this.Load += new System.EventHandler(this.PresentCust_Load);
            ((System.ComponentModel.ISupportInitialize)(this.summaryGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView summaryGrid;
        private System.Windows.Forms.Button editCusts;
        private System.Windows.Forms.Button editAdds;
    }
}

