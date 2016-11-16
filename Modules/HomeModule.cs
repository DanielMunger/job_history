using Nancy;
using System.Collections.Generic;
using JobsYouveHeld.Objects;


namespace JobsYouveHeld
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => {
                return View["index.cshtml"];
            };

            Get["/jobs"] = _ => {
                List<Job> allJobs = Job.GetAll();
                return View["/jobs.cshtml", allJobs];
            };

            Get["/jobs/{id}"] = parameters => {
                Job selectedJob = Job.Find(parameters.id);
                return View["job.cshtml", selectedJob];
            };

            Get["/jobs/new"] = _ => {
                return View["job_form.cshtml"];
            };

            Post["/jobs"] = _ => {
                string jobTitle = Request.Form["jobTitle"];
                string company = Request.Form["company"];
                string jobDuties = Request.Form["jobDuties"];
                int yearsHeld = int.Parse(Request.Form["yearsHeld"]);
                Job newJob = new Job(jobTitle, company, jobDuties, yearsHeld);
                List<Job> jobs = Job.GetAll();
                return View["jobs.cshtml", jobs];
            };
        }
    }
}
