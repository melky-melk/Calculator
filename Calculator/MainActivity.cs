using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Widget; //this needs to be here so the textview stuff is all valid
using Android.Views;
using System;

namespace Calculator
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private TextView calculatorText; // the field that will ve 
        private string[] numbers = new string[2];
        private string @operator;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            calculatorText = FindViewById<TextView>(Resource.Id.calculator_text_view); //  goes into the calculator text, the answer at the top of the calculator
        }

        //mneed to add attribute export, and go to references and add mono.android.export
        [Java.Interop.Export("ButtonClick")]
        public void ButtonClick (View v)
        {
            Button button = (Button)v; //casting a button into v so it changes into a button?

            //if the button clicked has any of these numbers or a decimal point
            // accesses the button's text and checks whether it matches with one of the characters in the if statement
            if ("0123456789.".Contains(button.Text))
                AddDigitOrDecimalPoint(button.Text); //calls a method for adding it
            //if the button was an operator
            else if ("/x-+".Contains(button.Text))
                AddOperator(button.Text);
            else if ("=" == button.Text)
                Calculate();
            else if ("DEL" == button.Text)
                DeleteNumber();
            else if ("AC" == button.Text)
                EraseAll();
        }

        private void AddDigitOrDecimalPoint(string value)
        {
            int index = @operator == null ? 0 : 1;
            
            switch (value)
            {
                case 0:

            }
        }

        private void AddOperator(string text)
        {
            throw new NotImplementedException();
        }
        private void EraseAll()
        {
            throw new NotImplementedException();
        }

        private void DeleteNumber()
        {
            throw new NotImplementedException();
        }

        private void Calculate()
        {
            throw new NotImplementedException();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}