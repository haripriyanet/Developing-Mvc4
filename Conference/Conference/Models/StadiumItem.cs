using Microsoft.Practices.Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Conference.Models
{

    public class StadiumItem : BindableBase, IStadiumItem
    {
        private string _id;
        private string _teamName;
        private string _formed;
        private string _stadiumName;
        private string _address;
        private string _postcode;
        private string _city;
        private string _smallLogo;
        private string _largeLogo;
        private double _latitude;
        private double _longitude;
        private string _website;

        public string Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }
        public string TeamName
        {
            get { return _teamName; }
            set { SetProperty(ref _teamName, value); }
        }
        public string Formed
        {
            get { return _formed; }
            set { SetProperty(ref _formed, value); }
        }
        public string StadiumName
        {
            get { return _stadiumName; }
            set { SetProperty(ref _stadiumName, value); }
        }
        public string Address
        {
            get { return _address; }
            set { SetProperty(ref _address, value); }
        }
        public string Postcode
        {
            get { return _postcode; }
            set { SetProperty(ref _postcode, value); }
        }
        public string City
        {
            get { return _city; }
            set { SetProperty(ref _city, value); }
        }
        public string SmallLogo
        {
            get { return _smallLogo; }
            set { SetProperty(ref _smallLogo, value); }
        }
        public string LargeLogo
        {
            get { return _largeLogo; }
            set { SetProperty(ref _largeLogo, value); }
        }
        public double Latitude
        {
            get { return _latitude; }
            set { SetProperty(ref _latitude, value); }
        }
        public double Longitude
        {
            get { return _longitude; }
            set { SetProperty(ref _longitude, value); }
        }
        public string Website
        {
            get { return _website; }
            set { SetProperty(ref _website, value); }
        }

        private Microsoft.Practices.Prism.Commands.DelegateCommand<StadiumItem> _itemClickCommand;
      
        public Microsoft.Practices.Prism.Commands.DelegateCommand<StadiumItem> ItemClickCommand
        {
            get { return _itemClickCommand; }
            set { SetProperty(ref _itemClickCommand, value); }
        }

        public StadiumItem (string id, string teamname, string formed, string stadiumname, 
            string address, string postcode, string city, string smalllogo, string largelogo, 
            double latitude, double longitude, string website)
	    {
            this._id = id;
            this._teamName = teamname;
            this._formed = formed;
            this._stadiumName = stadiumname;
            this._address = address;
            this._postcode = postcode;
            this._city = city;
            this._smallLogo = smalllogo;
            this._largeLogo = largelogo;
            this._latitude = latitude;
            this._longitude = longitude;
            this._website = website;
	    }   

    }

}