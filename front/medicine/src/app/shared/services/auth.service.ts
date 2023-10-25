import { Injectable } from "@angular/core";
import { environment } from "src/assets/environments/environment";
import { HttpClient, HttpErrorResponse, HttpResponse } from "@angular/common/http";
import { Router } from "@angular/router";
import { LoginDto } from "../models/viewModels/Dto/LoginDto";
import { JwtHelperService } from "@auth0/angular-jwt";
import { catchError, map } from "rxjs/operators";
import { BehaviorSubject, Observable, of } from "rxjs";
import { ApiResponse } from "../models/viewModels/ApiResponse";
import { UserSettingsDto } from "../models/viewModels/Dto/UserSettingsDto";

@Injectable({
  providedIn: "root",
})
export class AuthService {


  private TOKEN_SELECTOR = "TOKEN";
  private USER_SELECTOR = "USER";

  private authUrl = `${environment.apiUrl}auth`;

  private _user: UserSettingsDto | null;

  public get user(): UserSettingsDto | null {

    if (this._user === null) {
      const token = localStorage.getItem(this.USER_SELECTOR)
      const tokeDataOrNull: string | null = token ? new JwtHelperService().decodeToken(token)?.TokenData : null;
      this._user = tokeDataOrNull ? JSON.parse(tokeDataOrNull) : null;

      console.log(this._user);
    }

    return this._user;
  }

  private set user(value: UserSettingsDto) {
    
    localStorage.setItem(this.USER_SELECTOR, JSON.stringify(value));
    this._user = value;
  }

  constructor(
    private http: HttpClient,
  ) { this._user = null }

  private setToken(token: string) {
    localStorage.setItem(this.TOKEN_SELECTOR, token);
  }

  getToken() {
    localStorage.getItem(this.TOKEN_SELECTOR);
  }


  isLoginded(): boolean {
    console.log(this._user);
    return this._user != null;
  }

  logout(): void {
    localStorage.removeItem(this.TOKEN_SELECTOR);
    this._user = null;
  }

  login(user: LoginDto): Observable<HttpResponse<ApiResponse<[string, UserSettingsDto]>>> {
    return this.http.post<ApiResponse<[string, UserSettingsDto]>>(this.authUrl + "/login", user, { observe: 'response' })
      .pipe(
        catchError((error: HttpErrorResponse) => {
          // Handle the error here (e.g., log it or perform other actions).
          console.error('Error:', error);
          return of(new HttpResponse<ApiResponse<[string, UserSettingsDto]>>({ status: error.status, body: error.error }));
        }),
        map((response) => {
          if (response.status === 200 && response.body != null ) {
            const { Item1, Item2 } = response.body.Message as any;
            this.setToken(Item1);
            this.user = Item2; 
          }
          return response;
        })
      );
  }


  confirm(user: LoginDto) {
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
