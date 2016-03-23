using _03.CompanyHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompanyHierarchy
{
    class Project : IProject
    {
        private string projectName;
        private DateTime startDate;
        private string details;
        private string state;

        public Project(string projectName, DateTime startDate, string details, string state)
        {
            this.ProjectName = projectName;
            this.StartDate = startDate;
            this.Details = details;
        }

        public Project(string projectName, DateTime startDate, string state)
            : this(projectName, startDate, null, state)
        {
            this.State = state;
        }

        public DateTime StartDate { get; set; }

        public string ProjectName
        {
            get
            {
                return this.projectName;
            }
            set
            {
                if (value == "" || value == null)
                {
                    throw new ArgumentNullException("Name is a mandatory.No empty strings accepted");
                }

                this.projectName = value;
            }
        }

        public string Details
        {
            get
            {
                return this.details;
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentNullException("No empty strings accepted");
                }

                this.details = value;
            }
        }

        public string State
        {
            get
            {
                return this.state;
            }
            set
            {
                if (value != "open" && value != "closed")
                {
                    throw new ArgumentException("State can be only \"open\" or \"closed\"");
                }

                this.state = value;
            }
        }

        public void CloseProject()
        {
            if (state == "open")
            {
                state = "closed";
            }
            else
            {
                throw new InvalidOperationException("The project is already closed.");
            }
        }

        public override string ToString()
        {
            string projectInfo;

            projectInfo = string.Join("", "PROJECT INFO", "\n", "Project name:", ProjectName, "\n", "Start date:", StartDate, "\n", "Details:", Details, "\n",
                "State:", State);

            return projectInfo;
        }
    }
}
