using System;
using System.Windows.Forms;

namespace SportsApp
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
            this.components = new System.ComponentModel.Container();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.searchResult = new System.Windows.Forms.ListView();
            this.showBrothers = new System.Windows.Forms.Button();
            this.showCouples = new System.Windows.Forms.Button();
            this.showParentsWithSiblings = new System.Windows.Forms.Button();
            this.radioauthorityButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioshowChildren = new System.Windows.Forms.RadioButton();
            this.authorityButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.showChildren = new System.Windows.Forms.Button();
            this.showParents = new System.Windows.Forms.Button();
            this.authorityResult = new System.Windows.Forms.ListView();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(8, 32);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(127, 20);
            this.searchInput.TabIndex = 1;
            this.searchInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.searchInput.MouseLeave += new System.EventHandler(this.searchInput_MouseLeave);
            this.searchInput.MouseHover += new System.EventHandler(this.searchInput_MouseHover);
            // 
            // searchResult
            // 
            this.searchResult.HideSelection = false;
            this.searchResult.Location = new System.Drawing.Point(138, 139);
            this.searchResult.Name = "searchResult";
            this.searchResult.Size = new System.Drawing.Size(316, 241);
            this.searchResult.TabIndex = 2;
            this.searchResult.UseCompatibleStateImageBehavior = false;
            this.searchResult.View = System.Windows.Forms.View.List;
            this.searchResult.SelectedIndexChanged += new System.EventHandler(this.searchResult_SelectedIndexChanged);
            // 
            // showBrothers
            // 
            this.showBrothers.Location = new System.Drawing.Point(6, 242);
            this.showBrothers.Name = "showBrothers";
            this.showBrothers.Size = new System.Drawing.Size(126, 42);
            this.showBrothers.TabIndex = 3;
            this.showBrothers.Text = "Display Brothers";
            this.showBrothers.UseVisualStyleBackColor = true;
            this.showBrothers.Click += new System.EventHandler(this.showBrothers_Click);
            // 
            // showCouples
            // 
            this.showCouples.Location = new System.Drawing.Point(6, 290);
            this.showCouples.Name = "showCouples";
            this.showCouples.Size = new System.Drawing.Size(126, 42);
            this.showCouples.TabIndex = 4;
            this.showCouples.Text = "Show Couples";
            this.showCouples.UseVisualStyleBackColor = true;
            this.showCouples.Click += new System.EventHandler(this.showCouples_Click);
            // 
            // showParentsWithSiblings
            // 
            this.showParentsWithSiblings.Location = new System.Drawing.Point(6, 338);
            this.showParentsWithSiblings.Name = "showParentsWithSiblings";
            this.showParentsWithSiblings.Size = new System.Drawing.Size(126, 42);
            this.showParentsWithSiblings.TabIndex = 5;
            this.showParentsWithSiblings.Text = "Show Parents With Siblings";
            this.showParentsWithSiblings.UseVisualStyleBackColor = true;
            this.showParentsWithSiblings.Click += new System.EventHandler(this.showParentsWithSiblings_Click);
            // 
            // radioauthorityButton
            // 
            this.radioauthorityButton.AutoSize = true;
            this.radioauthorityButton.Location = new System.Drawing.Point(8, 57);
            this.radioauthorityButton.Name = "radioauthorityButton";
            this.radioauthorityButton.Size = new System.Drawing.Size(45, 17);
            this.radioauthorityButton.TabIndex = 6;
            this.radioauthorityButton.TabStop = true;
            this.radioauthorityButton.Text = "nice";
            this.radioauthorityButton.UseVisualStyleBackColor = true;
            this.radioauthorityButton.CheckedChanged += new System.EventHandler(this.radioauthorityButton_CheckedChanged);
            this.radioauthorityButton.MouseLeave += new System.EventHandler(this.searchInput_MouseLeave);
            this.radioauthorityButton.MouseHover += new System.EventHandler(this.searchInput_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseHover += new System.EventHandler(this.searchInput_MouseHover);
            // 
            // radioshowChildren
            // 
            this.radioshowChildren.AutoSize = true;
            this.radioshowChildren.Location = new System.Drawing.Point(72, 57);
            this.radioshowChildren.Name = "radioshowChildren";
            this.radioshowChildren.Size = new System.Drawing.Size(63, 17);
            this.radioshowChildren.TabIndex = 8;
            this.radioshowChildren.TabStop = true;
            this.radioshowChildren.Text = "naughty";
            this.radioshowChildren.UseVisualStyleBackColor = true;
            this.radioshowChildren.CheckedChanged += new System.EventHandler(this.radioshowChildren_CheckedChanged);
            this.radioshowChildren.MouseLeave += new System.EventHandler(this.searchInput_MouseLeave);
            this.radioshowChildren.MouseHover += new System.EventHandler(this.searchInput_MouseHover);
            // 
            // authorityButton
            // 
            this.authorityButton.Location = new System.Drawing.Point(8, 80);
            this.authorityButton.Name = "authorityButton";
            this.authorityButton.Size = new System.Drawing.Size(127, 20);
            this.authorityButton.TabIndex = 9;
            this.authorityButton.Text = "Result";
            this.authorityButton.UseVisualStyleBackColor = true;
            this.authorityButton.Click += new System.EventHandler(this.authorityButton_Click);
            this.authorityButton.MouseLeave += new System.EventHandler(this.searchInput_MouseLeave);
            this.authorityButton.MouseHover += new System.EventHandler(this.searchInput_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Hint: hover on elements to show help";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // showChildren
            // 
            this.showChildren.Location = new System.Drawing.Point(6, 140);
            this.showChildren.Name = "showChildren";
            this.showChildren.Size = new System.Drawing.Size(126, 45);
            this.showChildren.TabIndex = 12;
            this.showChildren.Text = "Show Children";
            this.showChildren.UseVisualStyleBackColor = true;
            this.showChildren.Click += new System.EventHandler(this.showChildren_Click);
            // 
            // showParents
            // 
            this.showParents.Location = new System.Drawing.Point(5, 191);
            this.showParents.Name = "showParents";
            this.showParents.Size = new System.Drawing.Size(126, 45);
            this.showParents.TabIndex = 13;
            this.showParents.Text = "Show Parents";
            this.showParents.UseVisualStyleBackColor = true;
            this.showParents.Click += new System.EventHandler(this.showParents_Click);
            // 
            // authorityResult
            // 
            this.authorityResult.HideSelection = false;
            this.authorityResult.Location = new System.Drawing.Point(141, 32);
            this.authorityResult.Name = "authorityResult";
            this.authorityResult.Size = new System.Drawing.Size(313, 68);
            this.authorityResult.TabIndex = 14;
            this.authorityResult.UseCompatibleStateImageBehavior = false;
            this.authorityResult.View = System.Windows.Forms.View.List;
            this.authorityResult.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.authorityResult_ColumnWidthChanging);
            this.authorityResult.MouseLeave += new System.EventHandler(this.searchInput_MouseLeave);
            this.authorityResult.MouseHover += new System.EventHandler(this.searchInput_MouseHover);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(345, 422);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(112, 13);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Razvan Olariu, 342AA";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(470, 444);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.authorityResult);
            this.Controls.Add(this.showParents);
            this.Controls.Add(this.showChildren);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.authorityButton);
            this.Controls.Add(this.radioshowChildren);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioauthorityButton);
            this.Controls.Add(this.showParentsWithSiblings);
            this.Controls.Add(this.showCouples);
            this.Controls.Add(this.showBrothers);
            this.Controls.Add(this.searchResult);
            this.Controls.Add(this.searchInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Family App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void radioshowChildren_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void radioauthorityButton_CheckedChanged(object sender, EventArgs e)
        {
        }

        #endregion
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.ListView searchResult;
        private System.Windows.Forms.Button showBrothers;
        private System.Windows.Forms.Button showCouples;
        private System.Windows.Forms.Button showParentsWithSiblings;
        private System.Windows.Forms.RadioButton radioauthorityButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioshowChildren;
        private System.Windows.Forms.Button authorityButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button showChildren;
        private Button showParents;
        private ListView authorityResult;
        private LinkLabel linkLabel1;
    }
}

