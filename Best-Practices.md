# Best Practices
- Co-locate Application and Data Stores
- Use Azure backup and smaller Virtual Machines (VMs)
- Use autoscaling
- Focus on security
  - Conduct penetration tests
  - Monitor app traffic and log your application activity
  - Use HTTPS for communication
- Co-locate Application and Data Stores
- Leverage Azure Content Delivery Network (CDN) for Quick Access
- Provide least Access
- Use tags to organize your Azure resources
- Create Azure Policies to enforce policies
- Start using Azure blueprints
- Use multiple authentication
- Don't store passwords
- Create Functions that run for a short time and design them to handle lighter operations.


DO: CAREFULLY SELECT VM SIZE

DO: GO FOR REUSING WHAT YOU WISH TO THROW AWAY
For example, instead of taking up more and more App Service Plans for web apps, it is always a good idea to reuse plans for web apps that are no longer active or in running order. Similarly Azure cloud functions can be reused from multiple applications in the same company’s applications.

DO: GO FOR AUTOMATION

DON’T: RUN RESOURCES WHILE YOU DON’T NEED THEM
