﻿#pragma checksum "..\..\..\UI\UstanoveWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5C939A99B0868522A4821C2FEA44500D0EA3DB6E"
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
    /// UstanoveWindow
    /// </summary>
    public partial class UstanoveWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\..\UI\UstanoveWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbPretraga;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\UI\UstanoveWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbPretraga;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\UI\UstanoveWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbSortiranje;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\UI\UstanoveWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbSortiraj;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\UI\UstanoveWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgUstanova;
        
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
            System.Uri resourceLocater = new System.Uri("/SF24-2016-POP2019;component/ui/ustanovewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UI\UstanoveWindow.xaml"
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
            this.tbPretraga = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.cbPretraga = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            
            #line 46 "..\..\..\UI\UstanoveWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.PretraziUstanovu_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cbSortiranje = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.cbSortiraj = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            
            #line 58 "..\..\..\UI\UstanoveWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SortirajUstanovu_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.dgUstanova = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 8:
            
            #line 82 "..\..\..\UI\UstanoveWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DodajUstanovu);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 83 "..\..\..\UI\UstanoveWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IzmeniUstanovu);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 84 "..\..\..\UI\UstanoveWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ObrisiUstanovu_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 85 "..\..\..\UI\UstanoveWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ZatvoriProzor_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

