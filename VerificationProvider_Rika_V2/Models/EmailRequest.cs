﻿

namespace VerificationProvider_Rika_V2.Models;

public class EmailRequest
{
    public string To { get; set; } = null!;
    public string Subject { get; set; } = null!;
    public string Body { get; set; } = null!;
    public string PlainText { get; set; } = null!;
}
