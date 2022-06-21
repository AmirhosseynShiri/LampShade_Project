using Microsoft.AspNetCore.Http;

namespace _0_FrameWork.Application.Zarpal
{
    public interface IPaymentService
    {
        PaymentStatus CreatePaymentRequest(string merchantId, int amount, string description,
            string callbackUrl, ref string redirectUrl, string userEmail, string userMobile);

        PaymentStatus PaymentVerification(string merchantId, string authority,
            int amount, ref long refId);
        string GetAuthorityCodeFromCallback(HttpContext context);

    }
}
