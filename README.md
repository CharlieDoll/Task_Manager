# Task_Manager
Task Management System (C#)

## Project Overview
The **Task Management System** is a console-based application developed in C# that allows users to manage their tasks. It includes user authentication and CRUD (Create, Read, Update, Delete) operations for tasks. This project is a great way to learn the fundamentals of C#, including Object-Oriented Programming (OOP), user input handling, and basic data storage techniques. It can also serve as a portfolio project to demonstrate practical programming skills.

## Features
- **User Authentication**: Users must log in to access the task management features.
- **Task Management**: Users can add, view, update, and delete tasks.
- **Task Status**: Tasks can have statuses like "To Do", "In Progress", or "Done".
- **Data Persistence**: User and task information is stored in memory (can be expanded to use file or database storage).

## Technologies Used
- **C#**: Core language used for developing the application.
- **.NET SDK**: Framework used for building and running the C# application.
- **Visual Studio Code**: Recommended code editor for development.

## How to Run the Project
### Prerequisites
- **.NET SDK**: Make sure you have .NET SDK installed. You can download it from [the official .NET website](https://dotnet.microsoft.com/download).
- **Visual Studio Code**: Install Visual Studio Code for an optimal coding environment. You will also need the C# extension for IntelliSense and debugging.

### Steps to Run
1. **Clone the Repository**
   ```sh
   git clone <repository-url>
   cd TaskManagementSystem
   ```

2. **Build and Run**
   - Open the terminal in the project folder and run the following command to build and run the project:
     ```sh
     dotnet run
     ```

3. **Login**
   - Use the default credentials to log in:
     - **Username**: `admin`
     - **Password**: `password`

4. **Main Menu**
   - After logging in, you can add tasks, view existing tasks, update task statuses, or delete tasks.

## Usage Instructions
- **Add Task**: Create a new task by providing a title and description.
- **View Tasks**: View all existing tasks, including their title, description, and status.
- **Update Task**: Update the status of an existing task to "To Do", "In Progress", or "Done".
- **Delete Task**: Remove a task from the system.

## Future Improvements
- **Database Integration**: Implement a database to store users and tasks for persistent data storage.
- **User Registration**: Add functionality to allow users to create their own accounts.
- **GUI**: Develop a graphical user interface using WPF (Windows Presentation Foundation) to make the application more user-friendly.

## Learning Objectives
- Understand **Object-Oriented Programming** (OOP) concepts such as classes, properties, and methods.
- Learn how to work with **collections** (like lists) to manage data.
- Practice handling **user input** and **console output** effectively.
- Gain experience in building a simple **authentication system**.

## Contribution
If you would like to contribute, please feel free to fork the repository and submit a pull request. Any improvements or suggestions are welcome.

## License
This project is open-source and available under the MIT License. Feel free to use, modify, and distribute it as you like.


