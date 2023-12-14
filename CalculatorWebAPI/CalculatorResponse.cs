namespace CalculatorWebAPI
{
    public class CalculatorResponse
    {
        public string TopText {  get; set; }
        public string OutputText { get; set; }
        public string InorderText { get; set; }
        public string PreorderText { get; set;}
        public string PostorderText { get; set;}

        public CalculatorResponse() { }
    }
}
