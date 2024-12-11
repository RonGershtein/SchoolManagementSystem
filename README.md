# SchoolManagementSystem
School Management System
C# Object-Oriented Programming Project – School Management System
This project demonstrates the principles of object-oriented programming (OOP) in C# through a hierarchical and functional implementation of a comprehensive school management system.

System Overview
The project's Classes are structured hierarchically as follows:

Loading Screen (FormLoadingScreen):
The loading bar progression is implemented using a Timer Tick event with an interval of 50 milliseconds. The bar updates until reaching 100%, after which the login screen is displayed.

Login Screen:
The login process authenticates users against the Teacherlist (Program.myschool.Teacherlist) using polymorphic methods like getUsername() and getPassword() to validate the credentials. This supports different user roles such as Teacher, School Manager, and Housekeeper.

Object State Persistence:
The system uses Serialization to save the current state of objects and allow restoration. Users can reload saved data to manage multiple school statuses within the same system.

Main Window:
This is the system's central interface, where access to additional windows depends on the user's role and permissions.

Key Features by Window
Staff Management Window:
Displays either the list of teachers or students based on user selection.

Student Management Window:
Enables adding grades for subjects (Hebrew, English, Math), absences, and disturbances. The average grades for each subject and overall are calculated automatically.

Faults Management Window:
Managed by the Housekeeper, this window allows adding faults with descriptions and locations, removing resolved faults, and exporting the fault list as a PDF.

School Expense Analysis Window:
Consolidates the following data:

Number of teachers and students.
Total teacher salaries.
Student-related expenses (security, trips, etc.).
Overall expenses.
The salary calculation uses polymorphism with the virtual method setSalary() overridden by derived classes for TeacherType. For example:

Teacher: Base salary + years of experience * 250 + bonus for degrees.
Housekeeper: Base salary * experience ^ 0.25.
School Manager: Base salary + managerial bonus + degree multiplier.
Technologies and Concepts Used
Object-Oriented Programming: Encapsulation, inheritance, polymorphism.
Serialization: Saving and loading object states.
Custom User Roles and Permissions.
Dynamic Data Calculations and Visualization.
This project showcases advanced OOP design and a user-friendly interface for managing school operations.
