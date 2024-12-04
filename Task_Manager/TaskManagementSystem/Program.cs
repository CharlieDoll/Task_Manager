// Step 1: Using Directives
using System;
using System.Collections.Generic;

// Step 2: Class Definitions
public class User
{
    public string Username { get; set; }
    public string Password { get; set; }

    public User(string username, string password)
    {
        Username = username;
        Password = password;
    }
}

public class TaskItem
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Status { get; set; } = "To Do";

    public TaskItem(string title, string description)
    {
        Title = title;
        Description = description;
    }

    public void UpdateStatus(string newStatus)
    {
        Status = newStatus;
    }
}

// Step 3: Main Program Class
class Program
{
    static List<User> users = new List<User>();
    static List<TaskItem> tasks = new List<TaskItem>();

    static void Main(string[] args)
    {
        SeedData(); // Optional, add some test data

        Console.WriteLine("Welcome to Task Management System!");

        // Simple login flow
        Console.Write("Enter username: ");
        string username = Console.ReadLine();
        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        User currentUser = AuthenticateUser(username, password);
        if (currentUser == null)
        {
            Console.WriteLine("Invalid credentials.");
            return;
        }

        Console.WriteLine($"Welcome, {currentUser.Username}!");
        ShowMainMenu();
    }

    static void ShowMainMenu()
    {
        while (true)
        {
            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Update Task");
            Console.WriteLine("4. Delete Task");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    ViewTasks();
                    break;
                case "3":
                    UpdateTask();
                    break;
                case "4":
                    DeleteTask();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid option, try again.");
                    break;
            }
        }
    }

    static void AddTask()
    {
        Console.Write("Enter task title: ");
        string title = Console.ReadLine();
        Console.Write("Enter task description: ");
        string description = Console.ReadLine();

        tasks.Add(new TaskItem(title, description));
        Console.WriteLine("Task added successfully.");
    }

    static void ViewTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks found.");
            return;
        }

        foreach (var task in tasks)
        {
            Console.WriteLine($"\nTitle: {task.Title}\nDescription: {task.Description}\nStatus: {task.Status}\n");
        }
    }

    static void UpdateTask()
    {
        Console.Write("Enter task title to update: ");
        string title = Console.ReadLine();

        var task = tasks.Find(t => t.Title == title);
        if (task == null)
        {
            Console.WriteLine("Task not found.");
            return;
        }

        Console.Write("Enter new status (To Do, In Progress, Done): ");
        string newStatus = Console.ReadLine();
        task.UpdateStatus(newStatus);
        Console.WriteLine("Task updated successfully.");
    }

    static void DeleteTask()
    {
        Console.Write("Enter task title to delete: ");
        string title = Console.ReadLine();

        var task = tasks.Find(t => t.Title == title);
        if (task == null)
        {
            Console.WriteLine("Task not found.");
            return;
        }

        tasks.Remove(task);
        Console.WriteLine("Task deleted successfully.");
    }

    static User AuthenticateUser(string username, string password)
    {
        return users.Find(user => user.Username == username && user.Password == password);
    }

    static void SeedData()
    {
        users.Add(new User("admin", "password"));
        tasks.Add(new TaskItem("Sample Task", "This is a sample task."));
    }
}
