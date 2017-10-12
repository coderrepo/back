using CoderFirst.DataAccess.Model;
using CoderFirst.DataAccess.BusinessObject;

public static class AdvertismentMapper
{
    public static Advertisment BuildDomain(AdvertismentBo bo)
    {
        return new Advertisment()
        {
            AdvertismentGuid = bo.AdvertismentGuid,
            Title = bo.Title,
            Description = bo.Description,
            ClickUrl = bo.ClickUrl,
            WebUrl = bo.WebUrl,
            ClosingOn = bo.ClosingOn,
            CreatedOn = bo.CreatedOn,
            TotalClick = bo.TotalClick,
            AddsImageName = bo.AddsImageName,
            Status = bo.Status
        };
    }

    public static AdvertismentBo BuildBo(Advertisment model)
    {
        return new AdvertismentBo
        {
            AdvertismentGuid = model.AdvertismentGuid,
            AdvertismentId = model.AdvertismentId,
            Title = model.Title,
            Description = model.Description,
            AddsImageName = model.AddsImageName,
            ClickUrl = model.ClickUrl,
            WebUrl = model.WebUrl,
            ClosingOn = model.ClosingOn,
            CreatedOn = model.CreatedOn,
            TotalClick = model.TotalClick,
            Status = model.Status
        };
    }
}
