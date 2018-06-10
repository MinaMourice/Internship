﻿using System.Threading.Tasks;
using Windows.Foundation.Metadata;
using Phoneword.UWP;
using Xamarin.Forms;

[assembly: Dependency(typeof(PhoneDialer))]

namespace Phoneword.UWP
{
    public class PhoneDialer : IDialer
    {
        public Task<bool> DialAsync(string number)
        {
            if (ApiInformation.IsApiContractPresent("Windows.ApplicationModel.Calls.CallsPhoneContract", 1,0))
            {
                Windows.Foundation.UniversalApiContract.Equals(number, "Phoneword");

               return Task.FromResult(true);
            }
            return Task.FromResult(false);
        }
    }
}