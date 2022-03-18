
namespace JiraTool._3._1
{
    partial class MainF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainF));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ts_menu = new System.Windows.Forms.ToolStrip();
            this.ts_menu_but_login = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ts_menu_com_board = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.ts_menu_com_project = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.ts_menu_com_sprint = new System.Windows.Forms.ToolStripComboBox();
            this.ts_menu_but_view = new System.Windows.Forms.ToolStripButton();
            this.ss_menu = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ss_menu_lab_accountname = new System.Windows.Forms.ToolStripStatusLabel();
            this.ss_menu_lab_processstatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sc_main = new System.Windows.Forms.SplitContainer();
            this.grp_summary = new System.Windows.Forms.GroupBox();
            this.lv_story = new System.Windows.Forms.ListView();
            this.col_lv_story_key = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_lv_story_summary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_lv_story_assignee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_lv_story_storypoints = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ts_story = new System.Windows.Forms.ToolStrip();
            this.grp_taskusage = new System.Windows.Forms.GroupBox();
            this.dgv_usage = new System.Windows.Forms.DataGridView();
            this.dgv_usage_col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_usage_col_points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_usage_col_view = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ts_menu.SuspendLayout();
            this.ss_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc_main)).BeginInit();
            this.sc_main.Panel1.SuspendLayout();
            this.sc_main.Panel2.SuspendLayout();
            this.sc_main.SuspendLayout();
            this.grp_summary.SuspendLayout();
            this.grp_taskusage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usage)).BeginInit();
            this.SuspendLayout();
            // 
            // ts_menu
            // 
            this.ts_menu.AutoSize = false;
            this.ts_menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_menu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ts_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_menu_but_login,
            this.toolStripLabel1,
            this.ts_menu_com_board,
            this.toolStripLabel2,
            this.ts_menu_com_project,
            this.toolStripLabel3,
            this.ts_menu_com_sprint,
            this.ts_menu_but_view});
            this.ts_menu.Location = new System.Drawing.Point(0, 0);
            this.ts_menu.Name = "ts_menu";
            this.ts_menu.Size = new System.Drawing.Size(1450, 22);
            this.ts_menu.TabIndex = 0;
            this.ts_menu.Text = "toolStrip1";
            // 
            // ts_menu_but_login
            // 
            this.ts_menu_but_login.BackColor = System.Drawing.Color.SteelBlue;
            this.ts_menu_but_login.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ts_menu_but_login.ForeColor = System.Drawing.Color.White;
            this.ts_menu_but_login.Image = ((System.Drawing.Image)(resources.GetObject("ts_menu_but_login.Image")));
            this.ts_menu_but_login.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ts_menu_but_login.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_menu_but_login.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.ts_menu_but_login.Name = "ts_menu_but_login";
            this.ts_menu_but_login.Size = new System.Drawing.Size(57, 19);
            this.ts_menu_but_login.Text = "Login";
            this.ts_menu_but_login.Click += new System.EventHandler(this.ts_menu_but_login_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.ForeColor = System.Drawing.Color.DarkRed;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(48, 19);
            this.toolStripLabel1.Text = "Boards:";
            // 
            // ts_menu_com_board
            // 
            this.ts_menu_com_board.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ts_menu_com_board.Name = "ts_menu_com_board";
            this.ts_menu_com_board.Size = new System.Drawing.Size(121, 22);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel2.ForeColor = System.Drawing.Color.DarkRed;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(50, 19);
            this.toolStripLabel2.Text = "Project:";
            // 
            // ts_menu_com_project
            // 
            this.ts_menu_com_project.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ts_menu_com_project.Name = "ts_menu_com_project";
            this.ts_menu_com_project.Size = new System.Drawing.Size(121, 22);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel3.ForeColor = System.Drawing.Color.DarkRed;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(44, 19);
            this.toolStripLabel3.Text = "Sprint:";
            // 
            // ts_menu_com_sprint
            // 
            this.ts_menu_com_sprint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ts_menu_com_sprint.Name = "ts_menu_com_sprint";
            this.ts_menu_com_sprint.Size = new System.Drawing.Size(121, 22);
            // 
            // ts_menu_but_view
            // 
            this.ts_menu_but_view.BackColor = System.Drawing.Color.SteelBlue;
            this.ts_menu_but_view.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ts_menu_but_view.ForeColor = System.Drawing.Color.White;
            this.ts_menu_but_view.Image = ((System.Drawing.Image)(resources.GetObject("ts_menu_but_view.Image")));
            this.ts_menu_but_view.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ts_menu_but_view.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_menu_but_view.Name = "ts_menu_but_view";
            this.ts_menu_but_view.Size = new System.Drawing.Size(55, 19);
            this.ts_menu_but_view.Text = "View";
            this.ts_menu_but_view.Click += new System.EventHandler(this.ts_menu_but_view_Click);
            // 
            // ss_menu
            // 
            this.ss_menu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ss_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.ss_menu_lab_accountname,
            this.ss_menu_lab_processstatus});
            this.ss_menu.Location = new System.Drawing.Point(0, 665);
            this.ss_menu.Name = "ss_menu";
            this.ss_menu.Size = new System.Drawing.Size(1450, 22);
            this.ss_menu.TabIndex = 1;
            this.ss_menu.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.DarkRed;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel1.Text = "Account:";
            // 
            // ss_menu_lab_accountname
            // 
            this.ss_menu_lab_accountname.Name = "ss_menu_lab_accountname";
            this.ss_menu_lab_accountname.Size = new System.Drawing.Size(12, 17);
            this.ss_menu_lab_accountname.Text = "-";
            // 
            // ss_menu_lab_processstatus
            // 
            this.ss_menu_lab_processstatus.Name = "ss_menu_lab_processstatus";
            this.ss_menu_lab_processstatus.Size = new System.Drawing.Size(88, 17);
            this.ss_menu_lab_processstatus.Text = "Not Connected";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 643);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1442, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 643);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(219, 232);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 0);
            this.panel3.TabIndex = 4;
            // 
            // sc_main
            // 
            this.sc_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc_main.Location = new System.Drawing.Point(8, 22);
            this.sc_main.Name = "sc_main";
            // 
            // sc_main.Panel1
            // 
            this.sc_main.Panel1.Controls.Add(this.grp_summary);
            // 
            // sc_main.Panel2
            // 
            this.sc_main.Panel2.Controls.Add(this.grp_taskusage);
            this.sc_main.Size = new System.Drawing.Size(1434, 643);
            this.sc_main.SplitterDistance = 977;
            this.sc_main.TabIndex = 5;
            // 
            // grp_summary
            // 
            this.grp_summary.Controls.Add(this.lv_story);
            this.grp_summary.Controls.Add(this.ts_story);
            this.grp_summary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_summary.Location = new System.Drawing.Point(0, 0);
            this.grp_summary.Name = "grp_summary";
            this.grp_summary.Size = new System.Drawing.Size(977, 643);
            this.grp_summary.TabIndex = 0;
            this.grp_summary.TabStop = false;
            this.grp_summary.Text = "Summary";
            // 
            // lv_story
            // 
            this.lv_story.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_lv_story_key,
            this.col_lv_story_summary,
            this.col_lv_story_assignee,
            this.col_lv_story_storypoints});
            this.lv_story.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_story.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_story.HideSelection = false;
            this.lv_story.HoverSelection = true;
            this.lv_story.Location = new System.Drawing.Point(3, 39);
            this.lv_story.MultiSelect = false;
            this.lv_story.Name = "lv_story";
            this.lv_story.Size = new System.Drawing.Size(971, 601);
            this.lv_story.TabIndex = 1;
            this.lv_story.UseCompatibleStateImageBehavior = false;
            this.lv_story.View = System.Windows.Forms.View.Details;
            // 
            // col_lv_story_key
            // 
            this.col_lv_story_key.Text = "Key";
            // 
            // col_lv_story_summary
            // 
            this.col_lv_story_summary.Text = "Summary";
            this.col_lv_story_summary.Width = 300;
            // 
            // col_lv_story_assignee
            // 
            this.col_lv_story_assignee.Text = "Assignee";
            this.col_lv_story_assignee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_lv_story_assignee.Width = 150;
            // 
            // col_lv_story_storypoints
            // 
            this.col_lv_story_storypoints.Text = "Points";
            this.col_lv_story_storypoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ts_story
            // 
            this.ts_story.AutoSize = false;
            this.ts_story.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_story.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ts_story.Location = new System.Drawing.Point(3, 17);
            this.ts_story.Name = "ts_story";
            this.ts_story.Size = new System.Drawing.Size(971, 22);
            this.ts_story.TabIndex = 0;
            this.ts_story.Text = "toolStrip1";
            // 
            // grp_taskusage
            // 
            this.grp_taskusage.Controls.Add(this.dgv_usage);
            this.grp_taskusage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_taskusage.Location = new System.Drawing.Point(0, 0);
            this.grp_taskusage.Name = "grp_taskusage";
            this.grp_taskusage.Size = new System.Drawing.Size(453, 643);
            this.grp_taskusage.TabIndex = 0;
            this.grp_taskusage.TabStop = false;
            this.grp_taskusage.Text = "Usage";
            // 
            // dgv_usage
            // 
            this.dgv_usage.AllowUserToAddRows = false;
            this.dgv_usage.AllowUserToDeleteRows = false;
            this.dgv_usage.AllowUserToResizeRows = false;
            this.dgv_usage.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_usage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_usage.ColumnHeadersHeight = 30;
            this.dgv_usage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_usage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_usage_col_name,
            this.dgv_usage_col_points,
            this.dgv_usage_col_view});
            this.dgv_usage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_usage.Location = new System.Drawing.Point(3, 17);
            this.dgv_usage.Name = "dgv_usage";
            this.dgv_usage.ReadOnly = true;
            this.dgv_usage.RowHeadersVisible = false;
            this.dgv_usage.RowHeadersWidth = 82;
            this.dgv_usage.RowTemplate.Height = 30;
            this.dgv_usage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_usage.Size = new System.Drawing.Size(447, 623);
            this.dgv_usage.TabIndex = 0;
            // 
            // dgv_usage_col_name
            // 
            this.dgv_usage_col_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_usage_col_name.HeaderText = "Name";
            this.dgv_usage_col_name.MinimumWidth = 10;
            this.dgv_usage_col_name.Name = "dgv_usage_col_name";
            this.dgv_usage_col_name.ReadOnly = true;
            // 
            // dgv_usage_col_points
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_usage_col_points.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_usage_col_points.HeaderText = "Points";
            this.dgv_usage_col_points.MinimumWidth = 10;
            this.dgv_usage_col_points.Name = "dgv_usage_col_points";
            this.dgv_usage_col_points.ReadOnly = true;
            this.dgv_usage_col_points.Width = 50;
            // 
            // dgv_usage_col_view
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_usage_col_view.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_usage_col_view.HeaderText = "View";
            this.dgv_usage_col_view.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.dgv_usage_col_view.MinimumWidth = 10;
            this.dgv_usage_col_view.Name = "dgv_usage_col_view";
            this.dgv_usage_col_view.ReadOnly = true;
            this.dgv_usage_col_view.Width = 50;
            // 
            // MainF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 687);
            this.Controls.Add(this.sc_main);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ss_menu);
            this.Controls.Add(this.ts_menu);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JIra Tool v3.1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ts_menu.ResumeLayout(false);
            this.ts_menu.PerformLayout();
            this.ss_menu.ResumeLayout(false);
            this.ss_menu.PerformLayout();
            this.sc_main.Panel1.ResumeLayout(false);
            this.sc_main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc_main)).EndInit();
            this.sc_main.ResumeLayout(false);
            this.grp_summary.ResumeLayout(false);
            this.grp_taskusage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ts_menu;
        private System.Windows.Forms.ToolStripButton ts_menu_but_login;
        private System.Windows.Forms.StatusStrip ss_menu;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel ss_menu_lab_accountname;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox ts_menu_com_board;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox ts_menu_com_project;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripComboBox ts_menu_com_sprint;
        private System.Windows.Forms.ToolStripButton ts_menu_but_view;
        private System.Windows.Forms.ToolStripStatusLabel ss_menu_lab_processstatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.SplitContainer sc_main;
        private System.Windows.Forms.GroupBox grp_summary;
        private System.Windows.Forms.ListView lv_story;
        private System.Windows.Forms.ToolStrip ts_story;
        private System.Windows.Forms.ColumnHeader col_lv_story_key;
        private System.Windows.Forms.ColumnHeader col_lv_story_summary;
        private System.Windows.Forms.ColumnHeader col_lv_story_assignee;
        private System.Windows.Forms.ColumnHeader col_lv_story_storypoints;
        private System.Windows.Forms.GroupBox grp_taskusage;
        private System.Windows.Forms.DataGridView dgv_usage;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_usage_col_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_usage_col_points;
        private System.Windows.Forms.DataGridViewLinkColumn dgv_usage_col_view;
    }
}

