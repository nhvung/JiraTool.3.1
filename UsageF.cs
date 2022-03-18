using Jira.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JiraTool._3._1
{
    public partial class UsageF : Form
    {
        DelegateProcess _dlg;
        List<StoryInfo> _stories;
        public UsageF(List<StoryInfo> stories)
        {
            InitializeComponent();
            _dlg = new DelegateProcess();
            _stories = stories;
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            _ = _InitializeValues();
        }
        Task _InitializeValues()
        {
            try
            {
                _dlg.Execute(lv_story, () => {
                    ListViewItem otherGroupItem = new ListViewItem("Others") { Name = "othertasks", Font = new Font("tahoma", 8, FontStyle.Bold), ForeColor = Color.RoyalBlue };
                    List<ListViewItem> otherItems = new List<ListViewItem>();
                    float totalSPs = 0;
                    ListViewGroup totalGrp = new ListViewGroup("");
                    foreach (var story in _stories)
                    {
                        if (story.HasSubTasks)
                        {
                            ListViewItem storyItem = new ListViewItem(new string[] { story.MainTask.Key, story.MainTask.Summary, "-", story.MainTask.Status, story.MainTask.OriginalEstimate })
                            {
                                Name = story.MainTask.Key,
                                Font = new Font("tahoma", 8, FontStyle.Bold),
                                ForeColor = Color.RoyalBlue
                            };
                            //ListViewGroup lvg = new ListViewGroup(story.MainTask.Key + ": " + story.MainTask.Summary);
                            ListViewItem[] items = story.SubTasks.Select(ite => new ListViewItem(new string[]
                            {
                                ite.Key,
                                ite.Summary,
                                ite.StoryPoints.ToString(),
                            })
                            { Name = ite.Key }).ToArray();

                            lv_story.Items.Add(storyItem);
                            lv_story.Items.AddRange(items);
                            totalSPs += story.SubTasks.Sum(ite => ite.StoryPoints);

                            //lst_story.Groups.Add(lvg);
                        }
                        else
                        {
                            ListViewItem storyItem = new ListViewItem(new string[] { story.MainTask.Key, story.MainTask.Summary, story.MainTask.StoryPoints.ToString() }) { Name = story.MainTask.Key, Font = new Font("tahoma", 9, FontStyle.Regular) };
                            otherItems.Add(storyItem);
                            //lst_story.Items.Add(item);
                            totalSPs += story.MainTask.StoryPoints;
                        }
                    }
                    if (otherItems.Count > 0)
                    {
                        lv_story.Items.Add(otherGroupItem);
                        lv_story.Items.AddRange(otherItems.ToArray());
                    }

                    ListViewItem item = new ListViewItem(new string[] { "", "TOTAL", totalSPs.ToString(), "" }, totalGrp) { Name = "total", Font = new Font("tahoma", 9, FontStyle.Bold) };
                    lv_story.Items.Add(item);
                    lv_story.Groups.Add(totalGrp);

                    lv_story.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                });

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return Task.CompletedTask;
        }
    }
}
