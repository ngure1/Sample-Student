## Sample student management system to test how the repo will be managed

### INSTALLATION
1. Fork the repo and clone your fork
2. Assuming you have docker installed ...run the following comand to pull the mysql image
```bash
  docker pull mysql
```
3. After the download is complete run the following command to start an instance of the image
```bash
docker run --name student-test-server -e MYSQL_ROOT_PASSWORD=default123 -p 33066:3306 -d mysql
```
4. Ensure the container ``student-test-server`` is running and connect it to either mysql workbench or your favourite software to run the sql commands.
#### **NB:Make sure you use the server as localhost, port as 33066, username as root and password as default123**
5. After connecting it successfully open the [db_config_commands](./db_config_commands/) file from the repo you cloned and run them in the software you connected the server to.
**NB:There are two .sql files run both of them**
6. Open the project in your terminal and run the following commands:
##### To restore the dependencies
```bash
dotnet restore
```
##### To build the project. 
```bash
dotnet build
```

7. Now open the solution in vusual studio and run it...hopefully it works