using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Models
{
    public class Project
    {
        [Required]
        [Display(Name = "项目编号")]
        public string ID { get; set; }
        [Display(Name = "项目名称")]
        public string Name { get; set; }
        [Display(Name = "机台数量")]
        public int Count { get; set; }
        [Display(Name = "设计人员")]
        public string Designer { get; set; }
        [Display(Name = "电控人员")]
        public string Engineer { get; set; }
        [Display(Name = "软件人员")]
        public string Programmer { get; set; }
        [Display(Name = "组装人员")]
        public string Assembler { get; set; }
        [Display(Name = "设计人员积分")]
        public double DesignerScore { get; set; }
        [Display(Name = "电控人员积分")]
        public double EngineerScore { get; set; }
        [Display(Name = "软件人员积分")]
        public double ProgrammerScore { get; set; }
        [Display(Name = "组装人员积分")]
        public double AssemblerScore { get; set; }
    }
}
