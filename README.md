# Management System for Social Events

Distributed Database System to manage Social Events.
The system implements Horizontal, Vertical and Hybrid Data Fragmentation.

Problem Description

Nowadays, there are many social events halls that need to manage their events in a more efficient way. Since usually the greatest demand for events are carried out seasonally and it is somewhat complicated to control them. Unfortunately there are many halls that keep their event records manually or have very limited systems.

I have noticed that in most of the social events halls, there is a finite amount of data that can be controlled and can be a functional part to manage the events.

All social events whether they are weddings, XV years, graduations, baptisms among others, have common elements that are part of it and some of them are not considered for management. Obviously the events are planned, organized and what is necessary to carry them out is obtained, this implies that the hall manages its resources in a more efficient way.

The resources to manage in most of the social events halls are: Tables, waiters, captains, Ingredients to be used in the food, Refreshments, Tableware and cutlery, Table linen, Set up personnel, Security, Photographers, Sound or Group, Cook and office employees.


System Implementation

Considering the process that is carried out to make an event, it is necessary to keep a record of the event where the number of people and the type of food is specified. As well as the captain and coordinator who will be responsible for the event and then register the waiters since they are external to the hall.

The system will have the ability to generate information relevant to the event, one part will be directed to the kitchen where they will need to know the amount of ingredients to use in the preparation of the food, if there is any ingredient that is about to run out, the system will send a request to the supplier.

Another report will be directed to the staff in charge of preparing the room, showing a list of the number of tables and chairs to occupy, the number of ghosts, tablecloths and table mats, the amount of soft drinks, the total of cutlery, trays and rests for the waiters, cloth napkins, vests. This in order to have everything prepared for the event and keep a good record.
The importance of the system is that it will keep a record of everything that was needed to make the event and so the manager will know everything that happened obtaining important information where you can take the right decisions for the next events.

SQL Databases

> - MySQL       ( Coordinator)
> - MariaDB     ( Node 1)
> - PostgreSQL  ( Node 2)
> - DB2         ( Node 3)
> - Oracle      ( Node 4)

Reports Tool
> - Crystal Reports

## Base de Datos
![Alt text](./db_design/Eventos2.png?raw=true)

![Alt text](./docs/Screenshots/Reports/banquetes-event.png?raw=true)

![Alt text](./docs/Screenshots/Reports/events-company.png?raw=true)

![Alt text](./docs/Screenshots/Reports/waiters-event.png?raw=true)

## System
![Alt text](./docs/Screenshots/clients.png?raw=true)

![Alt text](./docs/Screenshots/employers.png?raw=true)

![Alt text](./docs/Screenshots/musician.png?raw=true)

![Alt text](./docs/Screenshots/plates.png?raw=true)

![Alt text](./docs/Screenshots/events.png?raw=true)

![Alt text](./docs/Screenshots/employers-event.png?raw=true)

![Alt text](./docs/Screenshots/musician-events.png?raw=true)

![Alt text](./docs/Screenshots/banquetes.png?raw=true)

![Alt text](./docs/Screenshots/banquetes2.png?raw=true)
