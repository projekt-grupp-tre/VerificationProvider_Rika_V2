

namespace VerificationProvider_Rika_V2.Services;

public interface IVerificationCleanerService
{
    Task RemoveExpiredRecordAsync();
}
