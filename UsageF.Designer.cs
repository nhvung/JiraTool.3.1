
namespace JiraTool._3._1
{
    partial class UsageF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsageF));
            this.lv_story = new System.Windows.Forms.ListView();
            this.col_lv_story_key = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_lv_story_summary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_lv_story_storypoints = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lv_story
            // 
            this.lv_story.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_lv_story_key,
            this.col_lv_story_summary,
            this.col_lv_story_storypoints});
            this.lv_story.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_story.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_story.HideSelection = false;
            this.lv_story.HoverSelection = true;
            this.lv_story.Location = new System.Drawing.Point(0, 0);
            this.lv_story.MultiSelect = false;
            this.lv_story.Name = "lv_story";
            this.lv_story.Size = new System.Drawing.Size(943, 573);
            this.lv_story.TabIndex = 2;
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
            // col_lv_story_storypoints
            // 
            this.col_lv_story_storypoints.Text = "Points";
            this.col_lv_story_storypoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_lv_story_storypoints.Width = 186;
            // 
            // UsageF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 573);
            this.Controls.Add(this.lv_story);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.Name = "UsageF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_story;
        private System.Windows.Forms.ColumnHeader col_lv_story_key;
        private System.Windows.Forms.ColumnHeader col_lv_story_summary;
        private System.Windows.Forms.ColumnHeader col_lv_story_storypoints;
    }
}