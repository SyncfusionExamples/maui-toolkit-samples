namespace GettingStarted
{
    public class ChartViewModel
    {
        public List<Admission> Data { get; set; }

        public ChartViewModel()
        {
            Data = new List<Admission>()
            {
                new Admission() {XValue = "Enrolled", YValue=175},
                new Admission() {XValue = "Admits", YValue=190},
                new Admission() {XValue = "Applicants", YValue=245},
                new Admission() {XValue = "Inquiries ", YValue=290},
                new Admission() {XValue = "Prospects ", YValue=320},
            };
        }
    }
}