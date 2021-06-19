﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6648D4E94834E749C5D91C74520E3CDF2775C2FC8BC138662011FDF58A5C86D0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FordFulkersonVisualization;
using Petzold.Media2D;
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


namespace FordFulkersonVisualization {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 36 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RunAlgoButton;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteGraphButton;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddSourceButton;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddSinkButton;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddVertexButton;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddEdgeButton;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid CanvasSpace;
        
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
            System.Uri resourceLocater = new System.Uri("/FordFulkersonVisualization;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.RunAlgoButton = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\MainWindow.xaml"
            this.RunAlgoButton.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DeleteGraphButton = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\MainWindow.xaml"
            this.DeleteGraphButton.Click += new System.Windows.RoutedEventHandler(this.Button_Click2);
            
            #line default
            #line hidden
            return;
            case 3:
            this.AddSourceButton = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\MainWindow.xaml"
            this.AddSourceButton.Click += new System.Windows.RoutedEventHandler(this.AddSourceButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AddSinkButton = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\MainWindow.xaml"
            this.AddSinkButton.Click += new System.Windows.RoutedEventHandler(this.AddSinkButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.AddVertexButton = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\MainWindow.xaml"
            this.AddVertexButton.Click += new System.Windows.RoutedEventHandler(this.AddVertexButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.AddEdgeButton = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\MainWindow.xaml"
            this.AddEdgeButton.Click += new System.Windows.RoutedEventHandler(this.AddEdgeButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.CanvasSpace = ((System.Windows.Controls.Grid)(target));
            
            #line 50 "..\..\MainWindow.xaml"
            this.CanvasSpace.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.CanvasSpace_MouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 8:
            
            #line 68 "..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Ellipse)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Ellipse_MouseDown);
            
            #line default
            #line hidden
            break;
            case 9:
            
            #line 86 "..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Ellipse)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Ellipse_MouseDown);
            
            #line default
            #line hidden
            break;
            case 10:
            
            #line 105 "..\..\MainWindow.xaml"
            ((System.Windows.Shapes.Ellipse)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Ellipse_MouseDown);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}
