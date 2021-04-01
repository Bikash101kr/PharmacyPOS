using System;  
using System.IO;  
using Android.App;  
using Android.Content.PM;  
using Android.Graphics;  
using Android.OS;  
using Android.Runtime;  
using Android.Support.Design.Widget;  
using Android.Support.V4.App;  
using Android.Support.V4.Content;  
using Android.Support.V7.App;  
using Android.Views;  
using Android.Widget;  
using ZXing;  
using ZXing.Common;  
  
namespace BarCodeGenerator
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private TextView txtMessage;
        private string message;
        private static int size = 660;
        private static int small_size = 264;
        private Spinner spinnerValue;
        private string CodeType;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            ImageView image = FindViewById<ImageView>(Resource.Id.barcodeImage);
            Button btnGenerate = FindViewById<Button>(Resource.Id.generate);
            txtMessage = FindViewById<TextView>(Resource.Id.plain_text_input);
            spinnerValue = FindViewById<Spinner>(Resource.Id.spinner);
            FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);

            var adapter = ArrayAdapter.CreateFromResource(this, Resource.Array.selected_Code, Android.Resource.Layout.SimpleSpinnerItem);
            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinnerValue.Adapter = adapter;
            spinnerValue.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(SpinnerItemSelect);
            fab.Click += FabOnClick;

            btnGenerate.Click += delegate
            {
                string[] PERMISSIONS =
                {
                    "android.permission.READ_EXTERNAL_STORAGE",
                    "android.permission.WRITE_EXTERNAL_STORAGE"
                };

                var permission = ContextCompat.CheckSelfPermission(this, "android.permission.WRITE_EXTERNAL_STORAGE");
                var permissionread = ContextCompat.CheckSelfPermission(this, "android.permission.READ_EXTERNAL_STORAGE");

                if (permission != Permission.Granted && permissionread != Permission.Granted)
                    ActivityCompat.RequestPermissions(this, PERMISSIONS, 1);

                try
                {
                    if (permission == Permission.Granted && permissionread == Permission.Granted)
                    {
                        BitMatrix bitmapMatrix = null;
                        message = txtMessage.Text.ToString();

                        switch (CodeType)
                        {
                            case "QR Code":
                                bitmapMatrix = new MultiFormatWriter().encode(message, BarcodeFormat.QR_CODE, size, size);
                                break;
                            case "PDF 417":
                                bitmapMatrix = new MultiFormatWriter().encode(message, BarcodeFormat.PDF_417, size, small_size);
                                break;
                            case "CODE 128":
                                bitmapMatrix = new MultiFormatWriter().encode(message, BarcodeFormat.CODE_128, size, small_size);
                                break;
                            case "CODE 39":
                                bitmapMatrix = new MultiFormatWriter().encode(message, BarcodeFormat.CODE_39, size, small_size);
                                break;
                            case "AZTEC":
                                bitmapMatrix = new MultiFormatWriter().encode(message, BarcodeFormat.AZTEC, size, small_size);
                                break;
                        }

                        var width = bitmapMatrix.Width;
                        var height = bitmapMatrix.Height;
                        int[] pixelsImage = new int[width * height];

                        for (int i = 0; i < height; i++)
                        {
                            for (int j = 0; j < width; j++)
                            {
                                if (bitmapMatrix[j, i])
                                    pixelsImage[i * width + j] = (int)Convert.ToInt64(0xff000000);
                                else
                                    pixelsImage[i * width + j] = (int)Convert.ToInt64(0xffffffff);

                            }
                        }

                        Bitmap bitmap = Bitmap.CreateBitmap(width, height, Bitmap.Config.Argb8888);
                        bitmap.SetPixels(pixelsImage, 0, width, 0, 0, width, height);

                        var sdpath = Android.OS.Environment.ExternalStorageDirectory.AbsolutePath;
                        var path = System.IO.Path.Combine(sdpath, "logeshbarcode.jpg");
                        var stream = new FileStream(path, FileMode.Create);
                        bitmap.Compress(Bitmap.CompressFormat.Jpeg, 100, stream);
                        stream.Close();

                        image.SetImageBitmap(bitmap);
                    }
                    else
                    {
                        Console.WriteLine("No Permission");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception {ex} ");
                }
            };
        }

        private void SpinnerItemSelect(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = (Spinner)sender;
            CodeType = (string)spinner.GetItemAtPosition(e.Position);
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View)sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, 
            [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}