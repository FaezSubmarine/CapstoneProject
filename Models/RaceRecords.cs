using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CapstoneProject.Models
{

    public enum RequestStatus
    {
        PENDING,
        REJECTED,
        ACCEPTED
    }
    //[Table("raceRecordLists")]
    public class RaceRecords
    {
        [Key]
        public int id { get; set; }
        public string usernameID { get; set; }

        [Required]
        public int circuitID { get; set; }
        public circuit circuit { get; set; }

        [Required]
        [Display(Name = "Car")]
        public string carName { get; set; }

        //use https://www.regex101.com https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions?view=net-5.0

        [RegularExpression(@"\d{1,3}[m]\d{1,2}[s]|(?:DNF)|(?:DQ)", ErrorMessage = "timing is  not valid format")]
        public string timing { get; set; }

        public RaceRecords(string usernameID, int circuitID, string timing)
        {
            this.usernameID = usernameID;
            this.circuitID = circuitID;
            this.timing = timing;
        }
        public RaceRecords() : this("", 0, null)
        {

        }

    }
    [Table("raceRequestLists")]
    public class RaceRequest : RaceRecords
    {
        [Required]
        public DateTime dayOfArrival { get; set; }
        [Required]
        public DateTime timeOfArrival { get; set; }

        public RequestStatus requestStatus = RequestStatus.PENDING;

        public string declineReason { get; set; }
        public RaceRequest(string usernameID, int circuitID, string timing, DateTime dayOfArrival, DateTime timeOfArrival):base(usernameID, circuitID, timing)
        {
            this.dayOfArrival = dayOfArrival;
            this.timeOfArrival = timeOfArrival;
        }
        public RaceRequest() : this("", 0, null,DateTime.MinValue, DateTime.MinValue)
        {
        }
    }
}
