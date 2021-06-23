# Miscellaneous
## Azure Container Instances
- Creating a MySQL container
  ```
  sudo docker run --name=mysql-instance -p 3307:3306 --restart on-failure -d -e MYSQL_ROOT_PASSWORD=Azure@123 mysql
  ```
 - The following statement can be used to install the MySQL client
 ```
 sudo apt install -y mysql-client
 ```
 - Connect to the MySQL container
  ```
  mysql -h 127.0.0.1 -P 3307 -uroot -pAzure@123
  mysql> create database appdb;
  mysql> use appdb;
  mysql> \q
  ```

- Docker-Compose
  - Setup [Docker Compose](setup-docker-compose.md)
  - Refer: 104-Docker-Compose-Deploying-an-appplication-and-database-service.zip
    - Commands:
```
wget https://raw.githubusercontent.com/atingupta2005/Azure-Developer/master/10-Miscellaneous/04-Azure-Container-Instances/104-Docker-Compose-Deploying-an-appplication-and-database-service.zip
unzip 104-Docker-Compose-Deploying-an-appplication-and-database-service.zip
cd mysqlproject/
cat docker-compose.yml
cat Dockerfile
sudo docker-compose up -d
curl localhost:5000
```
