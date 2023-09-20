using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    // Interfaces just define the methods available to the class that implements them
    public interface ICommanderRepo
    {
        // Give me a list of commands of all of our command objects
        IEnumerable<Command> GetAppCommands();
        Command GetCommandById(int id);
    }
}