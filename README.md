# Enterprise_Standard_ERP_Application


The Application provide storing, editing and managing functionalities for different hierarchy of an Enterprise.<br/>
The controls are laid between Administrator, Head of Department and Employee with differential access priorities.
</br>
The .Net Framework is use to create the application which can operate in Windows Desktop.
</br>The SQL Server Express is use to set up the database

## Control Workflow :
<b>User View Control:</b></br>
Employee/ Worker can only view his/her data which had been recorded in the database, whereas the Head of Department have the rights to view the data of all the employees under their division but no access to other members of the Enterprise( including the Admin, other employees and other HOD's ), but the situtaion varies for Admin where he/she enjoys completed control over all the data of all the memeber of the Enterprise.

<b>Edit Control:</b></br>
Admin have the authorisation to modify, add and delete the records from the Database which contain the data of all members of Enterprise. Head of Department have controlled power over the employees under their command/divisio where they can modify the data related to their role. The Employee can only modify their personal information. 

<b>Synopsis :</b></br>
<img src="Screenshot (2).png" width="400">
</br>
<img src="Screenshot (3).png" width="400">

## Code snippet :

<b> Connection between the SQL Server and VB.Net :</b>
```c#
 Import System.Data.SqlClient 
 ```
 Dim <i>Variable_Name</i> As New SqlConnection("server=<i>server_name</i>, database=<i>database_name</i>, integrated security=SSPI ")

