﻿namespace CloudinaryDotNet.Actions
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Parsed response after a call of Explicit method.
    /// </summary>
    [DataContract]
    public class ExplicitResult : RawUploadResult
    {
        /// <summary>
        /// Gets or sets the specific type of asset.
        /// </summary>
        /// <summary>
        /// The derived images generated as per the requested eager transformations of the method call.
        /// </summary>
        [DataMember(Name = "eager")]
        public Eager[] Eager { get; set; }

        /// <summary>
        /// Gets or sets a list of responsive breakpoint settings of the asset.
        /// </summary>
        public List<ResponsiveBreakpointList> ResponsiveBreakpoints { get; set; }

        /// <summary>
        /// Gets or sets a status that is returned when passing 'Async' argument set to 'true' to the server.
        /// </summary>
        [DataMember(Name = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets any requested information from executing one of the Cloudinary Add-ons on the media asset.
        /// </summary>
        [DataMember(Name = "info")]
        public Info Info { get; set; }

        /// <summary>
        /// Gets or sets details of the quality analysis.
        /// </summary>
        [DataMember(Name = "quality_analysis")]
        public QualityAnalysis QualityAnalysis { get; set; }

        /// <summary>
        /// Gets or sets the quality score.
        /// </summary>
        [DataMember(Name = "quality_score")]
        public double QualityScore { get; set; }

        /// <summary>
        /// Gets or sets color information: predominant colors and histogram of 32 leading colors.
        /// </summary>
        [DataMember(Name = "colors")]
        public string[][] Colors { get; set; }

        /// <summary>
        /// Gets or sets details of cinemagraph analysis for the resource.
        /// </summary>
        [DataMember(Name = "cinemagraph_analysis")]
        public CinemagraphAnalysis CinemagraphAnalysis { get; set; }

        /// <summary>
        /// Gets or sets IPTC, XMP, and detailed Exif metadata. Supported for images, video, and audio.
        /// </summary>
        [Obsolete("Property Metadata is deprecated, please use ImageMetadata instead")]
        public Dictionary<string, string> Metadata
        {
            get { return ImageMetadata; }
            set { ImageMetadata = value; }
        }

        /// <summary>
        /// Gets or sets IPTC, XMP, and detailed Exif metadata. Supported for images, video, and audio.
        /// </summary>
        [DataMember(Name = "image_metadata")]
        public Dictionary<string, string> ImageMetadata { get; set; }

        /// <summary>
        /// Gets or sets a perceptual hash (pHash) of the uploaded resource for image similarity detection.
        /// </summary>
        [DataMember(Name = "phash")]
        public string Phash { get; set; }

        /// <summary>
        /// Gets or sets a list of coordinates of detected faces.
        /// </summary>
        [DataMember(Name = "faces")]
        public int[][] Faces { get; set; }

        /// <summary>
        /// Gets or sets parameter "width" of the resource. Not relevant for raw files.
        /// </summary>
        [DataMember(Name = "width")]
        public int Width { get; set; }

        /// <summary>
        /// Gets or sets parameter "height" of the resource. Not relevant for raw files.
        /// </summary>
        [DataMember(Name = "height")]
        public int Height { get; set; }

        /// <summary>
        /// Gets or sets a slot token.
        /// </summary>
        [DataMember(Name = "slot_token")]
        public string SlotToken { get; set; }

        /// <summary>
        /// Gets or sets the number of pages in the asset: included if the asset has multiple pages (e.g., PDF or animated GIF).
        /// </summary>
        [DataMember(Name = "pages")]
        public int Pages { get; set; }

        /// <summary>
        /// Gets or sets the likelihood that the image is an illustration as opposed to a photograph.
        /// A value between 0 (photo) and 1.0 (illustration).
        /// </summary>
        [DataMember(Name = "illustration_score")]
        public float IllustrationScore { get; set; }

        /// <summary>
        /// Gets or sets the predominant colors in the image according to both a Google palette and a Cloudinary palette.
        /// </summary>
        [DataMember(Name = "predominant")]
        public Predominant Predominant { get; set; }

        /// <summary>
        /// Gets or sets the predominant colors in the image according to both a Google palette and a Cloudinary palette.
        /// </summary>
        [DataMember(Name = "profiling_data")]
        public ProfilingData[] ProfilingData { get; set; }

        /// <summary>
        /// Gets or sets the color ambiguity score that indicate how good\bad an image is for colorblind people.
        /// Will they be able to differentiate between different elements in the image.
        /// </summary>
        [DataMember(Name = "accessibility_analysis")]
        public AccessibilityAnalysis AccessibilityAnalysis { get; set; }

        /// <summary>
        /// Overrides corresponding method of <see cref="BaseResult"/> class.
        /// Populates additional token fields.
        /// </summary>
        /// <param name="source">JSON token received from the server.</param>
        internal override void SetValues(JToken source)
        {
            var responsiveBreakpoints = source["responsive_breakpoints"];
            if (responsiveBreakpoints != null)
            {
                ResponsiveBreakpoints = responsiveBreakpoints.ToObject<List<ResponsiveBreakpointList>>();
            }
        }
    }

    /// <summary>
    /// Details of the derived image generated as per the requested eager transformation applied.
    /// </summary>
    [DataContract]
    public class Eager
    {
        /// <summary>
        /// Gets or sets URL for accessing the asset.
        /// </summary>
        [Obsolete("Property Uri is deprecated, please use Url instead")]
        public Uri Uri
        {
            get { return Url; }
            set { Url = value; }
        }

        /// <summary>
        /// Gets or sets the URL for accessing the uploaded asset.
        /// </summary>
        [DataMember(Name = "url")]
        public Uri Url { get; set; }

        /// <summary>
        /// Gets or sets the HTTPS URL for securely accessing the asset.
        /// </summary>
        [Obsolete("Property SecureUri is deprecated, please use SecureUrl instead")]
        public Uri SecureUri
        {
            get { return SecureUrl; }
            set { SecureUrl = value; }
        }

        /// <summary>
        /// Gets or sets the HTTPS URL for securely accessing the asset.
        /// </summary>
        [DataMember(Name = "secure_url")]
        public Uri SecureUrl { get; set; }

        /// <summary>
        /// Gets or sets the transformation applied to the asset.
        /// </summary>
        [DataMember(Name = "transformation")]
        public string Transformation { get; set; }

        /// <summary>
        /// Gets or sets parameter "width" of the resource. Not relevant for raw files.
        /// </summary>
        [DataMember(Name = "width")]
        public int Width { get; set; }

        /// <summary>
        /// Gets or sets parameter "height" of the resource. Not relevant for raw files.
        /// </summary>
        [DataMember(Name = "height")]
        public int Height { get; set; }

        /// <summary>
        /// Gets or sets the size of the media asset in bytes.
        /// </summary>
        [DataMember(Name = "bytes")]
        public long Bytes { get; set; }

        /// <summary>
        /// Gets or sets asset format.
        /// </summary>
        [DataMember(Name = "format")]
        public string Format { get; set; }
    }

    /// <summary>
    /// Represents processing statistics data.
    /// </summary>
    [DataContract]
    public class ProfilingData
    {
        /// <summary>
        /// Gets or sets cpu usage metrics.
        /// </summary>
        [DataMember(Name = "cpu")]
        public long Cpu { get; set; }

        /// <summary>
        /// Gets or sets real metrics.
        /// </summary>
        [DataMember(Name = "real")]
        public long Real { get; set; }

        /// <summary>
        /// Gets or sets processing statistics data about actions on resource.
        /// </summary>
        [DataMember(Name = "action")]
        public ProfilingDataAction Action { get; set; }
    }

    /// <summary>
    /// Represents processing statistics data about actions on resource.
    /// </summary>
    [DataContract]
    public class ProfilingDataAction
    {
        /// <summary>
        /// Gets or sets action name applied to resource asset.
        /// </summary>
        [DataMember(Name = "action")]
        public string Action { get; set; }

        /// <summary>
        /// Gets or sets action parameter applied to resource asset.
        /// </summary>
        [DataMember(Name = "parameter")]
        public string Parameter { get; set; }

        /// <summary>
        /// Gets or sets size before applied action.
        /// </summary>
        [DataMember(Name = "presize")]
        public long[] Presize { get; set; }

        /// <summary>
        /// Gets or sets size after applied action.
        /// </summary>
        [DataMember(Name = "postsize")]
        public long[] Postsize { get; set; }
    }
}
