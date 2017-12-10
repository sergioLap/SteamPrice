using System.Collections.Generic;
using System.Windows.Forms;

namespace SteamPrice
{
    partial class GetHistoryPriceForm
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
            this.HashNameAssetLabel = new System.Windows.Forms.Label();
            this.LoadHistoryPriceButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.LotLabel = new System.Windows.Forms.Label();
            this.LotTextBox = new System.Windows.Forms.TextBox();
            this.GameListlabel = new System.Windows.Forms.Label();
            this.GameListComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // HashNameAssetLabel
            // 
            this.HashNameAssetLabel.AutoSize = true;
            this.HashNameAssetLabel.Location = new System.Drawing.Point(12, 9);
            this.HashNameAssetLabel.Name = "HashNameAssetLabel";
            this.HashNameAssetLabel.Size = new System.Drawing.Size(0, 13);
            this.HashNameAssetLabel.TabIndex = 0;
            this.HashNameAssetLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LoadHistoryPriceButton
            // 
            this.LoadHistoryPriceButton.Location = new System.Drawing.Point(84, 201);
            this.LoadHistoryPriceButton.Name = "LoadHistoryPriceButton";
            this.LoadHistoryPriceButton.Size = new System.Drawing.Size(141, 55);
            this.LoadHistoryPriceButton.TabIndex = 2;
            this.LoadHistoryPriceButton.Text = "Загрузить цены";
            this.LoadHistoryPriceButton.UseVisualStyleBackColor = true;
            this.LoadHistoryPriceButton.Click += new System.EventHandler(this.LoadHistoryPriceButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // LotLabel
            // 
            this.LotLabel.AutoSize = true;
            this.LotLabel.Location = new System.Drawing.Point(81, 69);
            this.LotLabel.Name = "LotLabel";
            this.LotLabel.Size = new System.Drawing.Size(26, 13);
            this.LotLabel.TabIndex = 0;
            this.LotLabel.Text = "Лот";
            this.LotLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LotTextBox
            // 
            this.LotTextBox.Location = new System.Drawing.Point(84, 85);
            this.LotTextBox.Name = "LotTextBox";
            this.LotTextBox.Size = new System.Drawing.Size(141, 20);
            this.LotTextBox.TabIndex = 1;
            // 
            // GameListlabel
            // 
            this.GameListlabel.AutoSize = true;
            this.GameListlabel.Location = new System.Drawing.Point(81, 9);
            this.GameListlabel.Name = "GameListlabel";
            this.GameListlabel.Size = new System.Drawing.Size(32, 13);
            this.GameListlabel.TabIndex = 3;
            this.GameListlabel.Text = "Игра";
            this.GameListlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GameListComboBox
            // 
            this.GameListComboBox.FormattingEnabled = true;
            this.GameListComboBox.Location = new System.Drawing.Point(84, 25);
            this.GameListComboBox.Name = "GameListComboBox";
            this.GameListComboBox.Size = new System.Drawing.Size(140, 21);
            this.GameListComboBox.TabIndex = 4;
            // 
            // GetHistoryPriceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 268);
            this.Controls.Add(this.GameListComboBox);
            this.Controls.Add(this.GameListlabel);
            this.Controls.Add(this.LoadHistoryPriceButton);
            this.Controls.Add(this.LotTextBox);
            this.Controls.Add(this.LotLabel);
            this.Controls.Add(this.HashNameAssetLabel);
            this.MaximumSize = new System.Drawing.Size(325, 307);
            this.MinimumSize = new System.Drawing.Size(325, 307);
            this.Name = "GetHistoryPriceForm";
            this.Text = "SteamPrice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HashNameAssetLabel;
        private System.Windows.Forms.Button LoadHistoryPriceButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label LotLabel;
        private System.Windows.Forms.TextBox LotTextBox;
        private System.Windows.Forms.Label GameListlabel;
        private System.Windows.Forms.ComboBox GameListComboBox;
    }
}

