using ObjCRuntime;

namespace Demo.NET
{
	public class DemoViewController : UIViewController
	{
		public DemoViewController() { }

		public DemoViewController(NativeHandle handle) : base(handle) { }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			
			LoadImage();
		}

		private async void LoadImage()
		{
			var decoder = new WebP.Touch.WebPCodec();
			var httpClient = new HttpClient();
			using (var stream = await httpClient.GetStreamAsync("https://www.gstatic.com/webp/gallery/1.webp").ConfigureAwait(false))
			{
				var image = decoder.Decode(stream);
				InvokeOnMainThread(() =>
					{
						View = new UIImageView(image);
					});
			}
		}
	}
}

