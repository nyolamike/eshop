
using eshop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eshop.Attributes
{
    public class PhoneNumber : ValidationAttribute
    {
        public PhoneNumber(string ErrorMessage)
        {
            this.ErrorMessage = ErrorMessage;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            //phone nnumber formating addopted from
            //https://stackoverflow.com/questions/30434836/how-to-convert-mobile-number-to-international-format-in-c-sharp
            //////Country country = Countries.GetCountry(msg.Country);
            //////var util = PhoneNumberUtil.GetInstance();
            //////PhoneNumber pn = util.Parse(msg.PhoneNumber, country.ShortName.ToUpper());
            //////string internationalPhoneNumber = util.Format(pn, PhoneNumberFormat.INTERNATIONAL).Replace(" ", "");

            //var from = new Twilio.Types.PhoneNumber(Refs.TwilioPhoneNumber);
            //var to = new Twilio.Types.PhoneNumber(internationalPhoneNumber);
            //var message = MessageResource.Create(
            //    body: "Cheda Account Verification Code " + msg.Code,
            //    from: from,
            //    to:  to
            //);

            //nyd
            //enable this sinnipet when we are ready to roll out
            //var results = Refs.NexmoClient.SMS.Send(request: new SMS.SMSRequest
            //{
            //    from = "CHEDA PLATFORM",
            //    to = internationalPhoneNumber,
            //    text = "Cheda Account Verification Code " + msg.Code
            //});

            //_log.Info($"MailerActor: InvesterActor => i have finished sending your activation code");
            //Context.Parent.Tell(new VerificationCodeSent_(msg, msg.ChannelId));
            //return true;


            //Ask the security actor if this phone number exists
            //Task<bool> question = Refs.SecurityRef.Ask<bool>(new PhoneNumberExists_(value.ToString()));
            //question.Wait();
            //if (question.Result==false)
            //{
            //    return ValidationResult.Success;
            //}

            return new ValidationResult(ErrorMessage);
        }
    }
}
