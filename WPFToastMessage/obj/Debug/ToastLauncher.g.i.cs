﻿#pragma checksum "..\..\ToastLauncher.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "AC325ABF90346FD718FB07E2AEC1A5D4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
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


namespace Se.Creotec.WPFToastMessage {
    
    
    /// <summary>
    /// ToastLauncher
    /// </summary>
    public partial class ToastLauncher : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\ToastLauncher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnFire;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\ToastLauncher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTitle;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\ToastLauncher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMessage;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\ToastLauncher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider sliderDelay;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\ToastLauncher.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboPos;
        
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
            System.Uri resourceLocater = new System.Uri("/WPFToastMessage;component/toastlauncher.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ToastLauncher.xaml"
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
            this.btnFire = ((System.Windows.Controls.Button)(target));
            
            #line 6 "..\..\ToastLauncher.xaml"
            this.btnFire.Click += new System.Windows.RoutedEventHandler(this.btnFire_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtTitle = ((System.Windows.Controls.TextBox)(target));
            
            #line 7 "..\..\ToastLauncher.xaml"
            this.txtTitle.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtTitle_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtMessage = ((System.Windows.Controls.TextBox)(target));
            
            #line 12 "..\..\ToastLauncher.xaml"
            this.txtMessage.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtMessage_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.sliderDelay = ((System.Windows.Controls.Slider)(target));
            
            #line 13 "..\..\ToastLauncher.xaml"
            this.sliderDelay.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.sliderDelay_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.comboPos = ((System.Windows.Controls.ComboBox)(target));
            
            #line 14 "..\..\ToastLauncher.xaml"
            this.comboPos.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboPos_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

