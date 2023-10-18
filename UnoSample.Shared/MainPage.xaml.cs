using SkiaSharp.Views.UWP;
using System;
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
using SkiaSharp;
using SkiaSharp.Views.UWP;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UnoSample
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MainPage : Page
	{
		public MainPage()
		{
			this.InitializeComponent();
            CanvasView.PaintSurface += PaintSurface;
        }

        private void PaintSurface(object sender, SKPaintSurfaceEventArgs e)
		{
            var canvas = e.Surface.Canvas;
            canvas.Clear(SKColors.White);
            
            var paint = new SKPaint
            {
                Color = SKColors.Red,
                IsAntialias = true,
                Style = SKPaintStyle.Fill
            };
            
            var font = new SKFont
            {
                Size = 24
            };
            
            var coord = new SKPoint(e.Info.Width / 2, (e.Info.Height + font.Size) / 2);

            canvas.DrawText("SkiaSharp", coord.X, coord.Y, font, paint);
        }
    }
}
