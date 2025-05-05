using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util;
using Google.Apis.Util.Store;
using Newtonsoft.Json.Linq;
using RestSharp;
using StudentWebAPI.Models.Google;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Google.Apis.Drive.v3.DriveService;

namespace StudentWebAPI.RepositoryImpl.GoogleDrive
{
    public class GoogleDriveService
    {
        public static DriveService GetService()
        {
            GoogleDriveCredential googleCredential = new GoogleDriveCredential();
            GoogleCredentialVM googleCredentialVM = new GoogleCredentialVM();
            googleCredentialVM = googleCredential.getGoogleCredential();

            var username = googleCredentialVM.USER_NAME;
            var applicationName = googleCredentialVM.APPLICATION_NAME;
            string clientId = googleCredentialVM.CLIENT_ID;
            string clientSecret = googleCredentialVM.CLIENT_SECRET;
            string refreshToken = googleCredentialVM.REFRESH_TOKEN;

            //var uri = "https://www.googleapis.com/oauth2/v4/token?client_id="+clientId+"&client_secret="+clientSecret+"&refresh_token="+refreshToken+"&grant_type=refresh_token&access_type=offline";
            //var client = new RestClient(uri);

            ////client.Timeout = -1;
            //var request = new RestRequest(uri, Method.Post);
            //// client.UserAgent = "google-oauth-playground";
            //request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            ////request.AddParameter("client_id", clientId);
            ////request.AddParameter("client_secret", clientSecret);
            ////request.AddParameter("refresh_token", refreshToken);
            ////request.AddParameter("grant_type", "refresh_token");
            ////request.AddParameter("access_type", "offline");
            //RestResponse response = client.Execute(request);
            //JObject responseObj = JObject.Parse(response.Content);
            //Console.WriteLine(response.Content);

            var uri = "https://www.googleapis.com/oauth2/v4/token?client_id=738246366629-d6vu0ekgluntv1rkojm1moiuk8iaurf2.apps.googleusercontent.com&client_secret=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&refresh_token=1//04WT3bOblt26yCgYIARAAGAQSNwF-L9IrfxeYMbF_MfAzIQwXZWpmm5D7_L_4xLLmGQ_hUKheX_l88hEvDV56eCEsV4gxQZm6qSI&grant_type=refresh_token&access_type=offline";
            var client = new RestClient();
            var request = new RestRequest(uri, Method.Post);
            RestResponse response = client.Execute(request);
            JObject responseObj = JObject.Parse(response.Content);
            //StringBuilder getNewToken = new StringBuilder();
            //getNewToken.Append("https://oauth2.googleapis.com/token");
            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri(getNewToken.ToString());
            //var values = new Dictionary<string, string>
            //        {
            //            { "client_id", clientId },
            //            { "client_secret", clientSecret },
            //            { "refresh_token", refreshToken },
            //            { "grant_type", "refresh_token"}
            //        };

            //var content = new FormUrlEncodedContent(values);
            //var response = await client.PostAsync(getNewToken.ToString(), content);
           // var accessToken = ConfigurationManager.AppSetting["GoogleDrive:AccessToken"];
            var  accessToken = (string)responseObj["access_token"];
            //accessToken = "ya29.a0AfB_byBrIEbRu8EFOGDxFzPxsKCbCUDwlD9HLE39ITSL4j79JkoE5Sx99QDbcwyp0zPAmQxQK3fkiw4vq6Ui-HAtG-SHAWZCM6Jutfl1vQg3zbX9FkiV2g0jv5CULS9DeWj6zq3PGliKBUYGTuJRsgrKAveircP5Myq_o5kIaCgYKARYSARMSFQHsvYlsEX3c_j_y8bwG3K94M-hc0Q0175";// (string) responseObj["access_token"]; //"ya29.a0AfB_byARDjqdO1X2lYGaMUg1BEQb2sFLtxE0J5o-F-Jb2g_Aju6L_sDPstEGvt-CFapGUHapGY9vomMyZXuolkDTHspa49u4xpA7p6GpDXadbbHyk7Lv4_nHI_THAP18Ozgdr78KDfMWPiy69VnP4gZAayiOK85g4WBxaGKjaCgYKAcsSARMSFQHsvYls6ad3c7Fo8XA49kTTe6FcRQ0175";
            var tokenResponse = new TokenResponse
            {
                AccessToken = accessToken,
                RefreshToken = refreshToken,

            };


            /*tokenResponse.IsExpired(SystemClock.Default)*/
            ;


            var apiCodeFlow = new GoogleAuthorizationCodeFlow(new GoogleAuthorizationCodeFlow.Initializer
            {
                ClientSecrets = new ClientSecrets
                {
                    ClientId =clientId, // ConfigurationManager.AppSetting["GoogleDrive:ClientId"],
                    ClientSecret =clientSecret // ConfigurationManager.AppSetting["GoogleDrive:ClientSecret"]
                },
                Scopes = new[] { Scope.Drive },
                DataStore = new FileDataStore(applicationName, true),

            });


            var credential = new UserCredential(apiCodeFlow, username, tokenResponse);
            //var success = Task.Run(async () => await credential.RefreshTokenAsync(CancellationToken.None)).Result;



            var service = new DriveService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credential,
                ApplicationName = applicationName
            });

            return service;



        }







        //public static DriveService GetService()
        //{
        //    var applicationName = ConfigurationManager.AppSetting["GoogleDrive:ApplicationName"];
        //    var clientId = ConfigurationManager.AppSetting["GoogleDrive:ClientId"];
        //    var clientSecret = ConfigurationManager.AppSetting["GoogleDrive:ClientSecret"];
        //    var scopes = new[] { DriveService.Scope.Drive };

        //    var credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
        //        new ClientSecrets
        //        {
        //            ClientId = clientId,
        //            ClientSecret = clientSecret
        //        },
        //        scopes,
        //        "user",
        //        CancellationToken.None,
        //        new FileDataStore("DriveServiceCredentials")
        //    ).Result;

        //    var service = new DriveService(new BaseClientService.Initializer
        //    {
        //        HttpClientInitializer = credential,
        //        ApplicationName = applicationName
        //    });

        //    return service;
        //}
       

    }
}
