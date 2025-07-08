# 🏛️ Architect Arithmetic

A simple C# console application that estimates the cost of flooring materials for architectural floor plans using geometric approximations.

## 📐 Overview

This project is designed to practice core C# skills including:

- Method creation and use
- Mathematical operations
- Modular programming
- Console application structure using the .NET CLI

The application approximates the layout of famous buildings (like the Pantheon) using simple geometric shapes and calculates the material cost based on a fixed price per square meter.

---

## 📦 Project Structure

ArchitectArithmetic/  
├── ArchitectArithmetic.csproj  
└── Program.cs  

---

## 🚀 How to Run

### ✅ Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) installed
- Bash terminal (Linux, macOS, or WSL on Windows)

### ▶️ Run in Terminal

## Create and enter the project folder
dotnet new console -o ArchitectArithmetic  
cd ArchitectArithmetic

## Replace the Program.cs with your own or paste the full code

## Run the application

💡 Example Output  
The total cost for the Pantheon: ₤182279.91

🧮 Area Formulas  
- Shape	Formula   
- Circle	π × radius²   
- Rectangle	length × width   
- Triangle	(base × height) ÷ 2   

📁 Methods in Program   
- double Circle(double radius)   
- double Rect(double length, double width)   
- double Triangle(double bottom, double height)   
- double CalculateTotalCost()   

🔧 Possible Extensions  
- Accept user input for custom floor plans   
- Allow material selection (tile, marble, etc.)  
- Add UI with .NET MAUI or WPF  
- Store multiple building blueprints with different formulas  

🧠 Learning Objectives    
- Understanding and applying methods  
- Using Math class and constants like Math.PI  
- Practicing control of program flow  
- Writing clean and modular code in C#  
