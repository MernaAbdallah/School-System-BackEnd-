using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Lookups;

public class TeacherCategory
{
    [Key] // Specify the primary key
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Specify identity column
    public long TeacherCategoryID { get; private set; }

    public string Name { get; private set; }
}
