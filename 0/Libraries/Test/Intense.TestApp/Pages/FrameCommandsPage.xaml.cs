﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Intense.TestApp.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FrameCommandsPage : Page
    {
        public FrameCommandsPage()
        {
            this.InitializeComponent();

            // fill the targetframe backstack
            TargetFrame.Navigate(typeof(Page3));
            TargetFrame.BackStack.Add(new PageStackEntry(typeof(Page1), null, null));
            TargetFrame.BackStack.Add(new PageStackEntry(typeof(Page2), null, null));
        }
    }
}