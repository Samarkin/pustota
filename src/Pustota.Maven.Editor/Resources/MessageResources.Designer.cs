﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pustota.Maven.Editor.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class MessageResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal MessageResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Pustota.Maven.Editor.Resources.MessageResources", typeof(MessageResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There are unsaved changes in the repository. Do you want to quit?.
        /// </summary>
        internal static string DoYouWantToQuit {
            get {
                return ResourceManager.GetString("DoYouWantToQuit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do you want to save the changes?.
        /// </summary>
        internal static string DoYouWantToSaveChanges {
            get {
                return ResourceManager.GetString("DoYouWantToSaveChanges", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fix all.
        /// </summary>
        internal static string FixAll {
            get {
                return ResourceManager.GetString("FixAll", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fix dependency to match source.
        /// </summary>
        internal static string FixDependencyToMatchSource {
            get {
                return ResourceManager.GetString("FixDependencyToMatchSource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fix dependency to specific version.
        /// </summary>
        internal static string FixDependencyToSpecificVersion {
            get {
                return ResourceManager.GetString("FixDependencyToSpecificVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fix parent to match source.
        /// </summary>
        internal static string FixParentToMatchSource {
            get {
                return ResourceManager.GetString("FixParentToMatchSource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There are unsaved changes in the repository. Proceed reloading?.
        /// </summary>
        internal static string ProceedReloading {
            get {
                return ResourceManager.GetString("ProceedReloading", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There are some fixes to be applied permanently. Are you sure want to continue?.
        /// </summary>
        internal static string ThereAreSomeFixesToBeAppliedPermanently {
            get {
                return ResourceManager.GetString("ThereAreSomeFixesToBeAppliedPermanently", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to It will be applied permanently. Are you sure want to continue?.
        /// </summary>
        internal static string WillBeAppliedPermanently {
            get {
                return ResourceManager.GetString("WillBeAppliedPermanently", resourceCulture);
            }
        }
    }
}
