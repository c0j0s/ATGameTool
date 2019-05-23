using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATDBMerger
{
    public partial class Homepage : Form
    {
        private const string TAG = "Homepage";
        private const string cache = "./缓存";
        private Logger logger;

        private List<List<string>> aAccount = new List<List<string>>();
        private List<List<string>> aData = new List<List<string>>();
        private List<List<string>> aBasicCharInfo = new List<List<string>>();
        private List<List<string>> aGidInfo = new List<List<string>>();
        private List<List<string>> aPropertyRecall = new List<List<string>>();

        private List<List<string>> bAccount = new List<List<string>>();
        private List<List<string>> bData = new List<List<string>>();
        private List<List<string>> bBasicCharInfo = new List<List<string>>();
        private List<List<string>> bGidInfo = new List<List<string>>();
        private List<List<string>> bPropertyRecall = new List<List<string>>();

        private List<List<string>> conflict_account;
        private List<List<string>> conflict_char_info;

        #region Initialization
        public Homepage(Logger logger)
        {
            this.logger = logger;
            logger.Log(TAG, "Init: Logger attached to Homepage");
            InitializeComponent();
            InitializeEnvironment();

            Cb_share_account.Checked = true;
            Cb_share_account.Enabled = false;
        }

        private void InitializeEnvironment()
        {
            var directories_to_create = new List<string> { "数据库","缓存","数据库/a", "数据库/b"};
            directories_to_create.ForEach(
                directory =>{
                    if (!Directory.Exists(directory))
                    {
                        Directory.CreateDirectory(directory);
                        logger.Log(TAG, "InitializeEnvironment: directory created - " + directory );
                    }
                }
            );
        }
        #endregion

        #region Main Event Handlers
        private async void Btn_db_read_Click(object sender, EventArgs e)
        {
            bool all_file_exists = true;
            var path = "数据库/";

            if (!File.Exists(path + "a/account.sql"))  all_file_exists = false; else lb_a_adb_account_status.ForeColor = Color.Green; 
            if (!File.Exists(path + "a/data.sql")) all_file_exists = false; else  lb_a_ddb_data_status.ForeColor = Color.Green; 
            if (!File.Exists(path + "a/basic_char_info.sql")) all_file_exists = false; else lb_a_ddb_basic_char_info_status.ForeColor = Color.Green;
            if (!File.Exists(path + "a/gid_info.sql")) all_file_exists = false; else lb_a_ddb_gid_info_status.ForeColor = Color.Green;
            if (!File.Exists(path + "a/property_recall.sql")) all_file_exists = false; else lb_a_ddb_property_recall_status.ForeColor = Color.Green;

            if (!Cb_share_account.Checked)
            {
                if (!File.Exists(path + "b/account.sql")) all_file_exists = false; else lb_b_adb_account_status.ForeColor = Color.Green;
            }

            if (!File.Exists(path + "b/data.sql")) all_file_exists = false; else lb_b_ddb_data_status.ForeColor = Color.Green;
            if (!File.Exists(path + "b/basic_char_info.sql")) all_file_exists = false; else lb_b_ddb_basic_char_info_status.ForeColor = Color.Green;
            if (!File.Exists(path + "b/gid_info.sql")) all_file_exists = false; else lb_b_ddb_gid_info_status.ForeColor = Color.Green;
            if (!File.Exists(path + "b/property_recall.sql")) all_file_exists = false; else lb_b_ddb_property_recall_status.ForeColor = Color.Green;

            if (all_file_exists)
            {

                var loadDataTasks = new Task[]
                {
                    Task.Run(async () => aAccount = await LoadSqlFile(path + "a/account.sql")),
                    Task.Run(async () => aData = await LoadSqlFile(path + "a/data.sql")),
                    Task.Run(async () => aBasicCharInfo = await LoadSqlFile(path + "a/basic_char_info.sql")),
                    Task.Run(async () => aGidInfo = await LoadSqlFile(path + "a/gid_info.sql")),
                    Task.Run(async () => aPropertyRecall  = await LoadSqlFile(path + "a/property_recall.sql")),

                    Task.Run(async () => bAccount = await LoadSqlFile(path + "b/account.sql", !Cb_share_account.Checked)),
                    Task.Run(async () => bData = await LoadSqlFile(path + "b/data.sql")),
                    Task.Run(async () => bBasicCharInfo = await LoadSqlFile(path + "b/basic_char_info.sql")),
                    Task.Run(async () => bGidInfo = await LoadSqlFile(path + "b/gid_info.sql")),
                    Task.Run(async () => bPropertyRecall  = await LoadSqlFile(path + "b/property_recall.sql"))
                };

                try
                {
                    await Task.WhenAll(loadDataTasks);
                    ToggleDatabasePrepareStageFields(true);
                    Btn_db_read.Enabled = false;
                    Cb_share_account.Enabled = false;
                }
                catch (Exception ex)
                {
                    // handle exception
                }
            }
            else
            {
                MessageBox.Show(this,"未找到所有所需的文件，确保所需文件放置在正确的目录里。", "数据库文件加载失败");
            }
        }

        private void Btn_analyse_data_Click(object sender, EventArgs e)
        {
            Tb_db_a_charac_max_id_int.Text = GetMaxValue(aGidInfo,0);
            Lb_db_b_charac_count.Text = bGidInfo.Count.ToString();
            Lb_db_a_property_id.Text = GetMaxValue(aPropertyRecall, 0);

            if (Cb_share_account.Checked)
            {
                Cb_duplicate_account_add_suffix.Checked = false;
                Lb_db_b_duplicate_account_count.Visible = false;
                conflict_account = new List<List<string>>();
            }
            else {
                conflict_account = CheckForConflictValue(aAccount, bAccount, 0);
                Lb_db_b_duplicate_account_count.Text = conflict_account.Count.ToString();
            }

            conflict_char_info = CheckForConflictValue(aGidInfo, bGidInfo, 2);
            Lb_db_b_charac_duplicate_count.Text = conflict_char_info.Count.ToString();

            Btn_prepare_db_b_data.Enabled = true;
            gb_change_conflict_account.Enabled = !Cb_share_account.Checked;
            gb_change_conflict_char.Enabled = true;
            Btn_view_conflict_data.Enabled = true;
            Btn_analyse_data.Enabled = false;
            Gb_dist_name.Enabled = true;
        }

        private void Btn_view_conflict_data_Click(object sender, EventArgs e)
        {
            new ConflictChecking(conflict_account, conflict_char_info).Show();
        }

        private void Btn_prepare_db_b_data_Click(object sender, EventArgs e)
        {
            if (Tb_old_dist_name.Text.Equals("") || Tb_new_dist_name.Text.Equals(""))
            {
                MessageBox.Show(this, "确保所需参数已输入！", "输入选项");
                return;
            }

            if (Cb_duplicate_account_add_suffix.Checked)
            {
                if (Tb_duplicate_account_suffix.Text.Equals(""))
                {
                    MessageBox.Show(this, "确保所需参数已输入！", "输入选项");
                    return;
                }
            }

            if (Cb_duplicate_character_add_suffix.Checked)
            {
                if (Tb_duplicate_charac_suffix.Text.Equals(""))
                {
                    MessageBox.Show(this, "确保所需参数已输入！", "输入选项");
                    return;
                }
            }

            Tb_db_a_charac_max_id_int.Enabled = false;
            Btn_prepare_db_b_data.Enabled = false;
            gb_change_conflict_account.Enabled = false;
            gb_change_conflict_char.Enabled = false;
            Btn_view_conflict_data.Enabled = false;
            Gb_dist_name.Enabled = false;

            Tb_prepare_output.AppendText("备份数据库B到缓存\n");
            foreach (var file in Directory.GetFiles("数据库/b/"))
            {
                var temp = Directory.GetCurrentDirectory() + "/" + file.Replace("数据库/b", "缓存");

                if (File.Exists(temp))
                {
                    File.Delete(temp);
                }
                File.Copy(Directory.GetCurrentDirectory() + "/" + file, temp);
            }

            Tb_prepare_output.AppendText("开始转换数据识别码\n");

            //1 change all hex and int id to new cal value
            for (int i = 1; i <= int.Parse(Lb_db_b_charac_count.Text); i++)
            {
                var new_int_value = i + (int.Parse(Tb_db_a_charac_max_id_int.Text) * 10);
                var old_hex_value = Convert.ToString(i, 16).PadLeft(16, '0');
                var new_hex_value = Convert.ToString(new_int_value, 16).PadLeft(16, '0');
                //1.1 change data, property recall, basic char info to new hex val
                Tb_prepare_output.AppendText("转换 " + old_hex_value + " -> " + new_hex_value + "\n");
                SearchAndReplace("数据库/b/data.sql", old_hex_value, new_hex_value);
                SearchAndReplace("数据库/b/basic_char_info.sql", old_hex_value, new_hex_value);
                SearchAndReplace("数据库/b/property_recall.sql", old_hex_value, new_hex_value);

                //1.2 change gid int id to new val
                Tb_prepare_output.AppendText("转换 " + i + " -> " + new_int_value + "\n");
                SearchAndReplace("数据库/b/gid_info.sql", "(" + i.ToString() + ",", "(" + new_int_value.ToString() + ",");
            }

            Tb_prepare_output.AppendText("开始转换参数码\n");

            foreach (var item in bPropertyRecall)
            {
                var new_int_value = int.Parse(item[0]) + int.Parse(Lb_db_a_property_id.Text);
                Tb_prepare_output.AppendText("转换 " + item[0] + " -> " + new_int_value + "\n");
                SearchAndReplace("数据库/b/property_recall.sql", "(" + item[0].ToString() + ",", "(" + new_int_value.ToString() + ",");
            }

            //2 add suffix to char name
            if (Cb_duplicate_account_add_suffix.Checked)
            {
                Tb_prepare_output.AppendText("开始转换重复账号\n");
            }
            if (Cb_duplicate_character_add_suffix.Checked)
            {
                Tb_prepare_output.AppendText("开始转换重复角色名\n");
                foreach (var item in conflict_char_info)
                {
                    var new_value = item[2] + Tb_duplicate_charac_suffix.Text;
                    Tb_prepare_output.AppendText("转换 " + item[2] + " -> " + new_value + "\n");
                    SearchAndReplace("数据库/b/data.sql", item[2], new_value);
                    SearchAndReplace("数据库/b/basic_char_info.sql", item[2], new_value);
                    SearchAndReplace("数据库/b/property_recall.sql", item[2], new_value);
                    SearchAndReplace("数据库/b/gid_info.sql", item[2], new_value);
                }
            }

            //3 change dist name for data
            Tb_prepare_output.AppendText("开始转换区名 " + Tb_old_dist_name.Text + " -> " + Tb_new_dist_name.Text + "\n");
            SearchAndReplace("数据库/b/data.sql", Tb_old_dist_name.Text, Tb_new_dist_name.Text);

            Tb_prepare_output.AppendText("完成数据处理\n");
            Gb_db_prepare.Enabled = false;
            Gb_db_merge.Enabled = true;
        }
        #endregion 

        #region Supporting Functions
        private void Btn_a_open_directory_Click(object sender, EventArgs e)
        {
            Process.Start(Directory.GetCurrentDirectory() + @"\数据库\a");
        }

        private void Btn_b_open_directory_Click(object sender, EventArgs e)
        {
            Process.Start(Directory.GetCurrentDirectory() + @"\数据库\b");
        }

        private void ToggleDatabasePrepareStageFields(bool enable)
        {
            Gb_db_prepare.Enabled = enable;
            logger.Log(TAG, "Gb_db_prepare: " + enable);
        }
        
        private void ToggleDatabaseMergeStageFields(bool enable)
        {
            Gb_db_merge.Enabled = enable;
            logger.Log(TAG, "Gb_db_merge: " + enable);
        }

        private async Task<List<List<string>>> LoadSqlFile(string filepath, bool need_load = true) {
            try
            {
                var list = new List<List<string>>();
                if (need_load)
                {
                    string line;

                    StreamReader file = new StreamReader(filepath, Encoding.GetEncoding("gb2312"));
                    while ((line = file.ReadLine()) != null)
                    {
                        if (line.StartsWith("INSERT"))
                        {
                            list.Add(ExtractInsertValues(line));
                        }
                    }
                    file.Close();
                }
                
                return list;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private List<string> ExtractInsertValues(string insertStatement) {
            var split = insertStatement.Split('(');
            var clear = split[1].Replace(");", "");
            var values = clear.Replace("'", "").Replace(" ", "").Split(',');
            return values.ToList();
        }

        private string GetMaxValue(List<List<string>> datalist, int key_position) {
            try
            {
                string max = "0";
                datalist.ForEach(data =>
                {
                    var val = Int32.Parse(data[key_position]);

                    if (Int32.Parse(max) < val)
                    {
                        max = val.ToString();
                    }

                });
                return max;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private List<List<string>> CheckForConflictValue(List<List<string>> search_base, List<List<string>> check_base, int key_position) {

            var commons = search_base.Select(s1 => s1[key_position]).ToList().Intersect(check_base.Select(s2 => s2[key_position]).ToList()).ToList();

            List<List<string>> search_list = new List<List<string>>();

            foreach (var item in check_base)
            {
                if (commons.Exists(x => x.Equals(item[key_position])))
                {
                    search_list.Add(item);
                    Console.WriteLine(item[key_position]);
                }
            }

            return search_list;
        }

        private void SearchAndReplace(string file_path, string old_val, string new_val) {
            File.WriteAllText(file_path, File.ReadAllText(file_path, Encoding.GetEncoding("gb2312")).Replace(old_val, new_val), Encoding.GetEncoding("gb2312"));
        }
        
        private void Tb_db_a_charac_max_id_int_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var val = Tb_db_a_charac_max_id_int.Text;
                Lb_db_a_charac_max_id_hex.Text = Convert.ToString(Int32.Parse(val), 16).PadLeft (16,'0');
            }
            catch (Exception)
            {
                Lb_db_a_charac_max_id_hex.Text = "";
            }
        }

        #endregion

        private void Cb_share_account_CheckStateChanged(object sender, EventArgs e)
        {
            lb_b_adb_account_status.Visible = !Cb_share_account.Checked;
        }
    }
}
