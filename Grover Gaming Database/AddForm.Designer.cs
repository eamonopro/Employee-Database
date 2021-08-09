
namespace Grover_Gaming_Database
{
    partial class AddForm
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
            this.components = new System.ComponentModel.Container();
            this.addNameBox = new System.Windows.Forms.TextBox();
            this.addNameLabel = new System.Windows.Forms.Label();
            this.addJobLabel = new System.Windows.Forms.Label();
            this.addJobBox = new System.Windows.Forms.TextBox();
            this.addOkayButton = new System.Windows.Forms.Button();
            this.addNameWarning = new System.Windows.Forms.Label();
            this.addJobWarning = new System.Windows.Forms.Label();
            this.addCancelButton = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // addNameBox
            // 
            this.addNameBox.Location = new System.Drawing.Point(56, 17);
            this.addNameBox.Name = "addNameBox";
            this.addNameBox.Size = new System.Drawing.Size(132, 20);
            this.addNameBox.TabIndex = 1;
            // 
            // addNameLabel
            // 
            this.addNameLabel.AutoSize = true;
            this.addNameLabel.Location = new System.Drawing.Point(12, 20);
            this.addNameLabel.Name = "addNameLabel";
            this.addNameLabel.Size = new System.Drawing.Size(38, 13);
            this.addNameLabel.TabIndex = 0;
            this.addNameLabel.Text = "Name:";
            // 
            // addJobLabel
            // 
            this.addJobLabel.AutoSize = true;
            this.addJobLabel.Location = new System.Drawing.Point(23, 59);
            this.addJobLabel.Name = "addJobLabel";
            this.addJobLabel.Size = new System.Drawing.Size(27, 13);
            this.addJobLabel.TabIndex = 1;
            this.addJobLabel.Text = "Job:";
            // 
            // addJobBox
            // 
            this.addJobBox.Location = new System.Drawing.Point(56, 56);
            this.addJobBox.Name = "addJobBox";
            this.addJobBox.Size = new System.Drawing.Size(132, 20);
            this.addJobBox.TabIndex = 2;
            // 
            // addOkayButton
            // 
            this.addOkayButton.Location = new System.Drawing.Point(188, 115);
            this.addOkayButton.Name = "addOkayButton";
            this.addOkayButton.Size = new System.Drawing.Size(132, 39);
            this.addOkayButton.TabIndex = 3;
            this.addOkayButton.Text = "Confirm";
            this.addOkayButton.UseVisualStyleBackColor = true;
            this.addOkayButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // addNameWarning
            // 
            this.addNameWarning.AutoSize = true;
            this.addNameWarning.Location = new System.Drawing.Point(194, 24);
            this.addNameWarning.Name = "addNameWarning";
            this.addNameWarning.Size = new System.Drawing.Size(134, 13);
            this.addNameWarning.TabIndex = 5;
            this.addNameWarning.Text = "This field cannot be empty!";
            // 
            // addJobWarning
            // 
            this.addJobWarning.AutoSize = true;
            this.addJobWarning.Location = new System.Drawing.Point(194, 63);
            this.addJobWarning.Name = "addJobWarning";
            this.addJobWarning.Size = new System.Drawing.Size(134, 13);
            this.addJobWarning.TabIndex = 6;
            this.addJobWarning.Text = "This field cannot be empty!";
            // 
            // addCancelButton
            // 
            this.addCancelButton.Location = new System.Drawing.Point(12, 115);
            this.addCancelButton.Name = "addCancelButton";
            this.addCancelButton.Size = new System.Drawing.Size(132, 39);
            this.addCancelButton.TabIndex = 4;
            this.addCancelButton.Text = "Cancel";
            this.addCancelButton.UseVisualStyleBackColor = true;
            this.addCancelButton.Click += new System.EventHandler(this.addCancelButton_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // AddForm
            // 
            this.AcceptButton = this.addOkayButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 176);
            this.Controls.Add(this.addCancelButton);
            this.Controls.Add(this.addNameWarning);
            this.Controls.Add(this.addJobWarning);
            this.Controls.Add(this.addOkayButton);
            this.Controls.Add(this.addNameBox);
            this.Controls.Add(this.addJobBox);
            this.Controls.Add(this.addJobLabel);
            this.Controls.Add(this.addNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddForm";
            this.Text = "Add Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox addNameBox;
        private System.Windows.Forms.Label addNameLabel;
        private System.Windows.Forms.Label addJobLabel;
        private System.Windows.Forms.TextBox addJobBox;
        private System.Windows.Forms.Button addOkayButton;
        private System.Windows.Forms.Label addNameWarning;
        private System.Windows.Forms.Label addJobWarning;
        private System.Windows.Forms.Button addCancelButton;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}