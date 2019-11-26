# Softwaretesting Final Project

![software testing @ kea](https://img.shields.io/badge/software%20testing-kea-%23ea5045)
![docker](https://img.shields.io/badge/docker-yes-blue)

## Installation

Clone this repository. You may have to run a `dotnet restore` if there are anny errors. This is not needed if you use Docker.


## Usage

This section describes how to run the program.

### Using Docker

Build and run using docker:

```sh
docker build -t softwaretesting-final-project .
docker run -p 5000:5000 softwaretesting-final-project
```

Then, navigate to http://localhost:5000.

### Manually (for Development)

In the `app/` folder, run:
```sh
dotnet run 
```

Then, navigate to http://localhost:5000.

## Setup Jenkins locally using Docker

### Prerequisites
- have docker ce and docker compose installed and running

### Run

Open a command line / shell and navigate to the project folder (where this README file is stored). Then, run:

```sh
docker-compose up
```

The console output should give you the initial password which looks like this:

```sh
jenkins_1  | *************************************************************
jenkins_1  | *************************************************************
jenkins_1  | *************************************************************
jenkins_1  | 
jenkins_1  | Jenkins initial setup is required. An admin user has been created and a password generated.
jenkins_1  | Please use the following password to proceed to installation:
jenkins_1  | 
jenkins_1  | 904ba1daef8c611b9ab712c736b42265
jenkins_1  | 
jenkins_1  | This may also be found at: /var/jenkins_home/secrets/initialAdminPassword
jenkins_1  | 
jenkins_1  | *************************************************************
jenkins_1  | *************************************************************
jenkins_1  | *************************************************************
```

Copy the initial password you get for the next step.

### Setup Jenkins

1. Navigate to http://localhost:8080 and paste your admin password.
2. Install suggested plugins (this may take a while)
3. Create an admin user
4. Instance configuration: Just continue
5. Press *Start using Jenkins*
6. Press *Manage Jenkins* in the sidebar
7. Press *Manage Plugins*
8. Press *Available* tab and tick the checkbox for `MSTest`
9. Press *Install without restart*
10. Tick the checkbox *Restart Jenkins when installation is complete and no jobs are running* at the bottom of the next page and wait until the setup is finished

### Create a new job

1. Press on *Create new job*
2. Give it a name and select *Multibranch Pipeline*
3. Setup the pipeline
   1. Give it a display name
   2. Add a branch source: Select GitHub
   3. Create credentials and enter your Github user and password. Then, select the newly created credentials in the Dropdown.
   4. Enter the Repository HTTPS URL, e. g.: `https://github.com/kea-sd19i-softwaretesting/project-template.git` and validate
   5. Keep all other settings at its default values and press *Save*
4. 