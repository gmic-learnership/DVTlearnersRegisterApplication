﻿#pragma checksum "..\..\DailyRegisterPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FC27A1CF69ABA642E2CC29281CA82908"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DVTLeanersRegisterSystem;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace DVTLeanersRegisterSystem {
    
    
    /// <summary>
    /// DailyRegisterPage
    /// </summary>
    public partial class DailyRegisterPage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\DailyRegisterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dtpDate;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\DailyRegisterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbbxMentornames;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\DailyRegisterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTrainingOn;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\DailyRegisterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancel;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\DailyRegisterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSave;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\DailyRegisterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtgNamesAndHours;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\DailyRegisterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridComboBoxColumn Name;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\DailyRegisterPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn Hours;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/DVTLeanersRegisterSystem;component/dailyregisterpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DailyRegisterPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.dtpDate = ((System.Windows.Controls.DatePicker)(target));
            
            #line 31 "..\..\DailyRegisterPage.xaml"
            this.dtpDate.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.dtpDate_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cmbbxMentornames = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.txtTrainingOn = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.btnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\DailyRegisterPage.xaml"
            this.btnCancel.Click += new System.Windows.RoutedEventHandler(this.btnCancel_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\DailyRegisterPage.xaml"
            this.btnSave.Click += new System.Windows.RoutedEventHandler(this.btnSave_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.dtgNamesAndHours = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.Name = ((System.Windows.Controls.DataGridComboBoxColumn)(target));
            return;
            case 8:
            this.Hours = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

