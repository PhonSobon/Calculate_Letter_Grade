﻿namespace Calculate_Letter_Grade
{
    partial class frmCalculateLetterGrade
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
            this.txtNumericGrade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalculateLetterGrade = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblLetterGrade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numeric Grade:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNumericGrade
            // 
            this.txtNumericGrade.Location = new System.Drawing.Point(124, 39);
            this.txtNumericGrade.Name = "txtNumericGrade";
            this.txtNumericGrade.Size = new System.Drawing.Size(200, 22);
            this.txtNumericGrade.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Letter Grade:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCalculateLetterGrade
            // 
            this.btnCalculateLetterGrade.Location = new System.Drawing.Point(68, 151);
            this.btnCalculateLetterGrade.Name = "btnCalculateLetterGrade";
            this.btnCalculateLetterGrade.Size = new System.Drawing.Size(86, 74);
            this.btnCalculateLetterGrade.TabIndex = 2;
            this.btnCalculateLetterGrade.Text = "&Calculate Letter Grade";
            this.btnCalculateLetterGrade.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(193, 151);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 74);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // lblLetterGrade
            // 
            this.lblLetterGrade.BackColor = System.Drawing.SystemColors.Window;
            this.lblLetterGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLetterGrade.Location = new System.Drawing.Point(132, 87);
            this.lblLetterGrade.Name = "lblLetterGrade";
            this.lblLetterGrade.Size = new System.Drawing.Size(200, 23);
            this.lblLetterGrade.TabIndex = 4;
            // 
            // frmCalculateLetterGrade
            // 
            this.AcceptButton = this.btnCalculateLetterGrade;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(344, 237);
            this.Controls.Add(this.lblLetterGrade);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculateLetterGrade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumericGrade);
            this.Controls.Add(this.label1);
            this.Name = "frmCalculateLetterGrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculate Letter Grade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumericGrade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalculateLetterGrade;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblLetterGrade;
    }
}

