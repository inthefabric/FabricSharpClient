﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fabric.Clients.Cs.Spec.Data {
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
    internal class FabricResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal FabricResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Fabric.Clients.Cs.Spec.Data.FabricResource", typeof(FabricResource).Assembly);
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
        ///   Looks up a localized string similar to {
        ///      &quot;BuildVersion&quot;: &quot;0.3.0.4b054df&quot;,
        ///      &quot;BuildYear&quot;: 2014,
        ///      &quot;BuildMonth&quot;: 3,
        ///      &quot;BuildDay&quot;: 24,
        ///      &quot;Objects&quot;: [
        ///        {
        ///          &quot;Name&quot;: &quot;CreateFabClass&quot;,
        ///          &quot;Extends&quot;: &quot;CreateFabArtifact&quot;,
        ///          &quot;Description&quot;: &quot;Contains the data needed to create a new [[Class|Object|FabClass]].&quot;,
        ///          &quot;Properties&quot;: [
        ///            {
        ///              &quot;Name&quot;: &quot;Name&quot;,
        ///              &quot;Type&quot;: &quot;string&quot;,
        ///              &quot;Description&quot;: &quot;The name of the new [[Class|Object|FabClass]]. It mu [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SpecJson {
            get {
                return ResourceManager.GetString("SpecJson", resourceCulture);
            }
        }
    }
}
