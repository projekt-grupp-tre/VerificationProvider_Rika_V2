﻿
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using VerificationProvider_Rika_V2.Data.Contexts;
using VerificationProvider_Rika_V2.Models;

namespace VerificationProvider_Rika_V2.Services;

public class ValidateVerificationCodeService(ILogger<ValidateVerificationCodeService> logger, DataContext context) : IValidateVerificationCodeService
{
    private readonly ILogger<ValidateVerificationCodeService> _logger = logger;
    private readonly DataContext _context = context;


    public async Task<bool> ValidateCodeAsync(ValidateRequest validateRequest)
    {
        try
        {
            var entity = await _context.VerificationRequests.FirstOrDefaultAsync(x => x.Email == validateRequest.Email && x.Code == validateRequest.Code);
            if (entity != null)
            {
                _context.VerificationRequests.Remove(entity);
                await _context.SaveChangesAsync();
                return true;
            }
        }
        catch (System.Exception ex)
        {
            _logger.LogError($"ERROR : ValidateVerificationCode.ValidateCodeAsync.Run :: {ex.Message}");
        }
        return false;
    }

    public async Task<ValidateRequest> UnpackValidateRequestAsync(HttpRequest req)
    {
        try
        {
            var body = await new StreamReader(req.Body).ReadToEndAsync();
            if (!string.IsNullOrEmpty(body))
            {
                var validateRequest = JsonConvert.DeserializeObject<ValidateRequest>(body);
                if (validateRequest != null)
                    return validateRequest;
            }
        }
        catch (System.Exception ex)
        {
            _logger.LogError($"ERROR : UnpackValidateRequestAsync.Run :: {ex.Message}");


        }
        return null!;

    }

    public Task<bool> ValidateCodeAsync(string userEmail, ValidateRequest validateRequest)
    {
        throw new NotImplementedException();
    }

    public void Validate(string userEmail, string correctCode)
    {
        throw new NotImplementedException();
    }
}
