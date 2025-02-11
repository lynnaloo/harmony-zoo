# Azure Zoo

Take an exciting journey through the Azure Zoo, where we'll explore the fascinating world of Azure Integration Services.

## Azure Services

* Azure Service Bus: Use this for reliable messaging between different parts of the system. For example, when a visitor purchases a ticket online, a message is sent to the visitor management system.
* Azure Event Grid: Implement event-driven architecture to handle events such as ticket purchases, animal feeding times, and exhibit updates. This allows different services to react to these events in real-time.
* Azure API Management: Manage and secure APIs that expose functionalities such as ticket booking, exhibit information, and visitor feedback to external systems, such as mobile apps or partner services.
* Azure Logic Apps: Automate workflows, such as sending ticket confirmation emails, updating exhibit information, and notifying visitors about special events or feeding times.
* Azure Functions: Use serverless functions to handle specific tasks, like calculating visitor capacity or generating personalized recommendations for exhibits based on visitor preferences.

## User Views

* Home Screen
* Ticket Purchase Screen
* Admin Screen:

## Use-cases

### Managing Visitor Tickets and Providing Real-Time Updates on Exhibit Information:

* Web/Mobile App: Visitors can buy tickets and get real-time updates on exhibits.
* API Management: API Gateway manages API requests for ticket booking and exhibit information.
* Service Bus: Message Broker handles ticketing sales.
* Visitor Management Service: Interacts with exhibits and ticketing services to provide real-time updates.
* Event Handlers: Manage activities, exhibits, and notifications.

### Offering Interactive Support Through AI Chat Agents While Managing Events/Notifications:

* ChatAgent (Semantic Kernel + Azure OpenAI): Assists visitors with FAQs and provides interactive support.
* Event Grid: Event broker pushes events to event handlers for activities, exhibits, and notifications.
* Azure Functions: Handle specific tasks like calculating visitor capacity or generating personalized recommendations.
* Azure Logic Apps: Automate workflows such as sending ticket confirmation emails and updating exhibit information.

## Reference Architecture

<img width="1000" alt="Screenshot 2025-02-07 at 4 08 18 PM" src="https://github.com/user-attachments/assets/b7445546-02b8-45da-b285-7ee61484ef91" />
