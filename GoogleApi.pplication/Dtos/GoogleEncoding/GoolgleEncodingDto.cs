using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleApi.pplication.Dtos.GoogleEncoding
{
    public class GoogleEncodingDto
    {
        public plus_code plus_code { set; get; }
        public List<GoogleAdress> results { set; get; }
        public string status { set; get; }
    }
    public class plus_code
    {
        public string compound_code { get; set; }
        public string global_code { get; set; }
    }
    public class GoogleAdress
    {
        public List<Google_address_components> address_Components { set; get; }
        public string formatted_address { get; set; }
        public Google_geometry geometry { set; get; }
        public string place_id { get; set; }
        public plus_code plus_code { set; get; }
        public List<string> types { get; set; }

    }
    public class Google_address_components
    {
        public string long_name { get; set; }
        public string short_name { get; set; }
        public List<string> types { get; set; }
    }
    public class Google_geometry
    {
        public Google_bounds bounds { set; get; }
        public Google_cordenadas location { set; get; }
        public string location_type { set; get; }

        public Google_viewport viewport { set; get; }
    }
    public class Google_cordenadas
    {
        public double lat { set; get; }
        public double lng { set; get; }
    }

    public class Google_bounds
    {
        public Google_cordenadas northeast { set; get; }
        public Google_cordenadas southwest { set; get; }
    }


    public class Google_viewport
    {
        public Google_cordenadas northeast { set; get; }
        public Google_cordenadas southwest { set; get; }
    }
}