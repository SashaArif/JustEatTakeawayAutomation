Project Overview
	Built as an NUnit Test Project in Visual Studio.
	Designed using the Page Object Model (POM) for better maintainability and reusability.

Project Structure
	Functions → Contains methods that handle application interactions.
	Locators → Stores all element locators with their types (XPath, CSS, ID, etc.).
	WebDriver File → Handles browser selection and driver initialization.

	Execution Class
		Inherits from the WebDriver class.
		Executes test cases using the NUnit framework.

	Test Cases & Test Data → Written inside NUnit test classes for validation.

Test Execution
	Tests can be executed via Test Explorer in Visual Studio.
	All available test cases are displayed in Test Explorer after build.