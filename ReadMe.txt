The SQL tables and Procedures are in the folder Queries.

The project can be opened in Visual Studio with the GameStoreDatabaseProject.sIn file.
In order to connect the project to a locally made database you need to change a line in App.config.

<connectionStrings>
		<add name="Database" connectionString="Server=(localdb)\MSSQLLocalDb;Database=CIS560;Trusted_Connection=True;" providerName="System.Data.SqlClient"/>
</connectionStrings>

you need to change "Server=(localdb)\MSSQLLocalDb;Database=CIS560; to fit the names of you local Server and Database you made with the quieries