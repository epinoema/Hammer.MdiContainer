﻿using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Hammer.MDIContainer.Control.Extensions
{
    public static class WindowVisualExtension
   {
      public static RenderTargetBitmap CreateSnapshot(this MdiWindow window)
      {
         var bitmap = new RenderTargetBitmap((int)Math.Round(window.ActualWidth), (int)Math.Round(window.ActualHeight), 96, 96, PixelFormats.Default);
         var drawingVisual = new DrawingVisual();
         using (var context = drawingVisual.RenderOpen())
         {
            var brush = new VisualBrush(window);
            context.DrawRectangle(brush, null, new Rect(new Point(), new Size(window.ActualWidth, window.ActualHeight)));
            context.Close();
         }

         bitmap.Render(drawingVisual);

         return bitmap;
      }      
   }
}
