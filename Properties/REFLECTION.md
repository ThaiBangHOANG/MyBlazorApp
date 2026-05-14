Reflection on Using Microsoft Copilot in InventoryHub
Introduction

During the development of the InventoryHub application, Microsoft Copilot played a significant role in helping me build, debug, optimize, and refine the integration between the Blazor front-end and the ASP.NET Core Minimal API back-end.

Activity 1 – Generating Integration Code

Copilot assisted me in generating the initial integration code between the Blazor client and the Minimal API server. It suggested how to use HttpClient to call the API endpoint and deserialize JSON responses into strongly typed C# classes.

Copilot also helped improve code readability by suggesting cleaner async/await patterns and better organization of the Product model classes.

What I learned:

How Blazor communicates with APIs using HttpClient
How JSON deserialization works in .NET
How to structure asynchronous API calls properly
Activity 2 – Debugging Integration Issues

Copilot was extremely useful when debugging API route mismatches, CORS errors, and malformed JSON responses.

It suggested:

Updating the API route from /api/products to /api/productlist
Adding CORS middleware configuration
Implementing try-catch blocks for robust error handling

These suggestions helped resolve communication issues between the client and server quickly.

What I learned:

The importance of correct API routing
How browser security policies affect APIs
Best practices for handling exceptions in Blazor applications
Activity 3 – Creating and Managing JSON Structures

Copilot helped generate nested JSON structures that included category information for each product.

It also suggested improvements such as:

Using strongly typed classes
Structuring nested JSON objects properly
Using case-insensitive deserialization

This improved the maintainability and scalability of the application.

What I learned:

How nested JSON structures work
How APIs exchange structured data
How to map JSON to C# objects effectively
Activity 4 – Optimizing Performance

Copilot provided several performance optimization suggestions, including:

Reducing redundant API calls
Using OnInitializedAsync efficiently
Adding memory caching services
Refactoring repetitive code

These optimizations improved responsiveness and reduced unnecessary server processing.

What I learned:

How caching improves performance
Why minimizing API calls matters
How clean code improves maintainability
Challenges Encountered

One challenge was configuring the correct API URL and ensuring the client could communicate with the server without CORS issues.

Another challenge involved handling malformed JSON and matching the JSON structure with the Product model classes.

Copilot helped solve these issues by suggesting middleware configuration, exception handling, and improved deserialization logic.

Conclusion

Overall, Microsoft Copilot significantly improved my development workflow by helping generate code faster, debug integration issues, structure JSON responses, and optimize performance.

The experience taught me how AI-assisted development tools can improve productivity while also helping developers learn modern full-stack development practices.