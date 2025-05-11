public class Job
{
    // Keep track of the company, job title, start year, and end year.
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    // Display the job information
    public void DisplayDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}