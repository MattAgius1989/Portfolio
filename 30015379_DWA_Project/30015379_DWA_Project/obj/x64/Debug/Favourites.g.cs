﻿

#pragma checksum "C:\Users\Mathew\documents\visual studio 2015\Projects\30015379_DWA_Project\30015379_DWA_Project\Favourites.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "38FE065F94D553F63666ECA61749BD68"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _30015379_DWA_Project
{
    partial class Favourites : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 55 "..\..\..\Favourites.xaml"
                ((global::Windows.UI.Xaml.Controls.ListViewBase)(target)).ItemClick += this.ItemView_ItemClick;
                 #line default
                 #line hidden
                #line 59 "..\..\..\Favourites.xaml"
                ((global::Windows.UI.Xaml.Controls.ListViewBase)(target)).DragItemsStarting += this.itemGridView_DragItemsStarting;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 84 "..\..\..\Favourites.xaml"
                ((global::Windows.UI.Xaml.Controls.ListViewBase)(target)).ItemClick += this.ItemView_ItemClick;
                 #line default
                 #line hidden
                #line 89 "..\..\..\Favourites.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Drop += this.favoriteGridView_Drop;
                 #line default
                 #line hidden
                #line 90 "..\..\..\Favourites.xaml"
                ((global::Windows.UI.Xaml.Controls.ListViewBase)(target)).DragItemsStarting += this.drag_out;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 125 "..\..\..\Favourites.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Save;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 131 "..\..\..\Favourites.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Delete;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


