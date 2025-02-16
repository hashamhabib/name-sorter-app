# Name Sorter App

## Description

The **Name Sorter App** is a .NET Core console application that reads a list of names from a file, sorts them first by last name and then by given names, and outputs the sorted list both to the console and to a new file named `sorted-names-list.txt`.

## Project Structure

```
name-sorter-app/
│── .gitignore
│── README.md
│── name-sorter-app.sln
│── src/
│   └── name-sorter-app/
│       ├── NameSorter.cs
│       ├── Program.cs
│       ├── name-sorter-app.csproj
│── tests/
│   └── name-sorter-app.Tests/
│       ├── UnitTest1.cs
│       ├── name-sorter-app.Tests.csproj
│── unsorted-names-list.txt
```

## Features

- Reads a list of names from a specified input file.
- Sorts names based on last name, then given names.
- Outputs sorted names to the console.
- Saves the sorted names to a file.
- Follows SOLID principles for clean code design.
- Includes unit tests for validation.

## Prerequisites

- .NET Core SDK (version 6.0 or later)

## Installation

1. Clone the repository:
   ```sh
   git clone <repository_url>
   cd name-sorter-app
   ```
2. Restore dependencies:
   ```sh
   dotnet restore
   ```
3. Build the project:
   ```sh
   dotnet build src/name-sorter-app
   ```

## Usage

Run the application by providing the path to an input file containing names:

```sh
   dotnet run --project src/name-sorter-app <input-file-path>
```

Example:

```sh
   dotnet run --project src/name-sorter-app unsorted-names-list.txt
```

### Expected Output

If the input file `unsorted-names-list.txt` contains:

```
Janet Parsons
Vaughn Lewis
Adonis Julius Archer
Shelby Nathan Yoder
```

The console output and `sorted-names-list.txt` will contain:

```
Adonis Julius Archer
Vaughn Lewis
Janet Parsons
Shelby Nathan Yoder
```

## Unit Testing

Unit tests are available in the `tests/name-sorter-app.Tests` project.
To run tests, navigate to the project root directory and execute:

```sh
   dotnet test tests/name-sorter-app.Tests
```

This will execute all test cases and display results in the console.

## License

This project is open-source and available under the MIT License.

## Author

HASHAM HABIB
