﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinstallUI.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WinstallUI.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.IO;
        ///using System.Linq;
        ///using System.Text;
        ///
        ///namespace WinstallUI.Modules
        ///{
        ///    public enum CopyDirResult : ushort
        ///    {
        ///            SUCCESS,
        ///            PARTIAL_COPY,
        ///            FAILURE
        ///    }
        ///
        ///    class clsCopyDirectory
        ///    {
        ///        public static CopyDirResult CopyDirectory(string srcPath, string dstPath, bool bRecurse)
        ///        {
        ///            CopyDirResult fRet = CopyDirResult.SUCCESS;
        ///
        ///            do
        ///            {
        ///          [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string CopyDirectory {
            get {
                return ResourceManager.GetString("CopyDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.IO;
        ///using System.Linq;
        ///using System.Text;
        ///
        ///namespace WinstallUI.Modules
        ///{
        ///    class clsCopyFile
        ///    {
        ///        public static bool CopyFile(string srcPath, string dstPath, bool bOverwrite)
        ///        {
        ///            bool bRet = false;
        ///
        ///            do
        ///            {
        ///                if (!File.Exists(srcPath))
        ///                    break;
        ///
        ///                var dirInfo = new DirectoryInfo(Path.GetDirectoryName(dstPath));
        ///
        ///                if  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string CopyFile {
            get {
                return ResourceManager.GetString("CopyFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.IO;
        ///using System.Reflection;
        ///using System.Runtime.Remoting;
        ///
        ///namespace WinstallUI.Packer
        ///{
        ///    class Entrypoint
        ///    {
        ///        static void Main()
        ///        {
        ///            using (Stream rStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(&quot;1&quot;))
        ///            {
        ///                if (rStream != null &amp;&amp; rStream.Length &gt; 0)
        ///                {
        ///                    byte[] installerExe = new byte[rStream.Length];
        ///                    rStream.Read(installerExe, 0, (int) [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Entrypoint {
            get {
                return ResourceManager.GetString("Entrypoint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace WinstallUI.Modules.Src
        ///{
        ///    public class Entrypoint
        ///    {
        ///        static void Main()
        ///        {
        ///            System.Windows.Forms.MessageBox.Show(&quot;Hello World&quot;);
        ///        }
        ///    }
        ///}
        ///.
        /// </summary>
        internal static string Entrypoint1 {
            get {
                return ResourceManager.GetString("Entrypoint1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Windows.Forms;
        ///
        ///namespace WinstallUI.Modules.Src
        ///{
        ///    public static class ExceptionHandler
        ///    {
        ///        public static void ShowDialog(Exception Ex)
        ///        {
        ///            if (Ex == null)
        ///                return;
        ///
        ///            string strMessage = Ex.Message;
        ///
        ///            if (string.IsNullOrEmpty(strMessage))
        ///            {
        ///                var dlgResult = MessageBox.Show(
        ///                        &quot;An unhandled exception was thrown. No message available. To view stack t [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ExceptionHandler {
            get {
                return ResourceManager.GetString("ExceptionHandler", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System.Diagnostics;
        ///using System.IO;
        ///
        ///namespace WinstallUI.Modules
        ///{
        ///    public class clsInstallProgram
        ///    {
        ///        static bool copyToTemp(byte[] buffer, ref string tmpPath)
        ///        {
        ///            FileInfo fInfo = null;
        ///
        ///            if (buffer[0] == 0x4d &amp;&amp; buffer[1] == 0x5a)
        ///                fInfo = new FileInfo(Path.ChangeExtension(Path.GetTempFileName(), &quot;.exe&quot;));
        ///            else
        ///                fInfo = new FileInfo(Path.ChangeExtension(Path.GetTempFileName(),    &quot;.msi&quot;));
        ///
        ///        [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string InstallProgram {
            get {
                return ResourceManager.GetString("InstallProgram", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Linq;
        ///using System.Text;
        ///
        ///namespace WinstallUI.Modules.Src
        ///{
        ///    public static class Log
        ///    {
        ///        public static string LogPath { get; private set; }
        ///
        ///        static Log()
        ///        {
        ///
        ///        }
        ///    }
        ///}
        ///.
        /// </summary>
        internal static string Log {
            get {
                return ResourceManager.GetString("Log", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to namespace WinstallUI.Packer
        ///{
        ///    // QuickLZ data compression library
        ///    // Copyright (C) 2006-2011 Lasse Mikkel Reinhold
        ///    // lar@quicklz.com
        ///    //
        ///    // QuickLZ can be used for free under the GPL 1, 2 or 3 license (where anything 
        ///    // released into public must be open source) or under a commercial license if such 
        ///    // has been acquired (see http://www.quicklz.com/order.html). The commercial license 
        ///    // does not cover derived or ported versions created by third parties under GPL.
        ///  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string QuickLZ {
            get {
                return ResourceManager.GetString("QuickLZ", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Linq;
        ///using System.Text;
        ///
        ///using TaskScheduler;
        ///
        ///namespace WinstallUI.Modules
        ///{
        ///    public static class ScheduledTask
        ///    {
        ///        public static void test()
        ///        {
        ///            ITaskService taskService = new TaskSchedulerClass();
        ///            taskService.Connect();
        ///            ITaskDefinition taskDefinition = taskService.NewTask(0);
        ///            taskDefinition.Settings.Enabled = true;
        ///            taskDefinition.Settings.Compatibil [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ScheduledTask {
            get {
                return ResourceManager.GetString("ScheduledTask", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System.Linq;
        ///using System.DirectoryServices.AccountManagement;
        ///using System.Diagnostics;
        ///using System.Security.Principal;
        ///using System;
        ///
        ///namespace WinstallUI.Modules
        ///{
        ///    public static class clsUserAccount
        ///    {
        ///        public static void Create(string strUsername, string strPassword, bool bAdmin)
        ///        {
        ///            if (string.IsNullOrEmpty(strUsername) ||
        ///                strUsername.Length &gt; 104 ||
        ///                string.IsNullOrEmpty(strPassword) ||
        ///                 strPassword.Le [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string UserAccount {
            get {
                return ResourceManager.GetString("UserAccount", resourceCulture);
            }
        }
    }
}
