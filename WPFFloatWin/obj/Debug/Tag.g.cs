﻿#pragma checksum "..\..\Tag.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "49482AD3F793865F07581996DCF68017"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
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
using WPFFloatWin;


namespace WPFFloatWin {
    
    
    /// <summary>
    /// TagWindow
    /// </summary>
    public partial class TagWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\Tag.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid tw_grid;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\Tag.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas tw_canvas;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\Tag.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button tw_ctrlbutton;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\Tag.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border tw_border;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\Tag.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas tw_content;
        
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
            System.Uri resourceLocater = new System.Uri("/WPFFloatWin;component/tag.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Tag.xaml"
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
            
            #line 8 "..\..\Tag.xaml"
            ((WPFFloatWin.TagWindow)(target)).DragLeave += new System.Windows.DragEventHandler(this.Window_DragLeave);
            
            #line default
            #line hidden
            
            #line 8 "..\..\Tag.xaml"
            ((WPFFloatWin.TagWindow)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 8 "..\..\Tag.xaml"
            ((WPFFloatWin.TagWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 8 "..\..\Tag.xaml"
            ((WPFFloatWin.TagWindow)(target)).DragEnter += new System.Windows.DragEventHandler(this.Window_DragEnter);
            
            #line default
            #line hidden
            
            #line 8 "..\..\Tag.xaml"
            ((WPFFloatWin.TagWindow)(target)).Drop += new System.Windows.DragEventHandler(this.Window_Drop);
            
            #line default
            #line hidden
            
            #line 8 "..\..\Tag.xaml"
            ((WPFFloatWin.TagWindow)(target)).LocationChanged += new System.EventHandler(this.Window_LocationChanged);
            
            #line default
            #line hidden
            
            #line 8 "..\..\Tag.xaml"
            ((WPFFloatWin.TagWindow)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.Window_MouseLeave);
            
            #line default
            #line hidden
            
            #line 8 "..\..\Tag.xaml"
            ((WPFFloatWin.TagWindow)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Window_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tw_grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.tw_canvas = ((System.Windows.Controls.Canvas)(target));
            return;
            case 4:
            this.tw_ctrlbutton = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\Tag.xaml"
            this.tw_ctrlbutton.Click += new System.Windows.RoutedEventHandler(this.tw_ctrlbutton_Click);
            
            #line default
            #line hidden
            
            #line 43 "..\..\Tag.xaml"
            this.tw_ctrlbutton.MouseRightButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.tw_ctrlbutton_MouseRightButtonUp);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tw_border = ((System.Windows.Controls.Border)(target));
            return;
            case 6:
            this.tw_content = ((System.Windows.Controls.Canvas)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
