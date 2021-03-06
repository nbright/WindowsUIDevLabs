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
using CompositionSampleGallery.Samples.LightInterop;


namespace CompositionSampleGallery
{

    public sealed partial class LightInterop : SamplePage
    {
        public LightInterop()
        {
            this.InitializeComponent();

            // Target Grid with lights in code behind because SDK MinVersion > 14393 is needed for <Grid.Ligts> in markup (see .xaml file for comments)
            BackdropGrid.Lights.Add(new HoverLight());
            BackdropGrid.Lights.Add(new AmbLight());
        }

        public static string StaticSampleName { get { return "Light Interop"; } }
        public override string SampleName { get { return StaticSampleName; } }
        public override string SampleDescription { get { return "Use XamlLights and XamlCompositionBrushes to create Lights and Materials in XAML"; } }
    }
}
