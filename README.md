# ShopbridgeAPI

**Shop Bridge** is a Web API application that helps track the different items for sale. It is an inventory management system which keeps records of the items with their name, description, price of the same.

This project is built in **.NET Core 3.1.0**

## 📒 Table of Contents 

- [System Requirements](#-system-requirements)
- [Setup](#-setup)
- [Run Project](#-run-project)
- [Usage](#-usage)
- [Run Tests](#-run-tests)
- [Build](#-build)
- [Time Tracking](#-time-tracking)
- [License](#-license)

## ⚙ System Requirements

* IDE Framework - **Visual Studio 2019**
* Database - **SQL Server 2012 or higher**
* OS - **Windows 10**
* **IIS** should be installed.
---
## 🛠 Setup

1. Download the project from this repository.
2. Right-click on downloaded zip file. Click Properties. Check the checkbox for **Unblock**. Click Apply.
	> You can skip this step if you are cloning the repository.
	
3. Open **ShopBridgeAPI.sln** file via Visual Studio.
4. Right-click on **ShopBridgeDataModels** and select **Set as Startup Project**.
5. Open **Package Manager Console** in Visual Studio _(**Tools > NuGet Package Manager > Package Manager Console**)_.
	> Make sure Default Project is selected as **ShopBridgeDataModels** in the Package Manager Console.
6. Copy the below command and paste it in the Package Manager Console window.
    
	`PM > update-database`
	
	> NOTE : After pasting, hit *Enter*.
---
## ⌛ Run Project

* Right-click on **ShopBridgeAPI** project. Click _**Set as Startup Project**_.
* Run the project by pressing **F5** in the keyboard.
---
## ✔ Usage

* User can add items in the **Create Inventory Item** section of the page.
* The added items are listed below in the **List Inventory Items** section of the page.
* User can view the **item details** by clicking on each Items.
* Items can also be deleted from the specified **Delete** action button.

---
## 🧪 Run Tests

* Go to _**Test > Test Explorer**_.
* Click on **Run All Test** icon.
---
## 🌐 Build

* In the Build Menu, change Configuration Manager from Debug to **Release**.
* Right-click on **ShopBridgeAPI** project. Select **Publish**.
* Select **Folder** from list of Hosting options. Click **Next**.
* Choose a publishing directory. 
* Click **Finish**.
---
## 🕔 Time Tracking

* Backend Functionality - 6 hours
* Unit Test Coverage - 3 hours

---
## 📑 License

[![License: MIT](https://img.shields.io/badge/License-GNU-yellow.svg)](https://github.com/abhitomer/ShopbridgeAPI/blob/master/LICENSE)

[Shop Bridge](#ShopbridgeAPI) is under the **GNU General Public License v3.0**. See the [LICENSE](https://github.com/abhitomer/ShopbridgeAPI/blob/master/LICENSE) for more information.
