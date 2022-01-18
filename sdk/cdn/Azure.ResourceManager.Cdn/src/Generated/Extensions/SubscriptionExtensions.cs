// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Cdn
{
    /// <summary> A class to add extension methods to Subscription. </summary>
    public static partial class SubscriptionExtensions
    {
        private static ProfilesRestOperations GetProfilesRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, ArmClientOptions clientOptions, Uri endpoint = null, string apiVersion = default)
        {
            return new ProfilesRestOperations(clientDiagnostics, pipeline, clientOptions, endpoint, apiVersion);
        }

        private static CdnManagementRestOperations GetCdnManagementRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, ArmClientOptions clientOptions, Uri endpoint = null, string apiVersion = default)
        {
            return new CdnManagementRestOperations(clientDiagnostics, pipeline, clientOptions, endpoint, apiVersion);
        }

        private static ResourceUsageRestOperations GetResourceUsageRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, ArmClientOptions clientOptions, Uri endpoint = null, string apiVersion = default)
        {
            return new ResourceUsageRestOperations(clientDiagnostics, pipeline, clientOptions, endpoint, apiVersion);
        }

        private static ManagedRuleSetsRestOperations GetManagedRuleSetsRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, ArmClientOptions clientOptions, Uri endpoint = null, string apiVersion = default)
        {
            return new ManagedRuleSetsRestOperations(clientDiagnostics, pipeline, clientOptions, endpoint, apiVersion);
        }

        /// <summary> Lists the Profiles for this <see cref="Subscription" />. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<Profile> GetProfilesAsync(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                options.TryGetApiVersion(Profile.ResourceType, out string apiVersion);
                ProfilesRestOperations restOperations = GetProfilesRestOperations(clientDiagnostics, pipeline, options, baseUri, apiVersion);
                async Task<Page<Profile>> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetProfiles");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.ListAsync(subscription.Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new Profile(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                async Task<Page<Profile>> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetProfiles");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.ListNextPageAsync(nextLink, subscription.Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new Profile(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
            }
            );
        }

        /// <summary> Lists the Profiles for this <see cref="Subscription" />. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<Profile> GetProfiles(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                options.TryGetApiVersion(Profile.ResourceType, out string apiVersion);
                ProfilesRestOperations restOperations = GetProfilesRestOperations(clientDiagnostics, pipeline, options, baseUri, apiVersion);
                Page<Profile> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetProfiles");
                    scope.Start();
                    try
                    {
                        var response = restOperations.List(subscription.Id.SubscriptionId, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new Profile(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                Page<Profile> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetProfiles");
                    scope.Start();
                    try
                    {
                        var response = restOperations.ListNextPage(nextLink, subscription.Id.SubscriptionId, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new Profile(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
            }
            );
        }

        /// <summary> Filters the list of Profiles for a <see cref="Subscription" /> represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<GenericResource> GetProfilesAsGenericResourcesAsync(this Subscription subscription, string filter, string expand, int? top, CancellationToken cancellationToken = default)
        {
            ResourceFilterCollection filters = new(Profile.ResourceType);
            filters.SubstringFilter = filter;
            return ResourceListOperations.GetAtContextAsync(subscription, filters, expand, top, cancellationToken);
        }

        /// <summary> Filters the list of Profiles for a <see cref="Subscription" /> represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<GenericResource> GetProfilesAsGenericResources(this Subscription subscription, string filter, string expand, int? top, CancellationToken cancellationToken = default)
        {
            ResourceFilterCollection filters = new(Profile.ResourceType);
            filters.SubstringFilter = filter;
            return ResourceListOperations.GetAtContext(subscription, filters, expand, top, cancellationToken);
        }

        /// <summary> Check the availability of a resource name. This is needed for resources where name is globally unique, such as a CDN endpoint. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="checkNameAvailabilityInput"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="checkNameAvailabilityInput"/> is null. </exception>
        public static async Task<Response<CheckNameAvailabilityOutput>> CheckCdnNameAvailabilityWithSubscriptionAsync(this Subscription subscription, CheckNameAvailabilityInput checkNameAvailabilityInput, CancellationToken cancellationToken = default)
        {
            if (checkNameAvailabilityInput == null)
            {
                throw new ArgumentNullException(nameof(checkNameAvailabilityInput));
            }

            return await subscription.UseClientContext(async (baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.CheckCdnNameAvailabilityWithSubscription");
                scope.Start();
                try
                {
                    var restOperations = GetCdnManagementRestOperations(clientDiagnostics, credential, options, pipeline, baseUri);
                    var response = await restOperations.CheckCdnNameAvailabilityWithSubscriptionAsync(subscription.Id.SubscriptionId, checkNameAvailabilityInput, cancellationToken).ConfigureAwait(false);
                    return response;
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            ).ConfigureAwait(false);
        }

        /// <summary> Check the availability of a resource name. This is needed for resources where name is globally unique, such as a CDN endpoint. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="checkNameAvailabilityInput"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="checkNameAvailabilityInput"/> is null. </exception>
        public static Response<CheckNameAvailabilityOutput> CheckCdnNameAvailabilityWithSubscription(this Subscription subscription, CheckNameAvailabilityInput checkNameAvailabilityInput, CancellationToken cancellationToken = default)
        {
            if (checkNameAvailabilityInput == null)
            {
                throw new ArgumentNullException(nameof(checkNameAvailabilityInput));
            }

            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.CheckCdnNameAvailabilityWithSubscription");
                scope.Start();
                try
                {
                    var restOperations = GetCdnManagementRestOperations(clientDiagnostics, credential, options, pipeline, baseUri);
                    var response = restOperations.CheckCdnNameAvailabilityWithSubscription(subscription.Id.SubscriptionId, checkNameAvailabilityInput, cancellationToken);
                    return response;
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            );
        }

        /// <summary> Check if the probe path is a valid path and the file can be accessed. Probe path is the path to a file hosted on the origin server to help accelerate the delivery of dynamic content via the CDN endpoint. This path is relative to the origin path specified in the endpoint configuration. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="validateProbeInput"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="validateProbeInput"/> is null. </exception>
        public static async Task<Response<ValidateProbeOutput>> ValidateProbeAsync(this Subscription subscription, ValidateProbeInput validateProbeInput, CancellationToken cancellationToken = default)
        {
            if (validateProbeInput == null)
            {
                throw new ArgumentNullException(nameof(validateProbeInput));
            }

            return await subscription.UseClientContext(async (baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.ValidateProbe");
                scope.Start();
                try
                {
                    CdnManagementRestOperations restOperations = GetCdnManagementRestOperations(clientDiagnostics, pipeline, options, baseUri);
                    var response = await restOperations.ValidateProbeAsync(subscription.Id.SubscriptionId, validateProbeInput, cancellationToken).ConfigureAwait(false);
                    return response;
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            ).ConfigureAwait(false);
        }

        /// <summary> Check if the probe path is a valid path and the file can be accessed. Probe path is the path to a file hosted on the origin server to help accelerate the delivery of dynamic content via the CDN endpoint. This path is relative to the origin path specified in the endpoint configuration. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="validateProbeInput"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="validateProbeInput"/> is null. </exception>
        public static Response<ValidateProbeOutput> ValidateProbe(this Subscription subscription, ValidateProbeInput validateProbeInput, CancellationToken cancellationToken = default)
        {
            if (validateProbeInput == null)
            {
                throw new ArgumentNullException(nameof(validateProbeInput));
            }

            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.ValidateProbe");
                scope.Start();
                try
                {
                    CdnManagementRestOperations restOperations = GetCdnManagementRestOperations(clientDiagnostics, pipeline, options, baseUri);
                    var response = restOperations.ValidateProbe(subscription.Id.SubscriptionId, validateProbeInput, cancellationToken);
                    return response;
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            );
        }

        /// <summary> Lists the ResourceUsages for this <see cref="Subscription" />. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ResourceUsage> GetResourceUsagesAsync(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                ResourceUsageRestOperations restOperations = GetResourceUsageRestOperations(clientDiagnostics, pipeline, options, baseUri);
                async Task<Page<ResourceUsage>> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetResourceUsages");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.ListAsync(subscription.Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                async Task<Page<ResourceUsage>> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetResourceUsages");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.ListNextPageAsync(nextLink, subscription.Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
            }
            );
        }

        /// <summary> Lists the ResourceUsages for this <see cref="Subscription" />. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<ResourceUsage> GetResourceUsages(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                ResourceUsageRestOperations restOperations = GetResourceUsageRestOperations(clientDiagnostics, pipeline, options, baseUri);
                Page<ResourceUsage> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetResourceUsages");
                    scope.Start();
                    try
                    {
                        var response = restOperations.List(subscription.Id.SubscriptionId, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                Page<ResourceUsage> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetResourceUsages");
                    scope.Start();
                    try
                    {
                        var response = restOperations.ListNextPage(nextLink, subscription.Id.SubscriptionId, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
            }
            );
        }

        /// <summary> Lists the ManagedRuleSetDefinitions for this <see cref="Subscription" />. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ManagedRuleSetDefinition> GetManagedRuleSetsAsync(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                ManagedRuleSetsRestOperations restOperations = GetManagedRuleSetsRestOperations(clientDiagnostics, pipeline, options, baseUri);
                async Task<Page<ManagedRuleSetDefinition>> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetManagedRuleSets");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.ListAsync(subscription.Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                async Task<Page<ManagedRuleSetDefinition>> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetManagedRuleSets");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.ListNextPageAsync(nextLink, subscription.Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
            }
            );
        }

        /// <summary> Lists the ManagedRuleSetDefinitions for this <see cref="Subscription" />. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<ManagedRuleSetDefinition> GetManagedRuleSets(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                ManagedRuleSetsRestOperations restOperations = GetManagedRuleSetsRestOperations(clientDiagnostics, pipeline, options, baseUri);
                Page<ManagedRuleSetDefinition> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetManagedRuleSets");
                    scope.Start();
                    try
                    {
                        var response = restOperations.List(subscription.Id.SubscriptionId, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                Page<ManagedRuleSetDefinition> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetManagedRuleSets");
                    scope.Start();
                    try
                    {
                        var response = restOperations.ListNextPage(nextLink, subscription.Id.SubscriptionId, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
            }
            );
        }
    }
}
