﻿using System;
using System.Collections.Generic;

namespace CloudinaryDotNet.Actions
{
    /// <summary>
    /// Parameters for transformation update.
    /// </summary>
    public class UpdateTransformParams : BaseParams
    {
        /// <summary>
        /// Instantiates the <see cref="UpdateTransformParams"/> object.
        /// </summary>
        public UpdateTransformParams()
        {
            Transformation = String.Empty;
        }

        /// <summary>
        /// Transformation represented as string.
        /// </summary>
        public string Transformation { get; set; }

        /// <summary>
        /// [optional] The transformation's extention.
        /// </summary>
        public string Format { get; set; }

        /// <summary>
        /// Gets or sets the transformation for unsafe updating.
        /// </summary>
        /// <value>
        /// New transformation.
        /// </value>
        public Transformation UnsafeTransform { get; set; }

        /// <summary>
        /// Whether this transformation is allowed when Strict Transformations are enabled.
        /// </summary>
        public bool Strict { get; set; }

        /// <summary>
        /// Validate object model.
        /// </summary>
        public override void Check()
        {
            if (String.IsNullOrEmpty(Transformation))
                throw new ArgumentException("Transformation must be set!");
        }

        /// <summary>
        /// Maps object model to dictionary of parameters in cloudinary notation.
        /// </summary>
        /// <returns>Sorted dictionary of parameters.</returns>
        public override SortedDictionary<string, object> ToParamsDictionary()
        {
            SortedDictionary<string, object> dict = base.ToParamsDictionary();

            dict.Add("transformation", Transformation);

            AddParam(dict, "allowed_for_strict", Strict ? "true" : "false");

            if (UnsafeTransform != null)
            {
                string unsafeTransformationStr = UnsafeTransform.Generate();

                if (Format != null)
                {
                    unsafeTransformationStr = unsafeTransformationStr + "/" + Format;
                }

                AddParam(dict, "unsafe_update", unsafeTransformationStr);
            }
            return dict;
        }
    }
}
