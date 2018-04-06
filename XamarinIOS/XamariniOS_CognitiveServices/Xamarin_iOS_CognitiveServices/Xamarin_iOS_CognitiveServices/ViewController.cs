using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Foundation;
using Media.Plugin;
using Microsoft.ProjectOxford.Vision;
using Microsoft.ProjectOxford.Vision.Contract;
using UIKit;

namespace Xamarin_iOS_CognitiveServices
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

		
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
		
		}

		partial void SelectButtonClick(UIButton sender)
		{
			selectImage();
		}

		async void selectImage()
		{
			var selectedImage = await CrossMedia.Current.PickPhotoAsync();
			SelectedPictureImageView.Image =  new UIImage(NSData.FromStream(selectedImage.GetStream()));
			await analyseImage(selectedImage.GetStream());
		}

		async Task analyseImage(Stream imageStream)
		{
			try
			{
				VisionServiceClient visionClient = new VisionServiceClient("<<YOUR API KEY HERE>>");
				VisualFeature[] features = { VisualFeature.Tags, VisualFeature.Categories, VisualFeature.Description };
				var analysisResult = await visionClient.AnalyzeImageAsync(imageStream, features.ToList(), null);
				AnalysisLabel.Text = string.Empty;
				analysisResult.Description.Tags.ToList().ForEach(tag => AnalysisLabel.Text = AnalysisLabel.Text + tag + "\n");
			}
			catch (Microsoft.ProjectOxford.Vision.ClientException ex)
			{
				AnalysisLabel.Text = ex.Error.Message;
			}
		}
	}
}
