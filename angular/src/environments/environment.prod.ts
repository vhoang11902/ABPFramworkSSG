import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:44359/',
  redirectUri: baseUrl,
  clientId: 'AbpSolution2_App',
  responseType: 'code',
  scope: 'offline_access AbpSolution2',
  requireHttps: true,
};

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'AbpSolution2',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44359',
      rootNamespace: 'AbpSolution2',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
  remoteEnv: {
    url: '/getEnvConfig',
    mergeStrategy: 'deepmerge'
  }
} as Environment;
