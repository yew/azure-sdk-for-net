# Azure Iot Hub Service API Design Doc
This document outlines the APIs for the Azure Iot Hub Service SDK

<details><summary><b>Type definition names</b></summary>
    
```
Configuration - TwinConfiguration
Module - ModuleIdentity
Device - DeviceIdentity
Twin - TwinData
Interface - PnpInterface
Property - PnpProperty
Reported - PnpReported
Desired - PnpDesired
```
</details>

<details><summary><b>Constructors</b></summary>
    
```csharp

```
</details>

<details><summary><b>Configurations</b></summary>
APIs for managing configurations for devices and modules
```csharp

```
</details>

<details><summary><b>Statistics</b></summary>
APIs for getting statistics about devices and modules, as well as service statistics
```csharp

```
</details>

<details><summary><b>Registry</b></summary>
APIs for managing device and module identities
```csharp
public class Devices
{
    /// <summary>
    /// Create or update a device identity.
    /// </summary>
    /// <param name="deviceIdentity">the device identity to create.</param>
    /// <param name="precondition">The condition on which to perform this operation. To create a device identity, this value must be equal to <see cref="IfMatchPrecondition.Unconditional"/>.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The created device identity.</returns>
    public virtual Task<Response<DeviceIdentity>> CreateOrUpdateIdentityAsync(DeviceIdentity deviceIdentity, IfMatchPrecondition precondition = IfMatchPrecondition.IfMatch, CancellationToken cancellationToken = default)

    /// <summary>
    /// Create or update a device identity.
    /// </summary>
    /// <param name="deviceIdentity">the device identity to create.</param>
    /// <param name="precondition">The condition on which to perform this operation. To create a device identity, this value must be equal to <see cref="IfMatchPrecondition.Unconditional"/>.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The created device identity.</returns>
    public virtual Response<DeviceIdentity> CreateOrUpdateIdentity(DeviceIdentity deviceIdentity, IfMatchPrecondition precondition = IfMatchPrecondition.IfMatch, CancellationToken cancellationToken = default)

    /// <summary>
    /// Get a single device identity.
    /// </summary>
    /// <param name="deviceId">The unique identifier of the device identity to get.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The retrieved device identity.</returns>
    public virtual Task<Response<DeviceIdentity>> GetIdentityAsync(string deviceId, CancellationToken cancellationToken = default)

    /// <summary>
    /// Get a single device identity.
    /// </summary>
    /// <param name="deviceId">The unique identifier of the device identity to get.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The retrieved device identity.</returns>
    public virtual Response<DeviceIdentity> GetIdentity(string deviceId, CancellationToken cancellationToken = default)

    /// <summary>
    /// Delete a single device identity.
    /// </summary>
    /// <param name="deviceIdentity">the device identity to delete. If no ETag is present on the device, then the condition must be equal to <see cref="IfMatchPrecondition.Unconditional"/> or equal to <see cref="IfMatchPrecondition.UnconditionalIfMatch"/></param>
    /// <param name="precondition">The condition on which to delete the device.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The http response.</returns>
    public virtual Task<Response> DeleteIdentityAsync(DeviceIdentity deviceIdentity, IfMatchPrecondition precondition = IfMatchPrecondition.IfMatch, CancellationToken cancellationToken = default)

    /// <summary>
    /// Delete a single device identity.
    /// </summary>
    /// <param name="deviceIdentity">the device identity to delete. If no ETag is present on the device, then the condition must be equal to <see cref="IfMatchPrecondition.Unconditional"/> or equal to <see cref="IfMatchPrecondition.UnconditionalIfMatch"/></param>
    /// <param name="precondition">The condition on which to delete the device.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The http response.</returns>
    public virtual Response DeleteIdentity(DeviceIdentity deviceIdentity, IfMatchPrecondition precondition = IfMatchPrecondition.IfMatch, CancellationToken cancellationToken = default)

    /// <summary>
    /// Create multiple devices with an initial twin. A maximum of 100 creations can be done per call, and each creation must have a unique device identity. For larger scale operations, consider using <see href="https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-identity-registry#import-and-export-device-identities">IoT Hub jobs</see>.
    /// </summary>
    /// <param name="devices">The pairs of devices their twins that will be created. For fields such as deviceId
    /// where device and twin have a definition, the device value will override the twin value.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The result of the bulk operation.</returns>
    public virtual Task<Response<BulkRegistryOperationResponse>> CreateIdentitiesWithTwinAsync(IDictionary<DeviceIdentity, TwinData> devices, CancellationToken cancellationToken = default)

    /// <summary>
    /// Create multiple devices with an initial twin. A maximum of 100 creations can be done per call, and each creation must have a unique device identity. For larger scale operations, consider using <see href="https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-identity-registry#import-and-export-device-identities">IoT Hub jobs</see>.
    /// </summary>
    /// <param name="devices">The pairs of devices their twins that will be created. For fields such as deviceId
    /// where device and twin have a definition, the device value will override the twin value.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The result of the bulk operation.</returns>
    public virtual Response<BulkRegistryOperationResponse> CreateIdentitiesWithTwin(IDictionary<DeviceIdentity, TwinData> devices, CancellationToken cancellationToken = default)

    /// <summary>
    /// Create multiple devices. A maximum of 100 creations can be done per call, and each device identity must be unique. For larger scale operations, consider using <see href="https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-identity-registry#import-and-export-device-identities">IoT Hub jobs</see>.
    /// </summary>
    /// <param name="deviceIdentities">The devices identities to create.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The result of the bulk operation.</returns>
    public virtual Task<Response<BulkRegistryOperationResponse>> CreateIdentitiesAsync(IEnumerable<DeviceIdentity> deviceIdentities, CancellationToken cancellationToken = default)

    /// <summary>
    /// Create multiple devices. A maximum of 100 creations can be done per call, and each device identity must be unique. For larger scale operations, consider using <see href="https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-identity-registry#import-and-export-device-identities">IoT Hub jobs</see>.
    /// </summary>
    /// <param name="deviceIdentities">The device identities to create.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The result of the bulk operation.</returns>
    public virtual Response<BulkRegistryOperationResponse> CreateIdentities(IEnumerable<DeviceIdentity> deviceIdentities, CancellationToken cancellationToken = default)

    /// <summary>
    /// Update multiple devices. A maximum of 100 updates can be done per call, and each operation must be done on a different identity. For larger scale operations, consider using <see href="https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-identity-registry#import-and-export-device-identities">IoT Hub jobs</see>..
    /// </summary>
    /// <param name="deviceIdentities">The devices to update.</param>
    /// <param name="precondition">The condition on which to update each device identity.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The result of the bulk operation.</returns>
    public virtual Task<Response<BulkRegistryOperationResponse>> UpdateIdentiesAsync(IEnumerable<DeviceIdentity> deviceIdentities, BulkIfMatchPrecondition precondition = BulkIfMatchPrecondition.IfMatch, CancellationToken cancellationToken = default)

    /// <summary>
    /// Update multiple devices. A maximum of 100 updates can be done per call, and each operation must be done on a different identity. For larger scale operations, consider using <see href="https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-identity-registry#import-and-export-device-identities">IoT Hub jobs</see>.
    /// </summary>
    /// <param name="deviceIdentities">The devices to update.</param>
    /// <param name="precondition">The condition on which to update each device identity.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The result of the bulk operation.</returns>
    public virtual Response<BulkRegistryOperationResponse> UpdateIdenties(IEnumerable<DeviceIdentity> deviceIdentities, BulkIfMatchPrecondition precondition = BulkIfMatchPrecondition.IfMatch, CancellationToken cancellationToken = default)

    /// <summary>
    /// Delete multiple devices. A maximum of 100 deletions can be done per call. For larger scale operations, consider using <see href="https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-identity-registry#import-and-export-device-identities">IoT Hub jobs</see>.
    /// </summary>
    /// <param name="deviceIdentities">The devices to delete.</param>
    /// <param name="precondition">The condition on which to delete each device identity.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The result of the bulk deletion.</returns>
    public virtual Task<Response<BulkRegistryOperationResponse>> DeleteIdentitiesAsync(IEnumerable<DeviceIdentity> deviceIdentities, BulkIfMatchPrecondition precondition = BulkIfMatchPrecondition.IfMatch, CancellationToken cancellationToken = default)

    /// <summary>
    /// Delete multiple devices. A maximum of 100 deletions can be done per call. For larger scale operations, consider using <see href="https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-identity-registry#import-and-export-device-identities">IoT Hub jobs</see>.
    /// </summary>
    /// <param name="deviceIdentities">The devices to delete.</param>
    /// <param name="precondition">The condition on which to delete each device identity.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The result of the bulk deletion.</returns>
    public virtual Response<BulkRegistryOperationResponse> DeleteIdentities(IEnumerable<DeviceIdentity> deviceIdentities, BulkIfMatchPrecondition precondition = BulkIfMatchPrecondition.IfMatch, CancellationToken cancellationToken = default)

    /// <summary>
    /// List a set of device twins.
    /// </summary>
    /// <param name="pageSize">The size of each page to be retrieved from the service. Service may override this size.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>A pageable set of device twins.</returns>
    public virtual AsyncPageable<TwinData> GetTwinsAsync(int? pageSize = null, CancellationToken cancellationToken = default)

    /// <summary>
    /// List a set of device twins.
    /// </summary>
    /// <param name="pageSize">The size of each page to be retrieved from the service. Service may override this size.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>A pageable set of device twins.</returns>
    public virtual Pageable<TwinData> GetTwins(int? pageSize = null, CancellationToken cancellationToken = default)

    /// <summary>
    /// Get a device's twin.
    /// </summary>
    /// <param name="deviceId">The unique identifier of the device identity to get the twin of.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The device's twin, including reported properties and desired properties.</returns>
    public virtual Task<Response<TwinData>> GetTwinAsync(string deviceId, CancellationToken cancellationToken = default)

    /// <summary>
    /// Get a device's twin.
    /// </summary>
    /// <param name="deviceId">The unique identifier of the device identity to get the twin of.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The device's twin, including reported properties and desired properties.</returns>
    public virtual Response<TwinData> GetTwin(string deviceId, CancellationToken cancellationToken = default)

    /// <summary>
    /// Update a device's twin.
    /// </summary>
    /// <param name="twinUpdate">The properties to update. Any existing properties not referenced by this patch will be unaffected by this patch.</param>
    /// <param name="precondition">The condition for which this operation will execute.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The new representation of the device twin.</returns>
    public virtual Task<Response<TwinData>> UpdateTwinAsync(TwinData twinUpdate, IfMatchPrecondition precondition = IfMatchPrecondition.IfMatch, CancellationToken cancellationToken = default)

    /// <summary>
    /// Update a device's twin.
    /// </summary>
    /// <param name="twinUpdate">The properties to update. Any existing properties not referenced by this patch will be unaffected by this patch.</param>
    /// <param name="precondition">The condition for which this operation will execute.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The new representation of the device twin.</returns>
    public virtual Response<TwinData> UpdateTwin(TwinData twinUpdate, IfMatchPrecondition precondition = IfMatchPrecondition.IfMatch, CancellationToken cancellationToken = default)

    /// <summary>
    /// Update multiple devices' twins. A maximum of 100 updates can be done per call, and each operation must be done on a different device twin. For larger scale operations, consider using <see href="https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-identity-registry#import-and-export-device-identities">IoT Hub jobs</see>.
    /// </summary>
    /// <param name="twinUpdates">The new twins to replace the twins on existing devices.</param>
    /// <param name="precondition">The condition on which to update each device twin.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The result of the bulk operation.</returns>
    public virtual Task<Response<BulkRegistryOperationResponse>> UpdateTwinsAsync(IEnumerable<TwinData> twinUpdates, BulkIfMatchPrecondition precondition = BulkIfMatchPrecondition.IfMatch, CancellationToken cancellationToken = default)

    /// <summary>
    /// Update multiple devices' twins. A maximum of 100 updates can be done per call, and each operation must be done on a different device twin. For larger scale operations, consider using <see href="https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-identity-registry#import-and-export-device-identities">IoT Hub jobs</see>.
    /// </summary>
    /// <param name="twinUpdates">The new twins to replace the twins on existing devices.</param>
    /// <param name="precondition">The condition on which to update each device twin.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The result of the bulk operation.</returns>
    public virtual Response<BulkRegistryOperationResponse> UpdateTwins(IEnumerable<TwinData> twinUpdates, BulkIfMatchPrecondition precondition = BulkIfMatchPrecondition.IfMatch, CancellationToken cancellationToken = default)

    /// <summary>
    /// Invoke a method on a device.
    /// </summary>
    /// <param name="deviceId">The unique identifier of the device identity to invoke the method on.</param>
    /// <param name="directMethodRequest">The details of the method to invoke.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The result of the method invocation.</returns>
    public virtual Task<Response<CloudToDeviceMethodResponse>> InvokeMethodAsync(string deviceId, CloudToDeviceMethodRequest directMethodRequest, CancellationToken cancellationToken = default)

    /// <summary>
    /// Invoke a method on a device.
    /// </summary>
    /// <param name="deviceId">The unique identifier of the device identity to invoke the method on.</param>
    /// <param name="directMethodRequest">The details of the method to invoke.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The result of the method invocation.</returns>
    public virtual Response<CloudToDeviceMethodResponse> InvokeMethod(string deviceId, CloudToDeviceMethodRequest directMethodRequest, CancellationToken cancellationToken = default)
}
```
</details>

<details><summary><b>Jobs</b></summary>
APIs for using IotHub jobs
```csharp

```
</details>

<details><summary><b>V2 Jobs</b></summary>
(maybe combine with job APIs, or maybe don't expose v1 job APIs. Talk with service about this)

```csharp

```
</details>

<details><summary><b>Twin</b></summary>
Device and module twin operations
```csharp

```
</details>

<details><summary><b>Methods</b></summary>
Device and module direct methods
```csharp

```
</details>

<details><summary><b>Cloud to Device Messaging</b></summary>
No sign of this in the swagger    
```csharp

```
</details>

<details><summary><b>Feedback Message</b></summary>
APIs for getting feedback messages
```csharp

```
</details>

<details><summary><b>File Upload Notifications</b></summary>
No sign of this in the swagger
```csharp

```
</details>

<details><summary><b>Query</b></summary>
APIs for querying on device or module identities
```csharp

```
</details>
