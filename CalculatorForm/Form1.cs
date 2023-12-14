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
        /// �Ыطs���p���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void CreateCalculator(object sender, EventArgs e)
        {
            calculatorID = await CreateCalculatorAsync();
            MessageBox.Show($"Created calculator with ID: {calculatorID}");
        }

        /// <summary>
        /// �I�����s
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
        /// call createCalculator �� API�A�|���� ID ���r��
        /// </summary>
        /// <returns>string</returns>
        private async Task<string> CreateCalculatorAsync()
        {
            HttpResponseMessage response = await client.PostAsync("CalculatorControler/create", null);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }

        /// <summary>
        /// call Press �� API�C�|����@�� Dictionary�A�̭��]�n��ܪ����Ӧr��
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tag"></param>
        /// <param name="value"></param>
        /// <returns>Dictionary</returns>
        private async Task<CalculatorResponse> PressAsync(string id, string tag, string value)
        {
            if (value == "+") // "+" �b URL �����O���N�q�A�n�ӧO�B�z
            {
                value = "%2b";
            }

            HttpResponseMessage response = await client.PostAsync($"CalculatorControler/{id}/press?tag={tag}&value={value}", null);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<CalculatorResponse>();
        }
    }
}