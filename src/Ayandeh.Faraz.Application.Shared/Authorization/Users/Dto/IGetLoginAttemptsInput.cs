using Abp.Application.Services.Dto;

namespace Ayandeh.Faraz.Authorization.Users.Dto
{
    public interface IGetLoginAttemptsInput: ISortedResultRequest
    {
        string Filter { get; set; }
    }
}