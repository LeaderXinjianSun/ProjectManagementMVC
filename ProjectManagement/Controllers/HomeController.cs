using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Models;
using ProjectManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProjectRepository _projectRepository;

        public HomeController(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }
        public IActionResult Index()
        {
            IEnumerable<Project> projects = _projectRepository.GetAllProjects();

            return View(projects);

        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProjectCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                Project newProject = new Project
                {
                    //Id = _projectRepository.GetAllProjects().Count() + 1,
                    ProjectID = model.ProjectID,
                    Name = model.Name,
                    Count = model.Count,
                    Designer = model.Designer,
                    Engineer = model.Engineer,
                    Programmer = model.Programmer,
                    Assembler = model.Assembler,
                    DesignerScore = model.DesignerScore,
                    EngineerScore = model.EngineerScore,
                    ProgrammerScore = model.ProgrammerScore,
                    AssemblerScore = model.AssemblerScore
                };

                _projectRepository.Add(newProject);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public ViewResult Edit(int id)
        {
            Project project = _projectRepository.GetProject(id);
            ProjectEditViewModel projectEditView = new ProjectEditViewModel
            {
                Id = project.Id,
                ProjectID = project.ProjectID,
                Name = project.Name,
                Count = project.Count,
                Designer = project.Designer,
                Engineer = project.Engineer,
                Programmer = project.Programmer,
                Assembler = project.Assembler,
                DesignerScore = project.DesignerScore,
                EngineerScore = project.EngineerScore,
                ProgrammerScore = project.ProgrammerScore,
                AssemblerScore = project.AssemblerScore
            };
            return View(projectEditView);
        }
        [HttpPost]
        public IActionResult Edit(ProjectEditViewModel model)
        {
            //检查提供的数据是否有效，如果没有通过验证，需要重新编辑项目信息
            //这样用户就可以更正并重新提交编辑表单
            if (ModelState.IsValid)
            {
                Project project = _projectRepository.GetProject(model.Id);
                project.ProjectID = model.ProjectID;
                project.Name = model.Name;
                project.Designer = model.Designer;
                project.Engineer = model.Engineer;
                project.Programmer = model.Programmer;
                project.Assembler = model.Assembler;
                project.Count = model.Count;
                project.DesignerScore = model.DesignerScore;
                project.EngineerScore = model.EngineerScore;
                project.ProgrammerScore = model.ProgrammerScore;
                project.AssemblerScore = model.AssemblerScore;
                Project updateStudent = _projectRepository.Update(project);
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Delete(int id)
        {
            _projectRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
