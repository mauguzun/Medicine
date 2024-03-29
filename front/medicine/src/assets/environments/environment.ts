// This file can be replaced during build by using the `fileReplacements` array.
// `ng build --prod` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.

export const environment = {
  production: false,
  locales: ['en', 'lv'],
  defaultLocale: 'en',
  apiUrl: 'https://localhost:44375/',
  graphURL: 'https://localhost:44375/',

  backUrl : 'main',

  minQuanity: 0.1,

  maxIntervalCount: 300,
  maxTimesPerInterval: 12,
  minTitleLength: 2,
  default: {
    quantity: 2,
  }
};

/*
 * For easier debugging in development mode, you can import the following file
 * to ignore zone related error stack frames such as `zone.run`, `zoneDelegate.invokeTask`.
 *
 * This import should be commented out in production mode because it will have a negative impact
 * on performance if an error is thrown.
 */
// import 'zone.js/dist/zone-error';  // Included with Angular CLI.
