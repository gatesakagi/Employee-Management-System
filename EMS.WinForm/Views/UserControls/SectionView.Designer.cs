﻿namespace EMS.WinForm.Views.UserControls
{
    partial class SectionView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.MenuToolStrip = new System.Windows.Forms.ToolStrip();
            this.NewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.CopyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ViewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SearchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SearchToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.MessageStatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.SectionDetailPanel = new System.Windows.Forms.Panel();
            this.DepartmentComboBox = new System.Windows.Forms.ComboBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SectionCodeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SectionNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SectionGridView = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.MenuToolStrip.SuspendLayout();
            this.MessageStatusStrip.SuspendLayout();
            this.SectionDetailPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SectionGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 22);
            this.panel2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Section Configuration";
            // 
            // MenuToolStrip
            // 
            this.MenuToolStrip.AutoSize = false;
            this.MenuToolStrip.BackColor = System.Drawing.Color.White;
            this.MenuToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripButton,
            this.EditToolStripButton,
            this.CopyToolStripButton,
            this.toolStripSeparator3,
            this.ViewToolStripButton,
            this.toolStripSeparator2,
            this.DeleteToolStripButton,
            this.SearchToolStripButton,
            this.SearchToolStripTextBox,
            this.toolStripLabel1});
            this.MenuToolStrip.Location = new System.Drawing.Point(0, 22);
            this.MenuToolStrip.Name = "MenuToolStrip";
            this.MenuToolStrip.Size = new System.Drawing.Size(800, 28);
            this.MenuToolStrip.Stretch = true;
            this.MenuToolStrip.TabIndex = 6;
            this.MenuToolStrip.Text = "toolStrip1";
            // 
            // NewToolStripButton
            // 
            this.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewToolStripButton.Image = global::EMS.WinForm.Properties.Resources.Add_16xMD;
            this.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewToolStripButton.Margin = new System.Windows.Forms.Padding(3);
            this.NewToolStripButton.Name = "NewToolStripButton";
            this.NewToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.NewToolStripButton.Text = "New";
            this.NewToolStripButton.Click += new System.EventHandler(this.NewToolStripButton_Click);
            // 
            // EditToolStripButton
            // 
            this.EditToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditToolStripButton.Image = global::EMS.WinForm.Properties.Resources.Edit_grey_16xMD;
            this.EditToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditToolStripButton.Margin = new System.Windows.Forms.Padding(3);
            this.EditToolStripButton.Name = "EditToolStripButton";
            this.EditToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.EditToolStripButton.Text = "Edit";
            this.EditToolStripButton.ToolTipText = "Edit";
            this.EditToolStripButton.Click += new System.EventHandler(this.EditToolStripButton_Click);
            // 
            // CopyToolStripButton
            // 
            this.CopyToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CopyToolStripButton.Image = global::EMS.WinForm.Properties.Resources.CopyToClipboard_16x;
            this.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CopyToolStripButton.Margin = new System.Windows.Forms.Padding(3);
            this.CopyToolStripButton.Name = "CopyToolStripButton";
            this.CopyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.CopyToolStripButton.Text = "Copy";
            this.CopyToolStripButton.Click += new System.EventHandler(this.CopyToolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // ViewToolStripButton
            // 
            this.ViewToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ViewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ViewToolStripButton.Image = global::EMS.WinForm.Properties.Resources.table_16xMD;
            this.ViewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ViewToolStripButton.Margin = new System.Windows.Forms.Padding(3);
            this.ViewToolStripButton.Name = "ViewToolStripButton";
            this.ViewToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ViewToolStripButton.Text = "View";
            this.ViewToolStripButton.Click += new System.EventHandler(this.ViewToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // DeleteToolStripButton
            // 
            this.DeleteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteToolStripButton.Image = global::EMS.WinForm.Properties.Resources.Cancel_16xMD;
            this.DeleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteToolStripButton.Margin = new System.Windows.Forms.Padding(3);
            this.DeleteToolStripButton.Name = "DeleteToolStripButton";
            this.DeleteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.DeleteToolStripButton.Text = "Delete";
            this.DeleteToolStripButton.ToolTipText = "Delete";
            this.DeleteToolStripButton.Click += new System.EventHandler(this.DeleteToolStripButton_Click);
            // 
            // SearchToolStripButton
            // 
            this.SearchToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.SearchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SearchToolStripButton.Image = global::EMS.WinForm.Properties.Resources.Search_16xMD;
            this.SearchToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SearchToolStripButton.Margin = new System.Windows.Forms.Padding(3);
            this.SearchToolStripButton.Name = "SearchToolStripButton";
            this.SearchToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.SearchToolStripButton.Text = "Search";
            this.SearchToolStripButton.Click += new System.EventHandler(this.SearchToolStripButton_Click);
            // 
            // SearchToolStripTextBox
            // 
            this.SearchToolStripTextBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.SearchToolStripTextBox.AutoSize = false;
            this.SearchToolStripTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.SearchToolStripTextBox.Margin = new System.Windows.Forms.Padding(3);
            this.SearchToolStripTextBox.Name = "SearchToolStripTextBox";
            this.SearchToolStripTextBox.Size = new System.Drawing.Size(120, 21);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 22);
            this.toolStripLabel1.Text = "Search";
            // 
            // MessageStatusStrip
            // 
            this.MessageStatusStrip.AutoSize = false;
            this.MessageStatusStrip.BackColor = System.Drawing.Color.White;
            this.MessageStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.MessageStatusStrip.Location = new System.Drawing.Point(0, 572);
            this.MessageStatusStrip.Name = "MessageStatusStrip";
            this.MessageStatusStrip.Size = new System.Drawing.Size(800, 28);
            this.MessageStatusStrip.TabIndex = 8;
            this.MessageStatusStrip.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(3);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(38, 22);
            this.StatusLabel.Text = "Saved";
            // 
            // SectionDetailPanel
            // 
            this.SectionDetailPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SectionDetailPanel.Controls.Add(this.DepartmentComboBox);
            this.SectionDetailPanel.Controls.Add(this.CancelButton);
            this.SectionDetailPanel.Controls.Add(this.SaveButton);
            this.SectionDetailPanel.Controls.Add(this.label3);
            this.SectionDetailPanel.Controls.Add(this.SectionCodeTextBox);
            this.SectionDetailPanel.Controls.Add(this.label2);
            this.SectionDetailPanel.Controls.Add(this.SectionNameTextBox);
            this.SectionDetailPanel.Controls.Add(this.label1);
            this.SectionDetailPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SectionDetailPanel.Enabled = false;
            this.SectionDetailPanel.Location = new System.Drawing.Point(0, 50);
            this.SectionDetailPanel.Name = "SectionDetailPanel";
            this.SectionDetailPanel.Size = new System.Drawing.Size(220, 522);
            this.SectionDetailPanel.TabIndex = 9;
            // 
            // DepartmentComboBox
            // 
            this.DepartmentComboBox.FormattingEnabled = true;
            this.DepartmentComboBox.Location = new System.Drawing.Point(17, 36);
            this.DepartmentComboBox.Name = "DepartmentComboBox";
            this.DepartmentComboBox.Size = new System.Drawing.Size(184, 21);
            this.DepartmentComboBox.TabIndex = 8;
            this.DepartmentComboBox.SelectedIndexChanged += new System.EventHandler(this.DepartmentComboBox_SelectedIndexChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.Image = global::EMS.WinForm.Properties.Resources.Cancel_grey_16xMD;
            this.CancelButton.Location = new System.Drawing.Point(89, 157);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(66, 26);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Image = global::EMS.WinForm.Properties.Resources.save_16xMD;
            this.SaveButton.Location = new System.Drawing.Point(17, 157);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(66, 26);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Section Code:";
            // 
            // SectionCodeTextBox
            // 
            this.SectionCodeTextBox.Location = new System.Drawing.Point(17, 119);
            this.SectionCodeTextBox.Name = "SectionCodeTextBox";
            this.SectionCodeTextBox.Size = new System.Drawing.Size(184, 20);
            this.SectionCodeTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Section Name:";
            // 
            // SectionNameTextBox
            // 
            this.SectionNameTextBox.Location = new System.Drawing.Point(17, 77);
            this.SectionNameTextBox.Name = "SectionNameTextBox";
            this.SectionNameTextBox.Size = new System.Drawing.Size(184, 20);
            this.SectionNameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Department:";
            // 
            // SectionGridView
            // 
            this.SectionGridView.BackgroundColor = System.Drawing.Color.White;
            this.SectionGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SectionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SectionGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SectionGridView.Location = new System.Drawing.Point(220, 50);
            this.SectionGridView.Name = "SectionGridView";
            this.SectionGridView.Size = new System.Drawing.Size(580, 522);
            this.SectionGridView.TabIndex = 10;
            // 
            // SectionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SectionGridView);
            this.Controls.Add(this.SectionDetailPanel);
            this.Controls.Add(this.MessageStatusStrip);
            this.Controls.Add(this.MenuToolStrip);
            this.Controls.Add(this.panel2);
            this.Name = "SectionView";
            this.Size = new System.Drawing.Size(800, 600);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.MenuToolStrip.ResumeLayout(false);
            this.MenuToolStrip.PerformLayout();
            this.MessageStatusStrip.ResumeLayout(false);
            this.MessageStatusStrip.PerformLayout();
            this.SectionDetailPanel.ResumeLayout(false);
            this.SectionDetailPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SectionGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStrip MenuToolStrip;
        private System.Windows.Forms.ToolStripButton NewToolStripButton;
        private System.Windows.Forms.ToolStripButton EditToolStripButton;
        private System.Windows.Forms.ToolStripButton CopyToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton ViewToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton DeleteToolStripButton;
        private System.Windows.Forms.ToolStripButton SearchToolStripButton;
        private System.Windows.Forms.ToolStripTextBox SearchToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.StatusStrip MessageStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.Panel SectionDetailPanel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SectionCodeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SectionNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView SectionGridView;
        private System.Windows.Forms.ComboBox DepartmentComboBox;
    }
}
