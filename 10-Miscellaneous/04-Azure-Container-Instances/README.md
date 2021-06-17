# Miscellaneous
## Azure Container Instances
- Azure Container Instances - Container Groups
  - A collection of containers that get scheduled on the same host machine
  - Container in the same container group share the resources, local network and storage volumes
  - Deployment of the container group can be done via a Resource Manager template YAML file

- Building a Custom MySQL Image
  - Refer [Dockerfile](Dockerfile)
  - Refer 01.sql
  - Run below commands
  ```
  docker build -t customsql .
  docker run -d -p 13306:3306 --name appsql customsql
  docke exec -it appsql bash
  # mysql -u root -p Azure@123456
  mysql> use appdb
  mysql> select * from Course
  mysql> \q
  # exit
  docker tag customsql appregistry100012.azurecr.io/customsql
  az login
  az acr login --name <registy name>
  docker push appregistry100012.azurecr.io/customsql
  ```
  - Refer to repositories in ACR

- Azure Container Instances - Container Groups - Container Registry
  - Refer: containersdb.yaml
  - Run below commands
  ```
  az container create --resource-group new-grp --file containersdb.yml
  ```
  - Refer ACI - AppGroup
  - Open container and connect

- Azure Container Instances - Container Groups - Deploying app and database service
  - Make sure that sqlapp image is pushed to ACR
  - Refer: containersapp.yml
  - Run below commands:
  ```
  az container create --resource-group new-grp --file containersapp.yml
  ```


- Azure Container Instances - Working with secrets
