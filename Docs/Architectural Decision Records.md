# Architectural Decision Records 
- https://adr.github.io/

## Tech Stack
The project is initialized with the "React and ASP.NET Core" template from Visual Studio 2022 targeting .NET 8.
React and Asp.NET Core project template
- .NET 8 C# [API]
- React v ? [client]
- Vite [client]

Tailwind Elements React
- Tailwind CSS
- TW Elements React for Vite
    https://tw-elements.com/docs/react/getting-started/quick-start/#vite


## Development Tools
- Visual Studio 2022 (Community edition or better)
- Visual Studio Code
 Plug-ins
 * Tailwind CSS IntelliSense
    Fixes "Unknown @ Rule" warnings in CSS.  Requires additional configuration.
    https://www.codeconcisely.com/posts/tailwind-css-unknown-at-rules/
 * SonarLint
    Code quality linter
 * Gitlens
    Source control tools
 * ToDo Tree
    Inline "TODO" tool
- Node.js v22.1.0

## Project Initiation
Create React and Asp.NET Core project template
`npm install -D tailwindcss postcss autoprefixer`
`npm install tw-elements-react`