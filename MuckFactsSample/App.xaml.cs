using System;
using System.Collections.Generic;
using MuckFactsSample.Data;
using MuckFactsSample.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MuckFactsSample
{
    public partial class App : Application

    {

        static PersonalItemDatabase database;
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }
        public static PersonalItemDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new PersonalItemDatabase();
                    prefillDatabase();

                }
                return database;
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        static void prefillDatabase()
        {
            database.ClearAllAsync();
            List<PersonalItem> items = new List<PersonalItem>();
            items.Add(new PersonalItem() { Title = "Name", Detail = "Isaiah Muckerheide" });
            items.Add(new PersonalItem() { Title = "Job", Detail = "Flooring Specialist", Image = "https://media.istockphoto.com/id/638727076/photo/installing-wood-flooring.jpg?s=612x612&w=0&k=20&c=l4wcPVlfJ42CbR5U1OYgMdq1wW3HJtqABtz2MepeMpY=" });
            items.Add(new PersonalItem() { Title = "Married", Detail = "6 years", Image = "https://banner2.cleanpng.com/20180206/sgw/kisspng-wedding-ring-silver-clip-art-silver-ring-png-pic-5a79b6df0984e6.043612511517926111039.jpg" });
            items.Add(new PersonalItem() { Title = "Children", Detail = " 4, identical twins and irish twins.", Image = "https://media.istockphoto.com/id/546464946/photo/two-little-girls-on-a-forest-road.jpg?s=612x612&w=0&k=20&c=aoCSMXIRjGUpaa9RdBHbexiuo-jSop4kTTJeaC_IjcY=" });
            items.Add(new PersonalItem() { Title = "Sport", Detail = "Wrestled for 12 years.", Image = "https://as2.ftcdn.net/v2/jpg/01/83/37/55/1000_F_183375525_If2m21RoEypOjQyvVcb1PxOMJO0fZNXh.jpg" });
            items.Add(new PersonalItem() { Title = "Religion", Detail = "Born again-Christian", Image = "https://media.istockphoto.com/id/657091114/photo/crucifixion-of-jesus-christ.jpg?s=612x612&w=0&k=20&c=GrvlF-IaMzbTJoRxMfz-g8PVjlbdi7l56FmG6uOi0q0=" });

            database.InsertList(items);

        }
    }
}
