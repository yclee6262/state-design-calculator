using CalculatorWebAPI;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CalculatorForm
{
    public partial class Form1 : Form
    {
        private readonly CalculatorFunction CalculatorObject = new();
        private string? calculatorID;
        private readonly HttpClient client = new();

        public Form1()
        {
            InitializeComponent();
            OutputLabel.Text = Signs.ZERO;

            // Set the BaseAddress for HttpClient
            client.BaseAddress = new Uri("https://localhost:7005");
            client.DefaultRequestHeaders.Accept.Clear();

            CreateCalculator(this, EventArgs.Empty);
        }

        /// <summary>
        /// 創建新的計算機
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void CreateCalculator(object sender, EventArgs e)
        {
            calculatorID = await CreateCalculatorAsync();
            MessageBox.Show($"Created calculator with ID: {calculatorID}");
        }

        /// <summary>
        /// 點擊按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public async void ButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string tag = button.Tag.ToString();
            string value = button.Text;

            CalculatorResponse response = await PressAsync(calculatorID, tag, value);

            TopLabel.Text = response.TopText;
            OutputLabel.Text = response.OutputText;
            preorderString.Text = response.PreorderText;
            inorderString.Text = response.InorderText;
            postorderString.Text = response.PostorderText;
        }

        /// <summary>
        /// call createCalculator 的 API，會接到 ID 的字串
        /// </summary>
        /// <returns>string</returns>
        private async Task<string> CreateCalculatorAsync()
        {
            HttpResponseMessage response = await client.PostAsync("CalculatorControler/create", null);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }

        /// <summary>
        /// call Press 的 API。會接到一個 Dictionary，裡面包要顯示的五個字串
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tag"></param>
        /// <param name="value"></param>
        /// <returns>Dictionary</returns>
        private async Task<CalculatorResponse> PressAsync(string id, string tag, string value)
        {
            if (value == "+") // "+" 在 URL 中有別的意義，要個別處理
            {
                value = "%2b";
            }

            HttpResponseMessage response = await client.PostAsync($"CalculatorControler/{id}/press?tag={tag}&value={value}", null);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<CalculatorResponse>();
        }
    }
}