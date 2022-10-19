﻿using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace PS3Lib
{
    public partial class ConsoleList
    {
		#region Icon Byte Array (Opening this may lag your visual studio)
        /// <summary>
        /// Ps3 icon as byte[]
        /// </summary>
        private byte[] ps3icon = new byte[]
        {
        };
		
		/// <summary>
        /// The icon is stored as byte[] for ease of use from project to project
        /// This is a helper method for that.
        /// </summary>
        private static Icon BytesToIcon(byte[] bytes)
        {
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return new Icon(ms);
            }
        }
		#endregion

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
		
		private Label lblInfo;
        private Button btnConnect;
        private Button btnRefresh;
        private ListViewGroup listViewGroup;
        private ListView listView;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Consoles", System.Windows.Forms.HorizontalAlignment.Left);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRefresh.Location = new System.Drawing.Point(396, 469);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(158, 42);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnConnect.Enabled = false;
            this.btnConnect.Location = new System.Drawing.Point(22, 469);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(6);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(363, 42);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connection";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(22, 432);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(287, 25);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Select a console within this grid.";
            // 
            // listView
            // 
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            listViewGroup1.Header = "Consoles";
            listViewGroup1.Name = "consoleGroup";
            this.listView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(22, 22);
            this.listView.Margin = new System.Windows.Forms.Padding(6);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.ShowGroups = false;
            this.listView.Size = new System.Drawing.Size(528, 394);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.List;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // ConsoleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnRefresh;
            this.ClientSize = new System.Drawing.Size(576, 526);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnRefresh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsoleList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select a console...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsoleList_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
    }
}