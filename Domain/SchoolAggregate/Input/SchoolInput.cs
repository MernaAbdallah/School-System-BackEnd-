using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.SchoolAggregate.Input;

public class SchoolInput
{
    public string Name { get; set; }
    public List<StudentInput> studentInputs { get; set; } = new List<StudentInput>();
}
