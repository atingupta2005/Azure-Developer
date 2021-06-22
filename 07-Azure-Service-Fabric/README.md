# Azure Service Fabric
  - Reference -
    - Good: https://www.youtube.com/watch?v=dnkfnYn9yf8&list=PLiYmXnCpPCKZnOS0_wHrQXpD3fU-UXXU9&index=4
    - https://www.youtube.com/watch?v=vgtJ7DDNBEk
    - https://www.youtube.com/watch?v=v2FJsB0mnrI
    - https://docs.microsoft.com/en-us/azure/service-fabric/overview-managed-cluster
- Overview
  - Streamlines your deployment and cluster management
  -
- Service Fabric managed clusters
- Deploy a Service Fabric managed cluster
- Scale out a Service Fabric managed cluster
- Add and remove node types from a Service Fabric managed cluster
- Deploy an app to a Service Fabric managed cluster

## Deploy a .NET application to Service Fabric
### Using this application you learn how to:
- Create an application using .NET and Service Fabric
- Use ASP.NET core as a web front end
- Store application data in a stateful service
- Debug your application locally
- Scale-out the application across multiple nodes
- Perform a rolling application upgrade

### Prerequisites
- Install Visual Studio 2019
- Install Git
- Install the Microsoft Azure Service Fabric SDK
  - https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-get-started
- Run the following command to enable Visual Studio to deploy to the local Service Fabric cluster:
```
Set-ExecutionPolicy -ExecutionPolicy Unrestricted -Force -Scope CurrentUser
```

### Build a cluster
```
. "C:\Program Files\Microsoft SDKs\Service Fabric\ClusterSetup\DevClusterSetup.ps1"
```

- Run the following command to start the local cluster manager tool:
```
. "C:\Program Files\Microsoft SDKs\Service Fabric\Tools\ServiceFabricLocalClusterManager\ServiceFabricLocalClusterManager.exe"
```

### Download the sample
```
git clone https://github.com/Azure-Samples/service-fabric-dotnet-quickstart
```
