using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleApi.pplication.Dtos.GoogleEncoding
{
    public class GoogleEncodingDto
    {
        public plus_codeDto plus_code { set; get; }
        public List<GoogleAdressDto> results { set; get; }
        public string status { set; get; }
    }
    public class plus_codeDto
    {
        public string compound_code { get; set; }
        public string global_code { get; set; }
    }
    public class GoogleAdressDto
    {
        public List<Google_address_componentsDto> address_Components { set; get; }
        public string formatted_address { get; set; }
        public Google_geometryDto geometry { set; get; }
        public string place_id { get; set; }
        public plus_codeDto plus_code { set; get; }
        public List<string> types { get; set; }

    }
    public class Google_address_componentsDto
    {
        public string long_name { get; set; }
        public string short_name { get; set; }
        public List<string> types { get; set; }
    }
    public class Google_geometryDto
    {
        public Google_boundsDto bounds { set; get; }
        public Google_cordenadasDto location { set; get; }
        public string location_type { set; get; }

        public Google_boundsDto viewport { set; get; }
    }
    public class Google_cordenadasDto
    {
        public double lat { set; get; }
        public double lng { set; get; }
    }

    public class Google_boundsDto
    {
        public Google_cordenadasDto northeast { set; get; }
        public Google_cordenadasDto southwest { set; get; }
    }


/*    public class Google_viewport
    {
        public Google_cordenadasDto northeast { set; get; }
        public Google_cordenadasDto southwest { set; get; }
    }*/
}