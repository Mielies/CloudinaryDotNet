﻿namespace CloudinaryDotNet
{
    /// <summary>
    /// Struct with Cloudinary configuration parameters.
    /// </summary>
    public static class CloudinaryConfiguration
    {
        /// <summary>
        /// The name of your cloud.
        /// </summary>
        public static string CloudName = string.Empty;

        /// <summary>
        /// API key.
        /// </summary>
        public static string ApiKey = string.Empty;

        /// <summary>
        /// API secret.
        /// </summary>
        public static string ApiSecret = string.Empty;

        /// <summary>
        /// Authentication token for the token-based authentication.
        /// </summary>
        public static AuthToken AuthToken = null;

        /// <summary>
        /// Defines whether to generate 32 characters length signature for URIs.
        /// </summary>
        public static bool LongUrlSignature = false;

        /// <summary>
        /// Address of the proxy server that will be used for API calls.
        /// </summary>
        public static string ApiProxy = string.Empty;
    }
}
