using Android.App;
using Android.Widget;
using Android.OS;

namespace App1
{
	[Activity(Label = "App1", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
        private Button btn;
        int count = 0;
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            btn = FindViewById<Button>(Resource.Id.button1);
            //btn.SetOnClickListener()
            //这是什么东西
            btn.Click += delegate { btn.Text = string.Format("{0} click", count++); };
        }
	}
}

