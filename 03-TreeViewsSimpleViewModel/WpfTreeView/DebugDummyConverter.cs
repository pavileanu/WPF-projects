﻿using System;
using System.Windows;
using System.Windows.Data;
using System.Diagnostics;

namespace WpfTreeView
{
	public class DebugDummyConverter : IValueConverter
	{            
		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			//Debugger.Break();
			return value;
		}

		public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			//Debugger.Break();
			return value;
		}
	}
}