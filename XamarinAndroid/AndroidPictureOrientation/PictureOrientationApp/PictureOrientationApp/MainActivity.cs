using Android.App;
using Android.Widget;
using Android.OS;
using System.Threading.Tasks;
using Android.Content;
using Android.Graphics;
using Android.Database;
using Xamarin.Media;
using System;
using Android.Media;
using System.IO;

namespace PictureOrientationApp
{
	[Activity(Label = "PictureOrientationApp", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		ImageView _takenPictureImageView;
		Button _takePictureButton;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.Main);

			_takenPictureImageView = FindViewById<ImageView>(Resource.Id.TakenPictureImageView);
			_takePictureButton = FindViewById<Button>(Resource.Id.TakePictureButton);

			_takePictureButton.Click += delegate 
			{
				takePicture();
			};
		}

		void takePicture()
		{
			var picker = new MediaPicker(this);
			DateTime now = DateTime.Now;
			var intent = picker.GetTakePhotoUI(new StoreCameraMediaOptions
			{
				Name = "picture_" + now.Day + "_" + now.Month + "_" + now.Year + ".jpg",
				Directory = null
			});
			StartActivityForResult(intent, 1);
		}

		 Bitmap loadAndResizeBitmap(string filePath)
		{
			BitmapFactory.Options options = new BitmapFactory.Options { InJustDecodeBounds = true };
			BitmapFactory.DecodeFile(filePath, options);

			int REQUIRED_SIZE = 100;
			int width_tmp = options.OutWidth, height_tmp = options.OutHeight;
			int scale = 4;
			while (true)
			{
				if (width_tmp / 2 < REQUIRED_SIZE || height_tmp / 2 < REQUIRED_SIZE)
					break;
				width_tmp /= 2;
				height_tmp /= 2;
				scale++;
			}

			options.InSampleSize = scale;
			options.InJustDecodeBounds = false;
			Bitmap resizedBitmap = BitmapFactory.DecodeFile(filePath, options);

			ExifInterface exif = null;
			try
			{
				exif = new ExifInterface(filePath);
				string orientation = exif.GetAttribute(ExifInterface.TagOrientation);

				Matrix matrix = new Matrix();
				switch (orientation)
				{
					case "1": // landscape
						break;
					case "3":
						matrix.PreRotate(180);
						resizedBitmap = Bitmap.CreateBitmap(resizedBitmap, 0, 0, resizedBitmap.Width, resizedBitmap.Height, matrix, false);
						matrix.Dispose();
						matrix = null;
						break;
					case "4":
						matrix.PreRotate(180);
						resizedBitmap = Bitmap.CreateBitmap(resizedBitmap, 0, 0, resizedBitmap.Width, resizedBitmap.Height, matrix, false);
						matrix.Dispose();
						matrix = null;
						break;
					case "5":
						matrix.PreRotate(90);
						resizedBitmap = Bitmap.CreateBitmap(resizedBitmap, 0, 0, resizedBitmap.Width, resizedBitmap.Height, matrix, false);
						matrix.Dispose();
						matrix = null;
						break;
					case "6": // portrait
						matrix.PreRotate(90);
						resizedBitmap = Bitmap.CreateBitmap(resizedBitmap, 0, 0, resizedBitmap.Width, resizedBitmap.Height, matrix, false);
						matrix.Dispose();
						matrix = null;
						break;
					case "7":
						matrix.PreRotate(-90);
						resizedBitmap = Bitmap.CreateBitmap(resizedBitmap, 0, 0, resizedBitmap.Width, resizedBitmap.Height, matrix, false);
						matrix.Dispose();
						matrix = null;
						break;
					case "8":
						matrix.PreRotate(-90);
						resizedBitmap = Bitmap.CreateBitmap(resizedBitmap, 0, 0, resizedBitmap.Width, resizedBitmap.Height, matrix, false);
						matrix.Dispose();
						matrix = null;
						break;
				}

				return resizedBitmap;
			}
			catch (IOException ex)
			{
				Console.WriteLine("An exception was thrown when reading exif from media file...:" + ex.Message);
				return null;
			}
		}


		protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
		{
			base.OnActivityResult(requestCode, resultCode, data);

			if (requestCode == 1)
			{
				if (resultCode == Result.Ok)
				{
					data.GetMediaFileExtraAsync(this).ContinueWith(t =>
					{
						using (Bitmap bmp = loadAndResizeBitmap(t.Result.Path))
						{
							if (bmp != null)
							_takenPictureImageView.SetImageBitmap(bmp);
						}

					}, TaskScheduler.FromCurrentSynchronizationContext());
				}
			}
		}
	}
}

