﻿using GalaSoft.MvvmLight.Ioc;
using XamarinTemplate.Core.Base.Modules.Interfaces;
using XamarinTemplate.Core.Base.REST.Interfaces;

namespace XamarinTemplate.Core.Base.Containers
{
    public abstract class CoreServices
    {
        private static CoreServices Instance => SimpleIoc.Default.GetInstance<CoreServices>();

        #region Fields

        private INavigationService mNavigationService;
        private ILoggingService mLoggingService;
        private INetworkService mNetworkService;
        private IHttpClientService mHttpClientService;
        private IRestClient mRestClient;
        private INotificationMessageService mNotificationMessageService;
        private INotificationService mNotificationService;
        private INotificationIconService mNotificationIconService;
        private IDialogService mDialogService;
        private IAppSettingsService mAppSettingsService;
        private IStorageService mStorageService;

        #endregion

        #region Properties

        public static INavigationService NavigationService => Instance.mNavigationService 
            ?? (Instance.mNavigationService = SimpleIoc.Default.GetInstance<INavigationService>());

        public static ILoggingService LoggingService => Instance.mLoggingService 
            ?? (Instance.mLoggingService = SimpleIoc.Default.GetInstance<ILoggingService>());

        public static INetworkService NetworkService => Instance.mNetworkService 
            ?? (Instance.mNetworkService = SimpleIoc.Default.GetInstance<INetworkService>());

        public static IHttpClientService HtppClientService => Instance.mHttpClientService 
            ?? (Instance.mHttpClientService = SimpleIoc.Default.GetInstance<IHttpClientService>());

        public static IRestClient RestClient => Instance.mRestClient 
            ?? (Instance.mRestClient = SimpleIoc.Default.GetInstance<IRestClient>());

        public static INotificationMessageService NotificationMessageService => Instance.mNotificationMessageService 
            ?? (Instance.mNotificationMessageService = SimpleIoc.Default.GetInstance<INotificationMessageService>());

        public static INotificationService NotificationService => Instance.mNotificationService
            ?? (Instance.mNotificationService = SimpleIoc.Default.GetInstance<INotificationService>());

        public static INotificationIconService NotificationIconService => Instance.mNotificationIconService
            ?? (Instance.mNotificationIconService = SimpleIoc.Default.GetInstance<INotificationIconService>());

        public static IDialogService DialogService => Instance.mDialogService
            ?? (Instance.mDialogService = SimpleIoc.Default.GetInstance<IDialogService>());

        public static IAppSettingsService AppSettingsService => Instance.mAppSettingsService
            ?? (Instance.mAppSettingsService = SimpleIoc.Default.GetInstance<IAppSettingsService>());

        public static IStorageService StorageService => Instance.mStorageService
            ?? (Instance.mStorageService = SimpleIoc.Default.GetInstance<IStorageService>());

        #endregion
    }
}
