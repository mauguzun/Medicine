import { Injectable } from "@angular/core";
import { environment } from "src/assets/environments/environment";
import { HttpClient, HttpErrorResponse, HttpResponse } from "@angular/common/http";
import { Router } from "@angular/router";
import { LoginData } from "../models/viewModels/LoginData";
import { TokenData } from "../models/viewModels/TokenData";
import { JwtHelperService } from "@auth0/angular-jwt";
import { catchError, map } from "rxjs/operators";
import { BehaviorSubject, Observable, of } from "rxjs";
import { ApiResponse } from "../models/viewModels/ApiResponse";

@Injectable({
  providedIn: "root",
})
export class AuthService {



  private TOKEN_SELECTOR = "TOKEN";
  private LANG = "LANG";
  private TIMEZONE = "TIMEZONE";

  private authUrl = `${environment.apiUrl}auth`;
  private _user: TokenData | null;


  constructor(
    private http: HttpClient,
  ) { this._user = null }

  private setToken(token: string) {
    localStorage.setItem(this.TOKEN_SELECTOR, token);
  }

  public getUser(): TokenData | null {
    if (this._user === null) {
      const token = localStorage.getItem(this.TOKEN_SELECTOR)
      this._user = token ? new JwtHelperService().decodeToken<TokenData>(token) : null;
    }
    return this._user;
  }

  isLoginded(): boolean {
    return this.getUser() !== null;
  }

  logout():void{
    localStorage.removeItem(this.TOKEN_SELECTOR);
    this._user = null;
  }

  login(user: LoginData): Observable<HttpResponse<ApiResponse<string>>> {
    return this.http.post<ApiResponse<string>>(this.authUrl + "/login", user, { observe: 'response' })
      .pipe(
        catchError((error: HttpErrorResponse) => {
          // Handle the error here (e.g., log it or perform other actions).
          console.error('Error:', error);
          return of(new HttpResponse<ApiResponse<string>>({ status: error.status, body:  error.error }));
        }),
        map((response) => {
          if (response.status === 200 && response.body != null) {
            this.setToken(response.body.message);
          }
          return response;
        })
      );
  }


  confirm(user: LoginData) {
    return this.http.post<HttpResponse<string>>(this.authUrl + "/confirm", user)
      .pipe(
        catchError((error: HttpErrorResponse) => {
          return of(new HttpResponse<string>({ status: error.status, body: error.message }));
        }),
        map((response) => {
          if (response.status === 200 && response.body != null) {
            console.log(response.body);
            this.setToken(response.body);
          }
          return response;
        }))
  }




}
