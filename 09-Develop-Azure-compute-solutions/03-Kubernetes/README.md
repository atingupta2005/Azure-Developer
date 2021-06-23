# Kubernetes

## Install KubeCTL
```
curl -LO "https://dl.k8s.io/release/$(curl -L -s https://dl.k8s.io/release/stable.txt)/bin/linux/amd64/kubectl"
sudo install -o root -g root -m 0755 kubectl /usr/local/bin/kubectl
kubectl version --client
```

- Install Azure CLI (If Required)
```
curl -sL https://aka.ms/InstallAzureCLIDeb | sudo bash
```

- Setup autocomplete in bash into the current shell, bash-completion package should be installed first.
```
source <(kubectl completion bash)
echo "source <(kubectl completion bash)" >> ~/.bashrc # add autocomplete permanently to your bash shell.
```

- Use these commands if Azure Cluster and your namespace is already created
```
az login
#az account set --subscription "0aebf870-9dad-42d6-b841-71391fa04322"
sudo az aks get-credentials --resource-group rgJuly21 --name aksatin
```
```
sudo kubectl config use-context aksatin
sudo kubectl create namespace "ns-atingupta2005"  # Note: Specify your namespace here.
sudo kubectl get namespaces
sudo kubectl config set-context --current --namespace="ns-atingupta2005"  # Note: Specify your namespace here.
sudo kubectl get nodes
```
### 1.-------Deploy Docker image in Kubernetes
```
sudo kubectl create deployment hello-world-rest-api --image=atingupta2005/hello-world-rest-api:0.0.1.RELEASE
sudo kubectl get deployments
sudo kubectl expose deployment hello-world-rest-api --type=LoadBalancer --port=8080
sudo kubectl get service
watch -n 0.1 curl <url>
sudo kubectl get pods
sudo kubectl scale deployment hello-world-rest-api --replicas=3
sudo kubectl get pods
```

### 2.--------Pods
- Pod is the smallest deployable unit. Can not have container without Pod. Container lives inside Pod
```
sudo kubectl get pods
sudo kubectl get pods -o wide
```

```
sudo kubectl delete pod hello-world-rest-api-58ff5dd898-62l9d
```

```
sudo kubectl get pods
```

- Get list of various artifacts
```
sudo kubectl get all
sudo kubectl get events
sudo kubectl get pods
sudo kubectl get replicaset
sudo kubectl get deployment
sudo kubectl get service
```

## Apply yaml file
```
kubectl apply -f deployment-01-after-cleanup.yaml
watch kubectl get service
```

- Now let's change the Pod definition.
```
vim deployment-01-after-cleanup.yaml
```

- We can check if there is any difference in deployed environment with our yaml file
```
kubectl diff -f deployment-01-after-cleanup.yaml
```



## Short commands
```
kubectl get services
kubectl get svc
kubectl get ev  #Events
kubectl get rs  # Replicaset
kubectl get ns  #Namespace
kubectl get nodes
kubectl get no  #Nodes
kubectl get po  #Pods
```

## Auto Scaling
```
wget -O deploment_currency_exchange_autoscale.yaml https://raw.githubusercontent.com/atingupta2005/04-currency-exchange-microservice-basic/master/deployment.yaml
```

```
vim deploment_currency_exchange_autoscale.yaml
```

```
kubectl apply -f deploment_currency_exchange_autoscale.yaml
kubectl get pods
kubectl get service
watch -n 0.1 curl http://<service_ip>:8000/currency-exchange/from/EUR/to/INR
watch -n 0.1 curl http://<service_ip>:8000/currency-conversion/from/EUR/to/INR/quantity/10
```

- Let's autoscale deployment based on CPU usage
```
kubectl autoscale deployment currency-exchange --min=1 --max=3 --cpu-percent=10
watch -n 0.1 kubectl get pods  # PODS will be created/deleted automatically based on the Load
```

- See events
```
kubectl get events
```

## Extra commands:
```
kubectl delete --all namespaces
kubectl delete --all deployments --namespace=foo
kubectl delete pods --all
kubectl delete deployment --all
kubectl delete rc --all
kubectl delete rs --all
kubectl delete service -l provider=fabric8
kubectl delete secret -l provider=fabric8
kubectl delete ingress --all
kubectl delete configmap --all
kubectl delete sa --all
```
