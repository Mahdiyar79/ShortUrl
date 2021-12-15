using _0_FrameWork.Application;

namespace ShortUrl.Application.Contracts.ShortUrl
{
    public interface IShortUrlApplication
    {
        OperatResult Create(CreateShortUrl command);
        OperatResult GetOrginalUrl(ShowOrginalUrl command);
    }
}
