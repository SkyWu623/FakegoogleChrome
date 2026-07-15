using Microsoft.Web.WebView2.WinForms;

using System.Diagnostics;

using System.Numerics;

namespace google
{

    public partial class Form1 : Form
    {

        Dictionary<Button, WebView2> tabDictionary = new Dictionary<Button, WebView2>();

        // 用來記錄目前正在看哪一個網頁

        WebView2 currentBrowser = null;

        Button currentTabButton = null;

        Dictionary<string, HashSet<string>> _index = new Dictionary<string, HashSet<string>>();

        public Form1()
        {

            InitializeComponent();

            // 視窗載入時，先初始化 WebView2

            this.Load += Form1_Load;



            label1.Visible = false;

            lstResults.Visible = false;

        }
        private void btnSearch_TextChanged(object sender, EventArgs e)
        {

            if (btnSearch.Text == "")
            {



            }
            else
            {

                label1.Visible = true;

                lstResults.Visible = true;
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {

            // 必須先等待 WebView2 初始化完成
            await webViewChrome.EnsureCoreWebView2Async(null);
            // 初始化完成後，可以給它一個預設首頁（例如 Google）

            webViewChrome.CoreWebView2.Navigate("https://www.google.com");

            URL.Text = "https://www.google.com";

        }

        private void BuildIndex(string folderPath)
        {

            _index.Clear();

            var files = Directory.GetFiles(folderPath, "*.txt");


            foreach (var file in files)
            {

                string content = File.ReadAllText(file);

                char[] delimiters = { ' ', '.', ',', '\r', '\n', '\t' };

                string[] words = content.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);



                foreach (var word in words)
                {

                    string cleanWord = word.ToLower().Trim();

                    if (!_index.ContainsKey(cleanWord))

                        _index[cleanWord] = new HashSet<string>();



                    _index[cleanWord].Add(file);

                }

            }

        }

        private void txtSearch_Click(object sender, EventArgs e)

        {

            string query = btnSearch.Text;

            string path = @"C:\SearchTest";

            string answer = "";

            if (string.IsNullOrEmpty(query)) return;

            string[] files = Directory.GetFiles(path, "*.txt");

            int number = 0;

            foreach (var file in files)

            {

                //UTF-8

                string content = File.ReadAllText(file, System.Text.Encoding.Default);



                if (content.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0)

                {

                    answer += content;

                    lstResults.Items.Add($"搜尋:{query} 搜尋成功");

                    answer += "\r\n___________________________________________________________\r\n";

                    number++;

                }

            }

            if (number == 0)

            {

                answer += $"找不到符合搜尋字詞「{query}」的文件。" +

                    $"\r\n\r\n建議：" +

                    $"\r\n\r\n請檢查有無錯別字\r\n試試以其他關鍵字搜尋。" +

                    $"\r\n試試以較籠統的關鍵字搜尋。" +

                    $"\r\n試試以較少的關鍵字搜尋。";

            }
            else
            {

                Random random = new Random();

                double time = random.NextDouble();

                answer += $"約有{number}項搜尋結果(搜尋時間:{time:F2})";

                if (lstResults.Items.Count == 0)
                {

                    if (files.Length > 0)
                    {

                        string firstFileContent = File.ReadAllText(files[0], System.Text.Encoding.Default);

                        lstResults.Items.Add($"搜尋失敗 {files.Length} 第一個檔案前五字{(firstFileContent.Length > 5 ? firstFileContent.Substring(0, 5) : firstFileContent)}");

                    }
                    else
                    {

                        MessageBox.Show("錯誤");

                    }
                }
            }

            Form2 f2 = new Form2();


            // 將 Form1 設為 Form2 的擁有者

            f2.Owner = this;

            f2.Txt = answer;

            f2.urltext = query;

            f2.Show();

            this.Hide(); // 隱藏 Form1

        }



        private void label1_Click(object sender, EventArgs e)
        {

            label1.Visible = true;

            lstResults.Visible = true;

        }



        private void 紀錄ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (label1.Visible)

            {

                label1.Visible = false;

                lstResults.Visible = false;

            }

            else

            {

                label1.Visible = true;

                lstResults.Visible = true;

            }

        }



        private void gmailToolStripMenuItem_Click(object sender, EventArgs e)
        {



        }



        private void geminiToolStripMenuItem_Click(object sender, EventArgs e)

        {

            URL.Text = "https://gemini.google.com";



            Process.Start("C:\\Users\\Surface\\Desktop\\胡維基的AI4.0\\胡維基的AI3.0\\bin\\Debug\\胡維基的AI3.0.exe");

        }



        private void 登入ToolStripMenuItem_Click(object sender, EventArgs e)

        {



        }



        private void youtubeToolStripMenuItem_Click(object sender, EventArgs e)

        {

            URL.Text = "https://www.youtube.com";

            Process.Start("C:\\Users\\Surface\\Desktop\\影片播放\\影片播放\\bin\\Debug\\影片播放.exe\"");



        }



        private void G_Click(object sender, EventArgs e)

        {

            URL.Text = "www.盜版google.com";

        }



        private void 圖片ToolStripMenuItem_Click(object sender, EventArgs e)

        {

            URL.Text = "www.圖片google.com";



        }





        private void URL_TextChanged(object sender, EventArgs e)

        {



        }



        private void URL_KeyDown(object sender, KeyEventArgs e)

        {

            if (e.KeyCode == Keys.Enter)

            {

                NavigateToUrl();

                // 阻止嗶嗶聲

                e.SuppressKeyPress = true;

            }

        }

        // 請把這段補到你的 Form1 類別裡面

        private void NavigateToUrl()

        {

            string url = URL.Text.Trim();



            if (string.IsNullOrEmpty(url)) return;



            // 🔥 1. 攔截自訂網址：如果是盜版 google，就切換顯示並收工，不讓 WebView2 執行

            if (url == "www.盜版google.com" || url == "盜版google.com")

            {

                webViewChrome.Visible = false; // 隱藏瀏覽器

                panel2.Visible = true;         // 顯示你的搜尋 Panel

                panel2.BringToFront();         // 移到最上層

                return;                        // 直接跳出，不再往下執行

            }



            // 🔥 2. 一般網址：切換回 WebView2 瀏覽器模式

            panel2.Visible = false;           // 隱藏搜尋 Panel

            webViewChrome.Visible = true;     // 顯示瀏覽器

            webViewChrome.BringToFront();     // 移到最上層



            if (!url.StartsWith("http://") && !url.StartsWith("https://"))

            {

                url = "https://" + url;

            }



            try

            {

                webViewChrome.CoreWebView2.Navigate(url);

            }

            catch (Exception ex)

            {

                MessageBox.Show($"無法開啟網址: {ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }



        private void webViewChrome_Click(object sender, EventArgs e)
        {
            MessageBox.Show("網頁不正常","錯誤");
        }

        //刪除分頁

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            Process.Start("\"C:\\Users\\Surface\\Desktop\\google\\google\\bin\\Debug\\net8.0-windows\\google.exe\"");
        }

        private void Form1_MaximumSizeChanged(object sender, EventArgs e)
        {
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
        }

        private void webViewChrome_Resize(object sender, EventArgs e)
        {
        }
        private void Form1_Resize_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                webViewChrome.Height = 1280;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                webViewChrome.Height = 580;
            }
        }
    }

}