using System;
using System.ComponentModel;
using System.Windows;

namespace Expression.Blend.SampleData.SampleDataSource
{
	public class SampleDataSource : INotifyPropertyChanged
	{
		private ItemCollection _Collection = new ItemCollection();
		public event PropertyChangedEventHandler PropertyChanged;
		public ItemCollection Collection
		{
			get
			{
				return this._Collection;
			}
		}
		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		public SampleDataSource()
		{
			try
			{
				Uri uri = new Uri("/Demo;component/SampleData/SampleDataSource.xaml", UriKind.Relative);
				if (Application.GetResourceStream(uri) != null)
				{
					Application.LoadComponent(this, uri);
				}
			}
			catch (Exception)
			{
			}
		}
	}
}
