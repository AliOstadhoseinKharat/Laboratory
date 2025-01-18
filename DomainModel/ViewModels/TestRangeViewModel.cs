namespace DomainModel.ViewModels
{
    public class TestRangeViewModel
    {
        public int? FromAge { get; set; }
        public int? ToAge { get; set; }
        public int? Gender { get; set; }

        public double FromValue { get; set; }

        public double ToValue { get; set; }
        public string Description { get; set; }
        public string TestName { get; set; }
        public bool? Hazard { get; set; }
    }
}
