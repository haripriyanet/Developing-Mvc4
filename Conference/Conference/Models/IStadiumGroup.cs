using Microsoft.Practices.Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Conference.Models
{

    interface IStadiumGroup
    {

        string League { get; set; }
        string Logo { get; set; }
        ObservableCollection<StadiumItem> Items { get; set; }
        DelegateCommand<string> HeaderClickCommand { get; set; }

    }

}
