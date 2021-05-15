using System;
using System.Collections.Generic;
using System.Globalization;
using Mobildev.SMS.Enum;
using Mobildev.SMS.Extensions;
using NUnit.Framework;

namespace Mobildev.SMS.Tests
{
    [TestFixture]
    public class SmsClientFixture
    {
        [Test]
        public void send_sms()
        {
            //var smsClient = new SmsClient("karsan-mb1925", "081428");
           // var smsClient = new SmsClient("pelit1-mb1925", "4037");
            var smsClient = new SmsClient("tekiziletisim-mb1925", "8033");
            //var result = smsClient.Send(ActionTypes.SmsToConcat, "Test mesajı", new List<string> { "5313357661" }, "MDEV DEMO");
            var result = smsClient.Send(ActionTypes.Sms, "Test mesajı", new List<string> { "5313357661" }, "");
            Console.WriteLine(result);
        }

        [Test]
        public void phone_number_fixture()
        {
            var numbers = new[] { null, "", "0090 (216) 428 53 33", "0090", "0090 (533) 240 68 54", "0090 (532) 396 45 50", "0090 (212) 454 10 0", "0 (212) 454 10 56" };
            foreach (var number in numbers)
            {
                var phoneNumber = number.ToPhoneNumber();
                if (!phoneNumber.IsMobilePhoneNumber()) continue;
                Console.WriteLine(phoneNumber);
            }
        }

        [Test]
        public void get_user_info()
        {
            // var smsClient = new SmsClient("**", "**");
            //var smsClient = new SmsClient("mirhatt-mb1925", "54623");
            var smsClient = new SmsClient("tekiziletisim-mb1925", "8033");
            var result = smsClient.GetUserInfo(ActionTypes.UserInfo);
            Console.WriteLine(result);

        }
    }
}
