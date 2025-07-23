# Harmony City Zoo Park

Harmony City Zoo Park is a community zoo known for its diverse animal habitats. As a park attracting thousands of visitors each week, it offers experiences like 
animal feedings and interactive exhibits. 

The zoo’s visitor management system is an event-driven platform that supports visitor ticketing, exhibit updates, and real-time event notifications. Visitors receive 
timely updates about feeding times, exhibit changes, and upcoming events through a combination of APIs and messaging services.

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
