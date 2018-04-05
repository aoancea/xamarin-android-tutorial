using Android.App;
using Android.OS;
using Android.Widget;
using System.Collections.Generic;

namespace ListViewTutorial
{
    [Activity(Label = "ListViewTutorial", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private List<Person> mItems = new List<Person>();

        private ListView mListView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            mListView = FindViewById<ListView>(Resource.Id.myListView);

            mItems = new List<Person>()
            {
                new Person { Name = "John", LastName = "Smith", Age = "22", Gender = "male" },
                new Person { Name = "Tom", LastName = "Tom", Age = "35", Gender = "male" },
                new Person { Name = "Sally", LastName = "Susan", Age = "88", Gender = "female" },
            };

            MyListViewAdapter adapter = new MyListViewAdapter(this, mItems);

            mListView.Adapter = adapter;
        }
    }
}