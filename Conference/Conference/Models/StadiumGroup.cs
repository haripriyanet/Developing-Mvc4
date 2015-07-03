using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Conference.Models
{

    public class StadiumGroup : BindableBase, IStadiumGroup
    {
        public int StadiumGroupId { get; set; }

        private string _league;
        public string League 
        {
            get { return this._league; }
            set
            { SetProperty(ref _league, value); }
        }

        private string _logo;
        public string Logo {
            get { return _logo; }
            set { SetProperty(ref _logo, value); }
        }

        private DelegateCommand<string> _headerClickCommand;

        public DelegateCommand<string> HeaderClickCommand
        {
            get { return _headerClickCommand; }
            set { SetProperty(ref _headerClickCommand, value); }
        }


        public virtual ObservableCollection<StadiumItem> Items { get; set; }

        public StadiumGroup(string league, string logo)
        {
            this.League = league;
            this.Logo = logo;
            this.Items = new ObservableCollection<StadiumItem>();
        }

    }

}
