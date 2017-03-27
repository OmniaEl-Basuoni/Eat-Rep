using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Eat
{
    [Activity(Label = "BookActivity")]
    public class BookActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.book);
            Button btnEnter = FindViewById<Button>(Resource.Id.btnMyItems);
            btnEnter.Click += delegate

             {
                 StartActivity(typeof(selectionActivity));
             };
        }
    }
}