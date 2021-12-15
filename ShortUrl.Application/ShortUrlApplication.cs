using System;
using _0_FrameWork.Application;
using ShortUrl.Application.Contracts.ShortUrl;
using ShortUrl.Domain.ShortUrlAggrigation;

namespace ShortUrl.Application
{
    public class ShortUrlApplication : IShortUrlApplication
    {
        private readonly IShortUrlRepository _shortUrlRepository;
        public OperatResult Create(CreateShortUrl command)
        {
            var operation = new OperatResult();
            if (_shortUrlRepository.Exists(x => x.OrginalUrl == command.OrginalUrl))
                return operation.Failed("امکان ثبت رکورد تکراری وجود ندارد");
            Guid guid = new Guid();
            var CreateShortUrl = new Domain.ShortUrlAggrigation.ShortUrl(command.OrginalUrl, guid);
            _shortUrlRepository.CreateShortUrl(CreateShortUrl);
            _shortUrlRepository.SaveChanges();
            return operation.Succedded($"Short Url Is {guid}");
        }

        public OperatResult GetOrginalUrl(ShowOrginalUrl command)
        {
            var operation = new OperatResult();
            if (_shortUrlRepository.Exists(x => x.ShorterUrl.ToString() == command.ShorterUrl))
            {
                long i = 0;
                new Domain.ShortUrlAggrigation.ShortUrl(i);
                return operation.Succedded(command.OrginalUrl);
            }
            return operation.Failed("یو آر ال مورد نظر یافت نشد !");
        }
    }
}
