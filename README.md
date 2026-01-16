Step 1: Project Setup (Local)

cd /d/Padhai/bridgeLabz
mkdir BillingSystem
cd BillingSystem
touch Program.cs README.md
dotnet new sln -n BillingSystem

Step 2: Initialize Git

git init
dotnet new gitignore
in main branch
added initial billing code in file(Program.cs)
git add .
git commit -m "Initial project structure and basic billing program"


Step 3: Push to GitHub

git remote add origin https://github.com/Vedant-Pandey563/BillingSystem.git
git push -u origin main


Step 4: Create a Feature Branch

git checkout -b feature/add-tax
in featire branch 
Update billing logic
git add Program.cs
git commit -m "Add tax calculation"
git push -u origin feature/add-tax


Step 5: Simulate a Team Change
git checkout main
now in main branch 
Modify billing logic (add discount) in the program.cs file
git add Program.cs
git commit -m "Add discount logic to billing output"
git push origin main


Step 6: Merge Feature Branch
git merge feature/add-tax
Resolve merge conflict , open program.cs in main branch using nano
again merge 
git add Program.cs
git commit -m "Merge feature/add-tax and resolve billing conflict"
git push origin main
