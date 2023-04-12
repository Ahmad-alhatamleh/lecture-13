namespace lecture_13
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
            this.Submit = new System.Windows.Forms.Button();
            this.txtnamee = new System.Windows.Forms.TextBox();
            this.txtagee = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(216, 206);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(87, 51);
            this.Submit.TabIndex = 0;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // txtnamee
            // 
            this.txtnamee.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnamee.Location = new System.Drawing.Point(216, 55);
            this.txtnamee.Name = "txtnamee";
            this.txtnamee.Size = new System.Drawing.Size(161, 27);
            this.txtnamee.TabIndex = 1;
            this.txtnamee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnamee_KeyPress);
            // 
            // txtagee
            // 
            this.txtagee.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtagee.Location = new System.Drawing.Point(216, 124);
            this.txtagee.Name = "txtagee";
            this.txtagee.Size = new System.Drawing.Size(161, 27);
            this.txtagee.TabIndex = 2;
            this.txtagee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtagee_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter your name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(97, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Enter your age";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(435, 349);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtagee);
            this.Controls.Add(this.txtnamee);
            this.Controls.Add(this.Submit);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox txtnamee;
        private System.Windows.Forms.TextBox txtagee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

