namespace VivaVstoreTask
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
            this.TestBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ResponseLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AmountTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RespnseTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TestBtn
            // 
            this.TestBtn.Location = new System.Drawing.Point(115, 113);
            this.TestBtn.Name = "TestBtn";
            this.TestBtn.Size = new System.Drawing.Size(129, 43);
            this.TestBtn.TabIndex = 0;
            this.TestBtn.Text = "Pay";
            this.TestBtn.UseVisualStyleBackColor = true;
            this.TestBtn.Click += new System.EventHandler(this.TestBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Response";
            // 
            // ResponseLbl
            // 
            this.ResponseLbl.AutoSize = true;
            this.ResponseLbl.Location = new System.Drawing.Point(83, 158);
            this.ResponseLbl.Name = "ResponseLbl";
            this.ResponseLbl.Size = new System.Drawing.Size(0, 13);
            this.ResponseLbl.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Amount";
            // 
            // AmountTxt
            // 
            this.AmountTxt.Font = new System.Drawing.Font("Tahoma", 12F);
            this.AmountTxt.Location = new System.Drawing.Point(115, 37);
            this.AmountTxt.Name = "AmountTxt";
            this.AmountTxt.Size = new System.Drawing.Size(194, 27);
            this.AmountTxt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(22, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.TabIndex = 7;
            // 
            // RespnseTxt
            // 
            this.RespnseTxt.AutoSize = true;
            this.RespnseTxt.Location = new System.Drawing.Point(349, 62);
            this.RespnseTxt.Name = "RespnseTxt";
            this.RespnseTxt.Size = new System.Drawing.Size(0, 13);
            this.RespnseTxt.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 261);
            this.Controls.Add(this.RespnseTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AmountTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResponseLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TestBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Payment Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TestBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ResponseLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AmountTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label RespnseTxt;
    }
}

