﻿#pragma checksum "..\..\..\viewModel\appointment.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6904E202A21279D6F0A48069939730AE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace MIMS {
    
    
    /// <summary>
    /// appointment
    /// </summary>
    public partial class appointment : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\viewModel\appointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label DocLabel;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\viewModel\appointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox DocList;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\viewModel\appointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label FieldLabel;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\viewModel\appointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FieldList;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\viewModel\appointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_Clinic;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\viewModel\appointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox list_Clinic;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\viewModel\appointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_day;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\viewModel\appointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox list_day;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\viewModel\appointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_hour;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\viewModel\appointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox list_hour;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\viewModel\appointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_schedule;
        
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
            System.Uri resourceLocater = new System.Uri("/MIMS;component/viewmodel/appointment.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\viewModel\appointment.xaml"
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
            this.DocLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.DocList = ((System.Windows.Controls.ComboBox)(target));
            
            #line 10 "..\..\..\viewModel\appointment.xaml"
            this.DocList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DocList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.FieldLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.FieldList = ((System.Windows.Controls.ComboBox)(target));
            
            #line 12 "..\..\..\viewModel\appointment.xaml"
            this.FieldList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FieldList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lbl_Clinic = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.list_Clinic = ((System.Windows.Controls.ComboBox)(target));
            
            #line 14 "..\..\..\viewModel\appointment.xaml"
            this.list_Clinic.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.list_Clinic_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lbl_day = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.list_day = ((System.Windows.Controls.ComboBox)(target));
            
            #line 16 "..\..\..\viewModel\appointment.xaml"
            this.list_day.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.list_day_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.lbl_hour = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.list_hour = ((System.Windows.Controls.ComboBox)(target));
            
            #line 18 "..\..\..\viewModel\appointment.xaml"
            this.list_hour.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.list_hour_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btn_schedule = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\viewModel\appointment.xaml"
            this.btn_schedule.Click += new System.Windows.RoutedEventHandler(this.btn_schedule_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

