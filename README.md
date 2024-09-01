# Selenium Automation Template in C#

## Project Status

**In Progress...**

## Overview

This project is aimed at creating a robust and reusable template for Selenium automation in C#. The template provides a solid foundation for automating web application testing, following best practices in software engineering and test automation.

## Table of Contents

- [Project Status](#project-status)
- [Overview](#overview)
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Configuration](#configuration)
- [Usage](#usage)
- [License](#license)

## Features

- **Modular Architecture**: Easily extendable with page object models and utility classes.
- **Configuration Management**: Centralized configuration using `ConfigurationBuilder`.
- **Cross-Browser Support**: Easily adaptable to run tests on different browsers.
- **CI/CD Ready**: Integrates seamlessly with CI/CD pipelines for automated testing.
- **Reporting**: Generate detailed test reports (to be implemented).

## Technologies Used

- **C#**: The primary language for test scripts.
- **Selenium WebDriver**: For interacting with and automating web browsers.
- **NUnit**: For structuring and running tests.
- **ConfigurationBuilder**: For managing configuration settings.
- **ChromeDriver**: For automating tests on Google Chrome.

## Prerequisites

Before you begin, ensure you have met the following requirements:

- **.NET SDK**: [.NET 5.0 or later](https://dotnet.microsoft.com/download/dotnet/5.0)
- **Visual Studio 2019** or later with NUnit plugin.
- **Chrome Browser**: Ensure the latest version is installed.
- **ChromeDriver**: The version should match your Chrome browser.

## Installation

To set up the project locally, follow these steps:

1. **Clone the repository**:

   ```bash
    git clone https://github.com/AmineB2301/SeleniumCSharpPageObjectModelTemplate.git

   ```

2. **Navigate to the project directory**:

   ```bash
   cd SeleniumCSharpPageObjectModelTemplate

   ```

3. **Restore NuGet packages**:

   ```bash
   dotnet restore

   ```

4. **Open the project in Visual Studio**:

   Open the SeleniumCSharpPageObjectModelTemplate.sln solution file.

## Configuration

Configuration settings are managed through a appsettings.json file. This file includes settings such as the base URL for testing and credentials.

**_Example appsettings.json:_**

```bash
{
   "baseUrl": "https://demowebshop.tricentis.com/",
}
```

Place the appsettings.json file in the root of the project.

## Usage

**_Running Tests:_**

To execute the tests:

- Open Visual Studio.

- Navigate to the Test Explorer.

- Select and run the tests.

## License

This project is licensed under the [Non-Commercial License Agreement](LICENSE).
