import { MessageService } from "src/app/shared/services/message.service";
import { Injectable } from "@angular/core";
import { environment } from "src/assets/environments/environment";
import { HttpClient, HttpResponse } from "@angular/common/http";
import { Router } from "@angular/router";
import { ApiResponse, JsonResult } from "../models/viewModels/ApiResponse";
import { LoginData } from "../models/viewModels/LoginData";
import { TokenData } from "../models/viewModels/TokenData";
import { JwtHelperService } from "@auth0/angular-jwt";
import { catchError, map } from "rxjs/operators";
import { BehaviorSubject, Observable, of } from "rxjs";

@Injectable({
  providedIn: "root",
})
export class AuthService {


  private TOKEN_SELECTOR = "TOKEN";
  private LANG = "LANG";
  private TIMEZONE = "TIMEZONE";

  private authUrl = `${environment.apiUrl}auth`;


  constructor(
    private http: HttpClient,
    private router: Router,
    private messageService: MessageService,

  ) {

  }

  private setToken(token: string) {
    localStorage.setItem(this.TOKEN_SELECTOR, token);

  }

  public getUser(): TokenData | null {
    const token = localStorage.getItem(this.TOKEN_SELECTOR)
    return token ? new JwtHelperService().decodeToken<TokenData>(token) : null;
  }

  public getToken(): string | null {
    return localStorage.getItem(this.TOKEN_SELECTOR);
  }

  login(user: LoginData): Observable<HttpResponse<JsonResult>> {
    return this.http.post<JsonResult>(this.authUrl + "/login", user, { observe: 'response' })
    .pipe(
      catchError((error: any) => {
        // Handle the error here (e.g., log it or perform other actions).
        console.error('Error:', error);
        // Return an observable with an error response or re-throw the error if needed.
        return of(new HttpResponse<JsonResult>({ status: 500 }));
      }),
      map((response) => {
        if (response.status === 200 && response.body != null) {
          console.log(response.body);
          this.setToken(response.body.value);
        }
        return response;
      })
    );
  }


  confirm(user: LoginData) {
    return this.http.post<ApiResponse<string>>(this.authUrl + "/confirm", user)
      .pipe(map(response => {
        if (response.Error === false) {
          this.setToken(response.PayLoad)
          return true;
        } else {

          alert('show error')
          return false;

        }
      }));
  }




}
