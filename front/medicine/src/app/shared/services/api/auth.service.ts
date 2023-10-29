import { Injectable } from "@angular/core";
import { environment } from "src/assets/environments/environment";
import { HttpClient, HttpErrorResponse, HttpResponse } from "@angular/common/http";
import { LoginDto } from "../../models/viewModels/Dto/LoginDto";
import { JwtHelperService } from "@auth0/angular-jwt";
import { catchError, map } from "rxjs/operators";
import { ApiResponse, TupleReponse } from "../../models/viewModels/ApiResponse";
import { UserSettingsDto } from "../../models/viewModels/Dto/UserSettingsDto";
import { Observable, of } from 'rxjs';
import { SettingsService } from "./settings.service";


@Injectable({
  providedIn: "root",
})

export class AuthService {

  private TOKEN_SELECTOR = "TOKEN";

  private authUrl = `${environment.apiUrl}auth`;

  public get token(): string | null {
    return localStorage.getItem(this.TOKEN_SELECTOR);
  }

  private set token(value: string) {
    localStorage.setItem(this.TOKEN_SELECTOR, value);
  }


  constructor(
    private http: HttpClient,
    private settingsService : SettingsService
  ) {  }

  isLogined(): boolean {
    return this.token !== null;
  }

  logout(): void {
    localStorage.removeItem(this.TOKEN_SELECTOR);
    this.settingsService.logout();
  }

  login(user: LoginDto): Observable<HttpResponse<ApiResponse<TupleReponse<string, UserSettingsDto>>>> {
    return this.http.post<ApiResponse<TupleReponse<string, UserSettingsDto>>>(this.authUrl + "/login", user, { observe: 'response' })
      .pipe(
        catchError((error: HttpErrorResponse) => {
          // Handle the error here (e.g., log it or perform other actions).
          return of(new HttpResponse<ApiResponse<TupleReponse<string, UserSettingsDto>>>({ status: error.status, body: error.error }));
        }),
        map((response) => {
          if (response.status === 200 && response.body != null) {
            this.token = response.body.Message.Item1;
            this.settingsService.user = response.body.Message.Item2;
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
          }
          return response;
        }))
  }

}
