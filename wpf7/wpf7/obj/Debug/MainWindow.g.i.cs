// Updated by XamlIntelliSenseFileGenerator 30.05.2022 10:02:47
#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4E723F5369A041664C62467141FCFFE06A8E3F387CCBF50442808A5C41A26F11"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using wpf7;


namespace wpf7
{


    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 11 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas canvas1;

#line default
#line hidden


#line 14 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock label1;

#line default
#line hidden


#line 16 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock label2;

#line default
#line hidden


#line 18 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock label3;

#line default
#line hidden


#line 20 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock label4;

#line default
#line hidden


#line 23 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.UniformGrid grid1;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/wpf7;component/mainwindow.xaml", System.UriKind.Relative);

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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:

#line 9 "..\..\MainWindow.xaml"
                    ((wpf7.MainWindow)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.label1_MouseDown);

#line default
#line hidden
                    return;
                case 2:
                    this.canvas1 = ((System.Windows.Controls.Canvas)(target));

#line 12 "..\..\MainWindow.xaml"
                    this.canvas1.Drop += new System.Windows.DragEventHandler(this.canvas1_Drop);

#line default
#line hidden

#line 12 "..\..\MainWindow.xaml"
                    this.canvas1.DragEnter += new System.Windows.DragEventHandler(this.canvas1_DragEnter);

#line default
#line hidden

#line 13 "..\..\MainWindow.xaml"
                    this.canvas1.DragOver += new System.Windows.DragEventHandler(this.canvas1_DragEnter);

#line default
#line hidden

#line 13 "..\..\MainWindow.xaml"
                    this.canvas1.DragLeave += new System.Windows.DragEventHandler(this.canvas1_DragLeave);

#line default
#line hidden
                    return;
                case 3:
                    this.label1 = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 4:
                    this.label2 = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 5:
                    this.label3 = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 6:
                    this.label4 = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 7:
                    this.grid1 = ((System.Windows.Controls.Primitives.UniformGrid)(target));

#line 23 "..\..\MainWindow.xaml"
                    this.grid1.Drop += new System.Windows.DragEventHandler(this.grid1_Drop);

#line default
#line hidden

#line 24 "..\..\MainWindow.xaml"
                    this.grid1.PreviewDragEnter += new System.Windows.DragEventHandler(this.canvas1_DragEnter);

#line default
#line hidden

#line 24 "..\..\MainWindow.xaml"
                    this.grid1.PreviewDragOver += new System.Windows.DragEventHandler(this.canvas1_DragEnter);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Button button1;
        internal System.Windows.Shapes.Ellipse mark1;
        internal System.Windows.Controls.TextBlock caption1;
    }
}

