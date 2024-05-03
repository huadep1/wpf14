using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WpfApp14.Models;

namespace WpfApp14.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<TokenViewModel> Tokens { get; set; }

        public MainViewModel()
        {
            // Initialize Tokens collection and populate it with data
            Tokens = new ObservableCollection<TokenViewModel>();

            // Add some sample data
            Tokens.Add(
                new TokenViewModel(
                    new Token
                    {
                        name = "Token1",
                        symbol = "TKN1",
                        address = "0x123456789",
                        amount = 100,
                        txamount = 50,
                        takeprofit = 10,
                        stoploss = 5,
                        trailingstoploss = 3,
                        sellpercent = 50
                    }
                )
            );
            // Add more tokens as needed
        }
    }
}
