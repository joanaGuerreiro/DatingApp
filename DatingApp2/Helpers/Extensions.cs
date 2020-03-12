﻿using Microsoft.AspNetCore.Http;

namespace DatingApp2.Helpers
{
    public  static class Extensions
    {
        public static void AddApplicationError(this HttpResponse response, string message)
        { 
                response.Headers.Add("Application-Error",message);
                response.Headers.Add("Acess-Conntrol-Expose-Headers","Application-Error");
                response.Headers.Add("Acess-Conntrol-Allow-Origin", "*");

        }
    }
}
