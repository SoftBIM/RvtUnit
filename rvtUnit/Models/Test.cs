using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Media;
using GalaSoft.MvvmLight;

namespace rvtUnit.Models
{
	public class Test : ModelBase
	{
		private bool _IsChecked;
		public bool IsChecked
		{
			get
			{
				return _IsChecked;
			}
			set
			{
				_IsChecked = value;
				OnPropertyChanged(nameof(IsChecked));
			}
		}

		private string _TestName;
		public string TestName
		{
			get
			{
				return _TestName;
			}
			set
			{
				_TestName = value;
				OnPropertyChanged(nameof(TestName));
			}
		}

		private Brush _brush;
		public Brush Brush
		{
			get { return _brush; }
			set
			{
				_brush = value;
				OnPropertyChanged(nameof(Brush));
			}
		}

	
	}
}
