JVW.Logging
===========

Project came about since I wanted to use Common.Logging with the latest version of NLog and I'm under the impression that the NLog adapter project is a little dead:
https://www.nuget.org/packages/Common.Logging.NLog/. So I decided to roll my own which will use the latest versions of Common.Logging and NLog.

**Usage**
1. Download NuGet package into your solution: https://www.nuget.org/packages/JVW.Logging.CommonLoggingNLogAdapter/ or Install-Package JVW.Logging.CommonLoggingNLogAdapter.
2. Update your web/app.config with the values below:


    <configuration>
      <configSections>
        <sectionGroup name="common">
          <section name="logging" type="Common.Logging.ConfigurationSectionHandler, Common.Logging" />
        </sectionGroup>
        <section name="nlog" type="NLog.Config.ConfigSectionHandler, NLog"/>
      </configSections>
    
      <common>
        <logging>
          <factoryAdapter type="JVW.Logging.CommonLoggingNLogAdapter.NLogFactoryAdapter, JVW.Logging.CommonLoggingNLogAdapter">
            <arg key="configType" value="INLINE" />
          </factoryAdapter>
        </logging>
      </common>
    
      <nlog xmlns="http://www.nlog-project.org/schemas/NLog.xsd"
             xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
        <targets>
          <target xsi:type="Trace" name="TraceLogger" layout="${date:format=HH\:MM\:ss} ${logger} ${level} ${message}" />
        </targets>
        <rules>
          <logger name="*" minlevel="Trace" writeTo="TraceLogger" />
        </rules>
      </nlog>
    </configuration>

Don't forget to add references to Common.Logging in your other projects and log by using:

    private static ILog log = Common.Logging.LogManager.GetCurrentClassLogger();

in your classes.

**Links:**

 1. Common.Logging: http://netcommon.sourceforge.net/
 2. NLog: http://nlog-project.org/
 3. The project that I'm trying to update: https://www.nuget.org/packages/Common.Logging.NLog/ 