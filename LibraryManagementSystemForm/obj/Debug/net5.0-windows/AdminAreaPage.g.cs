﻿#pragma checksum "..\..\..\AdminAreaPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "369E803005EC40A04A1BA7A5B1D4F0157A39246F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LibraryManagementSystemForm;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace LibraryManagementSystemForm {
    
    
    /// <summary>
    /// AdminAreaPage
    /// </summary>
    public partial class AdminAreaPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\..\AdminAreaPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button showBooksBtn;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\AdminAreaPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button showusersBtn;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\AdminAreaPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button showIssuesBtn;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\AdminAreaPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button taskBtn;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\AdminAreaPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame adminFrm;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/LibraryManagementSystemForm;component/adminareapage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AdminAreaPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.showBooksBtn = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\AdminAreaPage.xaml"
            this.showBooksBtn.Click += new System.Windows.RoutedEventHandler(this.showBooksBtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.showusersBtn = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\AdminAreaPage.xaml"
            this.showusersBtn.Click += new System.Windows.RoutedEventHandler(this.showusersBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.showIssuesBtn = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\AdminAreaPage.xaml"
            this.showIssuesBtn.Click += new System.Windows.RoutedEventHandler(this.showIssuesBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.taskBtn = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\AdminAreaPage.xaml"
            this.taskBtn.Click += new System.Windows.RoutedEventHandler(this.taskBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.adminFrm = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

