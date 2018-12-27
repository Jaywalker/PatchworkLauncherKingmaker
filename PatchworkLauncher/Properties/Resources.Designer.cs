﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PatchworkLauncher.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PatchworkLauncher.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to AppInfo v{0}.
        /// </summary>
        internal static string AppInfoVersionFormat {
            get {
                return ResourceManager.GetString("AppInfoVersionFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configuration Error.
        /// </summary>
        internal static string ConfigurationError {
            get {
                return ResourceManager.GetString("ConfigurationError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configuration Warning.
        /// </summary>
        internal static string ConfigurationWarning {
            get {
                return ResourceManager.GetString("ConfigurationWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No client path set. Are you sure you want to launch the game directly, instead of through Galaxy or Steam? Launching directly will disable achievements, cloud saves, statistics tracking (e.g., time played), and DLC..
        /// </summary>
        internal static string DirectLaunchWarning {
            get {
                return ResourceManager.GetString("DirectLaunchWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap IconMed {
            get {
                object obj = ResourceManager.GetObject("IconMed", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap IconSmall {
            get {
                object obj = ResourceManager.GetObject("IconSmall", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No active mods configured..
        /// </summary>
        internal static string NoActiveMods {
            get {
                return ResourceManager.GetString("NoActiveMods", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} (#playwithfire).
        /// </summary>
        internal static string PatchworkVersionFormat {
            get {
                return ResourceManager.GetString("PatchworkVersionFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap patreon {
            get {
                object obj = ResourceManager.GetObject("patreon", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select folder containing GalaxyClient.exe or Steam.exe..
        /// </summary>
        internal static string SelectClientFolder {
            get {
                return ResourceManager.GetString("SelectClientFolder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select folder containing {0}..
        /// </summary>
        internal static string SelectExecutableFolderFormat {
            get {
                return ResourceManager.GetString("SelectExecutableFolderFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Patchwork Launcher is locked while the game is running.{0}{1}{2} (PID: {3}).
        /// </summary>
        internal static string UnlockRunningFormat {
            get {
                return ResourceManager.GetString("UnlockRunningFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Patchwork Launcher is locked while the game is running..
        /// </summary>
        internal static string UnlockRunningText {
            get {
                return ResourceManager.GetString("UnlockRunningText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Patchwork Launcher is locked during the test run process..
        /// </summary>
        internal static string UnlockTestRunText {
            get {
                return ResourceManager.GetString("UnlockTestRunText", resourceCulture);
            }
        }
    }
}
