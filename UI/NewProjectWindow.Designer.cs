﻿namespace MinishMaker.UI
{
    partial class NewProjectWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProjectWindow));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.projectNameTextBox = new System.Windows.Forms.TextBox();
            this.baseROMTextBox = new System.Windows.Forms.TextBox();
            this.baseROMButton = new System.Windows.Forms.Button();
            this.projectLabel = new System.Windows.Forms.Label();
            this.projectButton = new System.Windows.Forms.Button();
            this.projectTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.baseROMLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.projectNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.projectNameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.baseROMTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.baseROMButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.projectLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.projectButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.projectTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cancelButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.createButton, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.baseROMLabel, 0, 1);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(477, 182);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.projectNameLabel.AutoSize = true;
            this.projectNameLabel.Location = new System.Drawing.Point(23, 18);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(74, 13);
            this.projectNameLabel.TabIndex = 6;
            this.projectNameLabel.Text = "Project Name:";
            // 
            // projectNameTextBox
            // 
            this.projectNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.projectNameTextBox, 2);
            this.projectNameTextBox.Location = new System.Drawing.Point(103, 15);
            this.projectNameTextBox.Name = "projectNameTextBox";
            this.projectNameTextBox.Size = new System.Drawing.Size(371, 20);
            this.projectNameTextBox.TabIndex = 7;
            // 
            // baseROMTextBox
            // 
            this.baseROMTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.baseROMTextBox.Location = new System.Drawing.Point(103, 65);
            this.baseROMTextBox.Name = "baseROMTextBox";
            this.baseROMTextBox.Size = new System.Drawing.Size(261, 20);
            this.baseROMTextBox.TabIndex = 2;
            // 
            // baseROMButton
            // 
            this.baseROMButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.baseROMButton.Location = new System.Drawing.Point(370, 63);
            this.baseROMButton.Name = "baseROMButton";
            this.baseROMButton.Size = new System.Drawing.Size(104, 23);
            this.baseROMButton.TabIndex = 4;
            this.baseROMButton.Text = "Browse";
            this.baseROMButton.UseVisualStyleBackColor = true;
            this.baseROMButton.Click += new System.EventHandler(this.baseROMButton_Click);
            // 
            // projectLabel
            // 
            this.projectLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.projectLabel.AutoSize = true;
            this.projectLabel.Location = new System.Drawing.Point(10, 118);
            this.projectLabel.Name = "projectLabel";
            this.projectLabel.Size = new System.Drawing.Size(87, 13);
            this.projectLabel.TabIndex = 1;
            this.projectLabel.Text = "Project Location:";
            // 
            // projectButton
            // 
            this.projectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.projectButton.Location = new System.Drawing.Point(370, 113);
            this.projectButton.Name = "projectButton";
            this.projectButton.Size = new System.Drawing.Size(104, 23);
            this.projectButton.TabIndex = 5;
            this.projectButton.Text = "Browse";
            this.projectButton.UseVisualStyleBackColor = true;
            this.projectButton.Click += new System.EventHandler(this.projectButton_Click);
            // 
            // projectTextBox
            // 
            this.projectTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.projectTextBox.Location = new System.Drawing.Point(103, 115);
            this.projectTextBox.Name = "projectTextBox";
            this.projectTextBox.Size = new System.Drawing.Size(261, 20);
            this.projectTextBox.TabIndex = 3;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(3, 154);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(94, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // createButton
            // 
            this.createButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.createButton.Location = new System.Drawing.Point(370, 154);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(104, 23);
            this.createButton.TabIndex = 9;
            this.createButton.Text = "Create Project";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // baseROMLabel
            // 
            this.baseROMLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.baseROMLabel.AutoSize = true;
            this.baseROMLabel.Location = new System.Drawing.Point(35, 68);
            this.baseROMLabel.Name = "baseROMLabel";
            this.baseROMLabel.Size = new System.Drawing.Size(62, 13);
            this.baseROMLabel.TabIndex = 0;
            this.baseROMLabel.Text = "Base ROM:";
            this.baseROMLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewProjectWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 206);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(517, 245);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(517, 245);
            this.Name = "NewProjectWindow";
            this.Text = "Create New Project";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label baseROMLabel;
        private System.Windows.Forms.TextBox baseROMTextBox;
        private System.Windows.Forms.Button baseROMButton;
        private System.Windows.Forms.Label projectLabel;
        private System.Windows.Forms.TextBox projectTextBox;
        private System.Windows.Forms.Button projectButton;
        private System.Windows.Forms.Label projectNameLabel;
        private System.Windows.Forms.TextBox projectNameTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button createButton;
    }
}