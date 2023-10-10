using ObjCRuntime;

namespace Demo.Mac.NET;

public partial class ViewController : NSViewController {
	protected ViewController (NativeHandle handle) : base (handle)
	{
		// This constructor is required if the view controller is loaded from a xib or a storyboard.
		// Do not put any initialization here, use ViewDidLoad instead.
	}

	public override void ViewDidLoad ()
	{
		base.ViewDidLoad ();

        // Do any additional setup after loading the view.
        LoadImage();
    }

	public override NSObject RepresentedObject {
		get => base.RepresentedObject;
		set {
			base.RepresentedObject = value;

			// Update the view, if already loaded.
		}
	}

    private async void LoadImage()
    {
        var decoder = new WebP.Mac.WebPCodec();
        var httpClient = new HttpClient();
        using (var stream = await httpClient.GetStreamAsync("https://www.gstatic.com/webp/gallery/1.webp").ConfigureAwait(false))
        {
            var image = decoder.Decode(stream);
            InvokeOnMainThread(() =>
            {
                var imageView = new NSImageView(new CGRect(0, 0, View.Bounds.Width, View.Bounds.Height));
                View.AddSubview(imageView);
                imageView.Image = image;
            });
        }
    }
}

