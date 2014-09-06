JVW.Logging
===========

Project came about since I wanted to use Common.Logging with the latest version of NLog and I'm under the impression that the NLog adapter project is a little dead ( https://www.nuget.org/packages/Common.Logging.NLog/ ). So, I rolled my own.

Usage:

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

