namespace PooblesCandyShop
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
            this.candyInputLabel = new System.Windows.Forms.Label();
            this.activateCalButton = new System.Windows.Forms.Button();
            this.candyInput = new System.Windows.Forms.TextBox();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.totalOutputLabel = new System.Windows.Forms.Label();
            this.taxOutputLabel = new System.Windows.Forms.Label();
            this.subtotalOutputLabel = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.pooble = new System.Windows.Forms.PictureBox();
            this.errorLabel1 = new System.Windows.Forms.Label();
            this.errorLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pooble)).BeginInit();
            this.SuspendLayout();
            // 
            // candyInputLabel
            // 
            this.candyInputLabel.AutoSize = true;
            this.candyInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candyInputLabel.Location = new System.Drawing.Point(12, 42);
            this.candyInputLabel.Name = "candyInputLabel";
            this.candyInputLabel.Size = new System.Drawing.Size(180, 24);
            this.candyInputLabel.TabIndex = 0;
            this.candyInputLabel.Text = "How many candys?:\r\n";
            // 
            // activateCalButton
            // 
            this.activateCalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activateCalButton.Location = new System.Drawing.Point(95, 102);
            this.activateCalButton.Name = "activateCalButton";
            this.activateCalButton.Size = new System.Drawing.Size(168, 61);
            this.activateCalButton.TabIndex = 1;
            this.activateCalButton.Text = "Calculate Price";
            this.activateCalButton.UseVisualStyleBackColor = true;
            this.activateCalButton.Click += new System.EventHandler(this.activateCalButton_Click);
            // 
            // candyInput
            // 
            this.candyInput.Location = new System.Drawing.Point(214, 47);
            this.candyInput.Name = "candyInput";
            this.candyInput.Size = new System.Drawing.Size(111, 20);
            this.candyInput.TabIndex = 2;
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.AutoSize = true;
            this.subtotalOutput.BackColor = System.Drawing.Color.White;
            this.subtotalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalOutput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.subtotalOutput.Location = new System.Drawing.Point(210, 234);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(10, 24);
            this.subtotalOutput.TabIndex = 3;
            this.subtotalOutput.Text = "\r\n";
            // 
            // totalOutput
            // 
            this.totalOutput.AutoSize = true;
            this.totalOutput.BackColor = System.Drawing.Color.White;
            this.totalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutput.Location = new System.Drawing.Point(210, 360);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(10, 24);
            this.totalOutput.TabIndex = 5;
            this.totalOutput.Text = "\r\n";
            // 
            // totalOutputLabel
            // 
            this.totalOutputLabel.AutoSize = true;
            this.totalOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutputLabel.Location = new System.Drawing.Point(12, 360);
            this.totalOutputLabel.Name = "totalOutputLabel";
            this.totalOutputLabel.Size = new System.Drawing.Size(56, 24);
            this.totalOutputLabel.TabIndex = 6;
            this.totalOutputLabel.Text = "Total:\r\n";
            // 
            // taxOutputLabel
            // 
            this.taxOutputLabel.AutoSize = true;
            this.taxOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOutputLabel.Location = new System.Drawing.Point(12, 298);
            this.taxOutputLabel.Name = "taxOutputLabel";
            this.taxOutputLabel.Size = new System.Drawing.Size(47, 24);
            this.taxOutputLabel.TabIndex = 7;
            this.taxOutputLabel.Text = "Tax:\r\n";
            // 
            // subtotalOutputLabel
            // 
            this.subtotalOutputLabel.AutoSize = true;
            this.subtotalOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalOutputLabel.Location = new System.Drawing.Point(12, 234);
            this.subtotalOutputLabel.Name = "subtotalOutputLabel";
            this.subtotalOutputLabel.Size = new System.Drawing.Size(82, 24);
            this.subtotalOutputLabel.TabIndex = 8;
            this.subtotalOutputLabel.Text = "Subtotal:\r\n";
            // 
            // taxOutput
            // 
            this.taxOutput.AutoSize = true;
            this.taxOutput.BackColor = System.Drawing.Color.White;
            this.taxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOutput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.taxOutput.Location = new System.Drawing.Point(210, 298);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(10, 24);
            this.taxOutput.TabIndex = 9;
            this.taxOutput.Text = "\r\n";
            // 
            // pooble
            // 
            this.pooble.Image = global::PooblesCandyShop.Properties.Resources.pooble;
            this.pooble.Location = new System.Drawing.Point(384, 112);
            this.pooble.Name = "pooble";
            this.pooble.Size = new System.Drawing.Size(251, 320);
            this.pooble.TabIndex = 10;
            this.pooble.TabStop = false;
            // 
            // errorLabel1
            // 
            this.errorLabel1.AutoSize = true;
            this.errorLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel1.Location = new System.Drawing.Point(380, 42);
            this.errorLabel1.Name = "errorLabel1";
            this.errorLabel1.Size = new System.Drawing.Size(0, 20);
            this.errorLabel1.TabIndex = 11;
            // 
            // errorLabel2
            // 
            this.errorLabel2.AutoSize = true;
            this.errorLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel2.Location = new System.Drawing.Point(380, 81);
            this.errorLabel2.Name = "errorLabel2";
            this.errorLabel2.Size = new System.Drawing.Size(0, 20);
            this.errorLabel2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(647, 444);
            this.Controls.Add(this.errorLabel2);
            this.Controls.Add(this.errorLabel1);
            this.Controls.Add(this.pooble);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subtotalOutputLabel);
            this.Controls.Add(this.taxOutputLabel);
            this.Controls.Add(this.totalOutputLabel);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.candyInput);
            this.Controls.Add(this.activateCalButton);
            this.Controls.Add(this.candyInputLabel);
            this.Name = "Form1";
            this.Text = "Pooble\'s Candy Shop";
            ((System.ComponentModel.ISupportInitialize)(this.pooble)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label candyInputLabel;
        private System.Windows.Forms.Button activateCalButton;
        private System.Windows.Forms.TextBox candyInput;
        private System.Windows.Forms.Label subtotalOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label totalOutputLabel;
        private System.Windows.Forms.Label taxOutputLabel;
        private System.Windows.Forms.Label subtotalOutputLabel;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.PictureBox pooble;
        private System.Windows.Forms.Label errorLabel1;
        private System.Windows.Forms.Label errorLabel2;
    }
}

