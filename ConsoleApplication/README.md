# DCIT 318 Assignment 1

## Overview
This is a C# console application developed for the DCIT 318 – Programming II course. The application provides three main features, each accessible via a main menu:

1. **Grade Calculator**
2. **Ticket Price Calculator**
3. **Triangle Type Identifier**

---

## Features

### 1. Grade Calculator
- Prompts the user to input a numerical grade (0–100).
- Displays the corresponding letter grade:
  - 90 and above: A
  - 80–89: B
  - 70–79: C
  - 60–69: D
  - Below 60: F
- Validates input to ensure only numbers between 0 and 100 are accepted.

### 2. Ticket Price Calculator
- Prompts the user to enter their age.
- Ticket price logic:
  - Age 12 or younger, or 65 and older: **GHC 7**
  - All others: **GHC 10**
- Validates input to ensure age is a non-negative integer.

### 3. Triangle Type Identifier
- Prompts the user to enter three side lengths.
- Validates that the sides can form a valid triangle (triangle inequality rule).
- Determines and displays the triangle type:
  - **Equilateral**: All sides equal
  - **Isosceles**: Two sides equal
  - **Scalene**: All sides different

---

## How to Run
1. Open the solution in Visual Studio or your preferred C# IDE.
2. Build the solution.
3. Run the application. The main menu will appear in the console.
4. Select a feature by entering its corresponding number.
5. Follow the on-screen prompts for each feature.

---

## Project Structure
```
ConsoleApplication/
├── Program.cs                   // Main menu and navigation
├── GradeCalculator.cs           // Grade Calculator logic
├── TicketPriceCalculator.cs     // Ticket Price Calculator logic
├── TriangleTypeIdentifier.cs    // Triangle Type Identifier logic
├── ConsoleApplication.csproj    // Project file
└── README.md                    // Project documentation
```

---

## Author
- theGeniusDennis

## License
This project is for educational purposes only.
