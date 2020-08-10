using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 1,
                    ProjectID = "SZ-20191228-01",
                    Name = "收放板共用机（LDR-D5X-SF)   VPP D53_撕膜电测",
                    Count = 24,
                    Designer = "范杰",
                    Engineer = "邬海欣",
                    Programmer = "孙鑫建",
                    Assembler = "邱伟",
                    DesignerScore = 10,
                    EngineerScore = 10,
                    ProgrammerScore = 10,
                    AssemblerScore = 10
                },
                new Project
                {
                    Id = 2,
                    ProjectID = "LDR-SJ-0220",
                    Name = "X1023自动上下料机",
                    Count = 13,
                    Designer = "范杰",
                    Engineer = "李明昌",
                    Programmer = "孙鑫建",
                    Assembler = "李晓锁",
                    DesignerScore = 10,
                    EngineerScore = 10,
                    ProgrammerScore = 10,
                    AssemblerScore = 10
                }

                ) ;

        }
    }
}
