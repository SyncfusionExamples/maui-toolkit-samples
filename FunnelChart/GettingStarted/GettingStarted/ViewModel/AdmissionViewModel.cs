namespace GettingStarted
{
    public class AdmissionViewModel
    {
        public List<AdmissionModel> Data { get; set; }

        public AdmissionViewModel()
        {
            Data = new List<AdmissionModel>()
            {
                new AdmissionModel() {XValue = "Enrolled", YValue=175},
                new AdmissionModel() {XValue = "Admits", YValue=190},
                new AdmissionModel() {XValue = "Applicants", YValue=245},
                new AdmissionModel() {XValue = "Inquiries ", YValue=290},
                new AdmissionModel() {XValue = "Prospects ", YValue=320},
            };
        }
    }
}