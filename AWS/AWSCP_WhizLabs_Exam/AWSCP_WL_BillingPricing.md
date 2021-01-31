1) An organization has started a new project to create memes based on user comments and uploaded images. As this new project is stated on a pilot basis and is not pursued rigorously, cost efficiency is emphasized and not the uptime and processed time. 
Given these priorities, which EC2 Instances should be preferred?
- Spot Instance

2) An organization has developed an application that creates event-based memes. The organization has decided to run this application uninterrupted for the period of a plannied sporting even so taht the fans of the team can create memes and share them on social medoa to show their support. The sporting even s 3 months long. Which EC2 instance willl be best suited for this scenario?
-On Demand Instances
The point to be noted in this scenario is:
- Application is to be run uninterruptedly
-Duration of the requirement is 3 months
As the duration is 3 motnhs. Options B (Reserved Instances) and Option D (Dedicated Instances) are not good a good choice. 

3) Which of the below statement is correct regarding the AWS trusted advisor checks available to AWS Basic Support customers and AWS Developer Support customers?
- AWS Basic Support customers and AWS Developer Support customers both get access to 6 security checks and 50 service limit checks.

4) Which s3 storage class is preferable for storing on-prem data backup (Secondary backup) copy?
S3 One Zone-Infrequent Access. S3 One Zone-Infrequent Access should be the preferable S3 storage class as other storage classes are costly options. In this scenario, tje data os the secondary backup copy and hence shall be accessed infrequently. Data resilience is not mandatorily required since the data is a secondary backup copy. 

5) Which of the below listed AWS service(s) and feature(s) are free of cost?
- IAM

6) I make a conscious decision to move mt on-premise workloads to AWS cloud. What are the steos that I need to take so that my costs are not mismanaged? Select Two
- Spot instances will be useful for my dev/test environment workloads 
- This option can delete old and unused EBS snapshots to reduce the costs

7) My application has low invvocations and short execution times. Which compute technology will provide me with the best pricing?

- Lamda. The scenario is best suited for Lambda functions that will offer the least operational complexity & best cost. 

8) I hae different environments like Dev, Test, Prod for my Project, for which I use multiple AWS Accounts with AWS Organziations for managing those accounts. Which statments related to AWS Organizations are correct? Select Two
- It is advised to not have resources like EC2, S3 etc.. in the Master Account.
-CloudTrail can be used to monitor & log activities of all API calls from other Accounts

9)  I moved my On-Premises workload to AWS for cost efficiency. I ahve received my monthly bill & I would like to be visually adviced to utilize my AWS resources for making better selection decisions. hich AWS service will help ne do that?

- AWS Cost Explorer. Cost Explorer is a free service that helps ne view m cost data (bill) as a graph. For instance, I would like to see my EC2 service utilization wheather it is going up or down. The toool also allows me to filter the graph by values like API Operations, Cost allocation tags, AZ, EC2 instance types etc... With consolidating boilling the filter can also be applied to Member Acounts. From historical data, I can also see forecasts of future costs. Using this data, I can make informed decisions of fither improving costs using this data.

10) A client is planning to move some of his On-Premise application workloads to AWS Cloud. He wants to know the elements of AWS cloud for which he will have a cost associated. Which of these elements will NOT require the client to pay for its use?
- Inbound Data transfer. AWS works hard for driving  down costs allowing customers to reap its benefits. There are no in inbound data transfer charges across services in all regions. Thos means that customers an upload petabytes of data to storage destrinations like S3 without paying inbound data transfer fees. Data transfers from On-premise to AWS cloud will also not incur Transfer charges.

11) A client has a set of On-Premise applications. He wishes to use his existing SQL Server licenses on AWS cloud provied on a CPU core basis. What pricing model will best suit the clients requirements?
- On demand EC2 Dedicated Hosts

12) I have a huge amoount of data (images, documents), I want to store them on AWS storage service S3 and know how S3 is priced to make informed decisions. Which of the following is accounted as a cost for S3 storage?
Select Two
- Lifecycle transition requests
- Outbound data transfer from S3 in US-East to an EC2 instance in US-West

13) Which of the following statement related to consolidated billing is incorrect?
- A master account cannot incur usage charges

14) Reserved Instances are a great way to avail cost benefits for capacity that is redicted to be used continuously. Which of the following statements are incorrect for Reserved Instances? Select Two

-  Reserved instances of all types always guarantee capacity.
- Reserved Instances ensure dedicate tenancy for an  user who purchases them.

15) For a client who plans to migrate his workload from on-premisses into AWS, which of the following will help him understand the ROI of running his applications on Cloud compared to running them On-Premise?
- AWS Pricing Calculator. Is used to compare the cost of running your applications an On-Premise or co-located environment compared to AWS.
