using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.ViewModels
{
    public class ProjectEditViewModel : ProjectCreateViewModel
    {
        public int Id { get; set; }
        
    }
}
