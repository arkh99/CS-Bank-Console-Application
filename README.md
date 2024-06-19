# CS-Bank-Console-Application
A banking console application that lets the user view accounts, create new accounts, and deposit and withdraw money.

Key Features
Account Management
Create Account

Users can create a new bank account by providing the owner's name and an initial deposit.
The initial balance must be at least the minimum initial balance of 100.
Each account is assigned a unique account number.
View Accounts

Users can view a list of all existing accounts.
Displays account number, owner's name, and current balance.
If no accounts exist, a message is displayed indicating that no accounts are found.
Transactions
Deposit

Users can deposit money into an account by providing the account number and deposit amount.
The deposit amount must be a positive double.
Updates the balance of the specified account.
Withdraw

Users can withdraw money from an account by providing the account number and withdrawal amount.
The withdrawal amount must be a positive double and less than or equal to the current balance.
Updates the balance of the specified account.
User Interaction
Console Menu

The application prompts users to choose between the following operations: "View accounts", "Create an account", "Deposit", "Withdraw", or "Exit".
After each operation, the application returns to the main menu for further actions.
Input Validation

Ensures valid input for account creation, deposits, and withdrawals.
Validates that the account number exists before performing transactions.
Ensures names are not empty and monetary amounts are valid doubles.
