(c)2021 Advanced Workstation Solutions, Inc.  ALL RIGHTS RESERVED 

Welcome to Vehicle Search by Edward Tighe 

This is a simple sample solution in two parts:

	Domain for a Car Dealership  with a  WebAPI Interface.

	   Platform is .net core  with  C# used on the backend.
	   Angular SPA is   used on the Frontend.


	   After cloning the repo fro aws4u.visualstudio.com.

	   to starrt a server:
			1) Please start a windows cmd window and navigate to {repo}\VehicleSearch\API\publish
			2) execute "api" as a command. This should start a published version of the webAPI serving on http://localhost:5000 and https://localhost:5001
			3) OPTIONAL: verify by showing a swagger page at https://localhost:5001/swagger/index.html

	   Please start a windows cmd window and navigate to {repo}\VehicleSearch\VehicleSearch. 
	   assuming a reasonable versiobn of Node/npm and the Angular and AngularCLI, 
			1) please  perform an  "npm install" ; this might take some time
	        2) Next perform "npm run start" ,  which should also  take a bit
			3) Assuming the  server is running as above,  navigate to http://localhost:4200/

       Search for Vehicles.

	   The Web API server is in the VehicleSsearch.sln   (Leverages EF core to a sqlite database, with a WebAPI exposed for the client ) 
	   The Frontend is a  simple SPA written in Angular using Angular Material components.


	   
