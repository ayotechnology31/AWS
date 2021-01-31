1) Which AWS service is machine learning-based tool that analyzes metrics of historical utilization and makes recommendations of compute service(s) to be used for the workload?

AWS Computer Optimizer. Is a machine learning-based tool that analyzes of historical utilization and makes recommendations of compute service(s) to be used for the workload. 

2) Which of the below could be used to perform best practice =s alined deployment of popular technonogies on AWS, and eventually reduce the time taken for environment build and eventual usage of the environment?
AWS Quick Starts: Built by AQS Architects and partners, quick start helps to automate deployments with the best practice. Cloudformation templates are included along with Quick Start for the automation of the deployment. 

3) A developer working on enhancing few applications in AWS requires an AWS service that can host git-based repositories securely. Which AWS service can the developer user?
AWS CodeCommit: helpos in hosting git-based repositories securely. AWS CodeCommit is a fully managed service and provides source control services. 

4) Which of the below statements are true with regards to Amazon S3 security and access management? Choose 2
- Self-created S3 resources are only accessible to the user by default.

-Server-side and client-side encryptions are supported by S3 for data uploads.

5) An e-commerce company has launched a new application and determinded that it needs to perform load distribution for http and https traffic because of the increased traffic during the montly discount days. Which Load Balancer would be suitable?
- Application Load Balancer is apt for http and hppts traffic load balancing. Applicating load balancer operates at layer 7.

6) Which of the following statements related to the AWS Global Infrastucture are correct? Select best Two.
- Availability zones can contain one or more data centers.
-An EC2 instance's AMI in a particular region can be copied to another region for using it in that Region

7) Which of the following AWS automation service does NOT provide the capability of provisioning IT infrastructure and deployment of applications?
AWS Code Pipeline is a CI.Continuous Delivery service that builds, tests, & deploys code whenever there is a change int he source code. CodePipelines does not in itself provision IT infrastructure, instead it uses available targets like ECS, S3, ElasticBeanstalk for deployming generated artifacts. 

8) I have an applicaion whose execture time is short but is very critical. For keeping me costs minimum for running the application, what is the nest AWS Compute service that I can use?
Lambda function. With AWS lambda, code gets executed only when needed and AWS automatically takes care of dynamically provisioning.de-provisioning 

9) I have some data that is not frequently accessed. But when requested within six months, the data needs to be available immediately. After six months, the data is not accessed but needs to be maintained for historical purposes. What is the best S3 storage class lifecycle available to me with the lowest possible cost?
- Store data for the first 6 months in S3 One Zone - IA & move data to Glacier after that.

10) I have a Virtual Private Cloud infrastructure environment hosting an Application & a Database. What are the best practices that I can use to host them within the infrastructure? Select Two
- Host the Application in a Application & Database in a Private Subnet with an ELB fronending the Application in a Public Subnet
- Subnet configured for the ELB should contain a NAT Gateway

11)  I have stored this data in a DynamoDB table. After running an update, I change the Last Name from "Abraham" to "Mathew". When John reads his data immediately after the update, he still sees his Last Name as Abraham rather than Mathew. What is the possible reason?
By default Dynamo DB reads are eventually consistent

12) I have two applications, "Image Processing" & "Order Processing", hosted on my website on different EC2 servers in an Auto Scaling Group. What is the best way to provide access to a user for any of these applications on this website?
- I can use the Application Load Balancer that will route requests to different applications on the users request. 


13) I need to keep track of all invalid login attempts of a user when he tried to SSH to an EC2 instance. How can I achieve that?
-Collecting log data from the EC2 instance and delivering them to a CloudWatch Logs log stream.

14) I am using the Amazon Simple Notification SErvice to send notifications to alert admins whereever the CPU utilization of an EC2 instance crosses 70%. Which of the following can be subscribers to an SNS Topic? Select TWO
- Email
-CloudWatch

15) I have a website that hosts mission-critical applications and requires 99.999% uptime. What routing policy will I apply while using Route 53?
- Failover Routing is usually used in Disaster Recovery scenarios where an Active-Passive or Active-Active Disaster recovery configuration is required.
