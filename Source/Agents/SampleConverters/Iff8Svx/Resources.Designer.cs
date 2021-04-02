﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Polycode.NostalgicPlayer.Agent.SampleConverter.Iff8Svx {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Polycode.NostalgicPlayer.Agent.SampleConverter.Iff8Svx.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to NostalgicPlayer sample saver.
        /// </summary>
        internal static string IDS_IFF8SVX_ANNO {
            get {
                return ResourceManager.GetString("IDS_IFF8SVX_ANNO", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Created by Thomas Neumann.
        ///
        ///This format is the primary sample format on the Amiga. It contains 8-bit samples and can hold different compression formats.
        ///
        ///{0}.
        /// </summary>
        internal static string IDS_IFF8SVX_DESCRIPTION {
            get {
                return ResourceManager.GetString("IDS_IFF8SVX_DESCRIPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This one supports compressed samples using the Fibonacci delta encoding algorithm..
        /// </summary>
        internal static string IDS_IFF8SVX_DESCRIPTION_FIBONACCI {
            get {
                return ResourceManager.GetString("IDS_IFF8SVX_DESCRIPTION_FIBONACCI", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This one supports plain PCM files, which means no compression at all..
        /// </summary>
        internal static string IDS_IFF8SVX_DESCRIPTION_PCM {
            get {
                return ResourceManager.GetString("IDS_IFF8SVX_DESCRIPTION_PCM", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There isn&apos;t any sound data chunk (BODY chunk) in the file.
        /// </summary>
        internal static string IDS_IFF8SVX_ERR_NOBODY {
            get {
                return ResourceManager.GetString("IDS_IFF8SVX_ERR_NOBODY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There isn&apos;t any sound information (VHDR chunk) in the file.
        /// </summary>
        internal static string IDS_IFF8SVX_ERR_NOVHDR {
            get {
                return ResourceManager.GetString("IDS_IFF8SVX_ERR_NOVHDR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Octaves:.
        /// </summary>
        internal static string IDS_IFF8SVX_INFODESCLINE0 {
            get {
                return ResourceManager.GetString("IDS_IFF8SVX_INFODESCLINE0", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Copyright:.
        /// </summary>
        internal static string IDS_IFF8SVX_INFODESCLINE1 {
            get {
                return ResourceManager.GetString("IDS_IFF8SVX_INFODESCLINE1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Annotation:.
        /// </summary>
        internal static string IDS_IFF8SVX_INFODESCLINE2 {
            get {
                return ResourceManager.GetString("IDS_IFF8SVX_INFODESCLINE2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to n/a.
        /// </summary>
        internal static string IDS_IFF8SVX_NA {
            get {
                return ResourceManager.GetString("IDS_IFF8SVX_NA", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IFF-8SVX.
        /// </summary>
        internal static string IDS_IFF8SVX_NAME {
            get {
                return ResourceManager.GetString("IDS_IFF8SVX_NAME", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IFF-8SVX (Fibonacci).
        /// </summary>
        internal static string IDS_IFF8SVX_NAME_FIBONACCI {
            get {
                return ResourceManager.GetString("IDS_IFF8SVX_NAME_FIBONACCI", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IFF-8SVX (PCM).
        /// </summary>
        internal static string IDS_IFF8SVX_NAME_PCM {
            get {
                return ResourceManager.GetString("IDS_IFF8SVX_NAME_PCM", resourceCulture);
            }
        }
    }
}
