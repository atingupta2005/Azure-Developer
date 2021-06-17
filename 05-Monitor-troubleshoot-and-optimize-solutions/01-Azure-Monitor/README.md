# Azure Monitor
- What is Azure Monitor?
- Metric
- Logs
- Graphs
- [Azure Monitor - Azure CLI](Azure-Monitor-Azure-CLI.md)
- Auto-scaling Azure Web Apps
- Auto scaling a web app
  - Configure auto scaling rule based on CPU utilization
- Auto scaling a web app based on Queue storage
  - Need to change metric source in auto scaling rule configuration popup window
  - Check scaling logs in - "Run History" tab

  - Messages processed
      - Processed messages (Tooltip: messages that were processed and are no longer in the queue)
  - Active messages processed
      - Active/Unprocessed messages (Tooltip: messages present in the queue and ready to be processed)
  - Refer: https://docs.microsoft.com/en-us/azure/service-bus-messaging/monitor-service-bus-reference#message-metrics
