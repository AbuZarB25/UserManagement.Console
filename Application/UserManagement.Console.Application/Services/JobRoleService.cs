using System.Text;
using UserManagement.Console.Shared.Models;

namespace UserManagement.Console.Application.Services
{
  /// <summary>
  /// The Job Role Service class.
  /// </summary>
  /// <remarks>
  /// All related action to job role will be handled here.
  /// </remarks>
  public static class JobRoleService
  {

        private static IEnumerable<JobRole> jobRoles = new List<JobRole>()
        {
            new JobRole(1, "Associate"),
            new JobRole(2, "Senior Manager"),
            new JobRole(3, "Developer"),
            new JobRole(4, "Business Analyst"),
        };

        public static IEnumerable<JobRole> GetJobRoles()
        {
            return jobRoles;
        }

        public static bool ChangeJobRole(int userId, int jobRoleId)
        {
            var jobRole = jobRoles.FirstOrDefault(jr => jr.JobRoleId == jobRoleId);

            var user = UserService.GetUsers().FirstOrDefault(u => u.PersonId == userId);

            user.JobRole = jobRole.JobRoleName;

            return true;
        }
  }
}
