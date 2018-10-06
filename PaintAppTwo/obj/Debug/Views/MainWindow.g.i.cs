﻿#pragma checksum "..\..\..\Views\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7D09246CCD8B6F5D86C07D051DCC414023661F6B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PaintAppTwo;
using PaintAppTwo.Commands;
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


namespace PaintAppTwo.Views {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem openMenuBtn;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem newMenuBtn;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem saveMenuBtn;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox brushSizeTextBox;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button colorBtn;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label colorLabel;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.InkCanvas mainCanvas;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Ink.DrawingAttributes MainAttribute;
        
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
            System.Uri resourceLocater = new System.Uri("/PaintAppTwo;component/views/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\MainWindow.xaml"
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
            
            #line 13 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.Open_CanExecute);
            
            #line default
            #line hidden
            
            #line 13 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.Open_Executed);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 14 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.New_CanExecute);
            
            #line default
            #line hidden
            
            #line 14 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.New_Executed);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 15 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.Save_CanExecute);
            
            #line default
            #line hidden
            
            #line 15 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.Save_Executed);
            
            #line default
            #line hidden
            return;
            case 4:
            this.openMenuBtn = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 5:
            this.newMenuBtn = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 6:
            this.saveMenuBtn = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 7:
            this.brushSizeTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 68 "..\..\..\Views\MainWindow.xaml"
            this.brushSizeTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.brushSizeTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.colorBtn = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\..\Views\MainWindow.xaml"
            this.colorBtn.Click += new System.Windows.RoutedEventHandler(this.colorBtn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.colorLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.mainCanvas = ((System.Windows.Controls.InkCanvas)(target));
            return;
            case 11:
            this.MainAttribute = ((System.Windows.Ink.DrawingAttributes)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

