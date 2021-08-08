
namespace Grover_Gaming_Database
{
    partial class EditForm
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
            this.editOkayButton = new System.Windows.Forms.Button();
            this.editCancelButton = new System.Windows.Forms.Button();
            this.editNameBox = new System.Windows.Forms.TextBox();
            this.editJobBox = new System.Windows.Forms.TextBox();
            this.EditNameWarning = new System.Windows.Forms.Label();
            this.EditJobWarning = new System.Windows.Forms.Label();
            this.editNameLabel = new System.Windows.Forms.Label();
            this.editJobLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // editOkayButton
            // 
            this.editOkayButton.Location = new System.Drawing.Point(188, 115);
            this.editOkayButton.Name = "editOkayButton";
            this.editOkayButton.Size = new System.Drawing.Size(132, 39);
            this.editOkayButton.TabIndex = 0;
            this.editOkayButton.Text = "Confirm";
            this.editOkayButton.UseVisualStyleBackColor = true;
            this.editOkayButton.Click += new System.EventHandler(this.editOkayButton_Click);
            // 
            // editCancelButton
            // 
            this.editCancelButton.Location = new System.Drawing.Point(12, 115);
            this.editCancelButton.Name = "editCancelButton";
            this.editCancelButton.Size = new System.Drawing.Size(132, 39);
            this.editCancelButton.TabIndex = 1;
            this.editCancelButton.Text = "Cancel";
            this.editCancelButton.UseVisualStyleBackColor = true;
            this.editCancelButton.Click += new System.EventHandler(this.editCancelButton_Click);
            // 
            // editNameBox
            // 
            this.editNameBox.Location = new System.Drawing.Point(56, 17);
            this.editNameBox.Name = "editNameBox";
            this.editNameBox.Size = new System.Drawing.Size(132, 20);
            this.editNameBox.TabIndex = 2;
            // 
            // editJobBox
            // 
            this.editJobBox.Location = new System.Drawing.Point(56, 56);
            this.editJobBox.Name = "editJobBox";
            this.editJobBox.Size = new System.Drawing.Size(132, 20);
            this.editJobBox.TabIndex = 3;
            // 
            // EditNameWarning
            // 
            this.EditNameWarning.AutoSize = true;
            this.EditNameWarning.Location = new System.Drawing.Point(190, 20);
            this.EditNameWarning.Name = "EditNameWarning";
            this.EditNameWarning.Size = new System.Drawing.Size(134, 13);
            this.EditNameWarning.TabIndex = 4;
            this.EditNameWarning.Text = "This field cannot be empty!";
            // 
            // EditJobWarning
            // 
            this.EditJobWarning.AutoSize = true;
            this.EditJobWarning.Location = new System.Drawing.Point(190, 59);
            this.EditJobWarning.Name = "EditJobWarning";
            this.EditJobWarning.Size = new System.Drawing.Size(134, 13);
            this.EditJobWarning.TabIndex = 5;
            this.EditJobWarning.Text = "This field cannot be empty!";
            // 
            // editNameLabel
            // 
            this.editNameLabel.AutoSize = true;
            this.editNameLabel.Location = new System.Drawing.Point(12, 20);
            this.editNameLabel.Name = "editNameLabel";
            this.editNameLabel.Size = new System.Drawing.Size(38, 13);
            this.editNameLabel.TabIndex = 6;
            this.editNameLabel.Text = "Name:";
            // 
            // editJobLabel
            // 
            this.editJobLabel.AutoSize = true;
            this.editJobLabel.Location = new System.Drawing.Point(23, 59);
            this.editJobLabel.Name = "editJobLabel";
            this.editJobLabel.Size = new System.Drawing.Size(27, 13);
            this.editJobLabel.TabIndex = 7;
            this.editJobLabel.Text = "Job:";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 176);
            this.Controls.Add(this.editJobLabel);
            this.Controls.Add(this.editNameLabel);
            this.Controls.Add(this.EditJobWarning);
            this.Controls.Add(this.EditNameWarning);
            this.Controls.Add(this.editJobBox);
            this.Controls.Add(this.editNameBox);
            this.Controls.Add(this.editCancelButton);
            this.Controls.Add(this.editOkayButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditForm";
            this.Text = "EditEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editOkayButton;
        private System.Windows.Forms.Button editCancelButton;
        private System.Windows.Forms.TextBox editNameBox;
        private System.Windows.Forms.TextBox editJobBox;
        private System.Windows.Forms.Label EditNameWarning;
        private System.Windows.Forms.Label EditJobWarning;
        private System.Windows.Forms.Label editNameLabel;
        private System.Windows.Forms.Label editJobLabel;
    }
}