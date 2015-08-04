using MailChimp;
using MailChimp.Campaigns;
using MailChimp.Helper;
using MailChimp.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimpTemplateTest
{
    class Program
    {
        static void Main(string[] args)
        {
            UpdateCampaign();
           


        }

        private static void CreateCampaign() {

            // Arrange
            MailChimpManager mc = new MailChimpManager("e20533551f21cbc6b07c76e570dc33c4-us11");
            //ListResult lists = mc.GetLists();
            //string listID = lists.Data[0].Id;
            CampaignSegmentOptions segmentOptions = new CampaignSegmentOptions();
            segmentOptions.Match = "All";
            //string dateListCreated = lists.Data[0].DateCreated;
            segmentOptions.Conditions = new List<CampaignSegmentCriteria>();
            segmentOptions.Conditions.Add(new CampaignSegmentCriteria { Field = "date", Operator = "eq"});
            CampaignCreateContent content = new CampaignCreateContent();
            content.HTML = @"
    <meta charset='utf-8'>
    <title></title>




    <table width='600' border='0' align='center' cellpadding='0' cellspacing='0' style='background-color: #f0eeee; padding: 20px;'>
        <tbody><tr>
            <td>
                <table width='600' border='0' align='center' cellpadding='0' cellspacing='0'>
                    <tbody><tr>
                        <td style='background-color: #ffa900; padding: 10px 30px;'>
                            <img src='http://localhost:9780/UploadFile/media/e4ed06c6-5445-412e-8f6a-a434e61bee1b-logo.png'></td>
                    </tr>
                    <tr>
                        <td>
                            <img src='http://localhost:9780/UploadFile/media/4b5335ba-bf57-41e9-8092-a1c1d774d837-email-banner-old.jpg'></td>
                    </tr>
                    <tr>
                        <td style='padding: 20px 30px; text-align: left; color: #222222; font-family: Arial, Helvetica, sans-serif; font-size: 16px; background-color: #fff;'>
                       
                           <!-- <p>
                                <strong>Event Details</strong><br />
                                <br />
                                Sun-Sat, November 2-8, 10:30 AM - 3:30 P.M. Brighton Gardens of Washington Township 6800 Paragon Road, Dayton, IL 45459
                            </p>
                            <p>Have questions about the event? Please contact us at <strong>888-5555-7777.</strong> We look forward to seeing you there!</p>
                            <br />
                            <p>The desme Team</p>-->
                            <div ng-bind-html='model.Description' class='ng-binding'><p><strong>Dear *|FNAME|*,</strong></p>

<p>Thank you for registering for the Taste of Chicago event at the Brighton Gardens of Washington Township!</p>

<p><strong>Event Details</strong><br>
<br>
Sun-Sat, November 2-8, 10:30 AM - 3:30 P.M. Brighton Gardens of Washington Township 6800 Paragon Road, Dayton, IL 45459</p>

<p>Have questions about the event? Please contact us at <strong>888-5555-7777.</strong> We look forward to seeing you there!&nbsp;</p>

<p><a href='*|OFFERPURL|*/*|ACCESSCODE|*' target='_blank'>Click here for subscribe</a></p>

<p>The desme Team</p>

<p>&nbsp;</p>
</div>
                        </td>
                    </tr>
                  
                </tbody></table>
            </td>
        </tr>
    </tbody></table>";
            
            CampaignCreateOptions options = new CampaignCreateOptions();
            options.Title = "Email template testing...";
            options.ListId = "1fe090facf";
            options.ToName = "Test Name";
            options.FromEmail = "delwar@desme.com";
            options.FromName = "Testing Company Name";
            options.Subject = "Email template testing";
            Campaign result = mc.CreateCampaign("regular", options, content);
        }


        private static void UpdateCampaign()
        {

            // Arrange
            MailChimpManager mc = new MailChimpManager("e20533551f21cbc6b07c76e570dc33c4-us11");
            CampaignFilter filter = new CampaignFilter();
            filter.Title = "test123";
            var cam = mc.GetCampaigns(filter);


           
         
            CampaignCreateContent content = new CampaignCreateContent();
            string HTML = @"
    <meta charset='utf-8'>
    <title></title>




    <table width='600' border='0' align='center' cellpadding='0' cellspacing='0' style='background-color: #f0eeee; padding: 20px;'>
        <tbody><tr>
            <td>
                <table width='600' border='0' align='center' cellpadding='0' cellspacing='0'>
                    <tbody><tr>
                        <td style='background-color: #ffa900; padding: 10px 30px;'>
                            <img src='http://localhost:9780/UploadFile/media/e4ed06c6-5445-412e-8f6a-a434e61bee1b-logo.png'></td>
                    </tr>
                    <tr>
                        <td>
                            <img src='http://localhost:9780/UploadFile/media/4b5335ba-bf57-41e9-8092-a1c1d774d837-email-banner-old.jpg'></td>
                    </tr>
                    <tr>
                        <td style='padding: 20px 30px; text-align: left; color: #222222; font-family: Arial, Helvetica, sans-serif; font-size: 16px; background-color: #fff;'>
                       
                           <!-- <p>
                                <strong>Event Details</strong><br />
                                <br />
                                Sun-Sat, November 2-8, 10:30 AM - 3:30 P.M. Brighton Gardens of Washington Township 6800 Paragon Road, Dayton, IL 45459
                            </p>
                            <p>Have questions about the event? Please contact us at <strong>888-5555-7777.</strong> We look forward to seeing you there!</p>
                            <br />
                            <p>The desme Team</p>-->
                            <div ng-bind-html='model.Description' class='ng-binding'><p><strong>Dear *|FNAME|*,</strong></p>

<p>Thank you for registering for the Taste of Chicago event at the Brighton Gardens of Washington Township!</p>

<p><strong>Event Details</strong><br>
<br>
Sun-Sat, November 2-8, 10:30 AM - 3:30 P.M. Brighton Gardens of Washington Township 6800 Paragon Road, Dayton, IL 45459</p>

<p>Have questions about the event? Please contact us at <strong>888-5555-7777.</strong> We look forward to seeing you there!&nbsp;</p>

<p><a href='*|OFFERPURL|*/*|ACCESSCODE|*' target='_blank'>Click here for subscribe to delwar</a></p>

<p>The desme Team</p>

<p>&nbsp;</p>
</div>
                        </td>
                    </tr>
                  
                </tbody></table>
            </td>
        </tr>
    </tbody></table>";

           
            var result = mc.UpdateCampaign(cam.Data[0].Id, "content", new { html = HTML });
        }

      


        private static void SendCampaign() {

            MailChimpManager mc = new MailChimpManager("e20533551f21cbc6b07c76e570dc33c4-us11");
            CampaignFilter filter = new CampaignFilter();
            filter.Title = "Email template testing...";

            var cam = mc.GetCampaigns(filter);



            var result = mc.SendCampaign(cam.Data[0].Id);

        }

        private static void ScheduleCampaign()
        {

            MailChimpManager mc = new MailChimpManager("e20533551f21cbc6b07c76e570dc33c4-us11");
            CampaignFilter filter = new CampaignFilter();
            filter.Title = "Email template testing...";

            var cam = mc.GetCampaigns(filter);



          //  var result = mc.ScheduleCampaign

        }
       

        private static void GetCampaignId() {
            MailChimpManager mc = new MailChimpManager("e20533551f21cbc6b07c76e570dc33c4-us11");
            CampaignFilter filter = new CampaignFilter();
            filter.Title = "Testing uing anchor tag";

            var cam = mc.GetCampaigns(filter);

        
        }
        private static void BatchSubscribe() {

            MailChimpManager mc = new MailChimpManager("e20533551f21cbc6b07c76e570dc33c4-us11");
           ListResult lists = mc.GetLists();
           //1fe090facf
            List<BatchEmailParameter> emails = new List<BatchEmailParameter>();

            BatchEmailParameter email1 = new BatchEmailParameter()
            {
                Email = new EmailParameter()
                {
                    Email = "customeremail1@righthere.com"
                }
            };

            MergeVar mVar1 = new MergeVar();
            mVar1.Add("FNAME", "first1" + DateTime.Now);
            mVar1.Add("LNAME", "last1" + DateTime.Now);
            email1.MergeVars = mVar1;



            emails.Add(email1);


        }
    }
}
