namespace StudentWebAPI.Models.ViewModel.Dc_Dashboard
{
    public class ClassWiseStduDtl
    {
        public string OrgCode { get; set; }
        public string CampusCode { get; set; }
        public string ClassCode { get; set; }
        public string AttDate { get; set; }
        public string AttStatus { get; set; }

    }

    public class ClassWiseStduDtlVM
    {
        public string STUDENT_CODE { get; set; }
        public string STUDENT_NAME { get; set; }
        public string SMS_MOBILE_NUM { get; set; }
    }
}
