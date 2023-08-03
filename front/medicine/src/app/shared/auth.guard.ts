import { ApiAuthService } from './services/api/api-auth.service';
import { Injectable } from '@angular/core';
import { CanActivate, CanActivateChild, ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree, Router } from '@angular/router';
import { Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate, CanActivateChild {
  constructor(private auth: ApiAuthService, private router: Router) { }

  canActivate(route: import('@angular/router').ActivatedRouteSnapshot,
              state: import('@angular/router').RouterStateSnapshot): boolean | import('@angular/router').UrlTree | import('rxjs').Observable<boolean | import('@angular/router').UrlTree> | Promise<boolean | import('@angular/router').UrlTree> {
    if (this.auth.logIn) {
      return of(true);
    } else {
      this.router.navigate(['auth/login'], {
        queryParams: {
          accessDenied: true
        }
      });
      return of(false);
    }

  }

  canActivateChild(childRoute: import('@angular/router').ActivatedRouteSnapshot, state: import('@angular/router').RouterStateSnapshot): boolean | import('@angular/router').UrlTree | import('rxjs').Observable<boolean | import('@angular/router').UrlTree> | Promise<boolean | import('@angular/router').UrlTree> {
    return this.canActivate(childRoute, state);
  }

}
