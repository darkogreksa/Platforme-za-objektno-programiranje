﻿#pragma checksum "..\..\..\UI\AdminMenu.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "581CC361BB38888F42AC45CCF9341B7F3CD88874"
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
    /// AdminMenu
    /// </summary>
    public partial class AdminMenu : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\UI\AdminMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnUstanove;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\UI\AdminMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnUcionice;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\UI\AdminMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnKorisnici;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\UI\AdminMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnTermini;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\UI\AdminMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ZatvoriProzor;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\UI\AdminMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button IzlogujSe;
        
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
            System.Uri resourceLocater = new System.Uri("/SF24-2016-POP2019;component/ui/adminmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UI\AdminMenu.xaml"
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
            this.BtnUstanove = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\UI\AdminMenu.xaml"
            this.BtnUstanove.Click += new System.Windows.RoutedEventHandler(this.BtnUstanove_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtnUcionice = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\UI\AdminMenu.xaml"
            this.BtnUcionice.Click += new System.Windows.RoutedEventHandler(this.BtnUcionice_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnKorisnici = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\UI\AdminMenu.xaml"
            this.BtnKorisnici.Click += new System.Windows.RoutedEventHandler(this.BtnKorisnici_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnTermini = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\UI\AdminMenu.xaml"
            this.BtnTermini.Click += new System.Windows.RoutedEventHandler(this.BtnTermini_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ZatvoriProzor = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\UI\AdminMenu.xaml"
            this.ZatvoriProzor.Click += new System.Windows.RoutedEventHandler(this.ZatvoriProzor_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.IzlogujSe = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\UI\AdminMenu.xaml"
            this.IzlogujSe.Click += new System.Windows.RoutedEventHandler(this.IzlogujSe_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
