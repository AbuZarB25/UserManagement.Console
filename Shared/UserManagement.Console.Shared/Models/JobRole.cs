using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.Console.Shared.Models
{
    public class JobRole
    {
        public JobRole(int jobID, string jobRoleName)
        {
            this.JobRoleId = jobID;
            this.JobRoleName = jobRoleName;
        }
        public int JobRoleId { get; set; }

        public string JobRoleName { get; set; }
    }
}
