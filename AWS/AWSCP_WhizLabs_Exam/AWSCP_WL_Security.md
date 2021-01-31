1) Which of the below can be configured to enhance the security at the subnet level?

NACLs can be configured to enhance the security at the subnet level.

2) Under the "Shared Reponsibilty Model", which of the listed below is Customer's Responsibility?
Client-sde data encryption

3) To amke programmatic calls to AWS, a user was provided an access key ID and secret access key. However, the user has now forgotten the shared credentials and cannot make the required programmatic calls. ow can an access key ID and secret access key be provided to the user?
user "Create New Access Key" by logging in to AWS Management Console as the root user.

4) To enable an application on an ECs intance to perform some actions, the developer requires to grant access to the application for a few AWS resources. The developer plans to provide his credential to the instance, However, as the develper's credentials are long-term, the developer is looking for an alternate to reduce the security risk. 
What can the developer do in this scenario to enable applications on EC2 to get access to the required AWS resources temporarily?
IAM roles facilitae access delegation to services/users that in general do not have access to AWS resources of your organization. Users could assume the role (IAM Users) and / or services (AWS services) for getting temporaty securoty credentials. This can then be used to perform the required actions. An IAM group is a service to grant/revoke/manage permissions on a collection of IAM users. IAM tags add custom attributes to IAM users or roles. IAM tages use key-valye airs. 
IAm role can enable applciaton on EC2 to get access to required AWS resources temporarily. 

5) An application requires access to a databse to retrieve certain information and this action would require the developer to hard-code the credentials. Hard-coding the credentails is not a best practice, He can securely store encryped credentials and retrive them when required, eliminating the need of hard-coding credentials in the application. Which AWS service would you suggest to the develper?
AWS Secrets Manager
-helps in securly storing encryped credentials and ensures retrieval when required. The use of AWS Secrets Manager eliminagtes the need for hard-coding credentials in the application. 

6) When provisioning a securiy certificate from AWS Certificate Manager (ACM), which of the following statements is true? (choose Two)
- To veify a security certificate. a CNAME record would need to be created
- To verify a security certificate, the administrator would need to acknowledge a verification email sent to an address of their choice

7) An administrator would like VPCs in three different AWS accounts to access on-premise resources via a VPN connection terminating on a Transit Gateway. Each of the VPCs is in distint AWS regions. How can this be achieved?
-Use AWS Resource Access Manager (RAM) to share the Transit Gateway resource.

8) An administrator receives an alert an detailed repot regarding credit card infromation that has been erroneously uploaded by a user into one of the S3 buckets during an online questionnarie exercise for a survey. Which AWS service provided this detection and report?
- Amazon Macie. Is a fully managed AWS service that provides data security and privacy using machine learning algorithms, artifical intelligence and pattern matching. These mechanisms detect, discover, monitor, report and protect sensitive data stored in Amazon S3. Macie can detect and alert sensitive data, such as bank credit card information.

9) During an audit process, an organization is advised by the audit committee to certrally manage all the VPC security groups and WAF rules across their AWS environment. Given that the organization has multiple AWS accounts, how can this be achieved?
AWS Firewall Manager. Makes it possible to manage VPC security groups. AWS Sheild Advanced and WAF rules on one platform even acrosss multiple AWS accounts. 

10) Which of the following statements accurately describe a function of AWS Secrets Manager?
- Replaces the need to hardcorde authentication credentials in code.
-Makes it possible to include an API call in code that retrieves authentication information from a central repository 

AWS Secrets Manager allows users to replace authentication information in code with an API call to Secrets Manager This APIC call then retrieves the secret programmically. This safeguards the secert from being compromised since the secret is removed from the code. AWS Secrets Manager automatically rotates the secret in accordance with specified schedules which allows the implementation of more secure short-term secrets. These, in turn, reduce the risl of authentication inforamtion in code being compromised. 
https://docs.aws.amazon.com/secretsmanager/latest/userguide/intro.html

