# ETL Processing with SQL

## Control Flows

SQL server integration services provide three different types of control flows :

1. Tasks : They provide functionality.
2. Containers : That provide structures in packeges.
3. Precedence Constraints : They connect executables, containers, and tasks into an ordered control flow.

### Tasks

### Execute Process Task

It runs business application or batch file as a part of SSIS package. Custome log enteries are available for this task. For example, you can use the Execute Process task to expand a compressed text file. Then the package can use the text file as a data source for the data flow in the package.

### Expression Task

The Expression Task creates and evaluates expressions that set variable values at runtime, using the Expression Builder. The expression language includes functions and operators. 

The function expressions includes Mathematical function, String function, Date and Time function and System function. The operator that expression language provides are Cast, Add, SUbtract, Divide, Logical, Equal, Unequal, Conditional etc.

### File System Task

This task performs operation on files and directories in the file system. For example, by using the File System task, a package can create, move, or delete directories and files. All file system task use source, which can be a file or a directory. The source can be specified by using a File connection manager that points to the directory or file or by providing the name of a variable that contains the source path. The operations that copy and move file and directories and rename files use a destination and a source. The destination is specified by using a File connection manager or a variable. File system task operations can be configured to permit overwriting of destination files and directories. The operation that creates a new directory can be configured to use an existing directory that has the specified name instead of failing when the directory already exists.

### FTP Task

The FTP task downloads and uploads data files and manages directories on servers. For example, a package can download data files from a remote server or an Internet location as part of an Integration Services package workflow. 

### Script Task

This task provides code to perform functions that are not available in the built-in tasks and transformations that SQL Server Integration Services provides. Script task can also be used to access data by using other technologies that are not supported in built-in connection type. For exampe, a script can use Active Directory Service Interfaces (ADSI) to access and extract user names from Active Directory.

### Hadoop File-System Task

The Hadoop File System Task enables an SSIS package to copy files from, to, or within a Hadoop cluster.

### Hadoop Hive Task

Use the Hadoop Hive Task to run Hive script on a Hadoop cluster.



### Containers


### For Loop Containers

### ForEach Loop Containers

### Sequence Containers

### Precedence Constraints



## Data Flow

## Integration Service Logging



