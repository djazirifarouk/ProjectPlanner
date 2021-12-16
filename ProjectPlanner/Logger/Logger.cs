using System;

namespace ProjectPlanner.Logger;

public class Logger
{
    private string _docPath;
    public Logger()
    {
        _docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
    }

    public void LogAction(int projectId, string Action)
    {
        DateTime now = DateTime.Now;
        using (StreamWriter outputFile = new StreamWriter(Path.Combine(_docPath, $"{projectId.ToString()}.txt"), true))
        {
            outputFile.WriteLine($"{now.ToString()} : {Action}");
        }
    }

    public void LogProjectCreation(int projectId, string username, string projectName)
    {
        string log = $"{username} created project {projectName} with Id {projectId}";
        LogAction(projectId, log);
    }

    public void LogColumnCreation(int projectId, string username, string columnName)
    {
        string log = $"{username} created column '{columnName}'";
        LogAction(projectId, log);
    }

    public void LogTicketCreation(int projectId, string username, string ticketName, string columnName)
    {
        string log = $"{username} created ticket '{ticketName}' in column '{columnName}'";
        LogAction(projectId, log);
    }

    public void LogTagCreation(int projectId, string username, string tagName)
    {
        string log = $"{username} created tag '{tagName}'";
        LogAction(projectId, log);
    }

    public void LogAddingTagToTicket(int projectId, string username, string tagName, string ticketName)
    {
        string log = $"{username} added tag '{tagName}' to ticket '{ticketName}'";
        LogAction(projectId, log);
    }

    public void LogMovingTicketBetweenCols(int projectId, string username, string previousCol, string newCol, string ticketName)
    {
        string log = $"{username} moved ticket '{ticketName}' from column '{previousCol}' to '{newCol}'";
        LogAction(projectId, log);
    }

    public void LogTicketRemoval(int projectId, string username, string ticketName)
    {
        string log = $"{username} removed ticket '{ticketName}'";
        LogAction(projectId, log);
    }

}