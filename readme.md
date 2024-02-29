# Introduction

This library offers an easy integration with the HomeWizard Energy API.
It is available via NuGet and can be installed via:

```
PM> Install-Package Fg.HomeWizard.EnergyApi.Client
```

# Usage

To be able to retrieve data that is exposed by your HomeWizard P1 device, you first need to know the hostname of your P1 meter.  When your P1 meter is connected with your network, you'll be able to find the hostname in your _Host Clients_ list in your router.  For instance:

![host clients](./static/img/hostlist.png)

Find your `HomeWizardDevice` in your network using its hostname with the `HomewizardDeviceResolver`:

```csharp
HomeWizardDevice device = 
    await HomeWizardDeviceResolver.FindHomeWizardDeviceAsync("p1meter-015AB0", logger);
```
> Notice that you need to remove the `HW-` part of the hostname.

Once the device has been found, you can instantiate a `HomeWizardService` instance and read out the last readings via the code below:

```csharp
HomeWizardService service = new HomeWizardService(device);

Measurement currentMeasurement = await service.GetCurrentMeasurementsAsync();
```