﻿#pragma checksum "..\..\..\UI\PAWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5E2481110B92860EF5410461A7B02A5B1BC67BD1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SF24_2016_POP2019.UI;
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


namespace SF24_2016_POP2019.UI {
    
    
    /// <summary>
    /// PAWindow
    /// </summary>
    public partial class PAWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\UI\PAWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgProfAsist;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\UI\PAWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogout;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\UI\PAWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDodajTermin;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\UI\PAWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnKorisnikInfo;
        
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
            System.Uri resourceLocater = new System.Uri("/SF24-2016-POP2019;component/ui/pawindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UI\PAWindow.xaml"
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
            this.dgProfAsist = ((System.Windows.Controls.DataGrid)(target));
            
            #line 16 "..\..\..\UI\PAWindow.xaml"
            this.dgProfAsist.AutoGeneratedColumns += new System.EventHandler(this.DgProfAsist_AutoGeneratedColumns);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnLogout = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\UI\PAWindow.xaml"
            this.btnLogout.Click += new System.Windows.RoutedEventHandler(this.BtnLogout_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnDodajTermin = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\UI\PAWindow.xaml"
            this.btnDodajTermin.Click += new System.Windows.RoutedEventHandler(this.BtnDodajTermin_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnKorisnikInfo = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\UI\PAWindow.xaml"
            this.btnKorisnikInfo.Click += new System.Windows.RoutedEventHandler(this.BtnKorisnikInfo_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

