﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GlobalcachingApplication.Core.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection DisabledPlugins {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["DisabledPlugins"]));
            }
            set {
                this["DisabledPlugins"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UpgradeNeeded {
            get {
                return ((bool)(this["UpgradeNeeded"]));
            }
            set {
                this["UpgradeNeeded"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("51.5")]
        public double CenterLat {
            get {
                return ((double)(this["CenterLat"]));
            }
            set {
                this["CenterLat"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5.5")]
        public double CenterLon {
            get {
                return ((double)(this["CenterLon"]));
            }
            set {
                this["CenterLon"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("51.5")]
        public double HomeLat {
            get {
                return ((double)(this["HomeLat"]));
            }
            set {
                this["HomeLat"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5.5")]
        public double HomeLon {
            get {
                return ((double)(this["HomeLon"]));
            }
            set {
                this["HomeLon"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string GCComAccountName {
            get {
                return ((string)(this["GCComAccountName"]));
            }
            set {
                this["GCComAccountName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string GCComAccountToken {
            get {
                return ((string)(this["GCComAccountToken"]));
            }
            set {
                this["GCComAccountToken"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string GCComAccountTokenStaging {
            get {
                return ((string)(this["GCComAccountTokenStaging"]));
            }
            set {
                this["GCComAccountTokenStaging"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string GCComAccountMemberType {
            get {
                return ((string)(this["GCComAccountMemberType"]));
            }
            set {
                this["GCComAccountMemberType"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int GCComAccountMemberTypeId {
            get {
                return ((int)(this["GCComAccountMemberTypeId"]));
            }
            set {
                this["GCComAccountMemberTypeId"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int CultureID {
            get {
                return ((int)(this["CultureID"]));
            }
            set {
                this["CultureID"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("GlobalcachingApplication.Plugins.GAPPDataStorage.InternalStorage")]
        public string InternalStorageClass {
            get {
                return ((string)(this["InternalStorageClass"]));
            }
            set {
                this["InternalStorageClass"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool LoadLogsInBackground {
            get {
                return ((bool)(this["LoadLogsInBackground"]));
            }
            set {
                this["LoadLogsInBackground"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AutoSaveOnClose {
            get {
                return ((bool)(this["AutoSaveOnClose"]));
            }
            set {
                this["AutoSaveOnClose"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string PluginDataPath {
            get {
                return ((string)(this["PluginDataPath"]));
            }
            set {
                this["PluginDataPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string CSScriptsPath {
            get {
                return ((string)(this["CSScriptsPath"]));
            }
            set {
                this["CSScriptsPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection AvailablePluginDataPaths {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["AvailablePluginDataPaths"]));
            }
            set {
                this["AvailablePluginDataPaths"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool EnablePluginDataPathAtStartup {
            get {
                return ((bool)(this["EnablePluginDataPathAtStartup"]));
            }
            set {
                this["EnablePluginDataPathAtStartup"] = value;
            }
        }
    }
}
