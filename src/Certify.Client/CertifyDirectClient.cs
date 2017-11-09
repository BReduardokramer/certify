﻿using Certify.Management;
using Certify.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Certify.Client
{
    /// <summary>
    /// This version of the client is a direct reference to Certify.Core, for gradual code migration
    /// to CertifyServiceClient
    /// </summary>
    public class CertifyDirectClient : ICertifyClient
    {
        private CertifyManager _certifyManager = new CertifyManager();

        public Task<List<ManagedSite>> BeginAutoRenewal()
        {
            throw new NotImplementedException();
        }

        public Task BeginCertificateRequest(string managedSiteId)
        {
            throw new NotImplementedException();
        }

        public Task<string> CheckCertificateRequest(string managedSiteId)
        {
            throw new NotImplementedException();
        }

        public Task<UpdateCheck> CheckForUpdates()
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteManagedSite(string managedSiteId)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetAppVersion()
        {
            return Task.FromResult(new Management.Util().GetAppVersion().ToString());
        }

        public Task<List<ManagedSite>> GetManagedSite(string managedSiteId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ManagedSite>> GetManagedSites(ManagedSiteFilter filter)
        {
            throw new NotImplementedException();
        }

        public Task<Preferences> GetPreferences()
        {
            throw new NotImplementedException();
        }

        public Task<string> GetPrimaryContact()
        {
            throw new NotImplementedException();
        }

        public Task<List<DomainOption>> GetServerSiteDomains(StandardServerTypes serverType, string serverSiteId)
        {
            throw new NotImplementedException();
        }

        public Task<List<SiteBindingItem>> GetServerSiteList(StandardServerTypes serverType)
        {
            throw new NotImplementedException();
        }

        public Task<Version> GetServerVersion(StandardServerTypes serverType)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsServerAvailable(StandardServerTypes serverType)
        {
            throw new NotImplementedException();
        }

        public Task<APIResult> RevokeManageSiteCertificate(string managedSiteId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SetPreferences(Preferences preferences)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SetPrimaryContact(ContactRegistration contact)
        {
            return Task.FromResult(_certifyManager.AddRegisteredContact(contact));
        }

        public Task<APIResult> TestChallengeConfiguration(ManagedSite site)
        {
            throw new NotImplementedException();
        }

        public Task<ManagedSite> UpdateManagedSite(ManagedSite site)
        {
            return Task.FromResult(_certifyManager.UpdateManagedSite(site));
        }
    }
}