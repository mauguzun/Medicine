import { MessageService } from "src/app/shared/services/message.service";
import { Injectable } from "@angular/core";
import { environment } from "src/assets/environments/environment";
import { HttpClient } from "@angular/common/http";
import { Router } from "@angular/router";
import { ApiResponse } from "../models/viewModels/ApiResponse";
import { LoginData } from "../models/viewModels/LoginData";
import { TokenData } from "../models/viewModels/TokenData";
import { JwtHelperService } from "@auth0/angular-jwt";
import { map } from "rxjs/operators";

@Injectable({
  providedIn: "root",
})
export class AuthService {


  private TOKEN_SELECTOR = "TOKEN";
  private LANG = "LANG";
  private TIMEZONE = "TIMEZONE";
  private authUrl?: string;

  constructor(
    private http: HttpClient,
    private router: Router,
    private messageService: MessageService,

  ) {
    this.authUrl = `${environment.apiUrl}auth`;
  }

  private _setTokenAndRedirect(token: string) {
    // const TokenData = new JwtHelperService().decodeToken<TokenData>( token);
    localStorage.setItem(this.TOKEN_SELECTOR, token);

  }

  public getUser(): TokenData | null {
    const token = localStorage.getItem(this.TOKEN_SELECTOR)
    return token ? new JwtHelperService().decodeToken<TokenData>(token) : null;
  }

  public getToken(): string | null {
    return localStorage.getItem(this.TOKEN_SELECTOR);
  }

  async login(user: LoginData) {

    return this.http.post<ApiResponse<string>>(this.authUrl + "/login", user)
      .pipe(map(response => {
        if (response.Error === false) {
          this._setTokenAndRedirect(response.PayLoad)
          return true;
        } else {
          alert('show error')
          return false;
        }
      }));

  }

  async register(user: LoginData) {

    return this.http.post<ApiResponse<string>>(this.authUrl + "/register", user)
      .pipe(map(response => {
        if (response.Error === false) {
          this._setTokenAndRedirect(response.PayLoad)
          return true;
        } else {

          alert('show error')
          return false;

        }
      }));
  }

  confirm(user: LoginData) {
    return this.http.post<ApiResponse<string>>(this.authUrl + "/confirm", user)
      .pipe(map(response => {
        if (response.Error === false) {
          this._setTokenAndRedirect(response.PayLoad)
          return true;
        } else {

          alert('show error')
          return false;

        }
      }));
  }




}
