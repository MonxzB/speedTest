using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace speedTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Gán giá trị mặc định cho các label khi load form
            lblDownload.Text = "Download: -- Mbps";
            lblUpload.Text = "Upload: -- Mbps";
            lblPing.Text = "Ping: -- ms";
            lblStatus.Text = "Status: --";
            progressBar1.Visible = false;
        }

        private async void btnTest_Click(object sender, EventArgs e)
        {
            // Tắt nút Test và hiển thị ProgressBar
            btnTest.Enabled = false;
            lblStatus.Text = "Đang kiểm tra...";
            progressBar1.Visible = true;

            // Kiểm tra tốc độ mạng song song
            var downloadTask = TestDownloadSpeed();
            var uploadTask = TestUploadSpeed();
            var pingTask = GetPing();

            // Đợi tất cả các tác vụ hoàn thành đồng thời
            await Task.WhenAll(downloadTask, uploadTask, pingTask);

            // Cập nhật kết quả lên UI
            lblDownload.Text = $"Download: {downloadTask.Result:F2} Mbps";
            lblUpload.Text = $"Upload: {uploadTask.Result:F2} Mbps";
            lblPing.Text = $"Ping: {pingTask.Result} ms";

            // Cập nhật trạng thái thành "Đã xong"
            lblStatus.Text = "Đã xong";

            // Tắt ProgressBar và mở lại nút Test
            progressBar1.Visible = false;
            btnTest.Enabled = true;
        }


        // Phương thức kiểm tra tốc độ Download
        private async Task<double> TestDownloadSpeed()
        {
            string testUrl = "http://ipv4.download.thinkbroadband.com/10MB.zip"; // Tải file test

            using (HttpClient client = new HttpClient())
            {
                // Thêm header User-Agent để giả lập trình duyệt
                client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36");

                try
                {
                    var sw = Stopwatch.StartNew();
                    var data = await client.GetByteArrayAsync(testUrl);
                    sw.Stop();

                    double seconds = sw.Elapsed.TotalSeconds;
                    double bytes = data.Length;

                    double bitsPerSecond = (bytes * 8) / seconds;
                    double megabitsPerSecond = bitsPerSecond / 1_000_000;

                    return megabitsPerSecond;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi kiểm tra tốc độ download: " + ex.Message);
                    return 0;
                }
            }
        }

        // Phương thức kiểm tra tốc độ Upload
        private async Task<double> TestUploadSpeed()
        {
            byte[] testData = new byte[5 * 1024 * 1024]; // 5MB dữ liệu ngẫu nhiên
            new Random().NextBytes(testData);

            using (HttpClient client = new HttpClient())
            {
                var sw = Stopwatch.StartNew();
                var content = new ByteArrayContent(testData);

                try
                {
                    // Sử dụng URL Pipedream của bạn
                    var result = await client.PostAsync("https://eo3hng4ov51711h.m.pipedream.net", content);  // Pipedream URL

                    // Đo thời gian upload
                    sw.Stop();
                    double seconds = sw.Elapsed.TotalSeconds;
                    double bits = testData.Length * 8;
                    return (bits / seconds) / 1_000_000;  // Mbps
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi kiểm tra upload: " + ex.Message);
                    return -1;  // Trả về -1 nếu có lỗi
                }
            }
        }

        // Phương thức kiểm tra Ping
        private async Task<int> GetPing()
        {
            try
            {
                var pingSender = new System.Net.NetworkInformation.Ping();
                var reply = await pingSender.SendPingAsync("8.8.8.8"); // Google DNS
                return (int)reply.RoundtripTime;
            }
            catch
            {
                return -1;
            }
        }
    }
}
