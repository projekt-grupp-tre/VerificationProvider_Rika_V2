

using Microsoft.AspNetCore.Http;
using VerificationProvider_Rika_V2.Models;

namespace VerificationProvider_Rika_V2.Services;

public interface IValidateVerificationCodeService
{
    Task<ValidateRequest> UnpackValidateRequestAsync(HttpRequest req);
    void Validate(string userEmail, string correctCode);
    Task<bool> ValidateCodeAsync(string userEmail, ValidateRequest validateRequest);
    Task<bool> ValidateCodeAsync(ValidateRequest validateRequest);
}
