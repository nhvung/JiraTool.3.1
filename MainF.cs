using Jira;
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
    public partial class MainF : Form
    {
        DelegateProcess _dlg;
        JiraClient _jiraClient;
        Jira.Models.MyselfInfo _LoginInfo;
        List<string> _allStatusObjs, _onlyNewStatusObjs;
        public MainF()
        {
            InitializeComponent();
            ts_menu_com_board.ComboBox.DisplayMember = "Name";
            ts_menu_com_board.ComboBox.ValueMember = "ID";
            ts_menu_com_board.SelectedIndexChanged += Ts_menu_com_board_SelectedIndexChanged;

            ts_menu_com_project.ComboBox.DisplayMember = "Name";
            ts_menu_com_project.ComboBox.ValueMember = "ID";

            ts_menu_com_sprint.ComboBox.DisplayMember = "Name";
            ts_menu_com_sprint.ComboBox.ValueMember = "ID";

            _dlg = new DelegateProcess();

            _allStatusObjs = new List<string>()
                    {
                         "open", "reopened", "in progress", "resolved", "closed", "to do", "done"
                    };
            _onlyNewStatusObjs = new List<string>()
                    {
                         "open", "reopened", "in progress", "to do"
                    };

            dgv_usage.CellContentClick += Dgv_usage_CellContentClick;
        }

        private void Dgv_usage_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if(e.ColumnIndex == 2)
                {
                    string assignee = dgv_usage["dgv_usage_col_name", e.RowIndex].Value.ToString();

                    List<StoryInfo> stories = new List<StoryInfo>();
                    if(_stories?.Count > 0)
                    {
                        foreach (var story in _stories)
                        {
                            if (story.HasSubTasks)
                            {
                                StoryInfo iStory = new StoryInfo() { MainTask = story.MainTask, SubTasks = story.SubTasks.Where(ite => ite.Assignee.Equals(assignee, StringComparison.InvariantCultureIgnoreCase)).ToList() };
                                if (iStory.HasSubTasks)
                                    stories.Add(iStory);
                            }
                            else
                            {
                                if (story.MainTask.Assignee.Equals(assignee, StringComparison.InvariantCultureIgnoreCase))
                                {
                                    StoryInfo iStory = new StoryInfo() { MainTask = story.MainTask };
                                    stories.Add(iStory);
                                }
                            }
                        }


                        UsageF usageF = new UsageF(stories);
                        usageF.Show();
                    }
                    
                }
            }
            catch { }
        }

        private void Ts_menu_com_board_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                _dlg.Execute(ts_menu, () => 
                {
                    ts_menu_com_project.Items.Clear();
                    ts_menu_com_sprint.Items.Clear();
                });
                BoardInfo boardObj = ts_menu_com_board.SelectedItem as BoardInfo;
                if(boardObj != null)
                {
                    _ = _LoadProjects(boardObj.ID);
                    _ = _LoadSprints(boardObj.ID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ts_menu_but_login_Click(object sender, EventArgs e)
        {
            _dlg.Execute(ts_menu, () =>
            {
                ts_menu_but_login.Text = "Logging in...";
            });
            LoginF loginF = new LoginF();
            if(loginF.ShowDialog()== DialogResult.OK)
            {
                _LoginInfo = loginF.LoginInfo;
                _jiraClient = loginF.JiraClient;
                ss_menu_lab_accountname.Text = _LoginInfo.DisplayName;
                _ = _LoadBoards();
                ss_menu_lab_processstatus.Text = "Ready";
            }
            _dlg.Execute(ts_menu, () =>
            {
                ts_menu_but_login.Text = "Log in";
            });
        }

        async Task _LoadBoards()
        {
            _dlg.Execute(ts_menu, () => { ts_menu_com_board.Items.Clear(); });
            try
            {
                var boardObjs = await _jiraClient.GetBoardsAsync();
                if(boardObjs?.Count > 0)
                {
                    _dlg.Execute(ts_menu, () => {
                       
                        foreach (var boardObj in boardObjs.OrderBy(ite=>ite.Name, StringComparer.InvariantCultureIgnoreCase))
                        {
                            ts_menu_com_board.Items.Add(boardObj);
                        }
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        async Task _LoadProjects(int boardID)
        {
           
            try
            {
                _dlg.Execute(ts_menu, () => {
                    ts_menu_com_project.Items.Add(new ProjectInfo()
                    {
                        ID = -1,
                        Key = "allproject",
                        Name = "- ALL -"
                    });
                });
                var projectObjs = await _jiraClient.GetProjectsAsync(boardID);
                if (projectObjs?.Count > 0)
                {
                    _dlg.Execute(ts_menu, () => {

                        foreach (var projectObj in projectObjs.OrderBy(ite => ite.Name, StringComparer.InvariantCultureIgnoreCase))
                        {
                            ts_menu_com_project.Items.Add(projectObj);
                        }
                        
                    });
                }
                _dlg.Execute(ts_menu, () => {
                    ts_menu_com_project.SelectedIndex = 0;
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        async Task _LoadSprints(int boardID)
        {
            
            try
            {
                var sprintObjs = await _jiraClient.GetSprintsAsync(boardID);
                if (sprintObjs?.Count > 0)
                {
                    _dlg.Execute(ts_menu, () => {

                        foreach (var sprintObj in sprintObjs.OrderByDescending(ite => ite.ID))
                        {
                            ts_menu_com_sprint.Items.Add(sprintObj);
                        }
                        ts_menu_com_sprint.SelectedIndex = 0;
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ts_menu_but_view_Click(object sender, EventArgs e)
        {

            try
            {
                SprintInfo sprintObj = ts_menu_com_sprint.SelectedItem as SprintInfo;
                ProjectInfo projectObj = ts_menu_com_project.SelectedItem as ProjectInfo;
                if(projectObj != null && sprintObj != null)
                {
                    List<string> statusObjs = (ModifierKeys & Keys.Shift) == Keys.Shift ? _onlyNewStatusObjs : _allStatusObjs;
                    List<string> projectKeys = new List<string>();
                    if(projectObj.ID > 0)
                    {
                        projectKeys.Add(projectObj.Key);
                    }
                    _ = _LoadStories(sprintObj.ID, projectKeys, statusObjs);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        List<StoryInfo> _stories;
        object _lockObj;
        async Task _LoadStories(int sprintID, List<string> projectKeys, List<string> statuses)
        {
            if(_lockObj == null)
            {
                _lockObj = new object();
            }
            _dlg.Execute(ss_menu, delegate { ss_menu_lab_processstatus.Text = "Loading stories..."; });
            _dlg.Execute(ts_menu, delegate { 
                //ts_menu_but_view.Enabled = false; 
                ts_menu_but_view.Text = "Loading..."; 
            });
            _dlg.Execute(lv_story, delegate {
                lv_story.Items.Clear();
            });
            try
            {
                _stories = await _jiraClient.GetStoryInSprintAsync(sprintID, projectKeys, statuses, false);
                lock (_lockObj)
                {
                    if (_stories?.Count > 0)
                    {
                        ListViewGroup otherGrp = new ListViewGroup("");
                        ListViewItem otherGroupItem = new ListViewItem("Others", otherGrp) { Name = "othertasks", Font = new Font("tahoma", 9f, FontStyle.Bold), ForeColor = Color.RoyalBlue };
                        List<ListViewItem> otherItems = new List<ListViewItem>();
                        ListViewGroup totalGrp = new ListViewGroup("");

                        float totalSPs = 0;
                        foreach (var story in _stories)
                        {
                            _dlg.Execute(lv_story, () =>
                            {
                                if (story.HasSubTasks)
                                {
                                    ListViewGroup lvg = new ListViewGroup("");
                                    float mainPts = story.SubTasks.Sum(ite => ite.StoryPoints);
                                    ListViewItem storyItem = new ListViewItem(new string[] { story.MainTask.Key, story.MainTask.Summary, story.MainTask.Assignee, story.MainTask.StoryPoints.ToString() + " (" + mainPts + ")", story.MainTask.OriginalEstimate, story.MainTask.Status }, lvg) { Name = story.MainTask.Key, Font = new Font("tahoma", 9f, FontStyle.Bold), ForeColor = Color.RoyalBlue, Tag = "maintask" };
                                    ListViewItem[] items = story.SubTasks.Select(ite => new ListViewItem(new string[] { ite.Key, ite.Summary, ite.Assignee, ite.StoryPoints.ToString(), ite.OriginalEstimate, ite.Status }, lvg) { Name = ite.Key, Font = new Font("tahoma", 9, FontStyle.Regular), Tag = "subtask" }).ToArray();

                                    totalSPs += story.SubTasks.Sum(ite => ite.StoryPoints);
                                    lv_story.Items.Add(storyItem);
                                    lv_story.Items.AddRange(items);
                                    lv_story.Groups.Add(lvg);
                                }
                                else
                                {
                                    ListViewItem item = new ListViewItem(new string[] { story.MainTask.Key, story.MainTask.Summary, story.MainTask.Assignee, story.MainTask.StoryPoints.ToString(), story.MainTask.OriginalEstimate, story.MainTask.Status }, otherGrp) { Name = story.MainTask.Key, Font = new Font("tahoma", 9, FontStyle.Regular) };
                                    otherItems.Add(item);
                                    totalSPs += story.MainTask.StoryPoints;
                                }

                            });
                        }

                        _dlg.Execute(lv_story, () =>
                        {

                            lv_story.Items.Add(otherGroupItem);
                            lv_story.Items.AddRange(otherItems.ToArray());

                            ListViewItem item = new ListViewItem(new string[] { "", "TOTAL", "", totalSPs.ToString(), "" }, totalGrp) { Name = "total", Font = new Font("tahoma", 9, FontStyle.Bold) };
                            lv_story.Items.Add(item);

                            lv_story.Groups.Add(otherGrp);
                            lv_story.Groups.Add(totalGrp);
                            lv_story.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                        });

                        _ = _CalulateUsage(_stories);
                    } 
                }
            }
            catch { }
            _dlg.Execute(ss_menu, delegate { ss_menu_lab_processstatus.Text = "Ready"; });
            _dlg.Execute(ts_menu, delegate { 
                ts_menu_but_view.Text = "View";
                //ts_menu_but_view.Enabled = true;
            });
        }
        Task _CalulateUsage(List<StoryInfo> storyObjs)
        {
            _dlg.Execute(ss_menu, delegate { ss_menu_lab_processstatus.Text = "Calculating usage..."; });
            _dlg.ClearDataGridViewRows(dgv_usage);
            try
            {
                Dictionary<string, float> usages = new Dictionary<string, float>(StringComparer.InvariantCultureIgnoreCase);
                foreach (var story in storyObjs)
                {
                    if (story.HasSubTasks)
                    {
                        foreach (var issue in story.SubTasks)
                        {
                            if (!usages.ContainsKey(issue.Assignee))
                                usages[issue.Assignee] = 0;
                            usages[issue.Assignee] += issue.StoryPoints;
                        }
                    }
                    else
                    {
                        if (!usages.ContainsKey(story.MainTask.Assignee))
                            usages[story.MainTask.Assignee] = 0;
                        usages[story.MainTask.Assignee] += story.MainTask.StoryPoints;
                    }

                }

                foreach (var kv in usages.OrderByDescending(ite => ite.Value))
                {
                    _dlg.AddDataGridViewRow(dgv_usage, kv.Key, kv.Value, "View");
                }

            }
            catch //(Exception ex)
            {
                
            }
            _dlg.Execute(ss_menu, delegate { ss_menu_lab_processstatus.Text = "Ready"; });
            return Task.CompletedTask;
        }
    }
}
