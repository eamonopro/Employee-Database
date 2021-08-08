
namespace Grover_Gaming_Database
{
    partial class homePage
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
            this.mainAddButton = new System.Windows.Forms.Button();
            this.employeeList = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.jobTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mainDeleteButton = new System.Windows.Forms.Button();
            this.mainEditButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainAddButton
            // 
            this.mainAddButton.Location = new System.Drawing.Point(626, 366);
            this.mainAddButton.Name = "mainAddButton";
            this.mainAddButton.Size = new System.Drawing.Size(162, 54);
            this.mainAddButton.TabIndex = 3;
            this.mainAddButton.Text = "Add New Employee";
            this.mainAddButton.UseVisualStyleBackColor = true;
            this.mainAddButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // employeeList
            // 
            this.employeeList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.jobTitle});
            this.employeeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeList.FullRowSelect = true;
            this.employeeList.GridLines = true;
            this.employeeList.Location = new System.Drawing.Point(12, 12);
            this.employeeList.MultiSelect = false;
            this.employeeList.Name = "employeeList";
            this.employeeList.Size = new System.Drawing.Size(776, 330);
            this.employeeList.TabIndex = 1;
            this.employeeList.UseCompatibleStateImageBehavior = false;
            this.employeeList.View = System.Windows.Forms.View.Details;
            this.employeeList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.employeeList_ColumnClick);
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 268;
            // 
            // jobTitle
            // 
            this.jobTitle.Text = "Job Title";
            this.jobTitle.Width = 504;
            // 
            // mainDeleteButton
            // 
            this.mainDeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainDeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.mainDeleteButton.Location = new System.Drawing.Point(12, 366);
            this.mainDeleteButton.Name = "mainDeleteButton";
            this.mainDeleteButton.Size = new System.Drawing.Size(162, 54);
            this.mainDeleteButton.TabIndex = 1;
            this.mainDeleteButton.Text = "Delete Employee";
            this.mainDeleteButton.UseVisualStyleBackColor = true;
            this.mainDeleteButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // mainEditButton
            // 
            this.mainEditButton.Location = new System.Drawing.Point(434, 366);
            this.mainEditButton.Name = "mainEditButton";
            this.mainEditButton.Size = new System.Drawing.Size(162, 54);
            this.mainEditButton.TabIndex = 2;
            this.mainEditButton.Text = "Edit Employee";
            this.mainEditButton.UseVisualStyleBackColor = true;
            this.mainEditButton.Click += new System.EventHandler(this.mainEditButton_Click);
            // 
            // homePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainEditButton);
            this.Controls.Add(this.mainDeleteButton);
            this.Controls.Add(this.employeeList);
            this.Controls.Add(this.mainAddButton);
            this.Name = "homePage";
            this.Text = "Employee Database";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mainAddButton;
        private System.Windows.Forms.ListView employeeList;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader jobTitle;
        private System.Windows.Forms.Button mainDeleteButton;
        private System.Windows.Forms.Button mainEditButton;
    }
}

