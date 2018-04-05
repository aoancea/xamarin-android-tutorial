using Android.Content;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;

namespace ListViewTutorial
{
    public class MyListViewAdapter : BaseAdapter<Person>
    {
        private List<Person> mItems;
        private Context context;

        public MyListViewAdapter(Context context, List<Person> items)
        {
            mItems = items;
            this.context = context;
        }

        public override int Count => mItems.Count;
        public override long GetItemId(int position) => position;
        public override Person this[int position] => mItems[position];

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;

            if (row == null)
            {
                row = LayoutInflater.From(context).Inflate(Resource.Layout.listview_row, null, false);
            }

            TextView txtName = row.FindViewById<TextView>(Resource.Id.txtName);
            txtName.Text = mItems[position].Name;

            TextView txtLastName = row.FindViewById<TextView>(Resource.Id.txtLastName);
            txtLastName.Text = mItems[position].LastName;

            TextView txtAge = row.FindViewById<TextView>(Resource.Id.txtAge);
            txtAge.Text = mItems[position].Age;

            TextView txtGender = row.FindViewById<TextView>(Resource.Id.txtGender);
            txtGender.Text = mItems[position].Gender;

            return row;
        }
    }
}