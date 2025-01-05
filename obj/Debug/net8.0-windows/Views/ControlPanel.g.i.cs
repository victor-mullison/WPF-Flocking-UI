﻿#pragma checksum "..\..\..\..\Views\ControlPanel.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3AAD495697A86DCCDA6413110F2D8C06EA4E7E0A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
using WPFBoids.Views;


namespace WPFBoids.Views {
    
    
    /// <summary>
    /// ControlPanel
    /// </summary>
    public partial class ControlPanel : System.Windows.Controls.Grid, System.Windows.Markup.IComponentConnector {
        
        
        #line 2 "..\..\..\..\Views\ControlPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WPFBoids.Views.ControlPanel MyControlPanel;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\Views\ControlPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider AlignmentSlider;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\Views\ControlPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider CohesionSlider;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Views\ControlPanel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider SeparationSlider;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPFBoids;V1.0.0.0;component/views/controlpanel.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\ControlPanel.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.MyControlPanel = ((WPFBoids.Views.ControlPanel)(target));
            return;
            case 2:
            this.AlignmentSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 14 "..\..\..\..\Views\ControlPanel.xaml"
            this.AlignmentSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.Alignment_Changed);
            
            #line default
            #line hidden
            return;
            case 3:
            this.CohesionSlider = ((System.Windows.Controls.Slider)(target));
            return;
            case 4:
            this.SeparationSlider = ((System.Windows.Controls.Slider)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

