using System;

namespace GeekPlatform.Services
{
    public class FacebookService
    {
        private readonly String _accessToken;

        public FacebookService(string accessToken)
        {
            _accessToken = accessToken;
        }
    }
}
