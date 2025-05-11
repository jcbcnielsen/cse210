public class Resume
{
    // Keep track of a person's name and a list of their jobs.
    public string _name;
    public List<Job> _jobs = new List<Job>();

    // Display the name, followed by each of the jobs.
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job j in _jobs)
        {
            j.DisplayDetails();
        }
    }
}