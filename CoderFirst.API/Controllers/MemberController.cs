using Microsoft.AspNetCore.Mvc;
using CoderFirst.BusinessObject;
using CoderFirst.API.ModelValidation;
using CoderFirst.API.EmailHelper;

namespace CoderFirst.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Member")]
    public class MemberController : Controller
    {
        private readonly IEmailService _emailService;

        public MemberController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost]
        public void Subscribe([FromBody]  SubscriptionBo bo)
        {
            var result = new SubscriptionValidation().Validate(bo);

            if (result.IsValid)
            {

            }
            else
            {

            }
        }

        [HttpGet]
        public void sub( )
        {
            var body = Email.Body().Title("This is title").SubTitle("This is sub title").Title("This is title").Build();

            _emailService.SendEmailAsync("to email", "Subject", body);
        }

        //[HttpPost]
        //public async Task<ActionResult> Subscription(FormCollection formCollection)
        //{
        //    string emailAdress = formCollection["EmailAddress"];
        //    var subscriptionValidation = new SubscriptionValidation();
        //    var results = subscriptionValidation.Validate(new SubscriptionBo() { EmailAdress = emailAdress });
        //    if (results.IsValid)
        //    {
        //        string token = Guid.NewGuid().ToString();


        //        var body = EmailUtitlity.ReadHtmlFile(Server.MapPath(@"~\EmailTemplate\Member\MemberSubscription.html")).ToString();
        //        if (!string.IsNullOrEmpty(body))
        //        {
        //            var confirmationLink = Url.Action("ConfirmSubscription", "Member", new { Token = token }, Request.Url != null ? Request.Url.Scheme : "http://www.coderfirst.lk/");
        //            body = body.Replace("$tokenlink", confirmationLink);

        //            await Mailer.Send(body, "noreply@coderfirst.lk", emailAdress, "Confirm Subscription", "CoderFirst", true, null, null, EmailTypeEnum.Transaction);
        //        }

        //        _memberServices.Addsubscription(new SubscriptionBo()
        //        {
        //            EmailAdress = formCollection["EmailAddress"],
        //            SubscriptionDate = AppDateTime.GetCultureDateTime(),
        //            Token = token
        //        });

        //        return Json(new { Status = TransactionStatusEnum.Success.ToString(), Message = "Subscription is done successfully!. Please check your inbox and confirm email." }, JsonRequestBehavior.AllowGet);
        //    }
        //    else
        //    {
        //        return Json(new { validationMessage = AjaxValidationMessage.Built(results.Errors, results.IsValid) }, JsonRequestBehavior.AllowGet);
        //    }
        //}
    }
}