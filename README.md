# Azure-Service-Bus-Queues-Demo
Microsoft Azure Service Bus is a reliable information delivery service. The purpose of this service is to make communication easier. When two or more parties want to exchange information, they need a communication facilitator. Service Bus is a brokered, or third-party communication mechanism. This is similar to a postal service in the physical world. Postal services make it very easy to send different kinds of letters and packages with a variety of delivery guarantees, anywhere in the world.

To know more about Azure Service Bus, go to https://docs.microsoft.com/en-us/azure/service-bus-messaging/service-bus-fundamentals-hybrid-solutions
# Steps followed
## 1. Create a namespace using the Azure portal
a) Log on to the Azure portal.

b) In the left navigation pane of the portal, click New, then click Enterprise Integration, and then click Service Bus.

c) In the Create namespace dialog, enter a namespace name. The system immediately checks to see if the name is available.

d) After making sure the namespace name is available, choose the pricing tier (Basic, Standard, or Premium).

e) In the Subscription field, choose an Azure subscription in which to create the namespace.

f) In the Resource group field, choose an existing resource group in which the namespace will live, or create a new one.

g) In Location, choose the country or region in which your namespace should be hosted.

h) Then click Create. The system now creates your namespace and enables it. You might have to wait several minutes as the system provisions resources for your account.

## 2. Obtain the management credentials
a) In the list of namespaces, click the newly created namespace name.

b) In the namespace blade, click Shared access policies.

c) In the Shared access policies blade, click RootManageSharedAccessKey.

d) In the Policy: RootManageSharedAccessKey blade, click the copy button next to Connection string–primary key, to copy the connection string to your clipboard for later use. Paste this value into Notepad or some other temporary location.

e) Repeat the previous step, copying and pasting the value of Primary key to a temporary location for later use.

## 3. Create a queue using the Azure portal
a) Log on to the Azure portal.

b) In the left navigation pane of the portal, click Service Bus (if you don't see Service Bus, click More services).

c) Select the namespace that you would like to create the queue in.

d) In the Service Bus namespace blade, select Queues, then click Add queue.

e) Enter the Queue Name and leave the other values with their defaults.

h) At the bottom of the blade, click Create.

## 4. Send messages to the queue
### a) Create a console application
Launch Visual Studio and create a new Console application.

### b) Add the Service Bus NuGet package
1. Right-click the newly created project and select Manage NuGet Packages.
2. Click the Browse tab, then search for "Microsoft Azure Service Bus" and select the Microsoft Azure Service Bus item. Click Install to complete the installation, then close this dialog box.

### c) Write code to send a message to the queue
Please see the send method in Program.cs file in the project.

### d) Run the program to test the Send method
Run the program to test the Send method, and check the Azure portal. Click the name of your queue in the namespace Overview blade. Notice that the Active message count value should now be 1.

## 5. Receive messages from the queue
a) Please see the Receive method in Program.cs file in the project.

b) Run the program to test Receive method, and check the portal. Notice that the Queue Length value should now be 0.
