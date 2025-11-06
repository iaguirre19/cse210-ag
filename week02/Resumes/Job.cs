namespace Resumes
{
    public class Job
    {
        public string _company;
        public string _jobTitle;
        public int _startYear;
        public int _endYear;

        public string DisplayJobInformation()
        {
            if (_endYear == 0)

            {
                return ($"{_company} ({_jobTitle}) {_startYear}-Present");
            } else
            {
                return ($"{_company} ({_jobTitle}) {_startYear}-{_endYear}");
            }

        }
    }
}