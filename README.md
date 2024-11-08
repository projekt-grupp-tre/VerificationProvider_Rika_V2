# VerificationProvider_Rika_V2

"ServiceBusConnection": "Endpoint=sb://sb-emailprovider-v2.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=sBIcy5Zaw85JUZSKVh07clpqUEGvjXDoh+ASbFhN8eg=",


queue: verification_request 
Verification Request
{    public string Email { get; set; } = null!;
    public string Code { get; set; } = null!;    
}

queue: email_request for att send email 
 EmailRequest:
{
    public string To { get; set; } = null!;
    public string Subject { get; set; } = null!;
    public string HtmlBody { get; set; } = null!;
    public string PlainText { get; set; } = null!;
}

"Verify_FunctionKey": "https://verification-rika.azurewebsites.net/api/verify?code=0mQbf3eCNmaWk7YjezTtO2DZNsI0gDN6QD9p7Cd10z11AzFuY415IA%3D%3D", exempel----> {"email":".....","code":" "}

GenerateVerificationCodeHttp_FunctionKey: "https://verification-rika.azurewebsites.net/api/GenerateVerificationCodeHttp?code=BItffmctv-BTFfGNf9NM61EP5Mz1AVueZv_l54lDiED8AzFuZoyorg%3D%3D" ,exempel----> {"email":"....."}
