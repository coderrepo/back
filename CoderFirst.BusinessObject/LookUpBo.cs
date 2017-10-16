
namespace CoderFirst.BusinessObject
{

    public class LookUpBo : BoCommon
    {
        public int LookUpId { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public string LookUpType { get; set; }
        public bool IsPrimary { get; set; }
    }
}