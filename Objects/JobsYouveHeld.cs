using System.Collections.Generic;

namespace JobsYouveHeld.Objects
{
    public class Job
    {
        private string _jobTitle;
        private string _company;
        private string _jobDuties;
        private int _yearsHeld;
        private int _id;
        private static List<Job> _instances = new List<Job> {};

        public Job(string jobTitle, string company, string jobDuties, int yearsHeld)
        {
            _jobTitle = jobTitle;
            _company = company;
            _jobDuties = jobDuties;
            _yearsHeld = yearsHeld;
            _instances.Add(this);
            _id = _instances.Count;
        }

        public void SetJobTitle(string JobTitle)
        {
            _jobTitle = JobTitle;
        }

        public string GetJobTitle()
        {
            return _jobTitle;
        }
        public void SetCompany(string Company)
        {
            _company = Company;
        }

        public string GetCompany()
        {
            return _company;
        }
        public void SetJobDuties(string JobDuties)
        {
            _jobDuties = JobDuties;
        }

        public string GetJobDuties()
        {
            return _jobDuties;
        }
        public void SetYearsHeld(int YearsHeld)
        {
            _yearsHeld = YearsHeld;
        }

        public int GetYearsHeld()
        {
            return _yearsHeld;
        }

        public static Job Find(int SearchID)
        {
            return _instances[SearchID - 1];
        }
        public int GetId()
        {
            return _id;
        }

        public static List<Job> GetAll()
        {
            return _instances;
        }
    }
}
