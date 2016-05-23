using System;
using System.Collections.Generic;

namespace Cake.Common.NuGet
{
    /// <summary>
    /// Represents a NuSpec file.
    /// </summary>
    public sealed class NuSpec
    {
        /// <summary>
        /// Gets or sets the unique identifier for the package.
        /// This is the package name that is shown when packages are listed using
        /// the Package Manager Console. These are also used when installing a
        /// package using the <c>Install-Package</c> command within the Package Manager Console.
        /// Package IDs may not contain any spaces or characters that are invalid in an URL.
        /// In general, they follow the same rules as .NET namespaces do.
        /// So <c>Foo.Bar</c> is a valid ID, <c>Foo!</c> and <c>Foo Bar</c> are not.
        /// </summary>
        /// <value>The unique identifier for the package.</value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the version of the package, in a format like <c>1.2.3</c>.
        /// </summary>
        /// <value>The version of the package.</value>
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets the human-friendly title of the package displayed
        /// in the Manage NuGet Packages dialog. If none is specified, the ID is used instead.
        /// </summary>
        /// <value>The title of the package displayed.</value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the list of authors of the package code.
        /// </summary>
        /// <value>The authors of the package code.</value>
        public ICollection<string> Authors { get; set; }

        /// <summary>
        /// Gets or sets the list of the package owners.
        /// This is often the same list as in authors. 
        /// This is ignored when uploading the package to the NuGet.org Gallery.
        /// </summary>
        /// <value>The package owners.</value>
        public ICollection<string> Owners { get; set; }

        /// <summary>
        /// Gets or sets a long description of the package.
        /// This shows up in the right pane of the <c>Add Package Dialog</c> as well as in the
        /// Package Manager Console when listing packages using the <c>Get-Package</c> command.
        /// </summary>
        /// <value>The long description of the package.</value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a short description of the package.
        /// If specified, this shows up in the middle pane of the <c>Add Package Dialog</c>.
        /// If not specified, a truncated version of the description is used instead.
        /// </summary>
        /// <value>The short description of the package.</value>
        public string Summary { get; set; }

        /// <summary>
        /// Gets or sets a description of the changes made in each release of the package.
        /// This field only shows up when the updates tab is selected and the package
        /// is an update to a previously installed package.
        /// It is displayed where the description would normally be displayed.
        /// </summary>
        /// <value>The changes made in each release of the package.</value>
        public string ReleaseNotes { get; set; }

        /// <summary>
        /// Gets or sets a URL for the home page of the package.
        /// </summary>
        /// <value>The URL for the home page of the package.</value>
        public Uri ProjectUrl { get; set; }

        /// <summary>
        /// Gets or sets a URL for the image to use as the icon for the package.
        /// This should be a 64x64-pixel .png file that has a transparent background.
        /// </summary>
        /// <value>The URL for the image to use as the icon for the package.</value>
        public Uri IconUrl { get; set; }

        /// <summary>
        /// Gets or sets a URL to the license that the package is under.
        /// </summary>
        /// <value>The URL to the license that the package is under.</value>
        public Uri LicenseUrl { get; set; }

        /// <summary>
        /// Gets or sets the copyright details for the package.
        /// </summary>
        /// <value>The copyright details for the package.</value>
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the client needs to ensure
        /// that the package license (described by licenseUrl) is accepted before the package is installed.
        /// </summary>
        /// <value>
        /// <c>true</c> if license acceptance is required; otherwise, <c>false</c>.
        /// </value>
        public bool RequireLicenseAcceptance { get; set; }

        /// <summary>
        /// Gets or sets the list of dependencies for the package.
        /// </summary>
        /// <value>The dependencies for the package</value>
        public ICollection<NuSpecDependency> Dependencies { get; set; }

        /// <summary>
        /// Gets or sets a list of tags and keywords that describe the package.
        /// </summary>
        /// <value>The tags and keywords that describe the package.</value>
        public ICollection<string> Tags { get; set; }

        /// <summary>
        /// Gets or sets a value that indicates whether the package will be marked
        /// as a development-only dependency in the <c>packages.config</c>.
        /// This will cause the package to be excluded from the dependency list
        /// when the referencing project itself is later packaged.
        /// </summary>
        /// <value><c>true</c> if the package is a development dependency; otherwise, <c>false</c>.</value>
        public bool DevelopmentDependency { get; set; }

        /// <summary>
        /// Gets or sets a list of files included in the package.
        /// </summary>
        /// <value>The files included in the package.</value>
        public ICollection<NuSpecContent> Files { get; set; }
    }
}