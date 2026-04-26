using System.Collections.Generic;

namespace MyBlazorApp.Services
{
public class AttendanceService
{
private List<string> attendees = new List<string>();

    public void AddAttendee(string name)
    {
        if (!string.IsNullOrWhiteSpace(name))
        {
            attendees.Add(name);
        }
    }

    public List<string> GetAttendees()
    {
        return attendees;
    }

    public int GetTotalAttendees()
    {
        return attendees.Count;
    }
}

}
