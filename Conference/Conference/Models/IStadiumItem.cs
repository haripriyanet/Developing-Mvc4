using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.Models
{

    interface IStadiumItem
    {

        string Id { get; set; }
        string TeamName { get; set; }
        string Formed { get; set; }
        string StadiumName { get; set; }
        string Address { get; set; }
        string Postcode { get; set; }
        string City { get; set; }
        string SmallLogo { get; set; }
        string LargeLogo { get; set; }
        double Latitude { get; set; }
        double Longitude { get; set; }
        string Website { get; set; }

    }

}
