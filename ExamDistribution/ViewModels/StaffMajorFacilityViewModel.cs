namespace ExamDistribution.ViewModels
{
    public class StaffMajorFacilityViewModel
    {
        public string StaffId { get; set; } = string.Empty;
        public string StaffCode { get; set; } = string.Empty;
        public string StaffName { get; set; } = string.Empty;

        public string SelectedFacilityId { get; set; } = string.Empty;
        public string SelectedDepartmentFacilityId { get; set; } = string.Empty;
        public string SelectedMajorFacilityId { get; set; } = string.Empty;

        public List<FacilityDto> Facilities { get; set; } = new();
        public List<DepartmentFacilityViewModel> DepartmentFacilities { get; set; } = new();
        public List<MajorFacilityViewModel> MajorFacilities { get; set; } = new();

        public List<StaffMajorFacilityViewModel> StaffMajorFacilities { get; set; } = new();
        public string Id { get; internal set; }
        public string? MajorName { get; internal set; }
        public string? FacilityName { get; internal set; }
        public string? DepartmentName { get; internal set; }
    }

    public class FacilityDto
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
    }


    public class MajorFacilityViewModel
    {
        public string Id { get; set; } = string.Empty;
        public string MajorId { get; set; } = string.Empty;
        public string MajorName { get; set; } = string.Empty;
    }


    public class StaffMajorFacilityDto
    {
        public string Id { get; set; } = string.Empty;
        public string FacilityName { get; set; } = string.Empty;
        public string DepartmentName { get; set; } = string.Empty;
        public string MajorName { get; set; } = string.Empty;
    }
}
