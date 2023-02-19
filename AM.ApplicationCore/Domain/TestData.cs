using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public static class TestData
    {
        public static List<Plane> Planes { get; set; } = new List<Plane>(){
        new Plane
        {
            Capacity=150,
            ManufactureDate=new DateTime(2015,02,03),
            PlaneType=PlaneType.Boing
        },
        new Plane
        {
            PlaneType=PlaneType.Airbus,
            Capacity=200,
            ManufactureDate=new DateTime(2020,11,11),
        }
        };
        public static List<Staff> Staffs { get; set; } = new List<Staff>()
        {
            new Staff
            {
                 FirstName="captain",
                 LastName="captain",
                 EmailAddress="Captain.captain@gmail.com",
                 BirthDate=new DateTime(1965,01,01),
                 EmployementDate=new DateTime(1999,01,01),
                 Salary=99999
            },

             new Staff
            {
                 FirstName="hostess1",
                 LastName="hostess1",
                 EmailAddress="hostess1.hostess1@gmail.com",
                 BirthDate=new DateTime(1995,01,01),
                 EmployementDate=new DateTime(2020,01,01),
                 Salary=999
            }
        };
        public static List<Traveller> Travellers { get; set; } = new List<Traveller>()
        {
            new Traveller
            {
                FirstName="Traveller1",
                LastName="Traveller1",
                EmailAddress="traveller1@gmail.com",
                Nationality="Americain",
                BirthDate=new DateTime(1988,02,04),
                HealthInformation="No troubles"

            },
            new Traveller
            {
                FirstName="Traveller2",
                LastName="Traveller2",
                EmailAddress="traveller2@gmail.com",
                Nationality="French",
                BirthDate=new DateTime(1988,02,04),
                HealthInformation="Some troubles"

            }
        };
        public static List<Flight> Flights { get; set; } = new List<Flight>()
        {
            new Flight
            {
                Departure="Paris",
                EffectiveArrival=new DateTime(2022-12-11),
                plane=Planes[2],
                passangers=new List<Passanger>(Travellers),
                
            },
            new Flight
            {
                Departure="Paris",
                EffectiveArrival=new DateTime(2022-02-01),
                plane=Planes[1]
            }
        };

    }
}
