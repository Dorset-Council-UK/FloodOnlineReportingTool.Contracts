
# Developing for Flood Online Reporting Tool - Contracts

Thank you for your interest in contributing to the Flood Online Reporting Tool - Contracts! This guide will help you set up your development environment and understand the basic components of the project.

## Dependencies

To run Flood Online Reporting Tool - Contracts with minimal modification, you will need the following:

- **PostgreSQL 13+ with PostGIS extension**: This is the default database provider. The project uses Entity Framework, making it adaptable to other providers with minimal effort.
- **.NET 9**: Ensure you have the .NET 9 SDK installed.
- **Message system (optional)**: The project includes a messaging system using RabbitMQ. You can enable or disable this system through the `RabbitMQ:Enabled` setting in your configuration.
- **GDS Framework**: The project relies on the Government Digital Service (GDS) framework for its front-end. Make sure to run `npm install` to set up dependencies.

## Getting Started

1. **Clone the repository**:
   ```shell
   git clone <repository-url>
   cd <repository-folder>
   ```

2. **Create a new branch**:
   ```shell
   git checkout -b <branch-name>
   ```

3. **Install front-end dependencies**:

   Run the following command in the root folder:
   ```shell
   npm install
   ```

## Database Setup

Not Applicable

### User
Not Applicable


### Connection Strings
Not Applicable

## User Secrets and Configuration

Not Applicable

## Authentication

Not Applicable

## Other Customizations

For messaging, the `RabbitMQ` section allows you to enable or disable the MassTransit messaging system. By default, messaging is disabled (`RabbitMQ:Enabled = false`).

## Further Help

For further help, please reach out to the maintainers or consult the documentation. 
