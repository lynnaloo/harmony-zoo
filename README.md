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
<img width="1086" height="624" alt="Screenshot 2025-07-23 at 12 38 32 PM" src="https://github.com/user-attachments/assets/af00223a-6599-4bbc-b1b0-7a5a651b8866" />

