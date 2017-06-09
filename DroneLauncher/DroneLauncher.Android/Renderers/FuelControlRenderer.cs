using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DroneLauncher.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Xamarin.Forms.ProgressBar), typeof(FuelControlRenderer))]
namespace DroneLauncher.Droid.Renderers
{
    public class FuelControlRenderer : ProgressBarRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.ProgressBar> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.ScaleY = 4.0f;
                Control.ProgressDrawable.SetColorFilter(Android.Graphics.Color.Rgb(217, 0, 0), PorterDuff.Mode.SrcIn);
            }
        }
    }
}