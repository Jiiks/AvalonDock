﻿/************************************************************************
   AvalonDock

   Copyright (C) 2007-2013 Xceed Software Inc.

   This program is provided to you under the terms of the Microsoft Public
   License (Ms-PL) as published at https://opensource.org/licenses/MS-PL
 ************************************************************************/

using System;
using System.Windows.Data;
using System.Windows.Controls;
using AvalonDock.Layout;

namespace AvalonDock.Converters
{
	[ValueConversion(typeof(AnchorSide), typeof(Orientation))]
	public class AnchorSideToOrientationConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			AnchorSide side = (AnchorSide)value;
			if (side == AnchorSide.Left ||
				side == AnchorSide.Right)
				return Orientation.Vertical;

			return Orientation.Horizontal;
		}

		public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
