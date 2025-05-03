# More Then a Hello World App
---

### Purpose
These applications aim to demonstrate a broad range of coding skills in C#, covering mathematical operations, file manipulation, real-time communication, and game logic.  
---
## The Application
---

These applications will run in a terminal environment and go beyond simply displaying "Hello, World!" text.  
The project consists of four distinct applications:

### Applications
-   **Calculator** – Performs addition, subtraction, multiplication, and division on two or more numbers.  
-   **File Manager** – Allows opening, editing, decoding, and encoding of files.  
-   **Live Messenger** – Facilitates real-time communication within the terminal.  
-   **Terminal Video Game** – Creates dynamic, real-time connectivity terminal-based scenarios for interactive gameplay.  

### Additional Activities
Beyond development, the project also includes:  
-   **Diagram Design** – Structuring and visualizing key components.  
-   **Water Flow Process** – Mapping procedural steps for efficient execution.  
-   **CI/CD Methodology** – Showcasing continuous integration and deployment practices.  
-   **Project Notes** – Documenting insights, challenges, and future improvements.  
---
## Waterfall Staging
---

### Planning Stages
- Develop a software application that demonstrates skills in C#, Markdown, Diagramming, Visual Studio Code, and GitHub.
- A math, file, network, and game application are selected for their versatility and overwhelming usefulness in everyday life:
  - **Math**: A simple calculator for adding, subtracting, multiplying, and dividing two numbers or a list of numbers.
      **This app will _not_ follow the OOP standard, demonstrating the advantages of OOP compared to a non-OOP approach.**
  - **File**: Functionality to create, edit, delete, encode, and decode files.
  - **Network**: A simple client-to-host connection that sends a text message using OOP principles, incorporating the file application to encode and decode messages.
  - **Game**: A Space Invaders-style game that allows two-player connectivity, utilizing similar steps from the network component, with an option to encode and decode in an OOP approach.

### Planning Documentation Setup Stages
- The documentation method is a Markdown-style README file for GitHub.
- The document includes:
  - **Purpose**
  - **Application functionality**
  - **Setup and requirements for building the application**
  - **Diagram design of the applications**
  - **Implementation details**
  - **Testing process**
  - **Maintenance and improvements**
  - **Release information**

---
## Requirements
---
### Resources
- The project will be in C#, so we will be using Visual Studio Code.
  1. Downloaded [VSCode](https://code.visualstudio.com/docs/?dv=win32arm64user)
  2. Downloaded [.NET SDK](https://dotnet.microsoft.com/en-us/download)
  3. Downloaded [Git](https://git-scm.com/downloads)
  4. Added VSCode Extensions:
     1. **.NET Extension Pack**  
     2. **C# Dev Kit:** Log in to the Dev Kit to use the resources.  
     3. **Git Extension Pack:** Log in to GitHub to use the resources.  

### Problem/Errors
- An issue occurred when **C# Dev Kit** didn't prompt for login, and attempting to run the debugger resulted in an error prompt not working.
- Resolution run the C# Dev Kit and follow the prompt for setup
  - Step 1: Enter Key Bind ( [Ctrl] + [Shift] + P ) to open VSCode Command and extensions
  - Step 2: Enter or find "Welcome: Open Walkthrough..."
  - Step 3: Enter or find "Get Started With C# Dev Kit"
  - Step 4: Follow Steps-by-steps instructions
  
---
## Design of the applications
---

### Final Design of the Diagram

### Design Sudo Code
`
> Start 0: Output "Hello World!"
> Start 1: Output a request "Input any value or Q/q to Quit"
> Start 2: Get input
> Start 3: If Q/q; Output "Goodbye!" and end application 
> Start 4: Else if continue when any key is entered and send user to MainMenu()


> MainMenu 0: Output a Menu of all Four application and a option to quit
> MainMenu 1: Get input 
> MainMenu 2: If Q/q; Output "Goodbye!" and end application 
> MainMenu 3: Else Continue to Options
> MainMenu 4: (Switch 1): Send user to CalculatorApp() 
> MainMenu 5: (Switch 2): Send user to AllInOneFileApp()
> MainMenu 6: (Switch 3): Send user to MessengerApp()
> MainMenu 7: (Switch 4): Send user to LiveGameApp()
> MainMenu 8: (Switch 5): Error input run MainMenu(recursion)


> Calculator 0: Start While(true) loop
> Calculator 1: Output a Menu of all eight application, return to MainMenu(), and a option to quit
> Calculator 2: Get input
> Calculator 3: If Q/q; Output "Goodbye!" and end application 
> Calculator 4: Else if input to return to main menu the Output "Goodbye!"; Send user to MainMenu()  

> Calculator 4: Else if input equal TwoInput(option) 
> Calculator 5: Else if input equal MultipleInput(option)
>
> Calculator 5: TwoInput(option): Ask for the two inputs
> Calculator 6: TwoInput(Switch 1): Output result for Adding
> Calculator 7: TwoInput(Switch 2): Output result for Subtracting
> Calculator 8: TwoInput(Switch 3): Output result for Multiplying
> Calculator 9: TwoInput(Switch 4): Output result for Dividing
> Calculator 10: TwoInput(option): Output asking to key input anything to continue...
>
> Calculator 11: TwoInput(option): Ask for the multiple inputs 
> Calculator 12: MultipleInput(Switch 5):Output result for Adding
> Calculator 13: MultipleInput(Switch 6):Output result for Subtracting
> Calculator 14: MultipleInput(Switch 7):Output result for Multiplying
> Calculator 15: MultipleInput(Switch 8):Output result for Dividing
> Calculator 16: MultipleInput(option): Output asking to key input anything to continue...
> 
>Calculator 17: Loop Back
`

