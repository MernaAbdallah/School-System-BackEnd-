using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.EnrollmentAggregate;
using Domain.SchoolAggregate;

namespace Domain.Lookups
{
    public class StudentLevel
    {
        [Key] // Specify the primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Specify identity column
        public long StudentLevelID { get; private set; }

        public string Name { get; private set; }
    }
}
