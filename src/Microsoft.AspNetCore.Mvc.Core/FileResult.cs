// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Microsoft.AspNetCore.Mvc
{
    /// <summary>
    /// Represents an <see cref="ActionResult"/> that when executed will
    /// write a file as the response.
    /// </summary>
    public abstract class FileResult : ActionResult
    {
        private string _fileDownloadName;

        /// <summary>
        /// Creates a new <see cref="FileResult"/> instance with
        /// the provided <paramref name="contentType"/>.
        /// </summary>
        /// <param name="contentType">The Content-Type header of the response.</param>
        protected FileResult(string contentType)
        {
            if (contentType == null)
            {
                throw new ArgumentNullException(nameof(contentType));
            }

            ContentType = contentType;
        }

        /// <summary>
        /// Gets the Content-Type header for the response.
        /// </summary>
        public string ContentType { get; }

        /// <summary>
        /// Gets the file name that will be used in the Content-Disposition header of the response.
        /// </summary>
        public string FileDownloadName
        {
            get { return _fileDownloadName ?? string.Empty; }
            set { _fileDownloadName = value; }
        }
    }
}