# Azure Monitor Alerts
- You can also create Azure Monitor alerts via the Azure command line interface. An example of such a command is given below
```
az monitor metrics alert create -n demoalert -g demogrp1 --scopes /subscriptions/20c6eec9-2d80-4700-b0f6-4fde579a8783/resourceGroups/demogrp1/providers/Microsoft.Compute/virtualMachines/linuxvm --condition "avg Percentage CPU > 80" --window-size 5m --evaluation-frequency 1m --description "High CPU"
```

- The above command creates an alert when the average CPU percentage for a virtual machine goes beyond 80% for a period of 5 minutes.

- For the scope, we have to provide the full resource property id.

- To the property id of a resource, for example a virtual machine, go to Properties and get the Resource ID
