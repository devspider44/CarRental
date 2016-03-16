using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CarRental.Business.Entities
{
    [DataContract (Namespace="http://wwww.pluralsight.com/carrental")]
    public class Car
    {
        [DataMember]
        public int CardId { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Color { get; set; }
        [DataMember]
        public int Year { get; set; }
        [DataMember]
        public decimal RentalPrice { get; set; }
        [DataMember]
        public bool CurrentlyRented { get; set; }
    }
}