11) A client has decided to go for a MySQL, RDS databse on on the AWS cloud based on its Scalability & High Availability features. When does so, what role does he play in making the database secure? (Select Two).
- He can restrict RDP access to the database by using a Security Group
- He can plan for backup & recovery strategies for data that may be lost

RDS is a managed service (Database As a Service) that allows the user to ease administrative tasks like Database software updates and Operating System patch updates. Thus it helps the user concentrate more on the design/development of the database. The instance class types (EC2 VM's) that support the database instance configuration are abstracted from the user since it is provided as a service. All in all RDS offers automatica DB installation process, storage disk provisioning. Database upgrades, Secuirty patches and backups of SQL databasees. In this scenario, we would like to know the tasks that a user can perform as a part of the Shared responsibility model for security in an RDS database.

12) I have a web application with the following VPC configuration as shown below. Subnet 1 (173.31.0.0/20) hosts a Web server (on a EC2 instance) & Subnet 2(172.31.16.0/20) hosts a Databse Server (on a EC2 incense). Whichof the statements mentioned below does NOT define good practice froma Security & Compliance perspective & which may be modified in the Diagram? Select Two

Hosting the Web Server on a Default subnet is a good practice. Since the databse does not requirea Public IP, it is suitable to host the DB server on a non-default subnet that does not allocate a Public IP by default. 

The Subnet hosting the Database Server havinga  route to the Internet Gateway is a good practice. The database server should not have a route to the Internet Gateway.
https://docs.aws.amazon.com/vpc/latest/userguide/what-is-amazon-vpc.html
https://www.testpreptraining.com/tutorial/aws-cloud-practitioner/aws-cloud-security/

13) I have a mobile app that needs to access AWS resources like S3, Dynamo DB. What is the best way to be allow users of the modble app access to these AWS resources?
User Security Token Service (STS) with Identity Federation that will allow an User acess to resources within a session

The STS token will contain temporary credentials with a Role indicating the access level that a mobile app user can have. The secuirty credentials will be valid for a specific user session only. 

https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_providers_oidc_cognito.html
https://www.testpreptraining.com/tutorial/aws-cloud-practitioner/aws-access-management/
https://docs.aws.amazon.com/IAM/latest/UserGuide/introduction.html

14) I have a compliance requirement for my application, starting that unrestricted SSH access to any EC2 instance needs to be immediately notified to an admin. Which services can I use to achieve the requirement?
- AWS Inspector, Amazon SNS
- AWS Config, Amazon SNS


Both AWS Inspector & AWS Config can scan EC2 instances,, access their network exposure, and hen integrate with Amazon SNS to send notifications. Trusted Advisor also can check for overly permissive access of EC2 instances. Still, the notifications can be performed by monitoring the Trusted Advisor check results with AWS CloudWatch events that can use specific targets like Lambda, SNS etc. 

The Network Reachability rules package recently released for AWS Inspector helps analize Amazon VPC netowrk configuration to determine wheather an EC2 instance can be reached from external netwrks like the Internet. It does it by analizing netowrk configurations like Security Groups, NACLs, Route tables, etc... The assessment that is run, its security findings can be published to an SNS topic.


https://aws.amazon.com/blogs/security/amazon-inspector-assess-network-exposure-ec2-instances-aws-network-reachability-assessments/
https://aws.amazon.com/blogs/security/how-to-remediate-amazon-inspector-security-findings-automatically/
https://aws.amazon.com/blogs/aws/trusted-advisor-console-basic/
https://docs.aws.amazon.com/awssupport/latest/user/cloudwatch-events-ta.html

15) I enable encryption on an S3 bucket that I have created with the following selections. Reger to the figure below.
With the KMS encryption selected as (aws/s3), which of the following statement is NOT true?
- The LMS key can be rotated both automatically and manually.
AWS managed KMS keys cab only be rotated automatically compared to the Custom Managed KMS keys that can be rotated automatically or manually. Manual rotation of keys provides greater control over the keys & makes it more secure and difficult to compromise. 

https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html
https://youtu.be/SOnJyqwGn1I
