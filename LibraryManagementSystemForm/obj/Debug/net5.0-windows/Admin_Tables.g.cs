﻿#pragma checksum "..\..\..\Admin_Tables.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D5BC11F16C6E6C63EDDE851CEA7CC11E7EAE58D7"
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
    /// Admin_Tables
    /// </summary>
    public partial class Admin_Tables : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\..\Admin_Tables.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox tableContentTypeCbx;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Admin_Tables.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox searchCategoryCbx;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Admin_Tables.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchTbx;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Admin_Tables.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button searchBtn;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Admin_Tables.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid contentTableDgr;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Admin_Tables.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem editItemMenu;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Admin_Tables.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem deleteItemMenu;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Admin_Tables.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button prevBtn;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Admin_Tables.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock pageNoTbl;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\Admin_Tables.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button nextBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/LibraryManagementSystemForm;component/admin_tables.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Admin_Tables.xaml"
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
            this.tableContentTypeCbx = ((System.Windows.Controls.ComboBox)(target));
            
            #line 37 "..\..\..\Admin_Tables.xaml"
            this.tableContentTypeCbx.DropDownClosed += new System.EventHandler(this.tableContentTypeCbx_DropDownClosed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.searchCategoryCbx = ((System.Windows.Controls.ComboBox)(target));
            
            #line 42 "..\..\..\Admin_Tables.xaml"
            this.searchCategoryCbx.DropDownClosed += new System.EventHandler(this.searchCategoryCbx_DropDownClosed);
            
            #line default
            #line hidden
            return;
            case 3:
            this.searchTbx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.searchBtn = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\Admin_Tables.xaml"
            this.searchBtn.Click += new System.Windows.RoutedEventHandler(this.searchBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.contentTableDgr = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.editItemMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 49 "..\..\..\Admin_Tables.xaml"
            this.editItemMenu.Click += new System.Windows.RoutedEventHandler(this.editItemMenu_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.deleteItemMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 50 "..\..\..\Admin_Tables.xaml"
            this.deleteItemMenu.Click += new System.Windows.RoutedEventHandler(this.deleteItemMenu_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.prevBtn = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\Admin_Tables.xaml"
            this.prevBtn.Click += new System.Windows.RoutedEventHandler(this.prevBtn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.pageNoTbl = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.nextBtn = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\Admin_Tables.xaml"
            this.nextBtn.Click += new System.Windows.RoutedEventHandler(this.nextBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

