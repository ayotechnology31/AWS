1) Which of the below listed 2 designed principles relates to the "Operational Exellence pullar of the Wll-Architechted framework? Choose 2
Aniticipate Failure
Perform operations as code

https://aws.amazon.com/blogs/apn/the-5-pillars-of-the-aws-well-architected-framework/

2) What is the ability of AWS products and services to recover from disruptions and mitigate disruptions known as?
Resiliiency is the ability to reciver from disruptions and mitrigate disruptions
.
3) An architect is asked to design a solution for a distributed system in which the systems's components operate in a way that components of the one system do not negatively impact other components of the system. Which of the below listed architechtural best practice can ehlp to achieve this?
implement loose coupling. The scenario in the qustion talks about a distributed syste wherein there is minimal-to-no dependency amongst the components. This can be achieved by implementing loose coupling 

4) Which of the below statement is CORRECT regarding AWS Global infrastructure?
Each AWS region has multiple Availability Zones

5) An online marketplace start-up dealing in real estate is planning to move to the cloud. Which of the below is NOT a benefit to move to the cloud?
Increased varable cost as customer Benefit from massive economies of scale

6) My On-Premise application's deployment cycle is roughly around 3-4 weeks. On refactory this huge application, its features can deployed on AWS cloud in a matter of 2-3 days. What is the benefit achieved by moving to the AWS cloud?
Agility. Using an Agile environment provided by AWS Cloud I can release application features much faster than a traditional On-Premise environment

7) I need to migrate millions of customer' financial transaction data from the On-Premise Mainframe system to the AWS cloud. Which of the following Database services will give me the nest performance for Data retrieval & Data Analytics?
Amazon DynamoDB
Dynamo DB provides DynamoDB Accelerator (DAX) which is fully managed, hightly available in-memory cache. This will help us speed up the performance of data retrieval that we require. DynamoDB also has feature called DynamoDB streams that enables real-time capture of data changes using event notifications. This helps applications perform analytics on real-time asynchronous in nature to consuming applications like a Lamda function. Since the Customers transactional data is highly confidential * huge in volume a robust, scalable, secure, performant data store like DynamoDB will be the best fit for our scenario.

8) I have a certian applicatons On-premise that run 24x7 & have a consistant load I plan to move to the AWS cloud. What is the economic feature that will benefit me most referred to?

Save when you Reserve

From the scenario, we can see that the On-Premises applications workload is continous & stable. For these kinds of applications, it is easy to predict upfront capacity. Also, since the application runs continously, I will benefit by reserving capacity for a certain period of time. 

Since there is continuous usage of these applications with a predictable load, it will be best for me to reserve capacity upfront (period of 1-3 years) that will provide a substantial discount of 30-50% compared to its On Demand counterparts.

9) A client who has adoped AWS cloud services would like to ensure that his systems always scale with increasing traffic for a great end-user experience. I have implemented the same by defining AutoScaling Scale-in & Scale-Out policies & CloudWatch alarms that trigger the AutoScaling. Which Cloud Architechture Designed principles have I implemented here? Select Two
Operatonal Excellence 
Performance Efficiency

Looking at the scenario, a good end-user experience is attached to systens being performant with increasing load on them. A combination of Load balancing & AutoScaling enables a system to handle increase in load by spinning new instances to which the load will be distributed not to saturate resources like CPU & memory on a single servier instance. For the AutoScaling itself to work efficiently, there needs to be a good monitoring system that can track resource utilization and enable automation. The scenario combines the Operational Excellence & the Performance Effciency Architecture design principles.

10) A customers's Data center and its appllications are connected to AWS using a dedicated network (Direct Connect). What is the Cloud deployment model?
Hybrid Cloud
A Private Cloud refers to a cloud environment htat has been built In house on the Client;s premises using Virtualization and resource management tools. Private clouds are usually built for specific security and regulartory requirements, specially hardware or configuration requirements, and extremely critical network latency that may not be possible on a vendor's public cloud platform. Since our scenario has both the Client's data center & the AWS Cloud, it will not result in a Private Cloud configuration. 

11) Refer to the figure shown below. Based on the different cloud computing models, which of the following service is mapped to the correct cloud computin model?

A vendor application that needs minimal customization can benefit from the Saas compute model

Applications that require a great amoount of customization are best developmed in house using the PassS/IaaS model. Software vendors may provide customization but up to a limited extent. If tehre is an immediate requirement of any applicaton software service and the vendor of the software satisfies most of the client requirements, it is good to go with the SaaS paradigm to haev a faster Time-to-market & avoid operational maintenance overhead. An example can be Splunk Cloud which is a Saas monitoring solution on the cloud It is easy to roll out from a POC to a production deployment within a short period.

12) Which of the following may NOT be an Economic benefit to a client using AWS cloud services? Select Two
-The Client is running a MySQL Database Server on AWS with his own CPU bound license (BOYL).

The CPU bound software licenses will require a Dedicated Host tenancy model rather than a Shared tenancy model for the EC2 instances hosting the MySQL Databse software. Dedicated hosts are the most expensive tenancy modle when it comes to pricing. For example am m4 large On Demand dedicated host is 24 times more expensive than an On-demand shared host. A dedicated host tenancy may be used under exceptional circumstances of spiky traffic, while purchasing Hardware on-Prmise may not be the best option. Then the client can take advantage of Cloud Elasticity. 

- The client is running applications with a relatively predictable & consistent resource Demand using AWS Reserved Instances

Clients having applications wiht perdictable workloads and consistent resource demands should initially consider using a Private Cloud before considering Reserved EC2 instances for predictable.long term workloads. They will be able to maximize their resource utitlization and cloud spends. They will be less likely to take advantage of elasticity, which is the core strength of a Public Cloud.

13) Which of the following idicates a Single Point Of Failure (SPOF) in an AWS Cloud Architecture design? Refer to the figure below.
Bastion Host

We cab see in the figure that the Bastion Host has been deployed on only one of the AZ's causing a SPOF. For redundancy, the Bastion Host needs to be created in Multiple AZ's where a failure in a single AZ will not impact access to Server instances in Private subnets theough the Bastion Hosts.

14) Among the AWS resources or the AWS features (cloud concepts) listed below, which option does NOT provide automation capabilities?
High Availability may sometimes involve manual recovery of resources. It is mostly seen in Active-Passive kind of site failover mechanisms. One example could be a Backup & Restore strategy in a Disaster Recovery scenario where one site's catastrophic failure can allow downtime (based on the Recovery Time Objective -RTO & Recovert Point Objective -RPO criteria) for a limited period. Here, the failover to the Passive site willl be performed manually after the backups have been recovered and the resources powered on the take load. The advantage is the cost factor when compared to an Active0Active fault -tolerant site where both sites are fully functional. So evem though site availability is maintained, the recovery process and switching over can be manual We may compare High Availabiliyt to an analogy of a car that breaks down due to a tire burst. The recovery process would involve stopping the car and changing the tires before making it run again.

15) I have certain applications On-Premises that experince times within a year where infrastructure takes a heavier load impact (e.g. Christmas, Thanksgiving, etc) than other times in a year What is the best way in which can handle this load?
 
 By provisioning Burst Capacity on the AWS Cloud for the duration of the load


