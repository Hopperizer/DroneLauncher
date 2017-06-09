using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreGraphics;
using DroneLauncher.iOS.Renderers;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;


[assembly: ExportRenderer(typeof(ProgressBar), typeof(FuelControlRenderer))]
namespace DroneLauncher.iOS.Renderers
{
    public class FuelControlRenderer : ProgressBarRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<ProgressBar> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.TintColor = UIColor.FromRGB(217, 0, 0);
            }
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();

            var X = 1.0f;
            var Y = 4.0f;

            CGAffineTransform transform = CGAffineTransform.MakeScale(X, Y);
            Control.Transform = transform;
        }
    }
}