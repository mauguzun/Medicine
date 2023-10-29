import { Injectable } from '@angular/core';
import { environment } from "src/assets/environments/environment";
import { HttpClient, HttpErrorResponse, HttpResponse } from "@angular/common/http";
import { catchError, map } from "rxjs/operators";
import { ApiResponse } from "../../models/viewModels/ApiResponse";
import { UserSettingsDto } from "../../models/viewModels/Dto/UserSettingsDto";
import { Observable, of } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class SettingsService {

  private USER_SELECTOR = "USER";
  private authUrl = `${environment.apiUrl}auth/userSettings`;

  private _user: UserSettingsDto | null;

  constructor(
    private http: HttpClient,
  ) {
    this._user = null;
  }


  public get user(): UserSettingsDto | null {
    if (this._user === null) {
      const token = localStorage.getItem(this.USER_SELECTOR)
      this._user = token ? JSON.parse(token) : null;
    }
    return this._user;
  }

  public set user(value: UserSettingsDto) {
    localStorage.setItem(this.USER_SELECTOR, JSON.stringify(value));
    this._user = value;
  }

  logout(){
    localStorage.removeItem(this.USER_SELECTOR);
  }

  save(user: UserSettingsDto): Observable<HttpResponse<ApiResponse<string>>> {
    return this.http.post<ApiResponse<string>>(this.authUrl, user, { observe: 'response' })
      .pipe(
        catchError((error: HttpErrorResponse) => {
          console.log(error);
          return of(new HttpResponse<ApiResponse<string>>({ status: error.status, body: { Message: error.message } }));
        }),
        map((response) => {
          return response;
        })
      );
  }
}
