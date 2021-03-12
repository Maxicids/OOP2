﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "58983B71C6273822E584D5D4132A5FFFD7B2684CF276106DB2FE7BE85B8C6B45"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace Shop_Service {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.Transitions.TransitioningContent MenuTransition;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridCursor;
        
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
            System.Uri resourceLocater = new System.Uri("/Shop_Service;component/mainwindow.xaml", System.UriKind.Relative);
            
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
            
            #line 9 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.MainGrid_OnMouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 13 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonOff_OnClick);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 17 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonMinimize_OnClick);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 23 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonLogOut_OnClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.MenuTransition = ((MaterialDesignThemes.Wpf.Transitions.TransitioningContent)(target));
            return;
            case 6:
            this.GridCursor = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            
            #line 46 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.StackPanel)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.MenuElement_OnMouseLeave);
            
            #line default
            #line hidden
            
            #line 47 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.StackPanel)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.MenuElement_OnMouseEnter);
            
            #line default
            #line hidden
            
            #line 48 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.StackPanel)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Main_OnMouseDown);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 53 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.StackPanel)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.MenuElement_OnMouseLeave);
            
            #line default
            #line hidden
            
            #line 54 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.StackPanel)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.MenuElement_OnMouseEnter);
            
            #line default
            #line hidden
            
            #line 55 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.StackPanel)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Shop_OnMouseDown);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 60 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.StackPanel)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.MenuElement_OnMouseLeave);
            
            #line default
            #line hidden
            
            #line 61 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.StackPanel)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.MenuElement_OnMouseEnter);
            
            #line default
            #line hidden
            
            #line 62 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.StackPanel)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Stores_OnMouseDown);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 67 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.StackPanel)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.MenuElement_OnMouseLeave);
            
            #line default
            #line hidden
            
            #line 68 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.StackPanel)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.MenuElement_OnMouseEnter);
            
            #line default
            #line hidden
            
            #line 69 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.StackPanel)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Cart_OnMouseDown);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 75 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.StackPanel)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.MenuElement_OnMouseLeave);
            
            #line default
            #line hidden
            
            #line 76 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.StackPanel)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.MenuElement_OnMouseEnter);
            
            #line default
            #line hidden
            
            #line 77 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.StackPanel)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.About_OnMouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

