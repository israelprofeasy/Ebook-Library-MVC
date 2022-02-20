using System;

namespace EBookLibrary.Models.Settings
{
    public class JWTData
    {
        public const string Data = "JWTData";
        public TimeSpan TokenLifeTime { get; set; }

        public string SecretKey { get; set; }

        public string Issuer { get; set; }

        public string Audience { get; set; }
    }
}
