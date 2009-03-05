1) The "local.properties.xml" file should not be checked into SVN.

2) Every developer should create a "local.properties.xml" on their machine with properties configured to suit settings on their machine.

3) To build just the projects run this command (go build)

4) To build the projects and publish just the web application (go publishWebApp)

5) To build the projects and publish just the web site (go publishWebSite)

6) To build the projects and publish the web application and the website (go publish)

7) To change the default values of properties in the build file, run the command with the format (go build -D:[PROPERTY_NAME]=[NEW_PROPERTY_VALUE])

8) Settings for other machines can be setup with file names like "MACHINENAME.properties.xml" see the "Staging.properties.xml" file for details as to how to configure the buils system for a publishing to a machine names "Staging".

9) To run the build for the environment/MachineName configured in step 3, run the command like so for a machine named 'STAGING'. (go publish -D:env=STAGING)

10) If some values in configuration files like "web.config" or "App.config" needs to be configured differently on different machines then create a "web.config.template" or "App.config.template" accordingly with a copy of the contents from the original "web.config/App.config" file but with the values that need to be changed tokenized with TOKENS enclosed within @ characters like @TOKEN@. See the "web.config.template" file in the web application and the website for details.