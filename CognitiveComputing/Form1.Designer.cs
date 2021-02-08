
namespace CognitiveComputing
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
            this.faultTable = new System.Windows.Forms.ListView();
            this.faultId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.companyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contactNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.faultType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.threatLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.faultStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.logANewFaultToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllUnresolvedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logANewFaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllUnresolvedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // faultTable
            // 
            this.faultTable.BackColor = System.Drawing.SystemColors.Window;
            this.faultTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.faultId,
            this.companyName,
            this.contactNumber,
            this.faultType,
            this.description,
            this.threatLevel,
            this.faultStatus});
            this.faultTable.ContextMenuStrip = this.contextMenuStrip1;
            this.faultTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.faultTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.faultTable.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faultTable.ForeColor = System.Drawing.Color.Black;
            this.faultTable.FullRowSelect = true;
            this.faultTable.HideSelection = false;
            this.faultTable.Location = new System.Drawing.Point(0, 24);
            this.faultTable.MultiSelect = false;
            this.faultTable.Name = "faultTable";
            this.faultTable.Size = new System.Drawing.Size(970, 630);
            this.faultTable.TabIndex = 3;
            this.faultTable.UseCompatibleStateImageBehavior = false;
            this.faultTable.View = System.Windows.Forms.View.Details;
            // 
            // faultId
            // 
            this.faultId.Text = "ID";
            // 
            // companyName
            // 
            this.companyName.Text = "Company";
            this.companyName.Width = 180;
            // 
            // contactNumber
            // 
            this.contactNumber.Text = "Contact Number";
            this.contactNumber.Width = 163;
            // 
            // faultType
            // 
            this.faultType.Text = "Fault Type";
            this.faultType.Width = 128;
            // 
            // description
            // 
            this.description.Text = "Description";
            this.description.Width = 135;
            // 
            // threatLevel
            // 
            this.threatLevel.Text = "Threat Level";
            this.threatLevel.Width = 156;
            // 
            // faultStatus
            // 
            this.faultStatus.Text = "Status";
            this.faultStatus.Width = 143;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logANewFaultToolStripMenuItem1,
            this.selectAllUnresolvedToolStripMenuItem1,
            this.statisticsToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(215, 76);
            // 
            // logANewFaultToolStripMenuItem1
            // 
            this.logANewFaultToolStripMenuItem1.Name = "logANewFaultToolStripMenuItem1";
            this.logANewFaultToolStripMenuItem1.Size = new System.Drawing.Size(214, 24);
            this.logANewFaultToolStripMenuItem1.Text = "Log a &new Fault";
            this.logANewFaultToolStripMenuItem1.Click += new System.EventHandler(this.logANewFaultToolStripMenuItem_Click);
            // 
            // selectAllUnresolvedToolStripMenuItem1
            // 
            this.selectAllUnresolvedToolStripMenuItem1.Name = "selectAllUnresolvedToolStripMenuItem1";
            this.selectAllUnresolvedToolStripMenuItem1.Size = new System.Drawing.Size(214, 24);
            this.selectAllUnresolvedToolStripMenuItem1.Text = "Select all unresolved";
            this.selectAllUnresolvedToolStripMenuItem1.Click += new System.EventHandler(this.selectAllUnresolvedToolStripMenuItem_Click);
            // 
            // statisticsToolStripMenuItem1
            // 
            this.statisticsToolStripMenuItem1.Name = "statisticsToolStripMenuItem1";
            this.statisticsToolStripMenuItem1.Size = new System.Drawing.Size(214, 24);
            this.statisticsToolStripMenuItem1.Text = "Statistics";
            this.statisticsToolStripMenuItem1.Click += new System.EventHandler(this.statisticsToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.tableToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(970, 30);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textFormatToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save As";
            // 
            // textFormatToolStripMenuItem
            // 
            this.textFormatToolStripMenuItem.Name = "textFormatToolStripMenuItem";
            this.textFormatToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.textFormatToolStripMenuItem.Text = "Text Format";
            this.textFormatToolStripMenuItem.Click += new System.EventHandler(this.textFormatToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tableToolStripMenuItem
            // 
            this.tableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logANewFaultToolStripMenuItem,
            this.selectAllUnresolvedToolStripMenuItem,
            this.statisticsToolStripMenuItem});
            this.tableToolStripMenuItem.Name = "tableToolStripMenuItem";
            this.tableToolStripMenuItem.Size = new System.Drawing.Size(61, 26);
            this.tableToolStripMenuItem.Text = "&Table";
            // 
            // logANewFaultToolStripMenuItem
            // 
            this.logANewFaultToolStripMenuItem.Name = "logANewFaultToolStripMenuItem";
            this.logANewFaultToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.logANewFaultToolStripMenuItem.Text = "Log a &new fault";
            this.logANewFaultToolStripMenuItem.Click += new System.EventHandler(this.logANewFaultToolStripMenuItem_Click);
            // 
            // selectAllUnresolvedToolStripMenuItem
            // 
            this.selectAllUnresolvedToolStripMenuItem.Name = "selectAllUnresolvedToolStripMenuItem";
            this.selectAllUnresolvedToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.selectAllUnresolvedToolStripMenuItem.Text = "Select all Unresolved";
            this.selectAllUnresolvedToolStripMenuItem.Click += new System.EventHandler(this.selectAllUnresolvedToolStripMenuItem_Click);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            this.statisticsToolStripMenuItem.Click += new System.EventHandler(this.statisticsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(68, 26);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(970, 654);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.faultTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cognitive Computing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView faultTable;
        private System.Windows.Forms.ColumnHeader faultId;
        private System.Windows.Forms.ColumnHeader companyName;
        private System.Windows.Forms.ColumnHeader contactNumber;
        private System.Windows.Forms.ColumnHeader faultType;
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.ColumnHeader threatLevel;
        private System.Windows.Forms.ColumnHeader faultStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logANewFaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textFormatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllUnresolvedToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logANewFaultToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem selectAllUnresolvedToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem1;
    }
}

