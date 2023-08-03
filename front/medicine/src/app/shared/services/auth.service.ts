import { MessageService } from "src/app/shared/services/message.service";
import { Injectable } from "@angular/core";
import { environment } from "src/assets/environments/environment";
import { HttpClient } from "@angular/common/http";
import { Router } from "@angular/router";
import { ApiResponse } from "../models/viewModels/ApiResponse";
import { LoginData } from "../models/viewModels/LoginData";
import { TokenData } from "../models/viewModels/TokenData";
import { JwtHelperService } from "@auth0/angular-jwt";

@Injectable({
  providedIn: "root",
})
export class AuthService {


  private TOKEN_SELECTOR = "TOKEN";
  private LANG = "LANG";
  private TIMEZONE = "TIMEZONE";
  private authUrl? : string ;

  constructor(
    protected http: HttpClient,
    private router: Router,
    private messageService: MessageService,

  ) {
    this.authUrl = `${environment.apiUrl}auth`;
  }

  private _setTokenAndRedirect(resp: ApiResponse<string>, redirect = true) {
    
    const TokenData = new JwtHelperService().decodeToken<TokenData>( resp.PayLoad );

    localStorage.setItem(this.TOKEN_SELECTOR, resp.PayLoad);
    if (redirect) {
      this.router.navigate(["/therapy-lists"]);
    }
  }

  public getToken(): string | null {
    return localStorage.getItem(this.TOKEN_SELECTOR);
  }

  async login(user: LoginData) {
    
     this.http.post<ApiResponse<string>>(this.authUrl + "/login", user);

  }

  async register(user: LoginData) {
    await this.http
      .post(this.authUrl + "/register", user)
      .subscribe((resp: ApiResponse<string>) => {
        this.messageService.show(resp.PayLoad);
        if (resp.Error === false) {
          this.router.navigate([`auth/confirm/${user.Email}`]);
        }
        return true;
      }, (err) => {
        this.messageService.error(err.message);

      });
  }

  confirm(user: LoginData) {
    this.http
      .post(this.authUrl + "/confirm", user)
      .subscribe((resp: ApiResponse<string>) => {
        if (resp.Error === false) {
          this._setTokenAndRedirect(resp);
        } else {
          this.messageService.errorList(resp.Errors);
        }
      }, (err) => {
        this.messageService.error(err.message);

      });
  }
  udpateUser(currentToken: TokenData) {
    this.http
      .post(this.authUrl + "/UpdateUser", currentToken)
      .subscribe((resp: ApiResponse<string>) => {
        if (resp.Error === false) {
          this._setTokenAndRedirect(resp, false);
          this.messageService.show("user.settings.was.updated");
        } else {
          this.messageService.errorList(resp.Errors);
        }
      }, (err) => {
        this.messageService.error(err.message);
      });
  }

  setLang(lang: string) {
    localStorage.setItem(this.LANG, lang);
  }

  getLang(): string | null {
    return localStorage.getItem(this.LANG);
  }

  logout() {
    localStorage.removeItem(this.TOKEN_SELECTOR);
    this.router.navigate(["auth/login"]);
  }

  langList() {
    return environment.locales;
  }

  public get logIn(): boolean {
    return localStorage.getItem(this.TOKEN_SELECTOR) !== null;
  }

  public getUserConverted(): TokenData {
    let token: TokenData = new JwtHelperService().decodeToken(
      localStorage.getItem(this.TOKEN_SELECTOR)
    );
    token.IsMan = token.IsMan.toString() === "True" ? true : false;
    token.BirthDay = new Date(token.BirthDay);
    return token;
  }

  public getUser(): TokenData {
    return new JwtHelperService().decodeToken(localStorage.getItem(this.TOKEN_SELECTOR));
  }

  public getUserId() {
    const decodedToken: TokenData = new JwtHelperService().decodeToken(
      localStorage.getItem(this.TOKEN_SELECTOR)
    );
    return decodedToken.Id;
  }
}
