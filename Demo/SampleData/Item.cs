using System;
using System.ComponentModel;

namespace Expression.Blend.SampleData.SampleDataSource
{
	public class Item : INotifyPropertyChanged
	{
		private string _Property1 = string.Empty;
		private bool _Property2 = false;
		private string _Property3 = string.Empty;
		private string _Property4 = string.Empty;
		private string _Property5 = string.Empty;
		private string _Property6 = string.Empty;
		public event PropertyChangedEventHandler PropertyChanged;
		public string Property1
		{
			get
			{
				return this._Property1;
			}
			set
			{
				if (this._Property1 != value)
				{
					this._Property1 = value;
					this.OnPropertyChanged("Property1");
				}
			}
		}
		public bool Property2
		{
			get
			{
				return this._Property2;
			}
			set
			{
				if (this._Property2 != value)
				{
					this._Property2 = value;
					this.OnPropertyChanged("Property2");
				}
			}
		}
		public string Property3
		{
			get
			{
				return this._Property3;
			}
			set
			{
				if (this._Property3 != value)
				{
					this._Property3 = value;
					this.OnPropertyChanged("Property3");
				}
			}
		}
		public string Property4
		{
			get
			{
				return this._Property4;
			}
			set
			{
				if (this._Property4 != value)
				{
					this._Property4 = value;
					this.OnPropertyChanged("Property4");
				}
			}
		}
		public string Property5
		{
			get
			{
				return this._Property5;
			}
			set
			{
				if (this._Property5 != value)
				{
					this._Property5 = value;
					this.OnPropertyChanged("Property5");
				}
			}
		}
		public string Property6
		{
			get
			{
				return this._Property6;
			}
			set
			{
				if (this._Property6 != value)
				{
					this._Property6 = value;
					this.OnPropertyChanged("Property6");
				}
			}
		}
		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
