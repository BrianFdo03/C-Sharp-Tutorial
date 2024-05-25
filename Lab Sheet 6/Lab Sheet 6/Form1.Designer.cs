
namespace Lab_Sheet_6
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
            this.btnEnterEmployeeDetails = new System.Windows.Forms.Button();
            this.btnEnterContactDetails = new System.Windows.Forms.Button();
            this.btnDisplayEmployeeDetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnterEmployeeDetails
            // 
            this.btnEnterEmployeeDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterEmployeeDetails.Location = new System.Drawing.Point(161, 55);
            this.btnEnterEmployeeDetails.Name = "btnEnterEmployeeDetails";
            this.btnEnterEmployeeDetails.Size = new System.Drawing.Size(419, 42);
            this.btnEnterEmployeeDetails.TabIndex = 0;
            this.btnEnterEmployeeDetails.Text = "Enter Employee Details";
            this.btnEnterEmployeeDetails.UseVisualStyleBackColor = true;
            this.btnEnterEmployeeDetails.Click += new System.EventHandler(this.btnEnterEmployeeDetails_Click);
            // 
            // btnEnterContactDetails
            // 
            this.btnEnterContactDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterContactDetails.Location = new System.Drawing.Point(161, 155);
            this.btnEnterContactDetails.Name = "btnEnterContactDetails";
            this.btnEnterContactDetails.Size = new System.Drawing.Size(419, 42);
            this.btnEnterContactDetails.TabIndex = 1;
            this.btnEnterContactDetails.Text = "Enter Contact Details";
            this.btnEnterContactDetails.UseVisualStyleBackColor = true;
            this.btnEnterContactDetails.Click += new System.EventHandler(this.btnEnterContactDetails_Click);
            // 
            // btnDisplayEmployeeDetails
            // 
            this.btnDisplayEmployeeDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayEmployeeDetails.Location = new System.Drawing.Point(161, 268);
            this.btnDisplayEmployeeDetails.Name = "btnDisplayEmployeeDetails";
            this.btnDisplayEmployeeDetails.Size = new System.Drawing.Size(419, 42);
            this.btnDisplayEmployeeDetails.TabIndex = 2;
            this.btnDisplayEmployeeDetails.Text = "Display Employee Details";
            this.btnDisplayEmployeeDetails.UseVisualStyleBackColor = true;
            this.btnDisplayEmployeeDetails.Click += new System.EventHandler(this.btnDisplayEmployeeDetails_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDisplayEmployeeDetails);
            this.Controls.Add(this.btnEnterContactDetails);
            this.Controls.Add(this.btnEnterEmployeeDetails);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnterEmployeeDetails;
        private System.Windows.Forms.Button btnEnterContactDetails;
        private System.Windows.Forms.Button btnDisplayEmployeeDetails;
    }
}

