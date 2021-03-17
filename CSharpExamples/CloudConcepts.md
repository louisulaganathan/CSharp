Service virtualization
----------------------

Service virtualization is a mthod that helps you to emulate the behaviors of the components in a SOA.
```
  Development
  Testing 
  Operations
```
Above teams do not work in sync. they have to wait for others to have component ready

With Service Virtualization DevOps teams use virtual services instead of production services so they can test the system even when the key components are not ready.

Integration of components can happen early in the development life cycle.

Virtualization Tools:
---------------------
  Paraspft virtualize   = testors
  Traffic Parot         = DEV + Testors - Compatible for dockers & kubernetes
  WireMock              = API + SSL
  HoverflyCloud         = AWS + Google & Azure
  
  Scaling:
  ========
  
  Process of breaking down a software into different units.
  Scalling defines in terms of scalability
  Scalability improves security, durability & maintainability of an appln
  
  X-Axis Scaling (or) Horizontal Scaling:
  -----------------------------------------
  Break down an application into different horizontal units/parts like Models, Views, Controllers, Middlewares, etc
  
  Y-Axis Scaling (or) Vertical Scaling:
  --------------------------------------
  Resource level scaling
  Controlling network traffic by running application in multiple servers at the same time.
  
  z-Axis Scaling:
  ------------------
  Appln can be scaled at the business level.
  
