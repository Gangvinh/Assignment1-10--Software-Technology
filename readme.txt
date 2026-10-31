SMART TICKETING SYSTEM — ASSIGNMENT 1 PACKAGE

PACKAGE CONTENTS
- 524H0205_NguyenLeQuangVinh.docx: working report. Review its remaining placeholders and evidence gaps before submission.
- LabGroupAssignment1.xlsx: team workbook with clarification Q&A, requirements, use cases, artifact/consistency trackers, and marking sheets.
- LabGroupAssignment1.pdf: supplied assignment brief.
- diagrams/: editable Mermaid and PlantUML target-system design sources; not every planned service or device is implemented in the classroom demo.
- visuals/: diagram exports and six UI mockups (welcome, route, payment, QR payment, successful ticket, unsuccessful payment).
- Picture/: additional assignment diagram images.
- prototype/: C# Windows Forms demo and SQL Server scripts.

RUN THE PROTOTYPE WITH SQL SERVER
The app defaults to SQL Server LocalDB `(localdb)\MSSQLLocalDB`, database `SmartTicketing_VSRun`, using Windows authentication. That database must exist and contain the prototype schema and seed routes.

1. If needed, create the database in LocalDB, then run prototype/schema.sql followed by prototype/seed.sql in that database.
2. Open prototype/SmartTicketing.slnx or prototype/SmartTicketing.csproj in Visual Studio and run the project.
3. To use a different SQL Server, set SMARTTICKETING_SQL to a connection string before launching. Example:
   Server=localhost;Database=SmartTicketing;Trusted_Connection=True;TrustServerCertificate=True

Set SMARTTICKETING_SQL to `offline` to use sample routes without SQL. Offline purchases are simulated in memory and are not saved.

DEMO BEHAVIOR AND LIMITS
- The interface is English-only and supports destination selection, quantity 1–10, Card or QR Wallet, and simulated Approved, Declined, or Unknown/timeout outcomes.
- Approved QR-wallet demos display a scannable QR containing demo order details. Scanning it does not initiate a bank or wallet payment; confirm the selected simulated outcome in the app.
- Declined or Unknown/timeout outcomes go directly to the unsuccessful screen and issue no ticket QR.
- Approved purchases save order, payment, and ticket records when SQL is configured. The success screen displays a scannable QR encoding the ticket code.
- The prototype currently supports destination and quantity only; ticket-type, discount, and bilingual requirements remain unimplemented.
- Payment is simulated. The demo does not connect to a live gateway, store card details, print physical tickets, or validate tickets at a gate.
- The project targets .NET 8 Windows Forms and uses Microsoft.Data.SqlClient 6.1.2 and QRCoder 1.8.1. The project can roll forward to a later installed .NET runtime.

VERIFICATION RECORD
The project was built and the LocalDB schema/routes were inspected on 31 Oct 2026. Earlier reported scenarios cover approved, declined, and unknown/timeout order persistence; rebuild and relaunch after source changes. The current project build succeeds with 0 warnings and 0 errors.

SUBMISSION ITEMS TO CONFIRM
- Confirm team member contributions and assumptions with the instructor.
- The report still needs genuine repository/collaboration evidence and any required Visual Studio screenshots.
- The report identifies Visual Studio engineering/Code Map evidence as unavailable; do not claim it was supplied.
- Add real repository or design-tool URLs only if the team has them.


