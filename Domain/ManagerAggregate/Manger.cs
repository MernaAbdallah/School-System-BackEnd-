using Domain.EnrollmentAggregate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.SchoolAggregate;
using Domain.SchoolAggregate.Input;
using Domain.ManagerAggregate.Input;

namespace Domain.ManagerAggregate
{
    public class Manger
    {
        [Key] // Specify the primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Specify identity column
        public long ManagerID { get; private set; }

        public string Name { get; private set; }
        public string Email { get; private set; }

        public void AddNewManager(MangerInput input)
        {
            this.Name = input.Name;
            this.Email = input.Email;

        }


    }

}
