using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using GeoCoordinatePortable;
using Oracle.ManagedDataAccess.Client;
using StudentWebAPI.Data;
using StudentWebAPI.Models;

namespace StudentWebAPI.RepositoryImpl
{
    public class LocationDistance
    {
        public LocationDistance()
        {

        }
        public class LocationInfo
        {
            public double OrgLatitute { get; set; }
            public double OrgLongitude { get; set; }
            public double TeacherLatitute { get; set; }
            public double TeacherLongitude { get; set; }
            public double earthRadius { get; set; }
        }
        public double getLocationDistance(LocationInfo locationInfo)
        {
            
            double distanceInMeters = CalculateDistance(locationInfo.OrgLatitute, locationInfo.OrgLongitude, locationInfo.TeacherLatitute, locationInfo.TeacherLongitude, locationInfo.earthRadius);
            return distanceInMeters;

        }

        public double getTestDistance()
        {
            
            double lat1 = 23.742814039179546;
            double lon1 = 90.41373498617456;
            double lat2 = 23.743180505874477;
            double lon2 = 90.41407923811218;
            double earth = 6371000;
            double distanceInMeters = CalculateDistance(lat1, lon1, lat2, lon2, earth);
            return distanceInMeters;

        }
        public static double CalculateDistance(double lat1, double lon1, double lat2, double lon2, double EarthRadius)
        {
             
            double lat1Rad = ToRadians(lat1);
            double lon1Rad = ToRadians(lon1);
            double lat2Rad = ToRadians(lat2);
            double lon2Rad = ToRadians(lon2);
            double dLat = lat2Rad - lat1Rad;
            double dLon = lon2Rad - lon1Rad;

            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                       Math.Cos(lat1Rad) * Math.Cos(lat2Rad) *
                       Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            double distance = EarthRadius * c;

            return distance;
        }
        public static double ToRadians(double degrees)
        {
            return degrees * Math.PI / 180.0;
        }
      

}
    
   
}
