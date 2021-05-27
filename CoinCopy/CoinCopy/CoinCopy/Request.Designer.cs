﻿
namespace CoinCopy
{
    partial class Request
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
            this.cmbRequest = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.stockNumberTextBox = new System.Windows.Forms.TextBox();
            this.grpPrice = new System.Windows.Forms.GroupBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.rdoCustomPrice = new System.Windows.Forms.RadioButton();
            this.rdoMarketPrice = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.grpPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbRequest
            // 
            this.cmbRequest.FormattingEnabled = true;
            this.cmbRequest.Location = new System.Drawing.Point(11, 71);
            this.cmbRequest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRequest.Name = "cmbRequest";
            this.cmbRequest.Size = new System.Drawing.Size(98, 23);
            this.cmbRequest.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(373, 162);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 22);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "확인";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // stockNumberTextBox
            // 
            this.stockNumberTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.stockNumberTextBox.Location = new System.Drawing.Point(178, 71);
            this.stockNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stockNumberTextBox.Name = "stockNumberTextBox";
            this.stockNumberTextBox.Size = new System.Drawing.Size(73, 25);
            this.stockNumberTextBox.TabIndex = 2;
            this.stockNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stockNumberTextBox_KeyPress);
            // 
            // grpPrice
            // 
            this.grpPrice.Controls.Add(this.priceTextBox);
            this.grpPrice.Controls.Add(this.rdoCustomPrice);
            this.grpPrice.Controls.Add(this.rdoMarketPrice);
            this.grpPrice.Location = new System.Drawing.Point(273, 25);
            this.grpPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPrice.Name = "grpPrice";
            this.grpPrice.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPrice.Size = new System.Drawing.Size(175, 131);
            this.grpPrice.TabIndex = 3;
            this.grpPrice.TabStop = false;
            this.grpPrice.Text = "가격";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Enabled = false;
            this.priceTextBox.Location = new System.Drawing.Point(16, 84);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(139, 25);
            this.priceTextBox.TabIndex = 4;
            // 
            // rdoCustomPrice
            // 
            this.rdoCustomPrice.AutoSize = true;
            this.rdoCustomPrice.Location = new System.Drawing.Point(16, 59);
            this.rdoCustomPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoCustomPrice.Name = "rdoCustomPrice";
            this.rdoCustomPrice.Size = new System.Drawing.Size(73, 19);
            this.rdoCustomPrice.TabIndex = 1;
            this.rdoCustomPrice.TabStop = true;
            this.rdoCustomPrice.Text = "지정가";
            this.rdoCustomPrice.UseVisualStyleBackColor = true;
            this.rdoCustomPrice.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rdoCustomPrice_MouseClick);
            // 
            // rdoMarketPrice
            // 
            this.rdoMarketPrice.AutoSize = true;
            this.rdoMarketPrice.Location = new System.Drawing.Point(16, 34);
            this.rdoMarketPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoMarketPrice.Name = "rdoMarketPrice";
            this.rdoMarketPrice.Size = new System.Drawing.Size(73, 19);
            this.rdoMarketPrice.TabIndex = 0;
            this.rdoMarketPrice.TabStop = true;
            this.rdoMarketPrice.Text = "시장가";
            this.rdoMarketPrice.UseVisualStyleBackColor = true;
            this.rdoMarketPrice.CheckedChanged += new System.EventHandler(this.rdoMarketPrice_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "수량";
            // 
            // Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 198);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpPrice);
            this.Controls.Add(this.stockNumberTextBox);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cmbRequest);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Request";
            this.Text = "Request";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Request_FormClosing);
            this.Load += new System.EventHandler(this.Request_Load);
            this.grpPrice.ResumeLayout(false);
            this.grpPrice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRequest;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox stockNumberTextBox;
        private System.Windows.Forms.GroupBox grpPrice;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.RadioButton rdoCustomPrice;
        private System.Windows.Forms.RadioButton rdoMarketPrice;
        private System.Windows.Forms.Label label1;
    }
}