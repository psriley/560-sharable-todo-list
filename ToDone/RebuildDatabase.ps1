Param(
   [string] $Server = "(localdb)\MSSQLLocalDb",
   [string] $Database = "ToDone"
)

# This script requires the SQL Server module for PowerShell.
# The below commands may be required.

# To check whether the module is installed.
# Get-Module -ListAvailable -Name SqlServer;

# Install the SQL Server Module
# Install-Module -Name SqlServer -Scope CurrentUser

$CurrentDrive = (Get-Location).Drive.Name + ":"

Write-Host ""
Write-Host "Rebuilding database $Database on $Server..."

<#
   If on your local machine, you can drop and re-create the database.
#>
& ".\Scripts\DropDatabase.ps1" -Database $Database
& ".\Scripts\CreateDatabase.ps1" -Database $Database

<#
   If on the department's server, you don't have permissions to drop or create databases.
   In this case, maintain a script to drop all tables.
#>
#Write-Host "Dropping tables..."
#Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ToDoneApp\SQL\Tables\DropTables.sql"

Write-Host "Creating schema..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ToDoneApp\SQL\Schemas\ToDone.sql"

Write-Host "Creating tables..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ToDoneApp\SQL\Tables\ToDone.PrivacyLevel.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ToDoneApp\SQL\Tables\ToDone.User.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ToDoneApp\SQL\Tables\ToDone.FriendsUser.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ToDoneApp\SQL\Tables\ToDone.Task.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ToDoneApp\SQL\Tables\ToDone.TaskComment.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ToDoneApp\SQL\Tables\ToDone.Groups.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ToDoneApp\SQL\Tables\ToDone.GroupUser.sql"

Write-Host "Stored procedures..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ToDoneApp\SQL\Procedures\"

Write-Host "Inserting data..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "ToDoneApp\SQL\Data\ToDone.PrivacyLevelData.sql"

Write-Host "Rebuild completed."
Write-Host ""


Set-Location $CurrentDrive
