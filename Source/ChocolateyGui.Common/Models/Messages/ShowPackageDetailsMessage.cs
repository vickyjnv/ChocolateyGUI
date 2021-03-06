﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Chocolatey" file="ShowPackageDetailsMessage.cs">
//   Copyright 2014 - Present Rob Reynolds, the maintainers of Chocolatey, and RealDimensions Software, LLC
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using ChocolateyGui.Common.ViewModels.Items;

namespace ChocolateyGui.Common.Models.Messages
{
    public class ShowPackageDetailsMessage
    {
        public ShowPackageDetailsMessage(IPackageViewModel package)
        {
            Package = package;
        }

        public IPackageViewModel Package { get;  }
    }
}